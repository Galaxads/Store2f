using Avalonia.Controls;
using Avalonia.Interactivity;
using DynamicData;
using Store2f.ViewModels;
using System;

namespace Store2f.Views
{
    public partial class Redactor : Window
    {
        public Redactor()
        {
            InitializeComponent();
        }

        private void Add_Product(object source, RoutedEventArgs args)
        {
            if (Name.Text!=null && Descriprion.Text!=null && Price.Text!=null && Colvo.Text!=null && Price.Text!=null )
            {
                Saving_Date.products.Add(new (Saving_Date.products.Count,Name.Text, Descriprion.Text, Manufacture.Text, Convert.ToInt32(Price.Text), null, Convert.ToInt32(Colvo.Text)));
            }
            new Store().Show();
            Close();
        }
    }
}
