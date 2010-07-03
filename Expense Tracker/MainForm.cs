using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class MainForm : Form
    {
        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;
        SQLiteDataReader sql_reader;

        string applicationPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ExpenseTracker";

        private Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly MyAssembly, objExecutingAssemblies;
            string assemblyPath = "";

            objExecutingAssemblies = Assembly.GetExecutingAssembly();
            AssemblyName[] arrReferencedAssemblyNames = objExecutingAssemblies.GetReferencedAssemblies();

            foreach (AssemblyName assemblyName in arrReferencedAssemblyNames)
            {
                if (assemblyName.FullName.Substring(0, assemblyName.FullName.IndexOf(',')) == args.Name.Substring(0, args.Name.IndexOf(',')))
                {
                    assemblyPath = applicationPath + "\\" + args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";
                    break;
                }
            }

            MyAssembly = Assembly.LoadFrom(assemblyPath);

            return MyAssembly;
        }

        public MainForm()
        {
            Password pwd = new Password();
            pwd.ShowDialog();

            InitializeComponent();

            // Copy DLL to %APPDATA% directory
            if (!Directory.Exists(applicationPath))
            {
                Directory.CreateDirectory(applicationPath);
            }
            if (!File.Exists(applicationPath + "\\ExpenseTracker.db"))
            {
                File.WriteAllBytes(applicationPath + "\\ExpenseTracker.db", Properties.Resources.ExpenseTracker);
            }
            if (!File.Exists(applicationPath + "\\SQLite.dll"))
            {
                File.WriteAllBytes(applicationPath + "\\SQLite.dll", Properties.Resources.SQLite);
                File.SetAttributes(applicationPath + "\\SQLite.dll", FileAttributes.Hidden);
            }
            if (!File.Exists(applicationPath + "\\ZedGraph.dll"))
            {
                File.WriteAllBytes(applicationPath + "\\ZedGraph.dll", Properties.Resources.ZedGraph);
                File.SetAttributes(applicationPath + "\\ZedGraph.dll", FileAttributes.Hidden);
            }

            // Connect to database file
            sql_con = new SQLiteConnection("Data Source=" + applicationPath + "\\ExpenseTracker.db;Version=3;New=False;Compress=True;");
            sql_cmd = new SQLiteCommand();
            sql_con.Open();
            sql_cmd.Connection = sql_con;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Resolve assemblies path
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.AssemblyResolve += new ResolveEventHandler(MyResolveEventHandler);

            // Is there a record for this month ?
            // If not then create one
            sql_cmd.CommandText = "SELECT * FROM Month WHERE Year = '" + CustomDate.GetThaiYear(DateTime.Today.Year) + "' AND Month = '" + DateTime.Today.Month + "'";
            sql_reader = sql_cmd.ExecuteReader();
            if (!sql_reader.HasRows)
            {
                sql_reader.Close();
                sql_cmd.CommandText = "INSERT INTO Month VALUES('" + CustomDate.GetThaiYear(DateTime.Today.Year) + "','" + DateTime.Today.Month + "',0,0,0)";
                sql_cmd.ExecuteNonQuery();

                string[] split = DateTime.Now.ToLongDateString().Split(' ');
                toolStripHeader.Text = "บัญชีรับ-จ่าย ประจำเดือน " + split[1] + " พ.ศ. " + split[2];
            }
            else
            {
                sql_reader.Close();
                LoadCurrentMonth();
            }

            LoadHistoryList();
        }

        private void toolStripAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransactionForm frm = new AddTransactionForm();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dataGridView.Rows.Add(new Object[] {
                    frm.dateTimePicker.Value.Day + " " + CustomDate.GetThaiMonth(frm.dateTimePicker.Value.Month) + " " + CustomDate.GetThaiYear(frm.dateTimePicker.Value.Year),
                    frm.txtboxDescription.Text,
                    frm.cmbType.SelectedItem.ToString(),
                    (frm.cmbType.SelectedItem.ToString() == "รับ")? Properties.Resources._in : Properties.Resources._out,
                    Decimal.Parse(frm.txtboxAmount.Text).ToString("#,#0.00#")
                });

                sql_cmd.CommandText = "INSERT INTO Detail(Year,Month,Date,Description,Type,Amount) VALUES('" + CustomDate.GetThaiYear(DateTime.Today.Year) + "','" + DateTime.Today.Month + "','" + frm.dateTimePicker.Value.Day + " " + CustomDate.GetThaiMonth(frm.dateTimePicker.Value.Month) + " " + CustomDate.GetThaiYear(frm.dateTimePicker.Value.Year) + "','" + frm.txtboxDescription.Text + "','" + frm.cmbType.SelectedItem.ToString() + "','" + frm.txtboxAmount.Text + "')";
                sql_cmd.ExecuteNonQuery();

                UpdateTotalInDB();
            }
            frm.Dispose();
            dataGridView.Sort(dataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            dataGridView.ClearSelection();
        }

        private void CalculateTotal()
        {
            decimal totalIn = 0;
            decimal totalEx = 0;
            decimal totalBl = 0;

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (dataGridView.Rows[i].Cells[2].Value.ToString().Equals("รับ"))
                {
                    totalIn += Decimal.Parse(dataGridView.Rows[i].Cells[4].Value.ToString());
                }

                if (dataGridView.Rows[i].Cells[2].Value.ToString().Equals("จ่าย"))
                {
                    totalEx += Decimal.Parse(dataGridView.Rows[i].Cells[4].Value.ToString());
                }
            }

            totalBl = totalIn - totalEx;

            txtboxTotalIncome.Text = totalIn.ToString("#,#0.00#");
            txtboxTotalExpense.Text = totalEx.ToString("#,#0.00#");
            txtboxTotalBalance.Text = (totalIn - totalEx).ToString("#,#0.00#");
            txtboxTotalBalance.ForeColor = (totalBl >= 0) ? Color.Black : Color.Red;
        }

        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                toolStripAddTransaction_Click(sender, e);
            }
        }

        private void dataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView.RowCount > 0)
            {
                CalculateTotal();
            }
            else
            {
                txtboxTotalIncome.Text = "0.00";
                txtboxTotalExpense.Text = "0.00";
                txtboxTotalBalance.Text = "0.00";
                txtboxTotalBalance.ForeColor = Color.Black;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sql_con.Close();
        }

        private void toolStripViewHistory_Click(object sender, EventArgs e)
        {
            if (groupBox.Visible == false)
                OpenGroupBox();
            else
                CloseGroupBox();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != -1 && cmbMonth.SelectedIndex != -1)
            {
                toolStripAddTransaction.Visible = false;
                toolStripViewHistory.Visible = false;
                toolStripBackToPresent.Visible = true;

                LoadHistory();
            }
        }

        private void toolStripBackToPresent_Click(object sender, EventArgs e)
        {
            CloseGroupBox();

            toolStripAddTransaction.Visible = true;
            toolStripViewHistory.Visible = true;
            toolStripBackToPresent.Visible = false;

            LoadCurrentMonth();
        }

        private void LoadCurrentMonth()
        {
            toolStripHeader.Text = "บัญชีรับ-จ่าย ประจำเดือน " + CustomDate.GetThaiMonth(DateTime.Today.Month) + " พ.ศ. " + CustomDate.GetThaiYear(DateTime.Today.Year);

            ClearTable();

            // Load data for this month
            sql_cmd.CommandText = "SELECT Date, Description, Type, Amount FROM Detail WHERE Year = '" + CustomDate.GetThaiYear(DateTime.Today.Year) + "' AND Month = '" + DateTime.Today.Month + "'";
            sql_reader = sql_cmd.ExecuteReader();
            while (sql_reader.Read())
            {
                dataGridView.Rows.Add(new Object[] {
                        sql_reader.GetString(0),
                        sql_reader.GetString(1),
                        sql_reader.GetString(2),
                        (sql_reader.GetString(2) == "รับ")? Properties.Resources._in : Properties.Resources._out,
                        sql_reader.GetDecimal(3)
                    });
            }
            sql_reader.Close();

            dataGridView.Sort(dataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            dataGridView.ClearSelection();
        }

        private void LoadHistory()
        {
            toolStripHeader.Text = "บัญชีรับ-จ่าย ประจำเดือน " + cmbMonth.SelectedItem +" พ.ศ. " + cmbYear.SelectedItem;
            
            ClearTable();

            sql_cmd.CommandText = "SELECT Date, Description, Type, Amount FROM Detail WHERE Year = '" + cmbYear.SelectedItem + "' AND Month = '" + cmbMonth.SelectedItem + "'";
            sql_reader = sql_cmd.ExecuteReader();
            while (sql_reader.Read())
            {
                dataGridView.Rows.Add(new Object[] {
                    sql_reader.GetString(0),
                    sql_reader.GetString(1),
                    sql_reader.GetString(2),
                    (sql_reader.GetString(2) == "รับ")? Properties.Resources._in : Properties.Resources._out,
                    sql_reader.GetDecimal(3)
                });
            }
            sql_reader.Close();

            dataGridView.Sort(dataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            dataGridView.ClearSelection();
        }

        private void ClearTable()
        {
            int rowCount = dataGridView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                dataGridView.Rows.RemoveAt(0);
            }
        }

        private void btnCloseGroupBox_Click(object sender, EventArgs e)
        {
            CloseGroupBox();

            toolStripAddTransaction.Visible = true;
            toolStripViewHistory.Visible = true;
            toolStripBackToPresent.Visible = false;

            LoadCurrentMonth();
        }

        private void OpenGroupBox()
        {
            groupBox.Visible = true;

            Cursor.Position = new System.Drawing.Point(Cursor.Position.X, this.PointToScreen(toolStrip.Location).Y + 20);
        }

        private void CloseGroupBox()
        {
            groupBox.Visible = false;

            Cursor.Position = new System.Drawing.Point(Cursor.Position.X, this.PointToScreen(toolStrip.Location).Y + 20);

            cmbYear.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1;
        }

        private void LoadHistoryList()
        {
            sql_cmd.CommandText = "SELECT DISTINCT Year FROM Month WHERE Year != '" + CustomDate.GetThaiYear(DateTime.Today.Year) + "' OR Month != '" + DateTime.Today.Month + "'";
            sql_reader = sql_cmd.ExecuteReader();
            if (sql_reader.HasRows)
            {
                while (sql_reader.Read())
                {
                    cmbYear.Items.Add(sql_reader.GetString(0));
                }
                cmbYear.Enabled = true;
            }
            else
            {
                cmbYear.Enabled = false;
            }
            sql_reader.Close();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != -1)
            {
                cmbMonth.Items.Clear();

                sql_cmd.CommandText = "SELECT DISTINCT Month FROM Month WHERE Year = '" + cmbYear.SelectedItem + "' AND Month != '" + DateTime.Today.Month + "'";
                sql_reader = sql_cmd.ExecuteReader();
                if (sql_reader.HasRows)
                {
                    while (sql_reader.Read())
                    {
                        cmbMonth.Items.Add(CustomDate.GetThaiMonth(sql_reader.GetInt32(0)));
                    }
                    cmbMonth.Enabled = true;
                }
                else
                {
                    cmbMonth.Enabled = false;
                }
                sql_reader.Close();
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShowData.Enabled = (cmbMonth.SelectedIndex != -1) ? true : false;
        }

        private void dataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F1:
                    toolStripAddTransaction_Click(sender, e);
                    break;
                case Keys.Delete:
                    if (dataGridView.SelectedRows.Count == 1)
                        DeleteTransaction();
                    break;
            }
        }

        private void DeleteTransaction()
        {
            if (MessageBox.Show("Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                sql_cmd.CommandText = "DELETE FROM Detail WHERE Year = '" + CustomDate.GetThaiYear(DateTime.Today.Year) + "' AND Month = '" + DateTime.Today.Month + "' AND Date = '" + dataGridView.SelectedRows[0].Cells[0].Value + "' AND Description = '" + dataGridView.SelectedRows[0].Cells[1].Value + "' AND Type = '" + dataGridView.SelectedRows[0].Cells[2].Value + "' AND Amount = '" + dataGridView.SelectedRows[0].Cells[4].Value + "'";
                sql_cmd.ExecuteNonQuery();

                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);

                UpdateTotalInDB();

                dataGridView.ClearSelection();
            }
        }

        private void UpdateTotalInDB()
        {
            sql_cmd.CommandText = "UPDATE Month SET TotalIncome = '" + Decimal.Parse(txtboxTotalIncome.Text) + "', TotalExpense = '" + Decimal.Parse(txtboxTotalExpense.Text) + "', TotalBalance = '" + Decimal.Parse(txtboxTotalBalance.Text) + "' WHERE Year = '" + CustomDate.GetThaiYear(DateTime.Today.Year) + "' AND Month = '" + DateTime.Today.Month + "'";
            sql_cmd.ExecuteNonQuery();
        }

        private void toolStripReport_Click(object sender, EventArgs e)
        {
            Report rpt = new Report();
            rpt.ShowDialog();
            rpt.Dispose();
        }
    }
}
