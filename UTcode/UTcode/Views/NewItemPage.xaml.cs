using System;
using System.Collections.Generic;
using System.ComponentModel;
using UTcode.Models;
using UTcode.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UTcode.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}