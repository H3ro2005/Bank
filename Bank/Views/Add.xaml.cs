using Bank.ViewModels;

namespace Bank.Views;

public partial class Add : ContentPage
{
	public Add(AddVM AVM)
	{
		InitializeComponent();
		BindingContext= AVM;
	}
}