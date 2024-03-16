using eShop_mobile.ViewModels;

namespace eShop_mobile;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new HomeViewModel();
	}
}