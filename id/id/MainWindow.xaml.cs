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

namespace id
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Employee> Employees { get; }

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();

            Employees = new List<Employee>
            {
                new Employee { ID = 1, Name = "Hanna Pauline Bohol", Title = "Forensic Biologist", Department = "Forensic Department", Salary = 600000 },
                new Employee { ID = 2, Name = "Jane Smith", Title = "Project Manager", Department = "IT", Salary = 75000 },
                new Employee { ID = 3, Name = "Emily Davis", Title = "HR Specialist", Department = "HR", Salary = 50000 }
            };
            this.DataContext = this;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (NameTextBox.Text != "" && TitleTextBox.Text != "" && DeptTextBox.Text != "" && SalaryTextBox.Text != "")
                {
                    Employees.Add(new Employee
                    {
                        ID = int.Parse(IDTextBox.Text),
                        Name = NameTextBox.Text,
                        Title = TitleTextBox.Text,
                        Department = DeptTextBox.Text,
                        Salary = decimal.Parse(SalaryTextBox.Text)
                    });
                    Menu.Items.Refresh();

                    IDTextBox.Text = "";
                    NameTextBox.Text = "";
                    TitleTextBox.Text = "";
                    DeptTextBox.Text = "";
                    SalaryTextBox.Text = "";

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values.");
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            TitleTextBox.Text = "";
            DeptTextBox.Text = "";
            SalaryTextBox.Text = "";
        }
    }
}
