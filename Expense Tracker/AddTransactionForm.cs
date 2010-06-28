using System;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class AddTransactionForm : Form
    {
        public AddTransactionForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Hide();
            }
        }

        private bool IsValidated()
        {
            bool validated;
            validated = (txtboxDescription.TextLength > 0) ? true : false;
            validated = (cmbType.SelectedIndex != -1) ? true : false;
            validated = (txtboxAmount.TextLength > 0) ? true : false;
            return validated;
        }

        private void txtboxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || (Keys)(e.KeyChar) == Keys.Back || (Keys)(e.KeyChar) == Keys.Enter);

            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void txtboxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar != '\'' && e.KeyChar != '\"');
        }
    }
}
