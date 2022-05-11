using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        public InfoPage(int Id, string Name, string LastName, string DateOfBirth)
        {
            InitializeComponent();
            txtId.Text = Id.ToString();
            txtName.Text = Name;
            txtLastName.Text = LastName;
            txtDateOfBirth.Text = DateOfBirth;
        }
    }
}