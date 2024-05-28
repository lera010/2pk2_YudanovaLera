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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private IDataService dataService;
        private List<User> users;

        public RegisterWindow()
        {
            InitializeComponent();
            dataService = new JsonDataService();// создание экземпляра сервиса данных
            users = dataService.LoadData<List<User>>("users.json") ?? new List<User>();//загрузка пользователей из JSON файла
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)//обработка нажатия на кнопку зарегистрироваться
        {
            var newUser = new User//создание нового поьзователя
            {
                Id = users.Count + 1,
                Username = UsernameTextBox.Text,
                Password = PasswordBox.Password,
                Role = (RoleComboBox.SelectedItem as ComboBoxItem).Content.ToString()
            };

            users.Add(newUser);//добавление в лист users нового пользователя 
            dataService.SaveData("users.json", users);//сохранение в json файл

            MainWindow mainWindow = new MainWindow();//открытие главного окна
            mainWindow.Show();
            this.Close();
        }
    }
}
