
using System.ComponentModel;

namespace TimXiong.ScannerDriver
{
    [Description("Status code from CoreScanner object")]
    public enum StatusCode
    {
        /// <summary>
        /// Generic success
        /// </summary>
        [Description("Generic success")]
        SUCCESS = 0, 

        /// <summary>
        /// Generic false
        /// </summary>
        [Description("Generic false")]
        STATUS_FALSE = 1,

        /// <summary>
        /// Device is locked by another application
        /// </summary>
        [Description("Device is locked by another application")]
        STATUS_LOCKED = 10,

        /// <summary>
        /// Requested Type IDs are duplicated
        /// </summary>
        [Description("Requested Type IDs are duplicated")]
        ERROR_DUPLICATE_TYPES = 105,

        /// <summary>
        /// Invalid scanner ID
        /// </summary>
        [Description("Invalid scanner ID")]
        ERROR_INVALID_SCANNERID = 108,

        /// <summary>
        /// Required device is unavailable
        /// </summary>
        [Description("Required device is unavailable")]
        ERROR_DEVICE_UNAVAILABLE = 112,

        /// <summary>
        /// Device does not support the Opcode
        /// </summary>
        [Description("Device does not support the Opcode")]
        ERROR_OPCODE_NOT_SUPPORTED = 116,

        /// <summary>
        /// Operation failed in device
        /// </summary>
        [Description("Operation failed in device")]
        ERROR_OPERATION_FAILED = 117,

        /// <summary>
        /// Request failed in CoreScanner
        /// </summary>
        [Description("Request failed in CoreScanner")]
        ERROR_REQUEST_FAILED = 118,

        /// <summary>
        /// Device busy. Applications should retry command
        /// </summary>
        [Description("Device busy. Applications should retry command")]
        ERROR_DEVICE_BUSY = 120,

        /// <summary>
        /// CoreScanner is already opened
        /// </summary>
        [Description("CoreScanner is already opened")]
        ERROR_ALREADY_OPENED = 200,

        /// <summary>
        /// CoreScanner is already closed
        /// </summary>
        [Description("CoreScanner is already closed")]
        ERROR_ALREADY_CLOSED = 201,

        /// <summary>
        /// CoreScanner is closed
        /// </summary>
        [Description("CoreScanner is closed")]
        ERROR_CLOSED = 202
    }
}
