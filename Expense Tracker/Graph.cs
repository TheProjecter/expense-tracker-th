using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Expense_Tracker
{
    public partial class Graph : Form
    {
        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;
        SQLiteDataReader sql_reader;

        string applicationPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ExpenseTracker";

        private List<string> monthsLabel;

        public Graph()
        {
            InitializeComponent();

            monthsLabel = new List<string>();
            
            // Connect to database file
            sql_con = new SQLiteConnection("Data Source=" + applicationPath + "\\ExpenseTracker.db;Version=3;New=False;Compress=True;");
            sql_cmd = new SQLiteCommand();
            sql_con.Open();
            sql_cmd.Connection = sql_con;

            CreateChart(zedGraphControl);
        }

        public void CreateChart(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;

            PointPairList lstIncome = new PointPairList();
            PointPairList lstExpense = new PointPairList();

            // Set the title and axis labels
            myPane.Title.FontSpec.Family = "Browallia New";
            myPane.Title.FontSpec.Size = 24;
            myPane.Title.Text = "สรุป";
            myPane.XAxis.Title.FontSpec.Family = "Browallia New";
            myPane.XAxis.Title.FontSpec.Size = 16;
            myPane.XAxis.Title.Text = "เดือน";
            myPane.XAxis.Type = AxisType.Text;
            myPane.YAxis.Title.FontSpec.Family = "Browallia New";
            myPane.YAxis.Title.FontSpec.Size = 24;
            myPane.YAxis.Title.Text = "จำนวนเงิน";

            // Load data for this month
            sql_cmd.CommandText = "SELECT Month, TotalIncome, TotalExpense FROM Month WHERE Year = '" + CustomDate.GetThaiYear(DateTime.Today.Year) + "'";
            sql_reader = sql_cmd.ExecuteReader();
            while (sql_reader.Read())
            {
                monthsLabel.Add(sql_reader.GetString(0));
                lstIncome.Add(0, sql_reader.GetDouble(1));
                lstExpense.Add(0, sql_reader.GetDouble(2));
            }
            sql_reader.Close();

            myPane.XAxis.Scale.FontSpec.Family = "Browallia New";
            myPane.XAxis.Scale.FontSpec.Size = 16;
            myPane.XAxis.Scale.TextLabels = monthsLabel.ToArray();
            
            BarItem myCurve = myPane.AddBar("รายรับ", lstIncome, Color.Blue);
            BarItem myCurve2 = myPane.AddBar("รายจ่าย", lstExpense, Color.Red);

            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);

            myPane.YAxis.Scale.Max += myPane.YAxis.Scale.MajorStep;
            
            //BarItem.CreateBarLabels(myPane, false, "#,#0.00#", "Tahoma", 10, Color.Black, true, false, false);

            zgc.AxisChange();
        }

        private void Graph_FormClosing(object sender, FormClosingEventArgs e)
        {
            sql_con.Close();

            sql_con.Dispose();
            sql_cmd.Dispose();
            sql_reader.Dispose();
        }
    }
}
