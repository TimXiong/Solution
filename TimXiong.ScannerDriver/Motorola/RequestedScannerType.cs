
namespace TimXiong.ScannerDriver
{
    /// <summary>
    /// Types of scanners requested for use
    /// </summary>
    public enum RequestedScannerType : short
    {
        /// <summary>
        /// All scanners
        /// </summary>
        Scanner_Types_All = 1,

        /// <summary>
        /// SNAPI scanners
        /// </summary>
        Scanner_Types_SNAPI = 2,

        /// <summary>
        /// SSI scanners (RS232)
        /// </summary>
        Scanner_Types_SSI = 3,

        /// <summary>
        /// IBM hand held scanners (USB OPOS)
        /// </summary>
        Scanner_Types_IBNHID = 6,

        /// <summary>
        /// Nixdorf mode b scanners (RS232)
        /// </summary>
        Scanner_Types_NIXMODB = 7,

        /// <summary>
        /// USB HID keyboard emulation scanners
        /// </summary>
        Scanner_Types_HIDKB = 8,

        /// <summary>
        /// IBM table top scanners
        /// </summary>
        Scanner_Types_IBMTT = 9
    }
}