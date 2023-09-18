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
using System.Windows.Shapes;
using TimeManagementLibrary;

namespace TimeManagementApplication
{
    /// <summary>
    /// Interaction logic for Add_Module.xaml
    /// </summary>
    public partial class Add_Module : Window
    {
        List<Module> module = new List<Module>();

        public Add_Module()
        {
            InitializeComponent();
        }

        private void button_Continue_Click(object sender, RoutedEventArgs e)
        {
            Self_Study study = new Self_Study();
            this.Visibility = Visibility.Hidden;
            study.Show();
        }

        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();
        }

        private void button_AddModule_Click(object sender, RoutedEventArgs e)
        {
            string Code = textBox_Code.Text;
            string Name = textBox_Name.Text;
            int Credits = int.Parse(textBox_Credits.Text);
            int ClassHours = int.Parse(textBox_ClassHours.Text);
            DateTime startDate = startDatePicker.SelectedDate ?? DateTime.MinValue; //Selected date
            int numofWeeks = int.Parse(textBox_numofWeeks.Text);


            Module newModule = new Module
            {
                Code = Code,
                Name = Name,
                Credits = Credits,
                ClassHoursPerWeek = ClassHours,
                StartDate = startDate,
                NumOfWeeks = numofWeeks

            };

            listBox_AddModule.Items.Add(newModule);

        }

        private void textBox_Credits_TextChanged(object sender, TextChangedEventArgs e)
        {
            int Credits = int.Parse(textBox_Credits.Text);
        }

        private void listBox_AddModule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listBox_AddModule.ItemsSource = module;
        }
    }
}
