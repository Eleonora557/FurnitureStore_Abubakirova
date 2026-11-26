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
using FurnitureStore_Abubakirova.Classes;

namespace FurnitureStore_Abubakirova.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public static Main init;
        public List<Item> items = new List<Item>();
        

        public Main()
        {
            InitializeComponent();
            init = this;

            items.Add(new Item("Шкаф", 2000, "шкаф-1 (2).jpg","шкафы"));
            items.Add(new Item("Шкаф", 4000, "шкаф-1.jpg", "шкафы"));
            items.Add(new Item("Шкаф", 3000, "шкаф-3.jpg", "шкафы"));
            items.Add(new Item("Диван", 5000, "диван-1.jpg","диваны"));
            items.Add(new Item("Диван", 9000, "диван-2.jpg", "диваны"));
            items.Add(new Item("Диван", 12000, "диван-3.jpg", "диваны"));
            items.Add(new Item("Стул", 7000, "стул-1.jpg", "стулья"));
            items.Add(new Item("Стул", 3000, "стул-2.jpg", "стулья"));
            items.Add(new Item("Стул", 4000, "стул-3.jpg", "стулья"));
            Classes.Cart.itogPrice = 0;
            LoadItems();
        }

        public void LoadItems()
        {
            parent.Children.Clear();
            foreach (Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }

        }

        public void cartup(int pr)
        {
            cart.Content = $"Корзина ({pr})";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/Category.xaml",UriKind.Relative));
        }
    }
}
