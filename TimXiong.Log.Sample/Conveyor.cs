using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimXiong.Log.Sample
{
    public static class Conveyor
    {
        static Controller s_ControllerA = null;

        static Controller ControllerA
        {
            get
            {
                if (s_ControllerA == null)
                {
                    s_ControllerA = new Controller()
                    {
                        ExceptionAction = Conveyor.ExceptionAction,
                        MessageAction = Conveyor.MessageAction
                    };
                }
                return s_ControllerA;
            }
        }

        public static Action<Exception> ExceptionAction { get; set; }

        public static Action<string> MessageAction { get; set; }

        public static void Start()
        {
            ControllerA?.Connect();
        }

        public static void Close()
        {
            ControllerA?.Close();
        }
    }
}
