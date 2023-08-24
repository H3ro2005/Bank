using Bank.ViewModels;

namespace Bank.Views;

public partial class BankView : ContentPage
{
	public BankView(BankVM BVM)
	{
		InitializeComponent();
		BindingContext= BVM;
	}
}