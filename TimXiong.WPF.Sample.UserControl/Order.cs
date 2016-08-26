using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TimXiong.WPF.Sample.PutToWallControl
{
    public class Order : INotifyPropertyChanged
    {
        string m_DisplayData;

        string m_OrderNumber;

        string m_DebatchAddress;

        bool m_Enable;

        public string DebatchAddress
        {
            get
            {
                return this.m_DebatchAddress;
            }

            set
            {
                if (value != this.m_DebatchAddress)
                {
                    this.m_DebatchAddress = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string OrderNumber
        {
            get
            {
                return this.m_OrderNumber;
            }

            set
            {
                if (value != this.m_OrderNumber)
                {
                    this.m_OrderNumber = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string DisplayData
        {
            get
            {
                return this.m_DisplayData;
            }

            set
            {
                if (value != this.m_DisplayData)
                {
                    this.m_DisplayData = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool Enable
        {
            get
            {
                return this.m_Enable;
            }

            set
            {
                if (value != this.m_Enable)
                {
                    this.m_Enable = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}