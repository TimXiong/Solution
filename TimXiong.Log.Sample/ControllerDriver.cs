using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimXiong.Log.Sample
{
    public class ControllerDriver
    {
        public void Connect(bool exception = false)
        {
            if (exception)
            {
                throw new Exception("Connect failed.");
            }
        }

        public void Close(bool exception = true)
        {
            if (exception)
            {
                throw new Exception("Close failed.");
            }
        }

        public void TurnOnLight(bool exception = true)
        {
            if (exception)
            {
                throw new Exception("Turn on light failed.");
            }
        }

        public void TurnOffLight(bool exception = false)
        {
            if (exception)
            {
                throw new Exception("Turn off light failed.")
            }
        }
    }
}
