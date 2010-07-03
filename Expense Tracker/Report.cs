using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class Report : Form
    {
        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;
        SQLiteDataReader sql_reader;

        string applicationPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ExpenseTracker";


        public Report()
        {
            InitializeComponent();

            // Connect to database file
            sql_con = new SQLiteConnection("Data Source=" + applicationPath + "\\ExpenseTracker.db;Version=3;New=False;Compress=True;");
            sql_cmd = new SQLiteCommand();
            sql_con.Open();
            sql_cmd.Connection = sql_con;
            sql_cmd.CommandText = "SELECT * FROM Month";
            sql_reader = sql_cmd.ExecuteReader();
            while (sql_reader.Read())
            {
                dataGridView.Rows.Add(
                    sql_reader.GetInt32(0),
                    CustomDate.GetThaiMonth(sql_reader.GetInt32(1)), 
                    sql_reader.GetDecimal(2).ToString("#,#0.00#"), 
                    sql_reader.GetDecimal(3).ToString("#,#0.00#"), 
                    sql_reader.GetDecimal(4).ToString("#,#0.00#")
                );
            }
            sql_reader.Close();

            dataGridView.ClearSelection();
        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            sql_con.Close();

            sql_con.Dispose();
            sql_cmd.Dispose();
            sql_reader.Dispose();
        }

        private void toolStripGraph_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph();
            graph.ShowDialog();
            graph.Dispose();
        }
    }
}
