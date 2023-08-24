using Bank.ViewModels;

namespace Bank.Views;

public partial class CardMainView : ContentPage
{
	public CardMainView(CardMainVM CMVM)
	{
		InitializeComponent();
		BindingContext = CMVM;
	}
}