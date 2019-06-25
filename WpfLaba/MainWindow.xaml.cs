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

namespace WpfLaba
{  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedIndex != -1)
            {
                switch (comboBox.SelectedIndex)
                {
                    case 0:
                        Ex1 ex1 = new Ex1();
                        ex1.ShowDialog();
                        break;
                    case 1:
                        Ex2 ex2 = new Ex2();
                        ex2.ShowDialog();
                        break;
                    case 2:
                        Ex3 ex3 = new Ex3();
                        ex3.ShowDialog();
                        break;
                }
            }
        }
    }
}
