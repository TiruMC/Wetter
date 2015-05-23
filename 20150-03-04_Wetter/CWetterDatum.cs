using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150_03_04_Wetter
{
    class CWetterDatum
    {
        uint uiStations_ID = 0;

        public uint UiStations_ID
        {
            get { return uiStations_ID; }
            set { uiStations_ID = value; }
        }
        DateTime dtMess_Datum = DateTime.Now;

        public DateTime DtMess_Datum
        {
            get { return dtMess_Datum; }
            set { dtMess_Datum = value; }
        }
        int iQualitaets_Niveau = 0;

        public int IQualitaets_Niveau
        {
            get { return iQualitaets_Niveau; }
            set { iQualitaets_Niveau = value; }
        }
        double dLUFTTEMPERATUR = 0.0;

        public double DLUFTTEMPERATUR
        {
            get { return dLUFTTEMPERATUR; }
            set { dLUFTTEMPERATUR = value; }
        }
        double dDAMPFDRUCK = 0.0;

        public double DDAMPFDRUCK
        {
            get { return dDAMPFDRUCK; }
            set { dDAMPFDRUCK = value; }
        }
        double dBEDECKUNGSGRAD = 0.0;

        public double DBEDECKUNGSGRAD
        {
            get { return dBEDECKUNGSGRAD; }
            set { dBEDECKUNGSGRAD = value; }
        }
        double dLUFTDRUCK_STATIONSHOEHE = 0.0;

        public double DLUFTDRUCK_STATIONSHOEHE
        {
            get { return dLUFTDRUCK_STATIONSHOEHE; }
            set { dLUFTDRUCK_STATIONSHOEHE = value; }
        }
        double dREL_FEUCHTE = 0.0;

        public double DREL_FEUCHTE
        {
            get { return dREL_FEUCHTE; }
            set { dREL_FEUCHTE = value; }
        }
        double dWINDGESCHWINDIGKEIT = 0.0;

        public double DWINDGESCHWINDIGKEIT
        {
            get { return dWINDGESCHWINDIGKEIT; }
            set { dWINDGESCHWINDIGKEIT = value; }
        }
        double dLUFTTEMPERATUR_MAXIMUM = 0.0;

        public double DLUFTTEMPERATUR_MAXIMUM
        {
            get { return dLUFTTEMPERATUR_MAXIMUM; }
            set { dLUFTTEMPERATUR_MAXIMUM = value; }
        }
        double dLUFTTEMPERATUR_MINIMUM = 0.0;

        public double DLUFTTEMPERATUR_MINIMUM
        {
            get { return dLUFTTEMPERATUR_MINIMUM; }
            set { dLUFTTEMPERATUR_MINIMUM = value; }
        }
        double dLUFTTEMP_AM_ERDB_MINIMUM = 0.0;

        public double DLUFTTEMP_AM_ERDB_MINIMUM
        {
            get { return dLUFTTEMP_AM_ERDB_MINIMUM; }
            set { dLUFTTEMP_AM_ERDB_MINIMUM = value; }
        }
        double dWINDSPITZE_MAXIMUM = 0.0;

        public double DWINDSPITZE_MAXIMUM
        {
            get { return dWINDSPITZE_MAXIMUM; }
            set { dWINDSPITZE_MAXIMUM = value; }
        }
        double dNIEDERSCHLAGSHOEHE = 0.0;

        public double DNIEDERSCHLAGSHOEHE
        {
            get { return dNIEDERSCHLAGSHOEHE; }
            set { dNIEDERSCHLAGSHOEHE = value; }
        }
        int iNIEDERSCHLAGSHOEHE_IND = 0;

        public int INIEDERSCHLAGSHOEHE_IND
        {
            get { return iNIEDERSCHLAGSHOEHE_IND; }
            set { iNIEDERSCHLAGSHOEHE_IND = value; }
        }
        double dSONNENSCHEINDAUER = 0.0;

        public double DSONNENSCHEINDAUER
        {
            get { return dSONNENSCHEINDAUER; }
            set { dSONNENSCHEINDAUER = value; }
        }
        double dSCHNEEHOEHE = 0.0;

        public double DSCHNEEHOEHE
        {
            get { return dSCHNEEHOEHE; }
            set { dSCHNEEHOEHE = value; }
        }               




    }
}
