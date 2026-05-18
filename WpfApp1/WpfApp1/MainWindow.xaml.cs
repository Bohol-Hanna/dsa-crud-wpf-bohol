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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Shop> Products { get; }

        public class Shop
        {
            public int ID { get; set; }
            public string Product { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
        }

        public List<Shopping> Carts { get; }

        public class Shopping
        {
            public int IDUlit { get; set; }
            public string ProductUlit { get; set; }
            public string DescriptionUlit { get; set; }
            public int PriceUlit { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();

            Products = new List<Shop>
            {
                new Shop { ID = 1, Product = "Keychains", Description = "Accessories", Price = 20},
                new Shop { ID = 2, Product = "Pen", Description = "Supplies", Price = 50},
                new Shop { ID = 3, Product = "Skirt", Description = "Cloth", Price = 125}
            };
            this.DataContext = this;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (IDTextBox.Text != "" && NameTextBox.Text != "" && DescTextBox.Text != "" && PriceTextBox.Text != "")
                {
                    Products.Add(new Shop
                    {
                        ID = int.Parse(IDTextBox.Text),
                        Product = NameTextBox.Text,
                        Description = DescTextBox.Text,
                        Price = int.Parse(PriceTextBox.Text),
                    });
                    IDTextBox.Text = "";
                    NameTextBox.Text = "";
                    DescTextBox.Text = "";
                    PriceTextBox.Text = "";
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

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            DescTextBox.Text = "";
            PriceTextBox.Text = "";
        }

        private void AddCartButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (NameTextBox.Text != "" && DescTextBox.Text != "" && PriceTextBox.Text != "")
                {
                    Carts.Add(new Shopping
                    {
                        IDUlit = int.Parse(IDTextBox.Text),
                        ProductUlit = NameTextBox.Text,
                        DescriptionUlit = DescTextBox.Text,
                        PriceUlit = int.Parse(PriceTextBox.Text),
                    });
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values.");
            }
        }

        private void RemoveCartButton_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
