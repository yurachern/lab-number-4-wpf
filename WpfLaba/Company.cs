using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfLaba
{
    public class Company : INotifyPropertyChanged
    {
        string companyName;
        public string CompanyName { get => companyName; set
            {
                if (companyName != value)
                {
                    companyName = value;
                    OnPropertyChanged("CompanyName");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
