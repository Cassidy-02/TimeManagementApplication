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

namespace TimeManagementApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int page = 0;
            switch (page)
            {
                case 1:
                    Add_Module add = new Add_Module();
                    add.Show();
                    break;

                case 2:
                    Self_Study study = new Self_Study();
                    study.Show();
                    break;

                case 3:
                    Report report = new Report();
                    report.Show();
                    break;

            }

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Get the selected item
            ListBoxItem Item = (ListBoxItem)ListBox.SelectedItem;

            if (ListBox.SelectedItem != null)
            {
                //Navigate to the second window

                Add_Module add = new Add_Module();
                add.Show();
                this.Close();
            }
            else if (Item != null)
            {

                Self_Study study = new Self_Study();
                study.Show();
                this.Close();
            }

            else
            {

                Report report = new Report();
                report.Show();
                this.Close();


            }
            }
        }
    }



