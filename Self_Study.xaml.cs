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
    /// Interaction logic for Self_Study.xaml
    /// </summary>
    public partial class Self_Study : Window
    {
        List<Module> module = new List<Module>();
        public Self_Study()
        {
            InitializeComponent();
        }

        private void button_Continue_Click(object sender, RoutedEventArgs e)
        {
            Report report = new Report();
            this.Visibility = Visibility.Hidden;
            report.Show();
        }

        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            Add_Module add = new Add_Module();
            this.Visibility = Visibility.Hidden;
            add.Show();
        }

       public void Calculate()
        {
            foreach (Module module in module)
            {
                double SelfStudyHoursPerWeek =  (module.Credits * 10.0) / (module.NumOfWeeks - module.ClassHoursPerWeek);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Code = textBox_Code.Text;

            Module newModule = new Module()
            {
                Code = Code
            };
            foreach (Module module in module) {

                listBox_self_study.Items.Add($"Module:{module.Code} - Self-Study Hours:{Calculate}");
}
        }
    }
}
