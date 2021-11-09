using SQLite.Net;
using THIUWP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using THIUWP.ADO;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace THIUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        UserController usersController = new UserController();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Login_acount(object sender, RoutedEventArgs e)
        {
            string txtUserName = usernameTxt.Text;
            string txtPassWord = passwordTxt.Password;
            User user = new User() { username = txtUserName, password = txtPassWord };
            if (usersController.checkUserLogin(user))
            {
                alertTxt.Text = "Đăng nhập thành công";
            }
            else
            {
                alertTxt.Text = "Tên đăng nhập hoặc tài khoản không chính xác";
            }
        }
    }
}
