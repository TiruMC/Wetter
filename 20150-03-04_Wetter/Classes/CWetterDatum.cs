using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class CWetterDatum
    {
        public int       StationsID              { get; set; } 
        public DateTime  MessDatum               { get; set; } 
        public int       QualitaetsNiveau        { get; set; } 
        public double    Lufttemperatur          { get; set; } 
        public double    Dampfdruck              { get; set; } 
        public double    Bedeckungsgrad          { get; set; } 
        public double    LuftdruckStationshoehe  { get; set; } 
        public double    RelativeFeuchte         { get; set; } 
        public double    Windgeschwindigkeit     { get; set; } 
        public double    LufttemperaturMaximum   { get; set; } 
        public double    LufttemperaturMinimum   { get; set; } 
        public double    LufttemperaturERDB      { get; set; } 
        public double    WindspitzeMaximum       { get; set; } 
        public double    Niederschlagshoehe      { get; set; } 
        public int       NiederschlagshoeheIND   { get; set; } 
        public double    Sonnenscheindauer       { get; set; } 
        public double    Schneehoehe             { get; set; }             

    }
}
