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
    /// Логика взаимодействия для PatientWindow.xaml
    /// </summary>
    public partial class PatientWindow : Window
    {
        private IDataService dataService;
        private List<Doctor> doctors;
        private List<Appointment> appointments;
        private User currentUser;

        public PatientWindow(User user)
        {
            InitializeComponent();
            currentUser = user;
            dataService = new JsonDataService();// создание экземпляра сервиса данных
            doctors = dataService.LoadData<List<Doctor>>("doctors.json") ?? new List<Doctor>();//загрузка файлов из json 
            appointments = dataService.LoadData<List<Appointment>>("appointments.json") ?? new List<Appointment>();//загрузка файлов из json 
            DoctorComboBox.ItemsSource = doctors;//внесение в ComboBox существующих врачей


            var times = new List<string>//доступное время для записи
        {
            "09:00", "09:30", "10:00", "10:30", "11:00", "11:30",
            "12:00", "12:30", "13:00", "13:30", "14:00", "14:30",
            "15:00", "15:30", "16:00", "16:30", "17:00"
        };
            TimeComboBox.ItemsSource = times;

            LoadAppointments();
        }

        private void LoadAppointments()//загрузка существующих записей пациента
        {
            var userAppointments = appointments.Where(a => a.PatientId == currentUser.Id).Select(a => new
            {
                a.Id,
                DoctorName = doctors.FirstOrDefault(d => d.Id == a.DoctorId)?.Name,
                a.AppointmentDate
            }).ToList();

            AppointmentDataGrid.ItemsSource = userAppointments;
        }

        private void BookAppointmentButton_Click(object sender, RoutedEventArgs e)//запись
        {
            var selectedDoctor = DoctorComboBox.SelectedItem as Doctor;
            var selectedDate = DatePicker.SelectedDate;
            var selectedTime = TimeComboBox.SelectedItem as string;

            if (selectedDoctor != null && selectedDate.HasValue && !string.IsNullOrEmpty(selectedTime))//проверка записан ли пациент на это время
            {
                var appointmentDateTime = selectedDate.Value.Date.Add(TimeSpan.Parse(selectedTime));

                if (appointments.Any(a => a.DoctorId == selectedDoctor.Id && a.AppointmentDate == appointmentDateTime))
                {
                    MessageBox.Show("Этот временной интервал уже занят. Пожалуйста, выберите другое время.");
                    return;
                }

                var newAppointment = new Appointment//создание новой записи
                {
                    Id = appointments.Count + 1,
                    PatientId = currentUser.Id,
                    DoctorId = selectedDoctor.Id,
                    AppointmentDate = appointmentDateTime
                };

                appointments.Add(newAppointment);//добавление в лист
                dataService.SaveData("appointments.json", appointments);

                MessageBox.Show("Запись на прием успешна!");
                LoadAppointments();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите врача, дату и время");
            }
        }

        private void DeleteAppointmentButton_Click(object sender, RoutedEventArgs e)//удаление записи
        {
            if (AppointmentDataGrid.SelectedItem != null)
            {
                dynamic selectedAppointment = AppointmentDataGrid.SelectedItem;
                var appointment = appointments.FirstOrDefault(a => a.Id == selectedAppointment.Id);
                if (appointment != null)
                {
                    appointments.Remove(appointment);
                    dataService.SaveData("appointments.json", appointments);
                    MessageBox.Show("Запись удалена!");
                    LoadAppointments();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)//возвращение в главное окно
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
