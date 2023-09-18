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
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        List<Module> module = new List<Module>();
        public Report()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            Self_Study study = new Self_Study();
            this.Visibility = Visibility.Hidden;
            study.Show();
        }

        public void Date()
        {
            DateTime today = DateTime.Today;
            int UntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            DateTime startDate = today.AddDays(UntilMonday);
            DateTime endDate = startDate.AddDays(6); //Sunday is the last day of the week

            var moduleHoursDuringCurrentWeek = new Dictionary<string, int>();
            foreach (Module module in module)
            {
                if (module.StartDate >= startDate && module.StartDate <= endDate)
                {
                    if (moduleHoursDuringCurrentWeek.ContainsKey(module.Code))
                    {
                        moduleHoursDuringCurrentWeek[module.Code] += module.HoursWorked;
                    }
                    else
                    {
                        moduleHoursDuringCurrentWeek[module.Code] = module.HoursWorked;
                    }
                }
                if (moduleHoursDuringCurrentWeek.ContainsKey(module.Code))
                {
                    int SelfStudyHoursPerWeek = (module.Credits * 10) / (module.NumOfWeeks - module.HoursWorked);
                    int recordedHoursDuringWeek = moduleHoursDuringCurrentWeek[module.Code];
                    int remainingHours = SelfStudyHoursPerWeek - recordedHoursDuringWeek;



                    string Code = textBox_Code.Text;
                    int Spent = int.Parse(textBox_HourSpent.Text);

                    Module newModule = new Module()
                    {
                        Code = Code,
                        HoursWorked = Spent,
                    };


                    listBox_HourSpent.Items.Add($"Module:{module.Code} - Self-Study Remaining Hours: {remainingHours}");
                }
            }
        } 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Date();
        }

        private void button_Continue_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();
        }
    }
}
 