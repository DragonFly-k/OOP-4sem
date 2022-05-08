using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L6_7.Models
{
    public class WatchViewModel: INotifyPropertyChanged
    {
        private Watch watch;

        public WatchViewModel(Watch p)
        {
            watch = p;
        }
        public string DisplayedImage
        {
            get { return watch.DisplayedImage; }
            set
            {
                watch.DisplayedImage = value;
                OnPropertyChanged("DisplayedImage");
            }
        }
        public string Name
        {
            get { return watch.Name; }
            set
            {
                watch.Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Country
        {
            get { return watch.Country; }
            set
            {
                watch.Country = value;
                OnPropertyChanged("Country");
            }
        }
        public int Price
        {
            get { return watch.Price; }
            set
            {
                watch.Price = value;
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