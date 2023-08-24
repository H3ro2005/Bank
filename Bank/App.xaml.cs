using Bank.DbContext;
using Bank.ViewModels;
using Bank.Views;


namespace Bank;

public partial class App : Application
{
	public App()
	{

		InitializeComponent();
		checker();
        
       
		
	}
	public void checker()
	{

        if (Preferences.Default.ContainsKey("IsMainPage") && Preferences.Default.Get<bool>("IsMainPage",false) == true)
        {
            
            MainPage = new AppShell1();
        }
        else
        {
            MainPage = new AppShell();
        }
    }
   

}
