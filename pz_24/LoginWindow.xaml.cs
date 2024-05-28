using lib;
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

namespace pz_24
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private IDataService dataService;
        private List<User> users;

        public LoginWindow()
        {
            InitializeComponent();
            dataService = new JsonDataService();// создание экземпляра сервиса данных
            users = dataService.LoadData<List<User>>("users.json") ?? new List<User>();//загрузка пользователей из JSON файла
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)//нажатие на кнопку "войти"
        {
            var user = users.FirstOrDefault(u => u.Username == UsernameTextBox.Text && u.Password == PasswordBox.Password); //создание нового пользователя с введенными данными
            if (user != null)//если поля не пустые присвоить роль в зависимости от выбранной
            {

                if (user.Role == "admin")
                {
                    AdminWindow adminWindow = new AdminWindow();//открытие окна админа
                    adminWindow.Show();
                }
                else
                {
                    PatientWindow patientWindow = new PatientWindow(user);//открытие окна пациента
                    patientWindow.Show();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }
        }
    }
}
