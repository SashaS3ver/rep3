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

namespace Угадай
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num = 0;
        public MainWindow()
        {
            
            InitializeComponent();
            Random random = new Random();
            num = random.Next(1, 100);
        }

        private void btnclick1(object sender, RoutedEventArgs e)
        {                        
                int a = Convert.ToInt32(tx1.Text);

                if (num == a)
                {
                    MessageBox.Show("Ты выйграл");
                    list.Items.Add(a);
                    list.Items.Clear();
                }

                else if (a < num)
                {
                    list.Items.Add("Недобор");
                }

                else if (a > num)
                {
                    list.Items.Add("Перебор");
                }                       
           
        }
     

        private void txtt1(object sender, KeyEventArgs e)
        {
            //if (e.Key == Key.Back || e.Key == Key.Enter)
            //{
            //    int num = 0;
            //    Random random = new Random();
            //    num = random.Next(1, 100);

            //    int a = Convert.ToInt32(tx1.Text);

            //    if (num == a)
            //    {
            //        MessageBox.Show("Ты выйграл");
            //        list.Items.Add(a);
            //    }

            //    else if (a < num)
            //    {
            //        list.Items.Add("Недобор");
            //    }

            //    else if (a > num)
            //    {
            //        list.Items.Add("Перебор");
            //    }
            //}
            //else e.Handled = true;
        }

        private void tbxNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        
            { 
                e.Handled = (!Char.IsDigit(e.Text, 0));
            }

       
    }
}
