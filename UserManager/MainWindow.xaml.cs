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
using UserManager.DbLib;
using UserManager.Models;

namespace UserManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TableAccount _tableAccount;
        public MainWindow()
        {
             var connection = @"Data Source=C:\WPF\Проекты\UserManager\SQL\accounts.db";
            _tableAccount=new TableAccount(new TableAccountsSql(new TableOperationSqlite<Account>(connection)));
            InitializeComponent();
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            Input_Login.Clear();//очистим поле ввода логина
            Input_Password.Clear();//очистим поле ввода пароля или Input_Password.Text=string.Empty;
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            var login = Input_Login.Text;
            var password = Input_Password.Text;

            if(_tableAccount.ChackLoginPassword(login, password))//или MessageBox.Show(_tableAccount.ChackLoginPassword(login, password) ? "Вход разрешен" : "Вход запрещен"))
            {
                MessageBox.Show("Вход разрешен");
            }
            else
            {
                MessageBox.Show("Вход запрещен");
            }
        }
    }
}
