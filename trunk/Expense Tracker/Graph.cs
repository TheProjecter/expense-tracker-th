using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Expense_Tracker
{
    public partial class Graph : Form
    {
        private string[] months = {
            "มกราคม","กุมภาพันธ์","มีนาคม","เมษายน",
            "พฤษภาคม","มิถุนายน","กรกฏาคม","สิงหาคม",
            "กันยายน","ตุลาคม","พฤศจิกายน","ธันวาคม"
        };

        public Graph()
        {
            InitializeComponent();

            CreateChart(zedGraphControl);
        }

        public void CreateChart(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set the title and axis labels
            myPane.Title.FontSpec.Family = "Browallia New";
            myPane.Title.FontSpec.Size = 24;
            myPane.Title.Text = "สรุป";
            myPane.XAxis.Title.FontSpec.Family = "Browallia New";
            myPane.XAxis.Title.FontSpec.Size = 16;
            myPane.XAxis.Title.Text = "เดือน";
            myPane.XAxis.Type = AxisType.Text;
            myPane.XAxis.Scale.TextLabels = months;
            myPane.XAxis.Scale.FontSpec.Angle = 65;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.YAxis.Title.FontSpec.Family = "Browallia New";
            myPane.YAxis.Title.FontSpec.Size = 24;
            myPane.YAxis.Title.Text = "จำนวนเงิน";

            PointPairList list = new PointPairList();
            PointPairList list2 = new PointPairList();
            Random rand = new Random();

            // Generate random data for three curves
            for (int i = 1; i <= 12; i++)
            {
                double x = (double)i;
                double y = rand.NextDouble() * 1000;
                double y2 = rand.NextDouble() * 1000;
                double y3 = rand.NextDouble() * 1000;
                list.Add(x, y);
                list2.Add(x, y2);
            }

            // create the curves
            BarItem myCurve = myPane.AddBar("รายรับ", list, Color.Blue);
            BarItem myCurve2 = myPane.AddBar("รายจ่าย", list2, Color.Red);

            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White,
               Color.FromArgb(255, 255, 166), 45.0F);

            zgc.AxisChange();

            // expand the range of the Y axis slightly to accommodate the labels
            myPane.YAxis.Scale.Max += myPane.YAxis.Scale.MajorStep;

            // Create TextObj's to provide labels for each bar
            BarItem.CreateBarLabels(myPane, false, "f0");

        }
    }
}
