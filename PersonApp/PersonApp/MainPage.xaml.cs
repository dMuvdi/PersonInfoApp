using PersonApp.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void Submit(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtLastName.Text))
            {
                await DisplayAlert("Missing Fields", "Please enter all of them.", "OK");
                return;
            }
            Person p = new Person
            {
                id = Int32.Parse(txtId.Text),
                Name = txtName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dateofbirth.Date.ToShortDateString(),
            };
            await Navigation.PushAsync(new InfoPage(p.id, p.Name, p.LastName, p.DateOfBirth));
        }
    }
}
