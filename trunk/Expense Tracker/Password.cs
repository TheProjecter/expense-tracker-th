using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class Password : Form
    {
        private string password = "thepuppy";

        public Password()
        {
            InitializeComponent();
        }

        private void txtboxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (txtboxPassword.Text == password)
                {
                    Dispose();
                }
            }
            else if ((Keys)e.KeyChar == Keys.Escape)
            {
                DialogResult = System.Windows.Forms.DialogResult.Abort;
                System.Environment.Exit(0);
            }
        }
    }
}
