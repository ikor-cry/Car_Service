using Car_Service;
using Car_Service.Models;
using CarServiceApp.Windows;
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
        Appointment sel = new Appointment();
        public AppointmentPage()
        {
            InitializeComponent();

            db.Appointments.Include(s => s.Car).Include(s => s.Service).Load();

            ap = db.Appointments.Local.ToObservableCollection();

            DataContext = ap;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Appointment app = new Appointment();
            AddAppointmentWindow w = new AddAppointmentWindow();

            //w.DataContext = null;
            w.ShowDialog();
            if(w.DialogResult == true)
            {
                ap.Add(app);
                db.SaveChanges();
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if(sel != null)
            {

                if(MessageBox.Show("Точно хотите удалить?",))
                ap.Remove(sel);
                db.SaveChanges();
            }
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((sender as StackPanel).DataContext is Appointment s)
            {
                
                sel = s;
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
