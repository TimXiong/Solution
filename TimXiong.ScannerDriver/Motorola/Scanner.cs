
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TimXiong.ScannerDriver
{
    public class Scanner
    {
        [XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a unique ID assigned for a scanner
        /// </summary>
        [XmlElement("scannerID")]
        public string ScannerId { get; set; }

        /// <summary>
        /// Gets or sets device serial number
        /// </summary>
        [XmlAttribute("serialnumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets hardware unique ID
        /// </summary>
        [XmlElement("GUID")]
        public string GUID { get; set; }

        [XmlAttribute("VID")]
        public string VID { get; set; }

        [XmlElement("PID")]
        public string PID { get; set; }

        /// <summary>
        /// Gets or sets device model number
        /// </summary>
        [XmlAttribute("modelnumber")]
        public string Modelnumber { get; set; }

        /// <summary>
        /// Gets or sets device date of manufacture
        /// </summary>
        [XmlElement("DoM")]
        public string ManufactureDate { get; set; }

        /// <summary>
        /// Gets or sets current firmware version
        /// </summary>
        [XmlAttribute("firmware")]
        public string Firmware { get; set; }
    }

    [XmlRoot("scanners")]
    public class ScannerXmlReader
    {
        /// <summary>
        /// Gets scanners xml data sample
        /// </summary>
        public string Sample
        {
            get
            {
                return @"
                    <scanners>
                        <scanner type='SNAPI'>
                            <scannerID>1</scannerID>
                            <serialnumber>7116000501003</serialnumber>
                            <GUID>A2E647DED2163545B18BCEBD0A2A133D</GUID>
                            <VID>1504</VID>
                            <PID>6400</PID>
                            <modelnumber>DS670-SR20001ZZR</modelnumber>
                            <DoM>27APR07</DoM>
                            <firmware>NBRPUAAC</firmware>
                        </scanner>
                        <scanner type='SNAPI'>
                            <scannerID>2</scannerID>
                            <serialnumber>7116000501004</serialnumber>
                            <GUID>A2E647DED2163545B18BCEBD0A2A133E</GUID>
                            <VID>1504</VID>
                            <PID>6400</PID>
                            <modelnumber>DS670-SR20001ZZZ</modelnumber>
                            <DoM>27APR07</DoM>
                            <firmware>NBRPUAAC</firmware>
                        </scanner>
                    </scanners>";
            }
        }

        [XmlElement("scanner")]
        public List<Scanner> ScannerList = new List<Scanner>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlScannerData"></param>
        /// <returns></returns>
        public static List<Scanner> GetAllScanners(string xmlScannerData)
        {
            List<Scanner> scanners = new List<Scanner>();
            if (string.IsNullOrWhiteSpace(xmlScannerData))
            {
                return scanners;
            }
            return scanners;
        }
    }
}
