using System;
using System.Collections.Generic;
using System.IO;
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

namespace FurnitureStore_Abubakirova.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Classes.Item itemp;
        
        public Item(Classes.Item item)
        {
            InitializeComponent();
            itemp = item;
            

            if (itemp != null)
            {
                if(File.Exists(Directory.GetCurrentDirectory() + "/Images/" + itemp.src))
                {
                    image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/" + itemp.src));
                }
                else
                {
                    image.Source =new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/background.jpg"));

                }
                price.Content =     itemp.price;
                name.Content = itemp.name;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (itemp != null)
            //{
            //    Classes.Cart.itogPrice += itemp.price;

            //    MainWindow mainWin = (MainWindow)Application.Current.MainWindow;

            //    if (mainWin.frame.Content is Pages.Main mainPage)
            //    {
            //        mainp.cart.Content = $"Корзина ({Classes.Cart.itogPrice})";
            //    }
            //}


            if (itemp != null)
            {
                Classes.Cart.itogPrice += itemp.price;

            
                if (Pages.Main.init != null)
                {
                    Pages.Main.init.cartup(Classes.Cart.itogPrice);
                }
            }

        }
    }
}
