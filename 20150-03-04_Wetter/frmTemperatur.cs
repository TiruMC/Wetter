using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace _20150_03_04_Wetter
{
    public partial class frmTemperatur : Form
    {
        public frmTemperatur()
        {
            InitializeComponent();

           
        }

        public void CreateGraph(ZedGraphControl zgc, List<int> lDSJahre, List<double> lDSTemperaturen)
        {                                            
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles

            myPane.Title = "Durchschnittstemperaturen zwischen 1969 und 2012 in Düsseldorf";
            myPane.XAxis.Title = "Jahr";
            myPane.YAxis.Title = "Temperatur [Grad C]";


            myPane.XAxis.Min = 1969;
            myPane.XAxis.Max = 2012;

            double x, y1;
            PointPairList list1 = new PointPairList();
            for (int i = 0; i < lDSJahre.Count; i++)
            {
                x = (double)lDSJahre[i];
                y1 = lDSTemperaturen[i];
                
                list1.Add(x, y1);
              }

            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            LineItem myCurve = myPane.AddCurve("Temperatur",
                  list1, Color.Red, SymbolType.Diamond);
           
            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zgc.AxisChange();
        }
    }
}
