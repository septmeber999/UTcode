using System;
using System.Collections.Generic;
using UTcode.ViewModels;
using UTcode.Views;
using Xamarin.Forms;

namespace UTcode
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
