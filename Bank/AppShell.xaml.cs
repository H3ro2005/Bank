using Bank.Views;

namespace Bank;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		

		Routing.RegisterRoute(nameof(RegisterView), typeof(RegisterView));
        Routing.RegisterRoute("Log", typeof(LoginView));

    }
}
