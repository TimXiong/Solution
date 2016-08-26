using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TimXiong.WPF.Sample.PutToWallControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.ak.DataContext = new List<Order>()
            //{
            //    new Order() { DebatchAddress = "1220", DisplayData = "99999", OrderNumber = "98272839-1" },
            //    new Order() { DebatchAddress = "1221", DisplayData = "99999", OrderNumber = "98272839-1", Enable= true },
            //    new Order() { DebatchAddress = "1222", DisplayData = "99999", OrderNumber = "98272839-1" },
            //    new Order() { DebatchAddress = "1223", DisplayData = "99999", OrderNumber = "98272839-1" }
            //};
        }

        private void Dian_Click(object sender, RoutedEventArgs e)
        {
            PutToWallModel.Operation[0].DebatchAddress = "AAAA";
            PutToWallModel.Operation[0].Enable = true;
        }
    }
}
