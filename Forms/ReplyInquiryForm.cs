// =============================================================================
// Forms/ReplyInquiryForm.cs
// Lets an admin read a visitor's Contact Us inquiry and send a reply.
// The reply is emailed to the visitor and saved against the inquiry so the
// inbox can show which messages have been answered.
// Built in code (no .Designer.cs) so it needs no designer wiring.
// =============================================================================

using System;
using System.Drawing;
using System.Windows.Forms;
using PROJECTT.Models;
using PROJECTT.Services;

namespace PROJECTT
{
    public class ReplyInquiryForm : Form
    {
        private readonly ContactMessage _msg;
        private readonly string _adminName;

        private TextBox txtOriginal;
        private TextBox txtReply;
        private Button btnSend;
        private Button btnClose;
        private Label lblStatus;

        public ReplyInquiryForm(ContactMessage msg, string adminName)
        {
            _msg = msg;
            _adminName = adminName;
            BuildUi();

            if (!_msg.IsRead) ContactService.MarkAsRead(_msg.Id);

            if (_msg.IsReplied)
            {
                lblStatus.Text = $"Replied {(_msg.RepliedAt.HasValue ? _msg.RepliedAt.Value.ToString("dd MMM yyyy HH:mm") : "")}" +
                                 (string.IsNullOrEmpty(_msg.RepliedBy) ? "" : " by " + _msg.RepliedBy) +
                                 ". You can send another reply below.";
                lblStatus.ForeColor = Color.FromArgb(192, 182, 113);
                txtOriginal.Text += Environment.NewLine + Environment.NewLine +
                                    "---- Previous reply ----" + Environment.NewLine + _msg.ReplyText;
            }
        }

        private void BuildUi()
        {
            Text = "Reply to Inquiry";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(640, 600);
            BackColor = Color.FromArgb(60, 57, 46);
            ForeColor = AppPalette.Cream;
            Font = new Font("Segoe UI", 10F);

            var lblHeader = new Label
            {
                Text = $"From: {_msg.Name} <{_msg.Email}>\r\nSubject: {_msg.Subject}\r\nSent: {_msg.DateSent:dd MMM yyyy HH:mm}",
                Location = new Point(20, 16),
                Size = new Size(600, 62),
                ForeColor = Color.FromArgb(189, 179, 156)
            };

            txtOriginal = new TextBox
            {
                Text = _msg.Message,
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Location = new Point(20, 84),
                Size = new Size(600, 150),
                BackColor = Color.FromArgb(73, 70, 56),
                ForeColor = AppPalette.Cream,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lblReply = new Label
            {
                Text = "Your reply:",
                Location = new Point(20, 246),
                AutoSize = true
            };

            txtReply = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Location = new Point(20, 272),
                Size = new Size(600, 220),
                BackColor = Color.FromArgb(73, 70, 56),
                ForeColor = AppPalette.Cream,
                BorderStyle = BorderStyle.FixedSingle
            };

            lblStatus = new Label
            {
                Location = new Point(20, 500),
                Size = new Size(600, 24),
                ForeColor = Color.FromArgb(189, 179, 156)
            };

            btnSend = new Button
            {
                Text = "Send Reply",
                Location = new Point(400, 536),
                Size = new Size(130, 40),
                FlatStyle = FlatStyle.Flat,
                BackColor = AppPalette.Olive,
                ForeColor = AppPalette.Cream
            };
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.Click += btnSend_Click;

            btnClose = new Button
            {
                Text = "Close",
                Location = new Point(540, 536),
                Size = new Size(80, 40),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(77, 73, 58),
                ForeColor = AppPalette.Cream,
                DialogResult = DialogResult.Cancel
            };
            btnClose.FlatAppearance.BorderSize = 0;

            Controls.AddRange(new Control[] { lblHeader, txtOriginal, lblReply, txtReply, lblStatus, btnSend, btnClose });
            CancelButton = btnClose;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string reply = txtReply.Text.Trim();
            if (reply.Length == 0)
            {
                MessageBox.Show("Please type a reply first.", "Reply is empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!BookingService.EmailRx.IsMatch((_msg.Email ?? "").Trim()))
            {
                MessageBox.Show("This inquiry has no valid email address, so a reply can't be sent.",
                    "No email address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSend.Enabled = false;
            Cursor = Cursors.WaitCursor;
            lblStatus.ForeColor = Color.FromArgb(189, 179, 156);
            lblStatus.Text = "Sending...";

            try
            {
                await EmailService.SendInquiryReplyAsync(_msg.Email.Trim(), _msg.Name, _msg.Subject, _msg.Message, reply);
            }
            catch (Exception ex)
            {
                // Email failed: do NOT mark as replied, so the admin can retry.
                lblStatus.ForeColor = Color.FromArgb(174, 76, 61);
                lblStatus.Text = "Email failed: " + ex.Message;
                btnSend.Enabled = true;
                Cursor = Cursors.Default;
                return;
            }

            ContactService.SaveReply(_msg.Id, reply, _adminName);
            Cursor = Cursors.Default;
            MessageBox.Show("Your reply was emailed to " + _msg.Email + ".", "Reply sent",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
