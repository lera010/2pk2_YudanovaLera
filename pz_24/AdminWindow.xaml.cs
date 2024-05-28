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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private IDataService dataService;
        private List<Doctor> doctors;

        public AdminWindow()
        {
            InitializeComponent();
            dataService = new JsonDataService();// создание экземпляра сервиса данных
            doctors = dataService.LoadData<List<Doctor>>("doctors.json") ?? new List<Doctor>();// Загрузка пользователей из JSON файла
            DoctorDataGrid.ItemsSource = doctors;//вывод докторов
        }

        private void AddDoctorButton_Click(object sender, RoutedEventArgs e)//добавление нового доктора
        {
            doctors.Add(new Doctor { Id = doctors.Count + 1 });
            DoctorDataGrid.Items.Refresh();
        }

        private void DeleteDoctorButton_Click(object sender, RoutedEventArgs e)//удаление доктора
        {
            if (DoctorDataGrid.SelectedItem is Doctor selectedDoctor)//есди выбран доктор, то удаляется и список докторов обновляется
            {
                doctors.Remove(selectedDoctor);
                DoctorDataGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите врача для удаления.");
            }
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)//сохранение изменений
        {
            dataService.SaveData("doctors.json", doctors);
            MessageBox.Show("Изменения сохранены!");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)//возврат в главное окно
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
