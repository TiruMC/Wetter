using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150_03_04_Wetter
{

    public partial class MainForm : Form
    {
        List<CStationen>    lStationen   = new List<CStationen>();
        List<CWetterDatum>  lWetterDaten = new List<CWetterDatum>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var strPath = string.Empty;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strPath = ofd.FileName; 
                
                var strZeile = "";
                StreamReader file = new StreamReader(strPath);

                while ((strZeile = file.ReadLine()) != null) 
                {
                    tBoxAusgabe.Text += (strZeile + Environment.NewLine);
                }

                file.Close();
                
                file = new System.IO.StreamReader(strPath);
                
                while ((strZeile = file.ReadLine()) != null)
                {
                    try
                    {
                        CStationen s = new CStationen(); 
                        string[] strAStationen = strZeile.Split(';');

                        s.StationsIndex = Convert.ToInt32(strAStationen[0]);
                        s.Hoehe         = Convert.ToDouble(strAStationen[1], CultureInfo.InvariantCulture); 
                        s.Breite        = Convert.ToDouble(strAStationen[2], CultureInfo.InvariantCulture);
                        s.Laenge        = Convert.ToDouble(strAStationen[3], CultureInfo.InvariantCulture);
                        s.Name          = strAStationen[4];
                        s.Bundesland    = strAStationen[5];
                        
                        lStationen.Add(s);
                        
                    }

                    catch (Exception)
                    {
                        continue;
                    }
                }

                file.Close();

                for (var i = 0; i < lStationen.Count; i++)
                {
                    cmbWetterstationen.Items.Add(lStationen[i].StationsIndex + " - " + lStationen[i].Name.Trim() );
                }
            }
        }

        private void anzeigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var avgLenght = lStationen.Average(x => x.Laenge);
            var avgWidth  = lStationen.Average(x => x.Breite);


            string s = "<!DOCTYPE html><html><head><script src='http://maps.googleapis.com/maps/api/js'> </script><script> var myCenter=new google.maps.LatLng(";
            s += avgWidth.ToString().Replace(',', '.');
            s+=",";
            s += (avgLenght.ToString().Replace(',', '.'));
            s+="); function initialize(){var mapProp = {  center:myCenter,  zoom:5,  mapTypeId:google.maps.MapTypeId.ROADMAP  };var map=new google.maps.Map(document.getElementById('googleMap'),mapProp);var ";
            
            
            for (int i = 0; i < lStationen.Count; i++ )
            {
                s += " marker=new google.maps.Marker({position: new google.maps.LatLng(";
                s += lStationen[i].Breite.ToString().Replace(',', '.');   
                s +=",";
                s += lStationen[i].Laenge.ToString().Replace(',','.');   
                s += " )});marker.setMap(map);\n";
            
            }

            s += " }google.maps.event.addDomListener(window, 'load', initialize);</script></head><body><div id='googleMap' style='width:1000px;height:700px;'></div></body></html>";


            wbBrowser.DocumentText = s;
        }

        private void cmbWetterstationen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbWetterstationen.SelectedIndex;
            StringBuilder sb = new StringBuilder();

            sb.Append("<!DOCTYPE html><html><head><script src='http://maps.googleapis.com/maps/api/js'> </script><script> var myCenter=new google.maps.LatLng(");
            sb.Append(lStationen[index].Breite.ToString().Replace(',', '.'));
            sb.Append(",");
            sb.Append(lStationen[index].Laenge.ToString().Replace(',', '.'));
            sb.Append("); function initialize(){var mapProp = {  center:myCenter,  zoom:10,  mapTypeId:google.maps.MapTypeId.ROADMAP  };var map=new google.maps.Map(document.getElementById('googleMap'),mapProp);var ");
            sb.Append(" marker=new google.maps.Marker({position: new google.maps.LatLng(");
            sb.Append(lStationen[index].Breite.ToString().Replace(',', '.'));
            sb.Append(",");
            sb.Append(lStationen[index].Laenge.ToString().Replace(',', '.'));
            sb.Append(" )});marker.setMap(map);\n");
            sb.Append(" }google.maps.event.addDomListener(window, 'load', initialize);</script></head><body><div id='googleMap' style='width:1000px;height:700px;'></div></body></html>");

            wbBrowser.DocumentText = sb.ToString();
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var strPath = string.Empty;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strPath = ofd.FileName;

                StreamReader file = new StreamReader(strPath);
                var strZeile      = "";

                while ((strZeile = file.ReadLine()) != null)
                {
                    try
                    {
                        CWetterDatum w = new CWetterDatum();
                        string[] WetterDaten = strZeile.Split(';');

                        w.StationsID = Convert.ToInt32(WetterDaten[0]);

                        w.MessDatum = new DateTime(Convert.ToInt32(WetterDaten[1].Substring(0, 4)), Convert.ToInt32(WetterDaten[1].Substring(4, 2)), Convert.ToInt32(WetterDaten[1].Substring(6, 2)));

                        w.QualitaetsNiveau       = Convert.ToInt32(WetterDaten[2]);
                        w.Lufttemperatur         = Convert.ToDouble(WetterDaten[3],  CultureInfo.InvariantCulture);
                        w.Dampfdruck             = Convert.ToDouble(WetterDaten[4],  CultureInfo.InvariantCulture);
                        w.Bedeckungsgrad         = Convert.ToDouble(WetterDaten[5],  CultureInfo.InvariantCulture);
                        w.LuftdruckStationshoehe = Convert.ToDouble(WetterDaten[6],  CultureInfo.InvariantCulture);
                        w.RelativeFeuchte        = Convert.ToDouble(WetterDaten[7],  CultureInfo.InvariantCulture);
                        w.Windgeschwindigkeit    = Convert.ToDouble(WetterDaten[8],  CultureInfo.InvariantCulture);
                        w.LufttemperaturMaximum  = Convert.ToDouble(WetterDaten[9],  CultureInfo.InvariantCulture);
                        w.LufttemperaturMinimum  = Convert.ToDouble(WetterDaten[10], CultureInfo.InvariantCulture);
                        w.LufttemperaturERDB     = Convert.ToDouble(WetterDaten[11], CultureInfo.InvariantCulture);
                        w.WindspitzeMaximum      = Convert.ToDouble(WetterDaten[12], CultureInfo.InvariantCulture);
                        w.Niederschlagshoehe     = Convert.ToDouble(WetterDaten[13], CultureInfo.InvariantCulture);
                        w.NiederschlagshoeheIND  = Convert.ToInt32(WetterDaten[14]);
                        w.Sonnenscheindauer      = Convert.ToDouble(WetterDaten[15], CultureInfo.InvariantCulture);
                        w.Schneehoehe            = Convert.ToDouble(WetterDaten[16], CultureInfo.InvariantCulture);
                        w.Sonnenscheindauer      = Convert.ToDouble(WetterDaten[15], CultureInfo.InvariantCulture);

                        lWetterDaten.Add(w);
                    }

                    catch (Exception)
                    {
                        continue;
                    }
                    
                }

                file.Close();
            }  

        }

        private void temperaturDarstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTemp = new GraphicForm();

            List<int>    lDSJahre        = new List<int>();
            List<double> lDSTemperaturen = new List<double>();

            var iAktuellesJahr  = 0;
            var dAktuelleSumme  = 0.0;
            var iAktuelleAnzahl = 0;
            
            foreach(CWetterDatum w in lWetterDaten)
            {
                if (iAktuellesJahr != w.MessDatum.Year)
                {
                    dAktuelleSumme = dAktuelleSumme / iAktuelleAnzahl;
                    
                    lDSJahre.Add(iAktuellesJahr);
                    lDSTemperaturen.Add(dAktuelleSumme);

                    iAktuelleAnzahl = 0;
                    dAktuelleSumme = 0.0;
                    iAktuellesJahr = w.MessDatum.Year;
                }              
                
                dAktuelleSumme = dAktuelleSumme + w.Lufttemperatur;
                iAktuelleAnzahl++;
            }


            frmTemp.Show();
            frmTemp.CreateGraph(frmTemp.zgTemperatur, lDSJahre, lDSTemperaturen);
        }

    }
}
