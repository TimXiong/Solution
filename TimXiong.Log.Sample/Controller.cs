using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimXiong.Log.Sample
{
    public class Controller
    {
        static ControllerDriver Driver { get; set; } = new ControllerDriver();

        public Action<Exception> ExceptionAction { get; set; }

        public Action<string> MessageAction { get; set; }

        public void Connect()
        {
            try
            {
                MessageAction?.Invoke("Connect to controller.");
                Driver?.Connect();
            }
            catch (Exception ex)
            {
                ExceptionAction?.Invoke(ex);
            }
        }

        public void Close()
        {
            try
            {
                MessageAction?.Invoke("Disconnect.");
                Driver?.Close();
            }
            catch (Exception ex)
            {
                MessageAction?.Invoke(ex.Message);
            }
            finally
            {
                Driver = null;
            }
        }
    }
}
