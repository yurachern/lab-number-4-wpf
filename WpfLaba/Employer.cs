using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfLaba
{
    public class Employer : INotifyPropertyChanged
    {
        string name, lastName;
        int age;
        DateTime employmentDate;
        public Company OwnCompany { get; set; } 

        public string Name { get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string LastName { get => lastName; set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public int Age { get => age; set
            {
                if (age != value)
                {
                    age = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        public DateTime EmploymentDate { get => employmentDate; set
            {
                if (employmentDate != value)
                {
                    employmentDate = value;
                    OnPropertyChanged("EmploymentDate");
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
