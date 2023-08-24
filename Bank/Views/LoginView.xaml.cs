using Bank.ViewModels;

namespace Bank.Views;

public partial class LoginView : ContentPage
{
	public LoginView(LoginVM LVM)
	{
		InitializeComponent();
		BindingContext = LVM;
	  
	}
}