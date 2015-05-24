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
    public partial class GraphicForm : Form
    {
        public GraphicForm()
        {
            InitializeComponent();
        }

        public void CreateGraph(ZedGraphControl zgc, List<int> avgYear, List<double> avgTemp)
        {                                            
            GraphPane myPane    = zgc.GraphPane;

            myPane.Title        = "Durchschnittstemperaturen zwischen 1969 und 2012 in Düsseldorf";
            myPane.XAxis.Title  = "Jahr";
            myPane.YAxis.Title  = "Temperatur [°C]";

            myPane.XAxis.Min = 1969;
            myPane.XAxis.Max = 2012;

            var x  = 0.0;
            var y = 0.0; 
            
            PointPairList list1 = new PointPairList();
            
            for (int i = 0; i < avgYear.Count; i++)
            {
                x = (double)avgYear[i];
                y = avgTemp[i];
                
                list1.Add(x, y);
            }

            LineItem myCurve = myPane.AddCurve("Temperatur", list1, Color.Red, SymbolType.Diamond);
           
            zgc.AxisChange();
        }
    }
}
