using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150_03_04_Wetter
{

    public partial class Form1 : Form
    {
        List<CStationen> lStationen = new List<CStationen>();
        List<CWetterDatum> lWetterDaten = new List<CWetterDatum>();

        int iCounter = 0;

        public Form1()
        {
            InitializeComponent();
            wbBrowser.ScriptErrorsSuppressed = true;
        }


        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strPfad = string.Empty;
            /// string strPfad = "";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Stationsdateien (*.csv)|*.csv;|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Bei Auswahl einer Datei und OK-Bestätigung ...
                strPfad = openFileDialog1.FileName;  // ... wird der Variablen / dem Objekt 
                iCounter = 0;
                string strZeile = "";
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(strPfad);
                file.BaseStream.Position = 0;
                while ((strZeile = file.ReadLine()) != null) // solange nicht Ende
                {
                    tBoxAusgabe.Text += (strZeile + "\r\n");
                    iCounter++;
                }
                file.Close(); // Datei schließen
                int i = 0;
                file = new System.IO.StreamReader(strPfad);
                //strZeile = file.ReadLine(); // erste Zeile wird ignoriert
                while ((strZeile = file.ReadLine()) != null)
                {
                    try
                    {
                        CStationen s = new CStationen(); // neue noch leere Vokabel
                        // Trennen des Strings Split()
                        string[] strAStationen = strZeile.Split(';');
                        // speichern der einzelnen Substrings in dem Objekt s der Klasse CStationen
                        // Stationsindex;Höhe in m;Breite;Länge;Name;Bundesland
                        s.IStationsindex = Convert.ToInt32(strAStationen[0]);
                        s.DHoehe = Convert.ToDouble(strAStationen[1].Replace('.', ','));
                        s.DGPSBreite = Convert.ToDouble(strAStationen[2].Replace('.', ','));
                        s.DGPSLaenge = Convert.ToDouble(strAStationen[3].Replace('.', ','));
                        s.StrName = strAStationen[4];
                        s.StrBundesland = strAStationen[5];
                        lStationen.Add(s);
                        i++;
                    }
                    catch (Exception exp)
                    {
                        // MessageBox.Show("Fehler");
                        continue;
                    }
                }

                file.Close(); // Datei schließen
                
                
                for (i = 0; i < lStationen.Count; i++)
                {
                    cmbWetterstationen.Items.Add(lStationen[i].IStationsindex + " - " + lStationen[i].StrName.Trim() );
                }

                

            }
        }

        private void anzeigeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // geografische Mitte berechnen
            double dMitteBreite = 0;
            double dMitteLaenge = 0;

            for (int i = 0; i < lStationen.Count; i++)
            {
                dMitteBreite += lStationen[i].DGPSBreite;
                dMitteLaenge += lStationen[i].DGPSLaenge;
            }
            dMitteBreite = dMitteBreite / lStationen.Count;
            dMitteLaenge = dMitteLaenge / lStationen.Count;

            // string s = "<!DOCTYPE html><html><head><script src='http://maps.googleapis.com/maps/api/js'> </script><script> var myCenter=new google.maps.LatLng(51.508742,-0.120850); function initialize(){var mapProp = {  center:myCenter,  zoom:5,  mapTypeId:google.maps.MapTypeId.ROADMAP  };var map=new google.maps.Map(document.getElementById('googleMap'),mapProp);var marker=new google.maps.Marker({position: new google.maps.LatLng(51.508742,-0.120850)});marker.setMap(map);marker=new google.maps.Marker({position: new google.maps.LatLng(50.508742,-0.120850)});marker.setMap(map);marker=new google.maps.Marker({position: new google.maps.LatLng(49.508742,-0.120850)});marker.setMap(map);}google.maps.event.addDomListener(window, 'load', initialize);</script></head><body><div id='googleMap' style='width:1000px;height:700px;'></div></body></html>";
            // string s = "<!DOCTYPE html><html><head><script src='http://maps.googleapis.com/maps/api/js'> </script><script> var myCenter=new google.maps.LatLng({0},{1}); function initialize(){var mapProp = {  center:myCenter,  zoom:5,  mapTypeId:google.maps.MapTypeId.ROADMAP  };var map=new google.maps.Map(document.getElementById('googleMap'),mapProp);var ";
            


            string s = "<!DOCTYPE html><html><head><script src='http://maps.googleapis.com/maps/api/js'> </script><script> var myCenter=new google.maps.LatLng(";
            s += dMitteBreite.ToString().Replace(',', '.');
            s+=",";
            s += dMitteLaenge.ToString().Replace(',', '.');
            s+="); function initialize(){var mapProp = {  center:myCenter,  zoom:5,  mapTypeId:google.maps.MapTypeId.ROADMAP  };var map=new google.maps.Map(document.getElementById('googleMap'),mapProp);var ";
            
            
            
            for (int i = 0; i < lStationen.Count; i++ )
            {
                s += " marker=new google.maps.Marker({position: new google.maps.LatLng(";
                s += lStationen[i].DGPSBreite.ToString().Replace(',', '.');   
                s +=",";
                s += lStationen[i].DGPSLaenge.ToString().Replace(',','.');   
                s += " )});marker.setMap(map);\n";
            
            }
            s += " }google.maps.event.addDomListener(window, 'load', initialize);</script></head><body><div id='googleMap' style='width:1000px;height:700px;'></div></body></html>";



            wbBrowser.DocumentText = s;

        }

        private void cmbWetterstationen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iIndex = 0;
            // 1. Möglichkeit
            System.Windows.Forms.ComboBox c = (System.Windows.Forms.ComboBox) sender;
            iIndex = c.SelectedIndex;
            
            // Oder noch einfacher: 2. Möglichkeit
            iIndex = cmbWetterstationen.SelectedIndex;

            // MessageBox.Show(c.SelectedIndex.ToString());

            // ------------------> bis hier und ab hier
            
            
            // Vorspann
            string s = "<!DOCTYPE html><html><head><script src='http://maps.googleapis.com/maps/api/js'> </script><script> var myCenter=new google.maps.LatLng(";
            s += lStationen[iIndex].DGPSBreite.ToString().Replace(',', '.');
            s += ",";
            s += lStationen[iIndex].DGPSLaenge.ToString().Replace(',', '.');
            s += "); function initialize(){var mapProp = {  center:myCenter,  zoom:10,  mapTypeId:google.maps.MapTypeId.ROADMAP  };var map=new google.maps.Map(document.getElementById('googleMap'),mapProp);var ";


            // Mittelbereich, Marker
            s += " marker=new google.maps.Marker({position: new google.maps.LatLng(";
            s += lStationen[iIndex].DGPSBreite.ToString().Replace(',', '.');
            s += ",";
            s += lStationen[iIndex].DGPSLaenge.ToString().Replace(',', '.');
            s += " )});marker.setMap(map);\n";

            // Nachspann
            s += " }google.maps.event.addDomListener(window, 'load', initialize);</script></head><body><div id='googleMap' style='width:1000px;height:700px;'></div></body></html>";



            wbBrowser.DocumentText = s;



        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strPfad = string.Empty;
            /// string strPfad = "";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Wetterdaten einer Station (*.csv)|*.csv;|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Bei Auswahl einer Datei und OK-Bestätigung ...
                strPfad = openFileDialog1.FileName;  // ... wird der Variablen / dem Objekt 
                iCounter = 0;
                string strZeile = "";
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(strPfad);
                file.BaseStream.Position = 0;

                int i = 0;
                //strZeile = file.ReadLine(); // erste Zeile wird ignoriert
                while ((strZeile = file.ReadLine()) != null)
                {
                    try
                    {
                        CWetterDatum w = new CWetterDatum(); // neues noch leeres Wetterdatum
                        // Trennen des Strings Split()
                        string[] strAWetterDaten = strZeile.Split(';');
                        // speichern der einzelnen Substrings in dem Objekt s der // Stationsindex;Höhe in m;Breite;Länge;Name;Bundesland

                        w.UiStations_ID = Convert.ToUInt32(strAWetterDaten[0]);

                        // Neues Objekt vom Zeittyp DateTime. Der Konstruktor von DateTime erwartet 
                        // Jahr, Monat und Tag als int.
                        // Dieser String 19690701 wird aufgeteilt, mit Substring
                        //                    0-->
                        //                        4>
                        //                          6>
                        // Anschließend wird für die Umwandlung in int die Methode Convert aufgerufen
                        w.DtMess_Datum = new DateTime(2012, 03, 24, 12, 36, 47);
                        w.DtMess_Datum = new DateTime(Convert.ToInt32(strAWetterDaten[1].Substring(0, 4)),
                            Convert.ToInt32(strAWetterDaten[1].Substring(4, 2)),
                            Convert.ToInt32(strAWetterDaten[1].Substring(6, 2)));
                        w.IQualitaets_Niveau = Convert.ToInt32(strAWetterDaten[2]);
                        w.DLUFTTEMPERATUR = Convert.ToDouble(strAWetterDaten[3].Replace('.', ','));
                        w.DDAMPFDRUCK = Convert.ToDouble(strAWetterDaten[4].Replace('.', ','));
                        w.DBEDECKUNGSGRAD = Convert.ToDouble(strAWetterDaten[5].Replace('.', ','));
                        w.DLUFTDRUCK_STATIONSHOEHE = Convert.ToDouble(strAWetterDaten[6].Replace('.', ','));
                        w.DREL_FEUCHTE = Convert.ToDouble(strAWetterDaten[7].Replace('.', ','));
                        w.DWINDGESCHWINDIGKEIT = Convert.ToDouble(strAWetterDaten[8].Replace('.', ','));
                        w.DLUFTTEMPERATUR_MAXIMUM = Convert.ToDouble(strAWetterDaten[9].Replace('.', ','));
                        w.DLUFTTEMPERATUR_MINIMUM = Convert.ToDouble(strAWetterDaten[10].Replace('.', ','));
                        w.DLUFTTEMP_AM_ERDB_MINIMUM = Convert.ToDouble(strAWetterDaten[11].Replace('.', ','));
                        w.DWINDSPITZE_MAXIMUM = Convert.ToDouble(strAWetterDaten[12].Replace('.', ','));
                        w.DNIEDERSCHLAGSHOEHE = Convert.ToDouble(strAWetterDaten[13].Replace('.', ','));
                        w.INIEDERSCHLAGSHOEHE_IND = Convert.ToInt32(strAWetterDaten[14]);
                        w.DSONNENSCHEINDAUER = Convert.ToDouble(strAWetterDaten[15].Replace('.', ','));
                        w.DSCHNEEHOEHE = Convert.ToDouble(strAWetterDaten[16].Replace('.', ','));
                        // Merzt die Lokalisierung aus
                        w.DSONNENSCHEINDAUER = Convert.ToDouble(strAWetterDaten[15],
                            System.Globalization.CultureInfo.InvariantCulture);
                      
                        lWetterDaten.Add(w);
                    }
                    catch (Exception exp)
                    {
                        // MessageBox.Show("Fehler");
                        continue;
                    }
                    
                }

                file.Close(); // Datei schließen
            }  

        }

        private void temperaturDarstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemperatur frm = new frmTemperatur();
      
            // Neue Windows Form frmTemperatur starten

            // Die Form soll die Temperatur darstellen

            // Aufbereitung der Temperaturdaten 
            List<int> lDSJahre = new List<int>();
            List<double> lDSTemperaturen = new List<double>();

            int iAktuellesJahr = 0;
            double dAktuelleSumme = 0.0;
            int iAktuelleAnzahl = 0;
            
            foreach(CWetterDatum w in lWetterDaten)
            {
                // Jahr von w bestimmen
                if(iAktuellesJahr != w.DtMess_Datum.Year)
                {
                    // neues Jahr?
                    // alten Durchschnitt abspeichern
                    dAktuelleSumme = dAktuelleSumme / iAktuelleAnzahl;//Durchschnitt
                    lDSJahre.Add(iAktuellesJahr);
                    lDSTemperaturen.Add(dAktuelleSumme);

                    // Initialisieren
                    iAktuelleAnzahl = 0;
                    dAktuelleSumme = 0.0;
                    iAktuellesJahr = w.DtMess_Datum.Year;
                }              
                    // wenn nein, also ist das ein bereits benutztes Jahr
                    // Summe berechnen
                    dAktuelleSumme = dAktuelleSumme + w.DLUFTTEMPERATUR;
                    iAktuelleAnzahl++;
            }


            // Laden der T-Daten in den Zedgraphen
            

                /*
                 * Aufgabe:
                 * Durchschnittsdaten dem frm.zgTemeratur zur Verfügung stellen, aber wie?
                 * Orientieren am Zedgraph-Test-Projekt
                */
            
            frm.Show();
            frm.CreateGraph(frm.zgTemperatur, lDSJahre, lDSTemperaturen);
        }

        
    }
}
