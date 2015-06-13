using Interop.CoreScanner;
using System;
using TimXiong.Common;

namespace TimXiong.ScannerDriver
{
    public static class DeviceDriver
    {
        /// <summary>
        /// Core device driver object
        /// </summary>
        static CCoreScanner s_CoreScanner = new CCoreScanner();

        /// <summary>
        /// 
        /// </summary>
        static int MAX_NUM_DEVICES = 10; // max device : 255

        /// <summary>
        /// Gets device driver connected status
        /// </summary>
        public static bool Connected { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        static CCoreScanner DriverCore
        {
            get
            {
                return s_CoreScanner;
            }
        }

        /// <summary>
        /// Gets requested scanner types
        /// </summary>
        public static short[] ScannerTypes
        {
            get
            {
                return new short[] { (short)RequestedScannerType.Scanner_Types_All };
            }
        }

        /// <summary>
        /// Connect to CoreScanner, this function will always connect CoreScanner
        /// </summary>
        public static void Connect()
        {
            int status = (int)StatusCode.STATUS_FALSE;
            try
            {
                DriverCore.Open(0, ScannerTypes, 1, out status); //appHandle --> Reserved argument. Set to 0.
            }
            catch (Exception ex)
            {
                throw new ScannerDriverException("DriverCore.Open function error", ex);
            }
            ThrowErrorMessage(status);
            Connected = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GetScanners()
        {
            if (!Connected)
            {
                Connect();
            }
            short scannerCount = 0;
            int status = (int)StatusCode.STATUS_FALSE;
            string scannersXml = string.Empty;
            int[] scannerIdArrary = new int[MAX_NUM_DEVICES];
            try
            {
                DriverCore.GetScanners(out scannerCount, scannerIdArrary, out scannersXml, out status);
            }
            catch (Exception ex)
            {
                throw new ScannerDriverException("DriverCore.Close function error", ex);
            }
            ThrowErrorMessage(status);
            ////////// Get scanner from xml
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Disconnect()
        {
            int status = (int)StatusCode.STATUS_FALSE;
            try
            {
                DriverCore.Close(0, out status); //appHandle --> Reserved argument. Set to 0.
            }
            catch (Exception ex)
            {
                throw new ScannerDriverException("DriverCore.Close function error", ex);
            }
            ThrowErrorMessage(status);
            Connected = false;
        }

        /// <summary>
        /// This function will ignore code StatusCode.SUCCESS
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string AnalysisErrorStatusCode(int code)
        {
            StatusCode? statusCode = EnumHelper.SafeParse<StatusCode>(code.ToString());
            string errorMessage = string.Empty;
            if (statusCode.HasValue)
            {
                if (statusCode.Value != StatusCode.SUCCESS)
                {
                    errorMessage = statusCode.Value.ShowDescription();
                }
            }
            else
            {
                errorMessage = "Undefine error code, current error code : " + code;
            }
            return errorMessage;
        }

        /// <summary>
        /// Throw ScannerDriverException except status : StatusCode.SUCCESS
        /// </summary>
        /// <param name="status"></param>
        static void ThrowErrorMessage(int status)
        {
            string errorMessage = AnalysisErrorStatusCode(status);
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                throw new ScannerDriverException(errorMessage);
            }
        }
    }
}
