using Bank.ViewModels;

namespace Bank.Views;

public partial class EnterCode : ContentPage
{
	public EnterCode(UseCardVM UCVM)
	{
		InitializeComponent();
		BindingContext = UCVM;
	}
}