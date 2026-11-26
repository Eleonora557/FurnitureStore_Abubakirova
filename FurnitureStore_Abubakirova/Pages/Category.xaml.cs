using FurnitureStore_Abubakirova.Classes;
using FurnitureStore_Abubakirova.Elements;
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

namespace FurnitureStore_Abubakirova.Pages
{
    /// <summary>
    /// Логика взаимодействия для Category.xaml
    /// </summary>
    public partial class Category : Page
    {
        List<Classes.Categories> categories = new List<Classes.Categories>();
 
        public Category()
        {
            InitializeComponent();

           

            categories.Add(new Classes.Categories("шкафы"));
            categories.Add(new Classes.Categories("стулья"));
            categories.Add(new Classes.Categories("диваны"));
            combo.Items.Add("Все");

            foreach (Classes.Categories category in categories)
            {
                combo.Items.Add(category.name);
            }
            if (combo.Items.Count > 0)
            {
                combo.SelectedIndex = 0;
            }
        }

        public void Load()
        {
         
            string selectedCategory = "Все";

            if (combo.SelectedItem != null)
            {
                selectedCategory = combo.SelectedItem.ToString();
            }
            parent.Children.Clear();
             
            //List<Classes.Item> items = new List<Classes.Item>();
            //items.Add(new Classes.Item("Шкаф", 2000, "шкаф-1 (2).jpg", "шкафы"));
            //items.Add(new Classes.Item("Шкаф", 4000, "шкаф-1.jpg", "шкафы"));
            //items.Add(new Classes.Item("Шкаф", 3000, "шкаф-3.jpg", "шкафы"));
            //items.Add(new Classes.Item("Диван", 5000, "диван-1.jpg", "диваны"));
            //items.Add(new Classes.Item("Диван", 9000, "диван-2.jpg", "диваны"));
            //items.Add(new Classes.Item("Диван", 12000, "диван-3.jpg", "диваны"));
            //items.Add(new Classes.Item("Стул", 7000, "стул-1.jpg", "стулья"));
            //items.Add(new Classes.Item("Стул", 3000, "стул-2.jpg", "стулья"));
            //items.Add(new Classes.Item("Стул", 4000, "стул-3.jpg", "стулья"));

            foreach(Classes.Item I in Main.init.items)
            {
                if (selectedCategory == "Все" || I.category == selectedCategory)
                {
                    
                    parent.Children.Add(new Elements.Item(I));
                }
            }
        }
        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (parent != null)
            {
                Load(); 
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            MainWindow mainWin = (MainWindow)Application.Current.MainWindow;


            mainWin.OpenPage(Pages.Main.init);
        }
    }
}
