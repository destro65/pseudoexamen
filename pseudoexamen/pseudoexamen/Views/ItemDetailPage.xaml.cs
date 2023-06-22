using pseudoexamen.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace pseudoexamen.Views
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