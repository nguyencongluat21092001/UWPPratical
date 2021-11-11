using Bai1EmployeeList.ADO;
using Bai1EmployeeList.Model;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Bai1EmployeeList
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        EmployeeController employeeController = new EmployeeController();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void DBConnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Employee> listEmployee = employeeController.GetAllEmployee();
                string strDetail = "";

                if (listEmployee.Count > 0)
                {
                    foreach (var item in listEmployee)
                    {
                        strDetail += item.Id + ", " + item.Name + ", " + item.Role + ", " + item.Birthyear + "\n";
                    }
                    txtDetails.Text = strDetail;
                }
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
                throw;
            }
        }
    }
}
