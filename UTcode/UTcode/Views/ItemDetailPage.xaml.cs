using System.ComponentModel;
using UTcode.ViewModels;
using Xamarin.Forms;

namespace UTcode.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}