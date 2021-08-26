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
using System.Windows.Shapes;

namespace Classes.Windows {
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Login : Window {
        public Login() : base("Welcome", "/welcome") {
            InitializeComponent();
        }

        private void Login_Btn_Click(object sender, RoutedEventArgs e) {
            string username = username_textbox.Text;
            string password = password_textbox.Password;

            // TODO: use service class to handle user login
        }

        private void Clear_Btn_Click(object sender, RoutedEventArgs e) {
            Reg_First_Name_Textbox.Text = "";
            Reg_Last_Name_Textbox.Text = "";
            Reg_Email_Textbox.Text = "";
            Reg_username_textbox.Text = "";
            Reg_password_textbox.Password = "";
        }
    }
}
