using EntityExample.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EntityExample.Lib
{
    public class StyleHelper
    {
        public static readonly Font DefaultFont = new Font("Segoe UI", 10);
        public static readonly Font TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

        public static void ApplyGridStyle(System.Windows.Forms.DataGridView grid)
        {
            grid.Font = DefaultFont;
            grid.ColumnHeadersDefaultCellStyle.Font = TitleFont;
            grid.RowTemplate.Height = 30;
            grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            grid.MultiSelect = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
        }
        public static void ApplyButtonStyle(System.Windows.Forms.Button button)
        {
            button.Font = DefaultFont;
            button.BackColor = Color.LightGray;
            button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button.Height = 35;
        }
        public static void ApplyFormStyle(System.Windows.Forms.Form form)
        {
            form.Font = DefaultFont;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            form.BackgroundImage = Resources.Designer;
        }
        public static void ApplyFlowLayoutPanelStyle(System.Windows.Forms.FlowLayoutPanel panel)
        {
            panel.BackColor = Color.FromArgb(150, Color.White);
            panel.FlowDirection = FlowDirection.TopDown;
            panel.WrapContents = true;
            panel.Padding = new Padding(10, 30, 10, 10);
        }
    }
}
