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
using System.Windows.Shapes;

namespace CarServiceApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddAppointmentWindow.xaml
    /// </summary>
    public partial class AddAppointmentWindow : Window
    {
        CarServiceContext db = new CarServiceContext();
        ObservableCollection<Appointment> ap =  new ObservableCollection<Appointment>();

        public AddAppointmentWindow()
        {
            InitializeComponent();

            db.Appointments.Include(s => s.Car).Include(s => s.Service).Load();
            ap = db.Appointments.Local.ToObservableCollection();

            this.DataContext = ap;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
