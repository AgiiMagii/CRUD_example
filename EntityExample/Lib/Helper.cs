using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityExample.Lib
{
    public class Helper
    {
        public void ReloadGrid<T>(DataGridView grid, List<T> items) where T : class
        {
            grid.DataSource = null;
            grid.DataSource = items;
            grid.AutoResizeColumns();
        }
        public List<T> Paging<T>(List<T> items, int pageNr, int pageSize) where T : class
        {
            int startIndex = (pageNr - 1) * pageSize;
            List<T> pagedItems = items.Skip(startIndex).Take(pageSize).ToList();
            return pagedItems;
        }
        public void ClearForm(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RichTextBox)
                {
                    ((RichTextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearForm(control.Controls);
                }
            }
        }

    }
}
