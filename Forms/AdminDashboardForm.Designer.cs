// =============================================================================
// Forms/AdminDashboardForm.Designer.cs
// Standard Visual Studio Windows Forms Designer layout so the full GUI is
// displayable and editable in the Visual Studio Form Designer.
// =============================================================================

namespace PROJECTT.Forms
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAdminBrand = new System.Windows.Forms.Label();
            this.lblAdminPortalSub = new System.Windows.Forms.Label();
            this.lblSidebarUser = new System.Windows.Forms.Label();
            this.btnNavOverview = new System.Windows.Forms.Button();
            this.btnNavActivities = new System.Windows.Forms.Button();
            this.btnNavBookings = new System.Windows.Forms.Button();
            this.btnNavAttendance = new System.Windows.Forms.Button();
            this.btnNavReports = new System.Windows.Forms.Button();
            this.btnNavChangePass = new System.Windows.Forms.Button();
            this.btnNavNotifications = new System.Windows.Forms.Button();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.lblNotifHeading = new System.Windows.Forms.Label();
            this.lblNotifSub = new System.Windows.Forms.Label();
            this.cardNotifTotal = new System.Windows.Forms.Panel();
            this.lblNotifTotal = new System.Windows.Forms.Label();
            this.lblNotifTotalCap = new System.Windows.Forms.Label();
            this.cardNotifUnread = new System.Windows.Forms.Panel();
            this.lblNotifUnread = new System.Windows.Forms.Label();
            this.lblNotifUnreadCap = new System.Windows.Forms.Label();
            this.cardNotifRead = new System.Windows.Forms.Panel();
            this.lblNotifRead = new System.Windows.Forms.Label();
            this.lblNotifReadCap = new System.Windows.Forms.Label();
            this.lblNotifGridHeading = new System.Windows.Forms.Label();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.btnNavLogout = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.lblOverviewHeading = new System.Windows.Forms.Label();
            this.lblOverviewSub = new System.Windows.Forms.Label();
            this.tileBookings = new System.Windows.Forms.Panel();
            this.lblTileBookings = new System.Windows.Forms.Label();
            this.lblTileBookingsCap = new System.Windows.Forms.Label();
            this.tileRevenue = new System.Windows.Forms.Panel();
            this.lblTileRevenue = new System.Windows.Forms.Label();
            this.lblTileRevenueCap = new System.Windows.Forms.Label();
            this.tileUpcoming = new System.Windows.Forms.Panel();
            this.lblTileUpcoming = new System.Windows.Forms.Label();
            this.lblTileUpcomingCap = new System.Windows.Forms.Label();
            this.tileSeatsLeft = new System.Windows.Forms.Panel();
            this.lblTileSeatsLeft = new System.Windows.Forms.Label();
            this.lblTileSeatsLeftCap = new System.Windows.Forms.Label();
            this.pnlShortcuts = new System.Windows.Forms.Panel();
            this.lblShortcutsHeading = new System.Windows.Forms.Label();
            this.btnShortcutActivities = new System.Windows.Forms.Button();
            this.btnShortcutBookings = new System.Windows.Forms.Button();
            this.btnShortcutAttendance = new System.Windows.Forms.Button();
            this.btnShortcutReports = new System.Windows.Forms.Button();
            this.pnlActivities = new System.Windows.Forms.Panel();
            this.lblActivitiesHeading = new System.Windows.Forms.Label();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.pnlActivityForm = new System.Windows.Forms.Panel();
            this.lblActivityFormTitle = new System.Windows.Forms.Label();
            this.lblCatCap = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblActNameCap = new System.Windows.Forms.Label();
            this.txtActName = new System.Windows.Forms.TextBox();
            this.lblPriceCap = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblDescCap = new System.Windows.Forms.Label();
            this.txtActDescription = new System.Windows.Forms.TextBox();
            this.lblDateCap = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalSeatsCap = new System.Windows.Forms.Label();
            this.nudTotalSeats = new System.Windows.Forms.NumericUpDown();
            this.lblAvailSeatsCap = new System.Windows.Forms.Label();
            this.nudAvailableSeats = new System.Windows.Forms.NumericUpDown();
            this.lblActError = new System.Windows.Forms.Label();
            this.btnActAdd = new System.Windows.Forms.Button();
            this.btnActSave = new System.Windows.Forms.Button();
            this.btnActDelete = new System.Windows.Forms.Button();
            this.btnActClear = new System.Windows.Forms.Button();
            this.lblActImageCap = new System.Windows.Forms.Label();
            this.picActImagePreview = new System.Windows.Forms.PictureBox();
            this.cboActImagePreset = new System.Windows.Forms.ComboBox();
            this.btnUploadActImage = new System.Windows.Forms.Button();
            this.btnResetActImage = new System.Windows.Forms.Button();
            this.lblActImageStatus = new System.Windows.Forms.Label();
            this.btnBookingEditImage = new System.Windows.Forms.Button();
            this.pnlBookings = new System.Windows.Forms.Panel();
            this.lblBookingsHeading = new System.Windows.Forms.Label();
            this.lblBookingSearchCap = new System.Windows.Forms.Label();
            this.txtBookingSearch = new System.Windows.Forms.TextBox();
            this.lblBookingFilterCap = new System.Windows.Forms.Label();
            this.cboBookingActivityFilter = new System.Windows.Forms.ComboBox();
            this.chkEnableDateFilter = new System.Windows.Forms.CheckBox();
            this.dtpBookingDateFilter = new System.Windows.Forms.DateTimePicker();
            this.dgvAllBookings = new System.Windows.Forms.DataGridView();
            this.pnlAttendance = new System.Windows.Forms.Panel();
            this.lblAttendanceHeading = new System.Windows.Forms.Label();
            this.dgvAttendanceBookings = new System.Windows.Forms.DataGridView();
            this.pnlAttendanceUpdate = new System.Windows.Forms.Panel();
            this.lblSelectedBookingInfo = new System.Windows.Forms.Label();
            this.lblMarkAttCap = new System.Windows.Forms.Label();
            this.cboAttendanceStatus = new System.Windows.Forms.ComboBox();
            this.btnSaveAttendance = new System.Windows.Forms.Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblReportsHeading = new System.Windows.Forms.Label();
            this.pnlChartBar = new System.Windows.Forms.Panel();
            this.pnlChartFunnel = new System.Windows.Forms.Panel();
            this.pnlChartArea = new System.Windows.Forms.Panel();
            this.rtbReportOutput = new System.Windows.Forms.RichTextBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnOpenTicketsFolder = new System.Windows.Forms.Button();
            this.pnlChangePassword = new System.Windows.Forms.Panel();
            this.lblChangePassHeading = new System.Windows.Forms.Label();
            this.lblChangePassSub = new System.Windows.Forms.Label();
            this.lblCurrPassCap = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassCap = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfPassCap = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPassError = new System.Windows.Forms.Label();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.tileBookings.SuspendLayout();
            this.tileRevenue.SuspendLayout();
            this.tileUpcoming.SuspendLayout();
            this.tileSeatsLeft.SuspendLayout();
            this.pnlShortcuts.SuspendLayout();
            this.pnlActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActImagePreview)).BeginInit();
            this.pnlActivityForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailableSeats)).BeginInit();
            this.pnlBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).BeginInit();
            this.pnlAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceBookings)).BeginInit();
            this.pnlAttendanceUpdate.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.pnlChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(48)))));
            this.pnlSidebar.Controls.Add(this.pnlTop);
            this.pnlSidebar.Controls.Add(this.btnNavOverview);
            this.pnlSidebar.Controls.Add(this.btnNavActivities);
            this.pnlSidebar.Controls.Add(this.btnNavBookings);
            this.pnlSidebar.Controls.Add(this.btnNavAttendance);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavChangePass);
            this.pnlSidebar.Controls.Add(this.btnNavNotifications);
            this.pnlSidebar.Controls.Add(this.btnNavLogout);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 750);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.pnlTop.Controls.Add(this.lblAdminBrand);
            this.pnlTop.Controls.Add(this.lblAdminPortalSub);
            this.pnlTop.Controls.Add(this.lblSidebarUser);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(220, 130);
            this.pnlTop.TabIndex = 0;
            // 
            // lblAdminBrand
            // 
            this.lblAdminBrand.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblAdminBrand.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.lblAdminBrand.Location = new System.Drawing.Point(10, 14);
            this.lblAdminBrand.Name = "lblAdminBrand";
            this.lblAdminBrand.Size = new System.Drawing.Size(200, 28);
            this.lblAdminBrand.TabIndex = 0;
            this.lblAdminBrand.Text = "Blue Horizons Tours";
            this.lblAdminBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminPortalSub
            // 
            this.lblAdminPortalSub.Font = new System.Drawing.Font("Arial", 8.5F);
            this.lblAdminPortalSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.lblAdminPortalSub.Location = new System.Drawing.Point(10, 46);
            this.lblAdminPortalSub.Name = "lblAdminPortalSub";
            this.lblAdminPortalSub.Size = new System.Drawing.Size(200, 18);
            this.lblAdminPortalSub.TabIndex = 1;
            this.lblAdminPortalSub.Text = "ADMINISTRATOR PORTAL";
            this.lblAdminPortalSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSidebarUser
            // 
            this.lblSidebarUser.AutoEllipsis = true;
            this.lblSidebarUser.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblSidebarUser.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.lblSidebarUser.Location = new System.Drawing.Point(10, 74);
            this.lblSidebarUser.Name = "lblSidebarUser";
            this.lblSidebarUser.Size = new System.Drawing.Size(200, 40);
            this.lblSidebarUser.TabIndex = 2;
            this.lblSidebarUser.Text = "Admin: Blue Horizons";
            this.lblSidebarUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNavOverview
            // 
            this.btnNavOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnNavOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavOverview.FlatAppearance.BorderSize = 0;
            this.btnNavOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOverview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavOverview.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnNavOverview.Location = new System.Drawing.Point(0, 130);
            this.btnNavOverview.Name = "btnNavOverview";
            this.btnNavOverview.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavOverview.Size = new System.Drawing.Size(220, 48);
            this.btnNavOverview.TabIndex = 1;
            this.btnNavOverview.Text = "📊  Overview";
            this.btnNavOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavOverview.UseVisualStyleBackColor = false;
            this.btnNavOverview.Click += new System.EventHandler(this.btnNavOverview_Click);
            // 
            // btnNavActivities
            // 
            this.btnNavActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(48)))));
            this.btnNavActivities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavActivities.FlatAppearance.BorderSize = 0;
            this.btnNavActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavActivities.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavActivities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(194)))));
            this.btnNavActivities.Location = new System.Drawing.Point(0, 178);
            this.btnNavActivities.Name = "btnNavActivities";
            this.btnNavActivities.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavActivities.Size = new System.Drawing.Size(220, 48);
            this.btnNavActivities.TabIndex = 2;
            this.btnNavActivities.Text = "📅  Manage Activities";
            this.btnNavActivities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavActivities.UseVisualStyleBackColor = false;
            this.btnNavActivities.Click += new System.EventHandler(this.btnNavActivities_Click);
            // 
            // btnNavBookings
            // 
            this.btnNavBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(48)))));
            this.btnNavBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBookings.FlatAppearance.BorderSize = 0;
            this.btnNavBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBookings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(194)))));
            this.btnNavBookings.Location = new System.Drawing.Point(0, 226);
            this.btnNavBookings.Name = "btnNavBookings";
            this.btnNavBookings.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavBookings.Size = new System.Drawing.Size(220, 48);
            this.btnNavBookings.TabIndex = 3;
            this.btnNavBookings.Text = "🎟  All Bookings";
            this.btnNavBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBookings.UseVisualStyleBackColor = false;
            this.btnNavBookings.Click += new System.EventHandler(this.btnNavBookings_Click);
            // 
            // btnNavAttendance
            // 
            this.btnNavAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(48)))));
            this.btnNavAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAttendance.FlatAppearance.BorderSize = 0;
            this.btnNavAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAttendance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(194)))));
            this.btnNavAttendance.Location = new System.Drawing.Point(0, 274);
            this.btnNavAttendance.Name = "btnNavAttendance";
            this.btnNavAttendance.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavAttendance.Size = new System.Drawing.Size(220, 48);
            this.btnNavAttendance.TabIndex = 4;
            this.btnNavAttendance.Text = "📋  Attendance";
            this.btnNavAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAttendance.UseVisualStyleBackColor = false;
            this.btnNavAttendance.Click += new System.EventHandler(this.btnNavAttendance_Click);
            // 
            // btnNavReports
            // 
            this.btnNavReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(48)))));
            this.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReports.FlatAppearance.BorderSize = 0;
            this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(194)))));
            this.btnNavReports.Location = new System.Drawing.Point(0, 322);
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavReports.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavReports.Size = new System.Drawing.Size(220, 48);
            this.btnNavReports.TabIndex = 5;
            this.btnNavReports.Text = "📈  Reports";
            this.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReports.UseVisualStyleBackColor = false;
            this.btnNavReports.Click += new System.EventHandler(this.btnNavReports_Click);
            // 
            // btnNavChangePass
            // 
            this.btnNavChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(48)))));
            this.btnNavChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavChangePass.FlatAppearance.BorderSize = 0;
            this.btnNavChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavChangePass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(194)))));
            this.btnNavChangePass.Location = new System.Drawing.Point(0, 370);
            this.btnNavChangePass.Name = "btnNavChangePass";
            this.btnNavChangePass.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavChangePass.Size = new System.Drawing.Size(220, 48);
            this.btnNavChangePass.TabIndex = 6;
            this.btnNavChangePass.Text = "🔑  Change Password";
            this.btnNavChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavChangePass.UseVisualStyleBackColor = false;
            this.btnNavChangePass.Click += new System.EventHandler(this.btnNavChangePass_Click);
            // 
            // btnNavNotifications
            // 
            this.btnNavNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(48)))));
            this.btnNavNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavNotifications.FlatAppearance.BorderSize = 0;
            this.btnNavNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavNotifications.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavNotifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(194)))));
            this.btnNavNotifications.Location = new System.Drawing.Point(0, 418);
            this.btnNavNotifications.Name = "btnNavNotifications";
            this.btnNavNotifications.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavNotifications.Size = new System.Drawing.Size(220, 48);
            this.btnNavNotifications.TabIndex = 8;
            this.btnNavNotifications.Text = "🔔  Notifications";
            this.btnNavNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavNotifications.UseVisualStyleBackColor = false;
            this.btnNavNotifications.Click += new System.EventHandler(this.btnNavNotifications_Click);
            // 
            // btnNavLogout
            // 
            this.btnNavLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(48)))));
            this.btnNavLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLogout.FlatAppearance.BorderSize = 0;
            this.btnNavLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.btnNavLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.btnNavLogout.Location = new System.Drawing.Point(0, 698);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavLogout.Size = new System.Drawing.Size(220, 52);
            this.btnNavLogout.TabIndex = 7;
            this.btnNavLogout.Text = "🟠  Log Out";
            this.btnNavLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogout.UseVisualStyleBackColor = false;
            this.btnNavLogout.Click += new System.EventHandler(this.btnNavLogout_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(46)))));
            this.pnlContent.Controls.Add(this.pnlOverview);
            this.pnlContent.Controls.Add(this.pnlActivities);
            this.pnlContent.Controls.Add(this.pnlBookings);
            this.pnlContent.Controls.Add(this.pnlAttendance);
            this.pnlContent.Controls.Add(this.pnlReports);
            this.pnlContent.Controls.Add(this.pnlChangePassword);
            this.pnlContent.Controls.Add(this.pnlNotifications);
            this.pnlContent.Location = new System.Drawing.Point(220, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(980, 750);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlOverview
            // 
            this.pnlOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(46)))));
            this.pnlOverview.Controls.Add(this.tileBookings);
            this.pnlOverview.Controls.Add(this.tileRevenue);
            this.pnlOverview.Controls.Add(this.tileUpcoming);
            this.pnlOverview.Controls.Add(this.tileSeatsLeft);
            this.pnlOverview.Controls.Add(this.pnlShortcuts);
            this.pnlOverview.Location = new System.Drawing.Point(0, 0);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(980, 750);
            this.pnlOverview.TabIndex = 0;
            this.pnlOverview.Visible = true;
            // 
            // lblOverviewHeading
            // 
            this.lblOverviewHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(47)))));
            this.lblOverviewHeading.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblOverviewHeading.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.lblOverviewHeading.Location = new System.Drawing.Point(90, 50);
            this.lblOverviewHeading.Name = "lblOverviewHeading";
            this.lblOverviewHeading.Visible = false;
            this.lblOverviewHeading.Size = new System.Drawing.Size(800, 34);
            this.lblOverviewHeading.TabIndex = 0;
            this.lblOverviewHeading.Text = "Welcome Admin To The Blue Horizions administration system.";
            this.lblOverviewHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverviewSub
            // 
            this.lblOverviewSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(47)))));
            this.lblOverviewSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblOverviewSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(162)))), ((int)(((byte)(132)))));
            this.lblOverviewSub.Location = new System.Drawing.Point(90, 86);
            this.lblOverviewSub.Name = "lblOverviewSub";
            this.lblOverviewSub.Visible = false;
            this.lblOverviewSub.Size = new System.Drawing.Size(800, 22);
            this.lblOverviewSub.TabIndex = 1;
            this.lblOverviewSub.Text = "Control your System effortlessly through an sleek and clean orcherstrated UI design by the blue horizion team.";
            this.lblOverviewSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileBookings
            // 
            this.tileBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.tileBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tileBookings.Controls.Add(this.lblTileBookings);
            this.tileBookings.Controls.Add(this.lblTileBookingsCap);
            this.tileBookings.Location = new System.Drawing.Point(24, 646);
            this.tileBookings.Name = "tileBookings";
            this.tileBookings.Size = new System.Drawing.Size(221, 86);
            this.tileBookings.TabIndex = 2;
            // 
            // lblTileBookings
            // 
            this.lblTileBookings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTileBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(120)))), ((int)(((byte)(62)))));
            this.lblTileBookings.Location = new System.Drawing.Point(8, 8);
            this.lblTileBookings.Name = "lblTileBookings";
            this.lblTileBookings.Size = new System.Drawing.Size(205, 42);
            this.lblTileBookings.TabIndex = 0;
            this.lblTileBookings.Text = "3";
            this.lblTileBookings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTileBookingsCap
            // 
            this.lblTileBookingsCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblTileBookingsCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.lblTileBookingsCap.Location = new System.Drawing.Point(8, 52);
            this.lblTileBookingsCap.Name = "lblTileBookingsCap";
            this.lblTileBookingsCap.Size = new System.Drawing.Size(205, 24);
            this.lblTileBookingsCap.TabIndex = 1;
            this.lblTileBookingsCap.Text = "Total Bookings";
            this.lblTileBookingsCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileRevenue
            // 
            this.tileRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.tileRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tileRevenue.Controls.Add(this.lblTileRevenue);
            this.tileRevenue.Controls.Add(this.lblTileRevenueCap);
            this.tileRevenue.Location = new System.Drawing.Point(261, 646);
            this.tileRevenue.Name = "tileRevenue";
            this.tileRevenue.Size = new System.Drawing.Size(221, 86);
            this.tileRevenue.TabIndex = 3;
            // 
            // lblTileRevenue
            // 
            this.lblTileRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTileRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(53)))));
            this.lblTileRevenue.Location = new System.Drawing.Point(8, 8);
            this.lblTileRevenue.Name = "lblTileRevenue";
            this.lblTileRevenue.Size = new System.Drawing.Size(205, 42);
            this.lblTileRevenue.TabIndex = 0;
            this.lblTileRevenue.Text = "R27,500.00";
            this.lblTileRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTileRevenueCap
            // 
            this.lblTileRevenueCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblTileRevenueCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.lblTileRevenueCap.Location = new System.Drawing.Point(8, 52);
            this.lblTileRevenueCap.Name = "lblTileRevenueCap";
            this.lblTileRevenueCap.Size = new System.Drawing.Size(205, 24);
            this.lblTileRevenueCap.TabIndex = 1;
            this.lblTileRevenueCap.Text = "Total Revenue";
            this.lblTileRevenueCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileUpcoming
            // 
            this.tileUpcoming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.tileUpcoming.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tileUpcoming.Controls.Add(this.lblTileUpcoming);
            this.tileUpcoming.Controls.Add(this.lblTileUpcomingCap);
            this.tileUpcoming.Location = new System.Drawing.Point(498, 646);
            this.tileUpcoming.Name = "tileUpcoming";
            this.tileUpcoming.Size = new System.Drawing.Size(221, 86);
            this.tileUpcoming.TabIndex = 4;
            // 
            // lblTileUpcoming
            // 
            this.lblTileUpcoming.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTileUpcoming.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(134)))), ((int)(((byte)(87)))));
            this.lblTileUpcoming.Location = new System.Drawing.Point(8, 8);
            this.lblTileUpcoming.Name = "lblTileUpcoming";
            this.lblTileUpcoming.Size = new System.Drawing.Size(205, 42);
            this.lblTileUpcoming.TabIndex = 0;
            this.lblTileUpcoming.Text = "12";
            this.lblTileUpcoming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTileUpcomingCap
            // 
            this.lblTileUpcomingCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblTileUpcomingCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.lblTileUpcomingCap.Location = new System.Drawing.Point(8, 52);
            this.lblTileUpcomingCap.Name = "lblTileUpcomingCap";
            this.lblTileUpcomingCap.Size = new System.Drawing.Size(205, 24);
            this.lblTileUpcomingCap.TabIndex = 1;
            this.lblTileUpcomingCap.Text = "Upcoming Events";
            this.lblTileUpcomingCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileSeatsLeft
            // 
            this.tileSeatsLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.tileSeatsLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tileSeatsLeft.Controls.Add(this.lblTileSeatsLeft);
            this.tileSeatsLeft.Controls.Add(this.lblTileSeatsLeftCap);
            this.tileSeatsLeft.Location = new System.Drawing.Point(735, 646);
            this.tileSeatsLeft.Name = "tileSeatsLeft";
            this.tileSeatsLeft.Size = new System.Drawing.Size(221, 86);
            this.tileSeatsLeft.TabIndex = 5;
            // 
            // lblTileSeatsLeft
            // 
            this.lblTileSeatsLeft.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTileSeatsLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(169)))), ((int)(((byte)(119)))));
            this.lblTileSeatsLeft.Location = new System.Drawing.Point(8, 8);
            this.lblTileSeatsLeft.Name = "lblTileSeatsLeft";
            this.lblTileSeatsLeft.Size = new System.Drawing.Size(205, 42);
            this.lblTileSeatsLeft.TabIndex = 0;
            this.lblTileSeatsLeft.Text = "174";
            this.lblTileSeatsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTileSeatsLeftCap
            // 
            this.lblTileSeatsLeftCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblTileSeatsLeftCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.lblTileSeatsLeftCap.Location = new System.Drawing.Point(8, 52);
            this.lblTileSeatsLeftCap.Name = "lblTileSeatsLeftCap";
            this.lblTileSeatsLeftCap.Size = new System.Drawing.Size(205, 24);
            this.lblTileSeatsLeftCap.TabIndex = 1;
            this.lblTileSeatsLeftCap.Text = "Seats Remaining";
            this.lblTileSeatsLeftCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlShortcuts
            // 
            this.pnlShortcuts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(47)))));
            this.pnlShortcuts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlShortcuts.Controls.Add(this.lblShortcutsHeading);
            this.pnlShortcuts.Controls.Add(this.lblOverviewHeading);
            this.pnlShortcuts.Controls.Add(this.lblOverviewSub);
            this.pnlShortcuts.Controls.Add(this.btnShortcutActivities);
            this.pnlShortcuts.Controls.Add(this.btnShortcutBookings);
            this.pnlShortcuts.Controls.Add(this.btnShortcutAttendance);
            this.pnlShortcuts.Controls.Add(this.btnShortcutReports);
            this.pnlShortcuts.Location = new System.Drawing.Point(0, 0);
            this.pnlShortcuts.Name = "pnlShortcuts";
            this.pnlShortcuts.Size = new System.Drawing.Size(980, 628);
            this.pnlShortcuts.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBeamHub_Paint);
            this.pnlShortcuts.TabIndex = 6;
            // 
            // lblShortcutsHeading
            // 
            this.lblShortcutsHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.lblShortcutsHeading.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblShortcutsHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(207)))), ((int)(((byte)(169)))));
            this.lblShortcutsHeading.Location = new System.Drawing.Point(390, 18);
            this.lblShortcutsHeading.Name = "lblShortcutsHeading";
            this.lblShortcutsHeading.Visible = false;
            this.lblShortcutsHeading.Size = new System.Drawing.Size(200, 26);
            this.lblShortcutsHeading.TabIndex = 0;
            this.lblShortcutsHeading.Text = "●   LIVE INTEGRATIONS";
            this.lblShortcutsHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShortcutActivities
            // 
            this.btnShortcutActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.btnShortcutActivities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShortcutActivities.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(72)))));
            this.btnShortcutActivities.FlatAppearance.BorderSize = 1;
            this.btnShortcutActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortcutActivities.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnShortcutActivities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(197)))), ((int)(((byte)(179)))));
            this.btnShortcutActivities.Location = new System.Drawing.Point(112, 142);
            this.btnShortcutActivities.Name = "btnShortcutActivities";
            this.btnShortcutActivities.Visible = false;
            this.btnShortcutActivities.Size = new System.Drawing.Size(104, 76);
            this.btnShortcutActivities.TabIndex = 1;
            this.btnShortcutActivities.Text = "⛰\r\nACTIVITIES";
            this.btnShortcutActivities.UseVisualStyleBackColor = false;
            this.btnShortcutActivities.Click += new System.EventHandler(this.btnNavActivities_Click);
            // 
            // btnShortcutBookings
            // 
            this.btnShortcutBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.btnShortcutBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShortcutBookings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(72)))));
            this.btnShortcutBookings.FlatAppearance.BorderSize = 1;
            this.btnShortcutBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortcutBookings.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnShortcutBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(197)))), ((int)(((byte)(179)))));
            this.btnShortcutBookings.Location = new System.Drawing.Point(112, 292);
            this.btnShortcutBookings.Name = "btnShortcutBookings";
            this.btnShortcutBookings.Visible = false;
            this.btnShortcutBookings.Size = new System.Drawing.Size(104, 76);
            this.btnShortcutBookings.TabIndex = 2;
            this.btnShortcutBookings.Text = "📋\r\nALL BOOKINGS";
            this.btnShortcutBookings.UseVisualStyleBackColor = false;
            this.btnShortcutBookings.Click += new System.EventHandler(this.btnNavBookings_Click);
            // 
            // btnShortcutAttendance
            // 
            this.btnShortcutAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.btnShortcutAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShortcutAttendance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(72)))));
            this.btnShortcutAttendance.FlatAppearance.BorderSize = 1;
            this.btnShortcutAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortcutAttendance.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnShortcutAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(197)))), ((int)(((byte)(179)))));
            this.btnShortcutAttendance.Location = new System.Drawing.Point(112, 442);
            this.btnShortcutAttendance.Name = "btnShortcutAttendance";
            this.btnShortcutAttendance.Visible = false;
            this.btnShortcutAttendance.Size = new System.Drawing.Size(104, 76);
            this.btnShortcutAttendance.TabIndex = 3;
            this.btnShortcutAttendance.Text = "🛡\r\nATTENDANCE";
            this.btnShortcutAttendance.UseVisualStyleBackColor = false;
            this.btnShortcutAttendance.Click += new System.EventHandler(this.btnNavAttendance_Click);
            // 
            // btnShortcutReports
            // 
            this.btnShortcutReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.btnShortcutReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShortcutReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(72)))));
            this.btnShortcutReports.FlatAppearance.BorderSize = 1;
            this.btnShortcutReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortcutReports.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnShortcutReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(197)))), ((int)(((byte)(179)))));
            this.btnShortcutReports.Location = new System.Drawing.Point(764, 142);
            this.btnShortcutReports.Name = "btnShortcutReports";
            this.btnShortcutReports.Visible = false;
            this.btnShortcutReports.Size = new System.Drawing.Size(104, 76);
            this.btnShortcutReports.TabIndex = 4;
            this.btnShortcutReports.Text = "📊\r\nREPORTS";
            this.btnShortcutReports.UseVisualStyleBackColor = false;
            this.btnShortcutReports.Click += new System.EventHandler(this.btnNavReports_Click);
            // 
            // pnlActivities
            // 
            this.pnlActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(46)))));
            this.pnlActivities.Controls.Add(this.lblActivitiesHeading);
            this.pnlActivities.Controls.Add(this.dgvActivities);
            this.pnlActivities.Controls.Add(this.pnlActivityForm);
            this.pnlActivities.Location = new System.Drawing.Point(0, 0);
            this.pnlActivities.Name = "pnlActivities";
            this.pnlActivities.Size = new System.Drawing.Size(980, 750);
            this.pnlActivities.TabIndex = 1;
            this.pnlActivities.Visible = false;
            // 
            // lblActivitiesHeading
            // 
            this.lblActivitiesHeading.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblActivitiesHeading.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.lblActivitiesHeading.Location = new System.Drawing.Point(20, 16);
            this.lblActivitiesHeading.Name = "lblActivitiesHeading";
            this.lblActivitiesHeading.Size = new System.Drawing.Size(500, 36);
            this.lblActivitiesHeading.TabIndex = 0;
            this.lblActivitiesHeading.Text = "Manage Activities && Events";
            // 
            // dgvActivities
            // 
            this.dgvActivities.AllowUserToAddRows = false;
            this.dgvActivities.AllowUserToDeleteRows = false;
            this.dgvActivities.AllowUserToResizeRows = false;
            this.dgvActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivities.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(50)))));
            this.dgvActivities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActivities.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActivities.ColumnHeadersHeight = 34;
            this.dgvActivities.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.dgvActivities.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.dgvActivities.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.dgvActivities.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.dgvActivities.EnableHeadersVisualStyles = false;
            this.dgvActivities.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.dgvActivities.Location = new System.Drawing.Point(20, 56);
            this.dgvActivities.MultiSelect = false;
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.ReadOnly = true;
            this.dgvActivities.RowHeadersVisible = false;
            this.dgvActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivities.Size = new System.Drawing.Size(940, 320);
            this.dgvActivities.TabIndex = 1;
            this.dgvActivities.SelectionChanged += new System.EventHandler(this.dgvActivities_SelectionChanged);
            // 
            // pnlActivityForm
            // 
            this.pnlActivityForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.pnlActivityForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActivityForm.Controls.Add(this.lblActivityFormTitle);
            this.pnlActivityForm.Controls.Add(this.lblCatCap);
            this.pnlActivityForm.Controls.Add(this.cboCategory);
            this.pnlActivityForm.Controls.Add(this.lblActNameCap);
            this.pnlActivityForm.Controls.Add(this.txtActName);
            this.pnlActivityForm.Controls.Add(this.lblPriceCap);
            this.pnlActivityForm.Controls.Add(this.nudPrice);
            this.pnlActivityForm.Controls.Add(this.lblDescCap);
            this.pnlActivityForm.Controls.Add(this.txtActDescription);
            this.pnlActivityForm.Controls.Add(this.lblDateCap);
            this.pnlActivityForm.Controls.Add(this.dtpDate);
            this.pnlActivityForm.Controls.Add(this.lblTotalSeatsCap);
            this.pnlActivityForm.Controls.Add(this.nudTotalSeats);
            this.pnlActivityForm.Controls.Add(this.lblAvailSeatsCap);
            this.pnlActivityForm.Controls.Add(this.nudAvailableSeats);
            this.pnlActivityForm.Controls.Add(this.lblActError);
            this.pnlActivityForm.Controls.Add(this.btnActAdd);
            this.pnlActivityForm.Controls.Add(this.btnActSave);
            this.pnlActivityForm.Controls.Add(this.btnActDelete);
            this.pnlActivityForm.Controls.Add(this.btnActClear);
            this.pnlActivityForm.Controls.Add(this.lblActImageCap);
            this.pnlActivityForm.Controls.Add(this.picActImagePreview);
            this.pnlActivityForm.Controls.Add(this.cboActImagePreset);
            this.pnlActivityForm.Controls.Add(this.btnUploadActImage);
            this.pnlActivityForm.Controls.Add(this.btnResetActImage);
            this.pnlActivityForm.Controls.Add(this.lblActImageStatus);
            this.pnlActivityForm.Location = new System.Drawing.Point(20, 386);
            this.pnlActivityForm.Name = "pnlActivityForm";
            this.pnlActivityForm.Size = new System.Drawing.Size(940, 344);
            this.pnlActivityForm.TabIndex = 2;
            // 
            // lblActivityFormTitle
            // 
            this.lblActivityFormTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblActivityFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(194)))));
            this.lblActivityFormTitle.Location = new System.Drawing.Point(16, 12);
            this.lblActivityFormTitle.Name = "lblActivityFormTitle";
            this.lblActivityFormTitle.Size = new System.Drawing.Size(600, 20);
            this.lblActivityFormTitle.TabIndex = 0;
            this.lblActivityFormTitle.Text = "Activity Form (Add new activity or select row to edit)";
            // 
            // lblCatCap
            // 
            this.lblCatCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCatCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblCatCap.Location = new System.Drawing.Point(16, 38);
            this.lblCatCap.Name = "lblCatCap";
            this.lblCatCap.Size = new System.Drawing.Size(120, 16);
            this.lblCatCap.TabIndex = 1;
            this.lblCatCap.Text = "CATEGORY";
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(56)))));
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategory.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.cboCategory.Location = new System.Drawing.Point(16, 56);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(160, 26);
            this.cboCategory.TabIndex = 2;
            // 
            // lblActNameCap
            // 
            this.lblActNameCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblActNameCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblActNameCap.Location = new System.Drawing.Point(192, 38);
            this.lblActNameCap.Name = "lblActNameCap";
            this.lblActNameCap.Size = new System.Drawing.Size(200, 16);
            this.lblActNameCap.TabIndex = 3;
            this.lblActNameCap.Text = "ACTIVITY NAME";
            // 
            // txtActName
            // 
            this.txtActName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(56)))));
            this.txtActName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtActName.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.txtActName.Location = new System.Drawing.Point(192, 56);
            this.txtActName.Name = "txtActName";
            this.txtActName.Size = new System.Drawing.Size(420, 26);
            this.txtActName.TabIndex = 4;
            // 
            // lblPriceCap
            // 
            this.lblPriceCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPriceCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblPriceCap.Location = new System.Drawing.Point(628, 38);
            this.lblPriceCap.Name = "lblPriceCap";
            this.lblPriceCap.Size = new System.Drawing.Size(140, 16);
            this.lblPriceCap.TabIndex = 5;
            this.lblPriceCap.Text = "PRICE (ZAR > 0)";
            // 
            // nudPrice
            // 
            this.nudPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(56)))));
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudPrice.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.nudPrice.Location = new System.Drawing.Point(628, 56);
            this.nudPrice.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(140, 26);
            this.nudPrice.TabIndex = 6;
            this.nudPrice.Value = new decimal(new int[] { 350, 0, 0, 0 });
            // 
            // lblDescCap
            // 
            this.lblDescCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDescCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblDescCap.Location = new System.Drawing.Point(16, 92);
            this.lblDescCap.Name = "lblDescCap";
            this.lblDescCap.Size = new System.Drawing.Size(200, 16);
            this.lblDescCap.TabIndex = 7;
            this.lblDescCap.Text = "DESCRIPTION";
            // 
            // txtActDescription
            // 
            this.txtActDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(56)))));
            this.txtActDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtActDescription.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.txtActDescription.Location = new System.Drawing.Point(16, 110);
            this.txtActDescription.Name = "txtActDescription";
            this.txtActDescription.Size = new System.Drawing.Size(752, 26);
            this.txtActDescription.TabIndex = 8;
            // 
            // lblDateCap
            // 
            this.lblDateCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDateCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblDateCap.Location = new System.Drawing.Point(16, 146);
            this.lblDateCap.Name = "lblDateCap";
            this.lblDateCap.Size = new System.Drawing.Size(120, 16);
            this.lblDateCap.TabIndex = 9;
            this.lblDateCap.Text = "DATE";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(16, 164);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 10;
            // 
            // lblTotalSeatsCap
            // 
            this.lblTotalSeatsCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalSeatsCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblTotalSeatsCap.Location = new System.Drawing.Point(232, 146);
            this.lblTotalSeatsCap.Name = "lblTotalSeatsCap";
            this.lblTotalSeatsCap.Size = new System.Drawing.Size(160, 16);
            this.lblTotalSeatsCap.TabIndex = 11;
            this.lblTotalSeatsCap.Text = "TOTAL CAPACITY";
            // 
            // nudTotalSeats
            // 
            this.nudTotalSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(56)))));
            this.nudTotalSeats.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudTotalSeats.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.nudTotalSeats.Location = new System.Drawing.Point(232, 164);
            this.nudTotalSeats.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudTotalSeats.Name = "nudTotalSeats";
            this.nudTotalSeats.Size = new System.Drawing.Size(150, 26);
            this.nudTotalSeats.TabIndex = 12;
            this.nudTotalSeats.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblAvailSeatsCap
            // 
            this.lblAvailSeatsCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAvailSeatsCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblAvailSeatsCap.Location = new System.Drawing.Point(400, 146);
            this.lblAvailSeatsCap.Name = "lblAvailSeatsCap";
            this.lblAvailSeatsCap.Size = new System.Drawing.Size(160, 16);
            this.lblAvailSeatsCap.TabIndex = 13;
            this.lblAvailSeatsCap.Text = "AVAILABLE SEATS";
            // 
            // nudAvailableSeats
            // 
            this.nudAvailableSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(56)))));
            this.nudAvailableSeats.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudAvailableSeats.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.nudAvailableSeats.Location = new System.Drawing.Point(400, 164);
            this.nudAvailableSeats.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudAvailableSeats.Name = "nudAvailableSeats";
            this.nudAvailableSeats.Size = new System.Drawing.Size(150, 26);
            this.nudAvailableSeats.TabIndex = 14;
            this.nudAvailableSeats.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblActError
            // 
            this.lblActError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblActError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(126)))), ((int)(((byte)(114)))));
            this.lblActError.Location = new System.Drawing.Point(16, 202);
            this.lblActError.Name = "lblActError";
            this.lblActError.Size = new System.Drawing.Size(750, 20);
            this.lblActError.TabIndex = 15;
            this.lblActError.Visible = false;
            // 
            // btnActAdd
            // 
            this.btnActAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.btnActAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActAdd.FlatAppearance.BorderSize = 0;
            this.btnActAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActAdd.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnActAdd.Location = new System.Drawing.Point(16, 234);
            this.btnActAdd.Name = "btnActAdd";
            this.btnActAdd.Size = new System.Drawing.Size(160, 42);
            this.btnActAdd.TabIndex = 16;
            this.btnActAdd.Text = "➕  Add Activity";
            this.btnActAdd.UseVisualStyleBackColor = false;
            this.btnActAdd.Click += new System.EventHandler(this.btnActAdd_Click);
            // 
            // btnActSave
            // 
            this.btnActSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(53)))));
            this.btnActSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActSave.FlatAppearance.BorderSize = 0;
            this.btnActSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActSave.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnActSave.Location = new System.Drawing.Point(190, 234);
            this.btnActSave.Name = "btnActSave";
            this.btnActSave.Size = new System.Drawing.Size(160, 42);
            this.btnActSave.TabIndex = 17;
            this.btnActSave.Text = "💾  Save Edits";
            this.btnActSave.UseVisualStyleBackColor = false;
            this.btnActSave.Click += new System.EventHandler(this.btnActSave_Click);
            // 
            // btnActDelete
            // 
            this.btnActDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(77)))), ((int)(((byte)(62)))));
            this.btnActDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActDelete.FlatAppearance.BorderSize = 0;
            this.btnActDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActDelete.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnActDelete.Location = new System.Drawing.Point(364, 234);
            this.btnActDelete.Name = "btnActDelete";
            this.btnActDelete.Size = new System.Drawing.Size(160, 42);
            this.btnActDelete.TabIndex = 18;
            this.btnActDelete.Text = "🗑  Delete Activity";
            this.btnActDelete.UseVisualStyleBackColor = false;
            this.btnActDelete.Click += new System.EventHandler(this.btnActDelete_Click);
            // 
            // btnActClear
            // 
            this.btnActClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnActClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActClear.FlatAppearance.BorderSize = 0;
            this.btnActClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnActClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(194)))));
            this.btnActClear.Location = new System.Drawing.Point(538, 234);
            this.btnActClear.Name = "btnActClear";
            this.btnActClear.Size = new System.Drawing.Size(130, 42);
            this.btnActClear.TabIndex = 19;
            this.btnActClear.Text = "↺ Clear Form";
            this.btnActClear.UseVisualStyleBackColor = false;
            this.btnActClear.Click += new System.EventHandler(this.btnActClear_Click);
            // 
            // lblActImageCap
            // 
            this.lblActImageCap.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblActImageCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(194)))));
            this.lblActImageCap.Location = new System.Drawing.Point(684, 12);
            this.lblActImageCap.Name = "lblActImageCap";
            this.lblActImageCap.Size = new System.Drawing.Size(244, 18);
            this.lblActImageCap.TabIndex = 20;
            this.lblActImageCap.Text = "GALLERY PANEL IMAGE (EDIT / UPLOAD)";
            // 
            // picActImagePreview
            // 
            this.picActImagePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(50)))));
            this.picActImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picActImagePreview.Location = new System.Drawing.Point(684, 34);
            this.picActImagePreview.Name = "picActImagePreview";
            this.picActImagePreview.Size = new System.Drawing.Size(102, 136);
            this.picActImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picActImagePreview.TabIndex = 21;
            this.picActImagePreview.TabStop = false;
            // 
            // cboActImagePreset
            // 
            this.cboActImagePreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActImagePreset.Font = new System.Drawing.Font("Arial", 8.5F);
            this.cboActImagePreset.Location = new System.Drawing.Point(794, 34);
            this.cboActImagePreset.Name = "cboActImagePreset";
            this.cboActImagePreset.Size = new System.Drawing.Size(134, 24);
            this.cboActImagePreset.TabIndex = 22;
            this.cboActImagePreset.SelectedIndexChanged += new System.EventHandler(this.cboActImagePreset_SelectedIndexChanged);
            // 
            // btnUploadActImage
            // 
            this.btnUploadActImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(53)))));
            this.btnUploadActImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadActImage.FlatAppearance.BorderSize = 0;
            this.btnUploadActImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadActImage.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnUploadActImage.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnUploadActImage.Location = new System.Drawing.Point(794, 66);
            this.btnUploadActImage.Name = "btnUploadActImage";
            this.btnUploadActImage.Size = new System.Drawing.Size(134, 34);
            this.btnUploadActImage.TabIndex = 23;
            this.btnUploadActImage.Text = "📁 Upload Image...";
            this.btnUploadActImage.UseVisualStyleBackColor = false;
            this.btnUploadActImage.Click += new System.EventHandler(this.btnUploadActImage_Click);
            // 
            // btnResetActImage
            // 
            this.btnResetActImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnResetActImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetActImage.FlatAppearance.BorderSize = 0;
            this.btnResetActImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetActImage.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnResetActImage.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnResetActImage.Location = new System.Drawing.Point(794, 108);
            this.btnResetActImage.Name = "btnResetActImage";
            this.btnResetActImage.Size = new System.Drawing.Size(134, 30);
            this.btnResetActImage.TabIndex = 24;
            this.btnResetActImage.Text = "↺ Reset to Default";
            this.btnResetActImage.UseVisualStyleBackColor = false;
            this.btnResetActImage.Click += new System.EventHandler(this.btnResetActImage_Click);
            // 
            // lblActImageStatus
            // 
            this.lblActImageStatus.Font = new System.Drawing.Font("Arial", 7.75F);
            this.lblActImageStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(179)))), ((int)(((byte)(130)))));
            this.lblActImageStatus.Location = new System.Drawing.Point(684, 174);
            this.lblActImageStatus.Name = "lblActImageStatus";
            this.lblActImageStatus.Size = new System.Drawing.Size(244, 24);
            this.lblActImageStatus.TabIndex = 25;
            this.lblActImageStatus.Text = "Active: Auto (Match Tour Name)";
            // 
            // pnlBookings
            // 
            this.pnlBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(46)))));
            this.pnlBookings.Controls.Add(this.lblBookingsHeading);
            this.pnlBookings.Controls.Add(this.lblBookingSearchCap);
            this.pnlBookings.Controls.Add(this.txtBookingSearch);
            this.pnlBookings.Controls.Add(this.lblBookingFilterCap);
            this.pnlBookings.Controls.Add(this.cboBookingActivityFilter);
            this.pnlBookings.Controls.Add(this.chkEnableDateFilter);
            this.pnlBookings.Controls.Add(this.dtpBookingDateFilter);
            this.pnlBookings.Controls.Add(this.btnBookingEditImage);
            this.pnlBookings.Controls.Add(this.dgvAllBookings);
            this.pnlBookings.Location = new System.Drawing.Point(0, 0);
            this.pnlBookings.Name = "pnlBookings";
            this.pnlBookings.Size = new System.Drawing.Size(980, 750);
            this.pnlBookings.TabIndex = 2;
            this.pnlBookings.Visible = false;
            // 
            // lblBookingsHeading
            // 
            this.lblBookingsHeading.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblBookingsHeading.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.lblBookingsHeading.Location = new System.Drawing.Point(20, 16);
            this.lblBookingsHeading.Name = "lblBookingsHeading";
            this.lblBookingsHeading.Size = new System.Drawing.Size(500, 36);
            this.lblBookingsHeading.TabIndex = 0;
            this.lblBookingsHeading.Text = "All Visitor Bookings";
            // 
            // lblBookingSearchCap
            // 
            this.lblBookingSearchCap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookingSearchCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblBookingSearchCap.Location = new System.Drawing.Point(20, 56);
            this.lblBookingSearchCap.Name = "lblBookingSearchCap";
            this.lblBookingSearchCap.Size = new System.Drawing.Size(220, 16);
            this.lblBookingSearchCap.TabIndex = 1;
            this.lblBookingSearchCap.Text = "SEARCH (VISITOR / ACTIVITY)";
            // 
            // txtBookingSearch
            // 
            this.txtBookingSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookingSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBookingSearch.Location = new System.Drawing.Point(20, 74);
            this.txtBookingSearch.Name = "txtBookingSearch";
            this.txtBookingSearch.Size = new System.Drawing.Size(240, 26);
            this.txtBookingSearch.TabIndex = 2;
            this.txtBookingSearch.TextChanged += new System.EventHandler(this.txtBookingSearch_TextChanged);
            // 
            // lblBookingFilterCap
            // 
            this.lblBookingFilterCap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookingFilterCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblBookingFilterCap.Location = new System.Drawing.Point(280, 56);
            this.lblBookingFilterCap.Name = "lblBookingFilterCap";
            this.lblBookingFilterCap.Size = new System.Drawing.Size(150, 16);
            this.lblBookingFilterCap.TabIndex = 3;
            this.lblBookingFilterCap.Text = "ACTIVITY FILTER";
            // 
            // cboBookingActivityFilter
            // 
            this.cboBookingActivityFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookingActivityFilter.Font = new System.Drawing.Font("Arial", 10F);
            this.cboBookingActivityFilter.Location = new System.Drawing.Point(280, 74);
            this.cboBookingActivityFilter.Name = "cboBookingActivityFilter";
            this.cboBookingActivityFilter.Size = new System.Drawing.Size(220, 26);
            this.cboBookingActivityFilter.TabIndex = 4;
            this.cboBookingActivityFilter.SelectedIndexChanged += new System.EventHandler(this.cboBookingActivityFilter_SelectedIndexChanged);
            // 
            // chkEnableDateFilter
            // 
            this.chkEnableDateFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.chkEnableDateFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.chkEnableDateFilter.Location = new System.Drawing.Point(520, 74);
            this.chkEnableDateFilter.Name = "chkEnableDateFilter";
            this.chkEnableDateFilter.Size = new System.Drawing.Size(140, 26);
            this.chkEnableDateFilter.TabIndex = 5;
            this.chkEnableDateFilter.Text = "FILTER BY DATE:";
            this.chkEnableDateFilter.CheckedChanged += new System.EventHandler(this.chkEnableDateFilter_CheckedChanged);
            // 
            // dtpBookingDateFilter
            // 
            this.dtpBookingDateFilter.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpBookingDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingDateFilter.Location = new System.Drawing.Point(660, 74);
            this.dtpBookingDateFilter.Name = "dtpBookingDateFilter";
            this.dtpBookingDateFilter.Size = new System.Drawing.Size(140, 26);
            this.dtpBookingDateFilter.TabIndex = 6;
            this.dtpBookingDateFilter.ValueChanged += new System.EventHandler(this.dtpBookingDateFilter_ValueChanged);
            // 
            // btnBookingEditImage
            // 
            this.btnBookingEditImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.btnBookingEditImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookingEditImage.FlatAppearance.BorderSize = 0;
            this.btnBookingEditImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingEditImage.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnBookingEditImage.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnBookingEditImage.Location = new System.Drawing.Point(808, 68);
            this.btnBookingEditImage.Name = "btnBookingEditImage";
            this.btnBookingEditImage.Size = new System.Drawing.Size(152, 34);
            this.btnBookingEditImage.TabIndex = 8;
            this.btnBookingEditImage.Text = "🖼 Edit Panel Image";
            this.btnBookingEditImage.UseVisualStyleBackColor = false;
            this.btnBookingEditImage.Click += new System.EventHandler(this.btnBookingEditImage_Click);
            // 
            // dgvAllBookings
            // 
            this.dgvAllBookings.AllowUserToAddRows = false;
            this.dgvAllBookings.AllowUserToDeleteRows = false;
            this.dgvAllBookings.AllowUserToResizeRows = false;
            this.dgvAllBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(50)))));
            this.dgvAllBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllBookings.ColumnHeadersHeight = 34;
            this.dgvAllBookings.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.dgvAllBookings.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.dgvAllBookings.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.dgvAllBookings.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.dgvAllBookings.EnableHeadersVisualStyles = false;
            this.dgvAllBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.dgvAllBookings.Location = new System.Drawing.Point(20, 114);
            this.dgvAllBookings.MultiSelect = false;
            this.dgvAllBookings.Name = "dgvAllBookings";
            this.dgvAllBookings.ReadOnly = true;
            this.dgvAllBookings.RowHeadersVisible = false;
            this.dgvAllBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllBookings.Size = new System.Drawing.Size(940, 606);
            this.dgvAllBookings.TabIndex = 7;
            // 
            // pnlAttendance
            // 
            this.pnlAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(46)))));
            this.pnlAttendance.Controls.Add(this.lblAttendanceHeading);
            this.pnlAttendance.Controls.Add(this.dgvAttendanceBookings);
            this.pnlAttendance.Controls.Add(this.pnlAttendanceUpdate);
            this.pnlAttendance.Location = new System.Drawing.Point(0, 0);
            this.pnlAttendance.Name = "pnlAttendance";
            this.pnlAttendance.Size = new System.Drawing.Size(980, 750);
            this.pnlAttendance.TabIndex = 3;
            this.pnlAttendance.Visible = false;
            // 
            // lblAttendanceHeading
            // 
            this.lblAttendanceHeading.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblAttendanceHeading.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.lblAttendanceHeading.Location = new System.Drawing.Point(20, 16);
            this.lblAttendanceHeading.Name = "lblAttendanceHeading";
            this.lblAttendanceHeading.Size = new System.Drawing.Size(500, 36);
            this.lblAttendanceHeading.TabIndex = 0;
            this.lblAttendanceHeading.Text = "Mark Booking Attendance";
            // 
            // dgvAttendanceBookings
            // 
            this.dgvAttendanceBookings.AllowUserToAddRows = false;
            this.dgvAttendanceBookings.AllowUserToDeleteRows = false;
            this.dgvAttendanceBookings.AllowUserToResizeRows = false;
            this.dgvAttendanceBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendanceBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(50)))));
            this.dgvAttendanceBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendanceBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAttendanceBookings.ColumnHeadersHeight = 34;
            this.dgvAttendanceBookings.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.dgvAttendanceBookings.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.dgvAttendanceBookings.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(53)))));
            this.dgvAttendanceBookings.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.dgvAttendanceBookings.EnableHeadersVisualStyles = false;
            this.dgvAttendanceBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.dgvAttendanceBookings.Location = new System.Drawing.Point(20, 60);
            this.dgvAttendanceBookings.MultiSelect = false;
            this.dgvAttendanceBookings.Name = "dgvAttendanceBookings";
            this.dgvAttendanceBookings.ReadOnly = true;
            this.dgvAttendanceBookings.RowHeadersVisible = false;
            this.dgvAttendanceBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendanceBookings.Size = new System.Drawing.Size(940, 480);
            this.dgvAttendanceBookings.TabIndex = 1;
            this.dgvAttendanceBookings.SelectionChanged += new System.EventHandler(this.dgvAttendanceBookings_SelectionChanged);
            // 
            // pnlAttendanceUpdate
            // 
            this.pnlAttendanceUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.pnlAttendanceUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlAttendanceUpdate.Controls.Add(this.lblSelectedBookingInfo);
            this.pnlAttendanceUpdate.Controls.Add(this.lblMarkAttCap);
            this.pnlAttendanceUpdate.Controls.Add(this.cboAttendanceStatus);
            this.pnlAttendanceUpdate.Controls.Add(this.btnSaveAttendance);
            this.pnlAttendanceUpdate.Location = new System.Drawing.Point(20, 554);
            this.pnlAttendanceUpdate.Name = "pnlAttendanceUpdate";
            this.pnlAttendanceUpdate.Size = new System.Drawing.Size(940, 170);
            this.pnlAttendanceUpdate.TabIndex = 2;
            // 
            // lblSelectedBookingInfo
            // 
            this.lblSelectedBookingInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectedBookingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(194)))));
            this.lblSelectedBookingInfo.Location = new System.Drawing.Point(16, 14);
            this.lblSelectedBookingInfo.Name = "lblSelectedBookingInfo";
            this.lblSelectedBookingInfo.Size = new System.Drawing.Size(700, 24);
            this.lblSelectedBookingInfo.TabIndex = 0;
            this.lblSelectedBookingInfo.Text = "Select a booking row above to mark attendance.";
            // 
            // lblMarkAttCap
            // 
            this.lblMarkAttCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarkAttCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblMarkAttCap.Location = new System.Drawing.Point(16, 50);
            this.lblMarkAttCap.Name = "lblMarkAttCap";
            this.lblMarkAttCap.Size = new System.Drawing.Size(200, 18);
            this.lblMarkAttCap.TabIndex = 1;
            this.lblMarkAttCap.Text = "MARK ATTENDANCE STATUS:";
            // 
            // cboAttendanceStatus
            // 
            this.cboAttendanceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(56)))));
            this.cboAttendanceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAttendanceStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboAttendanceStatus.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.cboAttendanceStatus.Location = new System.Drawing.Point(16, 72);
            this.cboAttendanceStatus.Name = "cboAttendanceStatus";
            this.cboAttendanceStatus.Size = new System.Drawing.Size(240, 28);
            this.cboAttendanceStatus.TabIndex = 2;
            // 
            // btnSaveAttendance
            // 
            this.btnSaveAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(53)))));
            this.btnSaveAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAttendance.FlatAppearance.BorderSize = 0;
            this.btnSaveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveAttendance.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnSaveAttendance.Location = new System.Drawing.Point(280, 68);
            this.btnSaveAttendance.Name = "btnSaveAttendance";
            this.btnSaveAttendance.Size = new System.Drawing.Size(260, 44);
            this.btnSaveAttendance.TabIndex = 3;
            this.btnSaveAttendance.Text = "💾  Save Attendance Status";
            this.btnSaveAttendance.UseVisualStyleBackColor = false;
            this.btnSaveAttendance.Click += new System.EventHandler(this.btnSaveAttendance_Click);
            // 
            // pnlReports
            // 
            this.pnlReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(46)))));
            this.pnlReports.Controls.Add(this.lblReportsHeading);
            this.pnlReports.Controls.Add(this.pnlChartBar);
            this.pnlReports.Controls.Add(this.pnlChartFunnel);
            this.pnlReports.Controls.Add(this.pnlChartArea);
            this.pnlReports.Controls.Add(this.rtbReportOutput);
            this.pnlReports.Controls.Add(this.btnGenerateReport);
            this.pnlReports.Controls.Add(this.btnExportReport);
            this.pnlReports.Controls.Add(this.btnOpenTicketsFolder);
            this.pnlReports.Location = new System.Drawing.Point(0, 0);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(980, 750);
            this.pnlReports.TabIndex = 4;
            this.pnlReports.Visible = false;
            // 
            // lblReportsHeading
            // 
            this.lblReportsHeading.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblReportsHeading.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.lblReportsHeading.Location = new System.Drawing.Point(20, 14);
            this.lblReportsHeading.Name = "lblReportsHeading";
            this.lblReportsHeading.Size = new System.Drawing.Size(760, 34);
            this.lblReportsHeading.TabIndex = 0;
            this.lblReportsHeading.Text = "Booking && Attendance Reports — Bklit UI System Analytics";
            // 
            // pnlChartBar
            // 
            this.pnlChartBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.pnlChartBar.Location = new System.Drawing.Point(20, 54);
            this.pnlChartBar.Name = "pnlChartBar";
            this.pnlChartBar.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlChartBar_Paint);
            this.pnlChartBar.Size = new System.Drawing.Size(304, 290);
            this.pnlChartBar.TabIndex = 4;
            // 
            // pnlChartFunnel
            // 
            this.pnlChartFunnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.pnlChartFunnel.Location = new System.Drawing.Point(338, 54);
            this.pnlChartFunnel.Name = "pnlChartFunnel";
            this.pnlChartFunnel.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlChartFunnel_Paint);
            this.pnlChartFunnel.Size = new System.Drawing.Size(304, 290);
            this.pnlChartFunnel.TabIndex = 5;
            // 
            // pnlChartArea
            // 
            this.pnlChartArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.pnlChartArea.Location = new System.Drawing.Point(656, 54);
            this.pnlChartArea.Name = "pnlChartArea";
            this.pnlChartArea.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlChartArea_Paint);
            this.pnlChartArea.Size = new System.Drawing.Size(304, 290);
            this.pnlChartArea.TabIndex = 6;
            // 
            // rtbReportOutput
            // 
            this.rtbReportOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(65)))), ((int)(((byte)(51)))));
            this.rtbReportOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbReportOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbReportOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(196)))));
            this.rtbReportOutput.Location = new System.Drawing.Point(20, 356);
            this.rtbReportOutput.Name = "rtbReportOutput";
            this.rtbReportOutput.ReadOnly = true;
            this.rtbReportOutput.Size = new System.Drawing.Size(940, 288);
            this.rtbReportOutput.TabIndex = 1;
            this.rtbReportOutput.Text = "";
            this.rtbReportOutput.WordWrap = false;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnGenerateReport.Location = new System.Drawing.Point(20, 656);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(220, 46);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "🔄  Refresh Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnOpenTicketsFolder
            // 
            this.btnOpenTicketsFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(169)))), ((int)(((byte)(119)))));
            this.btnOpenTicketsFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenTicketsFolder.FlatAppearance.BorderSize = 0;
            this.btnOpenTicketsFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenTicketsFolder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenTicketsFolder.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnOpenTicketsFolder.Location = new System.Drawing.Point(550, 656);
            this.btnOpenTicketsFolder.Name = "btnOpenTicketsFolder";
            this.btnOpenTicketsFolder.Size = new System.Drawing.Size(220, 46);
            this.btnOpenTicketsFolder.TabIndex = 4;
            this.btnOpenTicketsFolder.Text = "🎫  Open PDF Tickets";
            this.btnOpenTicketsFolder.UseVisualStyleBackColor = false;
            this.btnOpenTicketsFolder.Click += new System.EventHandler(this.btnOpenTicketsFolder_Click);
            // 
            // btnExportReport
            // 
            this.btnExportReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(53)))));
            this.btnExportReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportReport.FlatAppearance.BorderSize = 0;
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportReport.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnExportReport.Location = new System.Drawing.Point(260, 656);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(280, 46);
            this.btnExportReport.TabIndex = 3;
            this.btnExportReport.Text = "💾  Export to /Data/Reports";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // pnlChangePassword
            // 
            this.pnlChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(46)))));
            this.pnlChangePassword.Controls.Add(this.lblChangePassHeading);
            this.pnlChangePassword.Controls.Add(this.lblChangePassSub);
            this.pnlChangePassword.Controls.Add(this.lblCurrPassCap);
            this.pnlChangePassword.Controls.Add(this.txtCurrentPassword);
            this.pnlChangePassword.Controls.Add(this.lblNewPassCap);
            this.pnlChangePassword.Controls.Add(this.txtNewPassword);
            this.pnlChangePassword.Controls.Add(this.lblConfPassCap);
            this.pnlChangePassword.Controls.Add(this.txtConfirmPassword);
            this.pnlChangePassword.Controls.Add(this.lblPassError);
            this.pnlChangePassword.Controls.Add(this.btnSavePassword);
            this.pnlChangePassword.Location = new System.Drawing.Point(0, 0);
            this.pnlChangePassword.Name = "pnlChangePassword";
            this.pnlChangePassword.Size = new System.Drawing.Size(980, 750);
            this.pnlChangePassword.TabIndex = 5;
            this.pnlChangePassword.Visible = false;
            // 
            // lblChangePassHeading
            // 
            this.lblChangePassHeading.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblChangePassHeading.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.lblChangePassHeading.Location = new System.Drawing.Point(30, 20);
            this.lblChangePassHeading.Name = "lblChangePassHeading";
            this.lblChangePassHeading.Size = new System.Drawing.Size(500, 36);
            this.lblChangePassHeading.TabIndex = 0;
            this.lblChangePassHeading.Text = "Change Admin Password";
            // 
            // lblChangePassSub
            // 
            this.lblChangePassSub.Font = new System.Drawing.Font("Arial", 10F);
            this.lblChangePassSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblChangePassSub.Location = new System.Drawing.Point(30, 60);
            this.lblChangePassSub.Name = "lblChangePassSub";
            this.lblChangePassSub.Size = new System.Drawing.Size(600, 24);
            this.lblChangePassSub.TabIndex = 1;
            this.lblChangePassSub.Text = "Enter your current password and set a new password.";
            // 
            // lblCurrPassCap
            // 
            this.lblCurrPassCap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrPassCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblCurrPassCap.Location = new System.Drawing.Point(30, 104);
            this.lblCurrPassCap.Name = "lblCurrPassCap";
            this.lblCurrPassCap.Size = new System.Drawing.Size(200, 18);
            this.lblCurrPassCap.TabIndex = 2;
            this.lblCurrPassCap.Text = "CURRENT PASSWORD";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(56)))));
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.txtCurrentPassword.Location = new System.Drawing.Point(30, 124);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(460, 32);
            this.txtCurrentPassword.TabIndex = 3;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassCap
            // 
            this.lblNewPassCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewPassCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblNewPassCap.Location = new System.Drawing.Point(30, 176);
            this.lblNewPassCap.Name = "lblNewPassCap";
            this.lblNewPassCap.Size = new System.Drawing.Size(200, 18);
            this.lblNewPassCap.TabIndex = 4;
            this.lblNewPassCap.Text = "NEW PASSWORD";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(56)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.txtNewPassword.Location = new System.Drawing.Point(30, 196);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(460, 32);
            this.txtNewPassword.TabIndex = 5;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfPassCap
            // 
            this.lblConfPassCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfPassCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblConfPassCap.Location = new System.Drawing.Point(30, 248);
            this.lblConfPassCap.Name = "lblConfPassCap";
            this.lblConfPassCap.Size = new System.Drawing.Size(200, 18);
            this.lblConfPassCap.TabIndex = 6;
            this.lblConfPassCap.Text = "CONFIRM NEW PASSWORD";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(56)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 268);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(460, 32);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblPassError
            // 
            this.lblPassError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPassError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(126)))), ((int)(((byte)(114)))));
            this.lblPassError.Location = new System.Drawing.Point(30, 320);
            this.lblPassError.Name = "lblPassError";
            this.lblPassError.Size = new System.Drawing.Size(600, 20);
            this.lblPassError.TabIndex = 8;
            this.lblPassError.Visible = false;
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.btnSavePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePassword.FlatAppearance.BorderSize = 0;
            this.btnSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSavePassword.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.btnSavePassword.Location = new System.Drawing.Point(30, 350);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(240, 48);
            this.btnSavePassword.TabIndex = 9;
            this.btnSavePassword.Text = "Update Password";
            this.btnSavePassword.UseVisualStyleBackColor = false;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(46)))));
            this.pnlNotifications.Controls.Add(this.lblNotifHeading);
            this.pnlNotifications.Controls.Add(this.lblNotifSub);
            this.pnlNotifications.Controls.Add(this.cardNotifTotal);
            this.pnlNotifications.Controls.Add(this.cardNotifUnread);
            this.pnlNotifications.Controls.Add(this.cardNotifRead);
            this.pnlNotifications.Controls.Add(this.lblNotifGridHeading);
            this.pnlNotifications.Controls.Add(this.dgvMessages);
            this.pnlNotifications.Location = new System.Drawing.Point(0, 0);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(980, 750);
            this.pnlNotifications.TabIndex = 8;
            this.pnlNotifications.Visible = false;
            // 
            // lblNotifHeading
            // 
            this.lblNotifHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNotifHeading.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.lblNotifHeading.Location = new System.Drawing.Point(24, 18);
            this.lblNotifHeading.Name = "lblNotifHeading";
            this.lblNotifHeading.Size = new System.Drawing.Size(700, 36);
            this.lblNotifHeading.Text = "Notifications & Contact Us Messages";
            // 
            // lblNotifSub
            // 
            this.lblNotifSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNotifSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.lblNotifSub.Location = new System.Drawing.Point(24, 56);
            this.lblNotifSub.Name = "lblNotifSub";
            this.lblNotifSub.Size = new System.Drawing.Size(820, 22);
            this.lblNotifSub.Text = "Visitor inquiries submitted via Contact Us. Double-click any message row to read full details and mark it as read.";
            // 
            // cardNotifTotal
            // 
            this.cardNotifTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.cardNotifTotal.Controls.Add(this.lblNotifTotal);
            this.cardNotifTotal.Controls.Add(this.lblNotifTotalCap);
            this.cardNotifTotal.Location = new System.Drawing.Point(24, 92);
            this.cardNotifTotal.Name = "cardNotifTotal";
            this.cardNotifTotal.Size = new System.Drawing.Size(220, 88);
            // 
            // lblNotifTotal
            // 
            this.lblNotifTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNotifTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(134)))), ((int)(((byte)(87)))));
            this.lblNotifTotal.Location = new System.Drawing.Point(10, 8);
            this.lblNotifTotal.Name = "lblNotifTotal";
            this.lblNotifTotal.Size = new System.Drawing.Size(200, 44);
            this.lblNotifTotal.Text = "0";
            this.lblNotifTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotifTotalCap
            // 
            this.lblNotifTotalCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNotifTotalCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.lblNotifTotalCap.Location = new System.Drawing.Point(10, 54);
            this.lblNotifTotalCap.Name = "lblNotifTotalCap";
            this.lblNotifTotalCap.Size = new System.Drawing.Size(200, 24);
            this.lblNotifTotalCap.Text = "Total Messages";
            this.lblNotifTotalCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardNotifUnread
            // 
            this.cardNotifUnread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.cardNotifUnread.Controls.Add(this.lblNotifUnread);
            this.cardNotifUnread.Controls.Add(this.lblNotifUnreadCap);
            this.cardNotifUnread.Location = new System.Drawing.Point(264, 92);
            this.cardNotifUnread.Name = "cardNotifUnread";
            this.cardNotifUnread.Size = new System.Drawing.Size(220, 88);
            // 
            // lblNotifUnread
            // 
            this.lblNotifUnread.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNotifUnread.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(169)))), ((int)(((byte)(119)))));
            this.lblNotifUnread.Location = new System.Drawing.Point(10, 8);
            this.lblNotifUnread.Name = "lblNotifUnread";
            this.lblNotifUnread.Size = new System.Drawing.Size(200, 44);
            this.lblNotifUnread.Text = "0";
            this.lblNotifUnread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotifUnreadCap
            // 
            this.lblNotifUnreadCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNotifUnreadCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.lblNotifUnreadCap.Location = new System.Drawing.Point(10, 54);
            this.lblNotifUnreadCap.Name = "lblNotifUnreadCap";
            this.lblNotifUnreadCap.Size = new System.Drawing.Size(200, 24);
            this.lblNotifUnreadCap.Text = "Unread";
            this.lblNotifUnreadCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardNotifRead
            // 
            this.cardNotifRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(52)))));
            this.cardNotifRead.Controls.Add(this.lblNotifRead);
            this.cardNotifRead.Controls.Add(this.lblNotifReadCap);
            this.cardNotifRead.Location = new System.Drawing.Point(504, 92);
            this.cardNotifRead.Name = "cardNotifRead";
            this.cardNotifRead.Size = new System.Drawing.Size(220, 88);
            // 
            // lblNotifRead
            // 
            this.lblNotifRead.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNotifRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(53)))));
            this.lblNotifRead.Location = new System.Drawing.Point(10, 8);
            this.lblNotifRead.Name = "lblNotifRead";
            this.lblNotifRead.Size = new System.Drawing.Size(200, 44);
            this.lblNotifRead.Text = "0";
            this.lblNotifRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotifReadCap
            // 
            this.lblNotifReadCap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNotifReadCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.lblNotifReadCap.Location = new System.Drawing.Point(10, 54);
            this.lblNotifReadCap.Name = "lblNotifReadCap";
            this.lblNotifReadCap.Size = new System.Drawing.Size(200, 24);
            this.lblNotifReadCap.Text = "Read";
            this.lblNotifReadCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotifGridHeading
            // 
            this.lblNotifGridHeading.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNotifGridHeading.ForeColor = System.Drawing.Color.FromArgb(232, 220, 194);
            this.lblNotifGridHeading.Location = new System.Drawing.Point(24, 196);
            this.lblNotifGridHeading.Name = "lblNotifGridHeading";
            this.lblNotifGridHeading.Size = new System.Drawing.Size(340, 24);
            this.lblNotifGridHeading.Text = "Recent Messages";
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(50)))));
            this.dgvMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMessages.Location = new System.Drawing.Point(24, 228);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.RowHeadersVisible = false;
            this.dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessages.Size = new System.Drawing.Size(930, 480);
            this.dgvMessages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMessages_CellDoubleClick);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(960, 620);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Horizons Tours – Admin Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlOverview.ResumeLayout(false);
            this.tileBookings.ResumeLayout(false);
            this.tileRevenue.ResumeLayout(false);
            this.tileUpcoming.ResumeLayout(false);
            this.tileSeatsLeft.ResumeLayout(false);
            this.pnlShortcuts.ResumeLayout(false);
            this.pnlActivities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActImagePreview)).EndInit();
            this.pnlActivityForm.ResumeLayout(false);
            this.pnlActivityForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailableSeats)).EndInit();
            this.pnlBookings.ResumeLayout(false);
            this.pnlBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).EndInit();
            this.pnlAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceBookings)).EndInit();
            this.pnlAttendanceUpdate.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.pnlChangePassword.ResumeLayout(false);
            this.pnlChangePassword.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAdminBrand;
        private System.Windows.Forms.Label lblAdminPortalSub;
        private System.Windows.Forms.Label lblSidebarUser;
        private System.Windows.Forms.Button btnNavOverview;
        private System.Windows.Forms.Button btnNavActivities;
        private System.Windows.Forms.Button btnNavBookings;
        private System.Windows.Forms.Button btnNavAttendance;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnNavChangePass;
        private System.Windows.Forms.Button btnNavLogout;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Label lblOverviewHeading;
        private System.Windows.Forms.Label lblOverviewSub;
        private System.Windows.Forms.Panel tileBookings;
        private System.Windows.Forms.Label lblTileBookings;
        private System.Windows.Forms.Label lblTileBookingsCap;
        private System.Windows.Forms.Panel tileRevenue;
        private System.Windows.Forms.Label lblTileRevenue;
        private System.Windows.Forms.Label lblTileRevenueCap;
        private System.Windows.Forms.Panel tileUpcoming;
        private System.Windows.Forms.Label lblTileUpcoming;
        private System.Windows.Forms.Label lblTileUpcomingCap;
        private System.Windows.Forms.Panel tileSeatsLeft;
        private System.Windows.Forms.Label lblTileSeatsLeft;
        private System.Windows.Forms.Label lblTileSeatsLeftCap;
        private System.Windows.Forms.Panel pnlShortcuts;
        private System.Windows.Forms.Label lblShortcutsHeading;
        private System.Windows.Forms.Button btnShortcutActivities;
        private System.Windows.Forms.Button btnShortcutBookings;
        private System.Windows.Forms.Button btnShortcutAttendance;
        private System.Windows.Forms.Button btnShortcutReports;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.Label lblActivitiesHeading;
        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.Panel pnlActivityForm;
        private System.Windows.Forms.Label lblActivityFormTitle;
        private System.Windows.Forms.Label lblCatCap;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblActNameCap;
        private System.Windows.Forms.TextBox txtActName;
        private System.Windows.Forms.Label lblPriceCap;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblDescCap;
        private System.Windows.Forms.TextBox txtActDescription;
        private System.Windows.Forms.Label lblDateCap;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTotalSeatsCap;
        private System.Windows.Forms.NumericUpDown nudTotalSeats;
        private System.Windows.Forms.Label lblAvailSeatsCap;
        private System.Windows.Forms.NumericUpDown nudAvailableSeats;
        private System.Windows.Forms.Label lblActError;
        private System.Windows.Forms.Button btnActAdd;
        private System.Windows.Forms.Button btnActSave;
        private System.Windows.Forms.Button btnActDelete;
        private System.Windows.Forms.Button btnActClear;
        private System.Windows.Forms.Label lblActImageCap;
        private System.Windows.Forms.PictureBox picActImagePreview;
        private System.Windows.Forms.ComboBox cboActImagePreset;
        private System.Windows.Forms.Button btnUploadActImage;
        private System.Windows.Forms.Button btnResetActImage;
        private System.Windows.Forms.Label lblActImageStatus;
        private System.Windows.Forms.Button btnBookingEditImage;
        private System.Windows.Forms.Button btnNavNotifications;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.Label lblNotifHeading;
        private System.Windows.Forms.Label lblNotifSub;
        private System.Windows.Forms.Panel cardNotifTotal;
        private System.Windows.Forms.Label lblNotifTotal;
        private System.Windows.Forms.Label lblNotifTotalCap;
        private System.Windows.Forms.Panel cardNotifUnread;
        private System.Windows.Forms.Label lblNotifUnread;
        private System.Windows.Forms.Label lblNotifUnreadCap;
        private System.Windows.Forms.Panel cardNotifRead;
        private System.Windows.Forms.Label lblNotifRead;
        private System.Windows.Forms.Label lblNotifReadCap;
        private System.Windows.Forms.Label lblNotifGridHeading;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.Panel pnlBookings;
        private System.Windows.Forms.Label lblBookingsHeading;
        private System.Windows.Forms.Label lblBookingSearchCap;
        private System.Windows.Forms.TextBox txtBookingSearch;
        private System.Windows.Forms.Label lblBookingFilterCap;
        private System.Windows.Forms.ComboBox cboBookingActivityFilter;
        private System.Windows.Forms.CheckBox chkEnableDateFilter;
        private System.Windows.Forms.DateTimePicker dtpBookingDateFilter;
        private System.Windows.Forms.DataGridView dgvAllBookings;
        private System.Windows.Forms.Panel pnlAttendance;
        private System.Windows.Forms.Label lblAttendanceHeading;
        private System.Windows.Forms.DataGridView dgvAttendanceBookings;
        private System.Windows.Forms.Panel pnlAttendanceUpdate;
        private System.Windows.Forms.Label lblSelectedBookingInfo;
        private System.Windows.Forms.Label lblMarkAttCap;
        private System.Windows.Forms.ComboBox cboAttendanceStatus;
        private System.Windows.Forms.Button btnSaveAttendance;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Label lblReportsHeading;
        private System.Windows.Forms.Panel pnlChartBar;
        private System.Windows.Forms.Panel pnlChartFunnel;
        private System.Windows.Forms.Panel pnlChartArea;
        private System.Windows.Forms.RichTextBox rtbReportOutput;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button btnOpenTicketsFolder;
        private System.Windows.Forms.Panel pnlChangePassword;
        private System.Windows.Forms.Label lblChangePassHeading;
        private System.Windows.Forms.Label lblChangePassSub;
        private System.Windows.Forms.Label lblCurrPassCap;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblNewPassCap;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfPassCap;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblPassError;
        private System.Windows.Forms.Button btnSavePassword;
    }
}
