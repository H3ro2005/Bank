using Bank.DbContext;
using Bank.Models;
using Bank.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace Bank.ViewModels
{
    public class LoginVM:prop
    {
        public AppShell1 shell;
        private readonly IUserService<RegisterModel> service;
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; pchange(nameof(Email)); }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; pchange(nameof(Password)); }
        }
        public async Task<bool> CheckUser()
        {
            if (await service.UserEP(email, password,0) == null)
            {
               
                return false;
            }
            else
            {
                return true;
            }
        }
        public async Task Preference()
        {
            var user = await service.UserEP(email, password, 0);
            Preferences.Default.Set<bool>("IsMainPage", true);

            Preferences.Default.Set<int>("id", user.Id);

            Application.Current.MainPage = shell;
        }
        public ICommand Register { get; private set; }
        public ICommand Confirm { get; private set; }
        public async Task RegNav() => await AppShell.Current.GoToAsync($"{nameof(RegisterView)}");
        public LoginVM(IUserService<RegisterModel> service,AppShell1 shell)
        {
            this.shell = shell;
            this.service = service;
            Register = new Command(async () => { await RegNav(); });
            Confirm = new Command(async () =>
            {
                if (await CheckUser() == true)
                {
                    await Preference();
                }
            });
            this.shell = shell;
        }
    }
}
