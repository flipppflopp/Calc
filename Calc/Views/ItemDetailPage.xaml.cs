using Calc.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Calc.Views
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