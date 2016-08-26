using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TimXiong.WPF.Sample.PutToWallControl
{
    public class PutToWallModel : INotifyPropertyChanged
    {
        public ObservableCollection<Order> Orders
        {
            get
            {
                return Operation;
            }

            set
            {
                NotifyPropertyChanged();
            }
        }

        public static ObservableCollection<Order> Operation
        {
            get
            {
                return new ObservableCollection<Order>()
                {
                    new Order() { DebatchAddress = "1220", DisplayData = "99999", OrderNumber = "98272839-1" },
                    new Order() { DebatchAddress = "1221", DisplayData = "99999", OrderNumber = "98272839-1", Enable = true },
                    new Order() { DebatchAddress = "1222", DisplayData = "99999", OrderNumber = "98272839-1" },
                    null
                    //new Order() { DebatchAddress = "1223", DisplayData = "99999", OrderNumber = "98272839-1" }
                };
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
