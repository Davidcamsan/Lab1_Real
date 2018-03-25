using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Lab1.ViewModels;

namespace Lab1.Views
{
    public partial class PersonaView : ContentPage
    {
        public PersonaView()
        {
            InitializeComponent();
            BindingContext = PersonaViewModel.GetInstance(); 

        }
    }
}
