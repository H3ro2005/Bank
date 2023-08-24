using Bank.ViewModels;
using System.Runtime.CompilerServices;

namespace Bank.Views;

public partial class Main : ContentPage
{

	public Main(MainVM MVM)
	{
		InitializeComponent();
		
		BindingContext = MVM;

	
		
	}

 
}