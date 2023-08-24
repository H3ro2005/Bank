using Bank.ViewModels;

namespace Bank.Views;

public partial class RegisterView : ContentPage
{
	public RegisterView(RegisterVM RVM)
	{
		InitializeComponent();
	   BindingContext= RVM;
	}
}