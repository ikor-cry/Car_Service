using Car_Service;
using Car_Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarServiceApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AppointmentPage.xaml
    /// </summary>
    public partial class AppointmentPage : Page
    {
        CarServiceContext db = new CarServiceContext();
        ObservableCollection<Appointment> ap = new ObservableCollection<Appointment>();
        public AppointmentPage()
        {
            InitializeComponent();

            db.Appointments.Include(s => s.Car).Include(s => s.Service).Load();

            ap = db.Appointments.Local.ToObservableCollection();

            DataContext = ap;
        }

        private void StackPanel_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var s = sender is StackPanel;
            MessageBoxResult result = MessageBox.Show(
            "Ты точно хочешь удалить это?",
            "Да или нет?",
            MessageBoxButton.YesNo,
            MessageBoxImage.Question);
            

            if (result == MessageBoxResult.Yes)
            {
                
                db.SaveChanges();
            }
        }
    }
}
