// =============================================================================
// Services/AppPalette.cs
// Single source of truth for the Blue Horizons Tours colour theme.
//
//   Sand   #C2B280   highlights, secondary text, glows
//   Tan    #A68B5B   secondary accent
//   Olive  #6B6F3A   primary accent / buttons / success
//   Dark   #3E3B2F   main background
//   Cream  #E8DCC2   primary text, light surfaces
// =============================================================================

using System.Drawing;

namespace PROJECTT.Services
{
    public static class AppPalette
    {
        public static readonly Color Sand  = Color.FromArgb(0xC2, 0xB2, 0x80);
        public static readonly Color Tan   = Color.FromArgb(0xA6, 0x8B, 0x5B);
        public static readonly Color Olive = Color.FromArgb(0x6B, 0x6F, 0x3A);
        public static readonly Color Dark  = Color.FromArgb(0x3E, 0x3B, 0x2F);
        public static readonly Color Cream = Color.FromArgb(0xE8, 0xDC, 0xC2);
    }
}
