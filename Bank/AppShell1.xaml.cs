using Bank.Views;

namespace Bank;

public partial class AppShell1 : Shell
{
	public AppShell1()
	{
		InitializeComponent();
 
        Routing.RegisterRoute(nameof(Main), typeof(Main));
		Routing.RegisterRoute(nameof(BankView), typeof(BankView));
		Routing.RegisterRoute(nameof(CardMainView), typeof(CardMainView));
		Routing.RegisterRoute(nameof(Add), typeof(Add));
		Routing.RegisterRoute(nameof(EnterCode), typeof(EnterCode));
    }
}