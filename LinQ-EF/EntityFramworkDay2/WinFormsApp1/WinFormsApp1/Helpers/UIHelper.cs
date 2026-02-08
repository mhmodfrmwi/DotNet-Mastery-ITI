using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp1.Controls;

namespace WinFormsApp1.Helpers
{
    public static class UIHelper
    {
        // Professional Color Palette (Slate & Royal Blue)
        public static readonly Color PrimaryColor = Color.FromArgb(37, 99, 235);    // Royal Blue #2563EB
        public static readonly Color SecondaryColor = Color.FromArgb(71, 85, 105);  // Slate 600 #475569
        public static readonly Color BackgroundColor = Color.FromArgb(241, 245, 249); // Slate 100 #F1F5F9
        public static readonly Color SurfaceColor = Color.White;
        public static readonly Color TextColor = Color.FromArgb(30, 41, 59);       // Slate 800 #1E293B
        public static readonly Color TextSecondaryColor = Color.FromArgb(100, 116, 139); // Slate 500 #64748B

        // Fonts
        public static readonly Font HeaderFont = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
        public static readonly Font BodyFont = new Font("Segoe UI", 10, FontStyle.Regular);

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public static void MakeRounded(Control control, int radius)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
        }

        public static void ApplyTheme(Form form)
        {
            form.BackColor = BackgroundColor;
            form.ForeColor = TextColor;
            form.Font = BodyFont;
            form.FormBorderStyle = FormBorderStyle.FixedSingle; // Clean look
            form.StartPosition = FormStartPosition.CenterScreen;

            foreach (Control control in form.Controls)
            {
                StyleControl(control);
            }
        }

        public static void StyleControl(Control control)
        {
            if (control is Button btn)
            {
                StyleButton(btn);
            }
            else if (control is Label lbl)
            {
                StyleLabel(lbl);
            }
            else if (control is ModernTextBox mtb)
            {
                StyleModernTextBox(mtb);
            }
            else if (control is TextBox txt)
            {
                StyleTextBox(txt);
            }
            else if (control is Panel pnl)
            {
                pnl.BackColor = SurfaceColor;
                foreach (Control child in pnl.Controls)
                {
                    StyleControl(child);
                }
            }
            else if (control is FlowLayoutPanel flp)
            {
                flp.BackColor = BackgroundColor; // Or transparent
                foreach (Control child in flp.Controls)
                {
                    StyleControl(child);
                }
            }
        }

        public static void StylePrimaryButton(Button btn)
        {
            StyleBaseButton(btn);
            btn.BackColor = PrimaryColor;
            btn.ForeColor = Color.White;
        }

        public static void StyleSecondaryButton(Button btn)
        {
            StyleBaseButton(btn);
            btn.BackColor = SecondaryColor; // Emerald
            btn.ForeColor = Color.White;
        }
        
        public static void StyleDangerButton(Button btn)
        {
            StyleBaseButton(btn);
            btn.BackColor = Color.Crimson; 
            btn.ForeColor = Color.White;
        }

        private static void StyleBaseButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        // Default styling if just passing a generic button
        public static void StyleButton(Button btn)
        {
            // If it's already colored, keep it? Or force primary?
            // Let's force Primary as default for uniformity unless specified otherwise
             if (btn.Name.ToLower().Contains("login") || btn.Name.ToLower().Contains("save") || btn.Name.ToLower().Contains("add"))
            {
                 StylePrimaryButton(btn);
            }
            else if (btn.Name.ToLower().Contains("cancel") || btn.Name.ToLower().Contains("delete"))
            {
                 StyleDangerButton(btn);
            }
            else if (btn.Name.ToLower().Contains("register"))
            {
                StyleSecondaryButton(btn);
            }
            else
            {
                StylePrimaryButton(btn);
            }
        }

        public static void StyleLabel(Label lbl)
        {
            lbl.ForeColor = TextColor;
            lbl.Font = BodyFont;
        }

        public static void StyleHeaderLabel(Label lbl)
        {
            lbl.ForeColor = PrimaryColor;
            lbl.Font = HeaderFont;
        }

        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = BodyFont;
            txt.BackColor = SurfaceColor;
            txt.ForeColor = TextColor;
        }

        public static void StyleModernTextBox(ModernTextBox mtb)
        {
            mtb.Font = BodyFont;
            mtb.BackColor = SurfaceColor;
            mtb.ForeColor = TextColor;
            mtb.BorderColor = PrimaryColor;
            mtb.BorderFocusColor = SecondaryColor;
        }
    }
}
