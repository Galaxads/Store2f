using Avalonia.Controls;
using Avalonia.Interactivity;
using Store2f.ViewModels;

namespace Store2f.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Authorization(object source, RoutedEventArgs args)
    {
        if (Logins.Text != null && Passwords.Text != null)
        {
            Saving_Date.people[0]._Login=Logins.Text;
            Saving_Date.people[0]._Password = Passwords.Text;
            new Store().Show();
            Close();
        }
    }
}
