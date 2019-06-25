using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfLaba
{
    /// <summary>
    /// Логика взаимодействия для Ex3.xaml
    /// </summary>
    public partial class Ex3 : Window
    {
        List<Employer> employers;
        int position;
        
        public Ex3()
        {
            InitializeComponent();
            CreateEmployers();         
            DataContext = employers[0];
        }
        private void CreateEmployers()
        {
            employers = new List<Employer> {
                new Employer { Name = "Петр", LastName = "Петров", Age = 35,
                    EmploymentDate = new DateTime(1984, 02, 15),
                    OwnCompany = new Company { CompanyName = "Петров продакшин" } },
                new Employer { Name = "Василий", LastName = "Васильев", Age = 40,
                    EmploymentDate = new DateTime(1979, 01, 9),
                    OwnCompany = new Company { CompanyName = "Васильев продакшин" } },
                new Employer { Name = "Сергей", LastName = "Сергеев", Age = 20,
                    EmploymentDate = new DateTime(1999, 03, 01),
                    OwnCompany = new Company {CompanyName = "Сергеев продакшин"} },
                new Employer { Name = "Григорий", LastName = "Григорьев", Age = 60,
                    EmploymentDate = new DateTime(1959, 02, 23),
                    OwnCompany = new Company {CompanyName = "Григорьев продакшин"} }
        };
        }
        private void ChangeRecord(int position)
        {
            btnPrev.IsEnabled = position > 0 ? true : false;
            btnNext.IsEnabled = position < employers.Count - 1 ? true : false;
            DataContext = employers[position];
        }
        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {            
            ChangeRecord(--position);
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            ChangeRecord(++position);           
        }
    }
}
