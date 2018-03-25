using System;
using System.Collections.Generic;
using Lab1.ViewModels;
using Xamarin.Forms;

namespace Lab1.Views
{
    public partial class UsuarioDetalle : ContentPage
    {
        public UsuarioDetalle()
        {
            InitializeComponent();

            BindingContext = PersonaViewModel.GetInstance();
        }
    }
}
