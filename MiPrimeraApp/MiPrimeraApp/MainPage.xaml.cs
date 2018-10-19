using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MiPrimeraApp
{
    public partial class MainPage : ContentPage
    {
        public Empleado  NuevEmpleado { get; set; }

        public MainPage()
        {
            var label = new Label
            {
                Text = "Ingresa tus datos"
            };

            var txtNombre = new Entry
            {
                Placeholder = "Escribre tu name"
            };

            var txtEmail = new Entry
            {
                Placeholder = "Escribre tu email"
            };

            var button = new Button
            {
                Text = "Apachurrale"
            };

            button.Clicked += (sender, e) =>
            {
                DisplayAlert("Mensaje", txtNombre.Text, "Ok");
                NuevEmpleado = new Empleado();
                NuevEmpleado.nombre = txtNombre.Text;
                NuevEmpleado.email = txtEmail.Text;
                BindingContext = NuevEmpleado;
                InitializeComponent();
            };

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = {label, txtNombre, txtEmail, button }
            };

        }
    }
}
