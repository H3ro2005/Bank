using Bank.DbContext;
using Bank.Models;
using Bank.Services;
using Bank.ViewModels;
using Bank.Views;
using Microsoft.Extensions.Logging;

namespace Bank;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<LoginView>();
        builder.Services.AddSingleton<LoginVM>();
        builder.Services.AddTransient<RegisterView>();
        builder.Services.AddTransient<RegisterVM>();
		builder.Services.AddSingleton<BankView>();
		builder.Services.AddTransient<MainVM>();
        builder.Services.AddTransient<Main>();
        builder.Services.AddSingleton<IUserService<RegisterModel>, UserService>();
        builder.Services.AddSingleton<IUserService<Autinfo>, BankService>();
		builder.Services.AddSingleton<BankData>();
        builder.Services.AddSingleton<CardData>();
        builder.Services.AddSingleton<BankVM>();
        builder.Services.AddSingleton<CardMainVM>();
        builder.Services.AddSingleton<CardMainView>();
		builder.Services.AddSingleton<Add>();
        builder.Services.AddSingleton<AddVM>();
		builder.Services.AddSingleton<AppShell1>();
		builder.Services.AddTransient<UseCardVM>();
		builder.Services.AddTransient<EnterCode>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
