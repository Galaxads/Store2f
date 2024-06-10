using Avalonia.Controls;
using Avalonia.Interactivity;
using Store2f.ViewModels;
using System.Linq;

namespace Store2f.Views
{
    public partial class Store : Window
    {
        public Store()
        {
            InitializeComponent();
            assortment_of_goods.ItemsSource =Saving_Date.products.ToList() ;
            Role_verification();
        }
       

        private void Role_verification()
        {
            UserRole.Text = $"Вы {Saving_Date.people[0]._User_Role}";
        }

        private void New_product(object sender, RoutedEventArgs args)
        {
            //int v = (int)(sender as Button)!.Tag!;
            new Redactor().Show();
            Close();
        }

       
    }
}
