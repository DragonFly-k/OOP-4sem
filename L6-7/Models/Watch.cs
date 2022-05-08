using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L6_7.Models
{
    public class Watch: INotifyPropertyChanged
    {
        private string name;
        private string country;
        private int price;
        private string displayedimage;


         
        public string DisplayedImage
        {
            get { return displayedimage; }
            set {
                displayedimage = value;
                OnPropertyChanged("DisplayedImage");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                country= value;
                OnPropertyChanged("Country");
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}