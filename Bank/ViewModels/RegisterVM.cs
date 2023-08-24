using Bank.DbContext;
using Bank.Models;
using Bank.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bank.ViewModels
{
    public class RegisterVM:prop
    {
        public RegisterModel reg = new RegisterModel();
        private readonly IUserService<RegisterModel> service;
        public ICommand Login { get; private set; }
        public ICommand Save { get; private set; }
        //properties
        public AppShell1 shell;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; pchange(nameof(Name)); }
        }
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; pchange(nameof(Surname)); }
        }
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
        private string cpassword;
        public string CPassword
        {
            get { return cpassword; }
            set { cpassword = value; pchange(nameof(CPassword)); }
        }

        public async Task LogNav() => await AppShell.Current.GoToAsync("../",true);
        public async Task<bool> UserAdd()
        {
            if (password == cpassword)
            {
                reg.Email = email;
                reg.Password = password;
                reg.Name = name;
                reg.Surname = surname;
                await service.AddUser(reg);
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task Preference()
        {
            var user = await service.UserEP(reg.Email, reg.Password,0);
            Preferences.Default.Set<bool>("IsMainPage", true);

            Preferences.Default.Set<int>("id",user.Id);

            Application.Current.MainPage = shell;
        }
        public RegisterVM(IUserService<RegisterModel> service, AppShell1 shell)
        {
            this.shell = shell;
            this.service = service;
            Login = new Command(async() => { await LogNav(); });
            Save = new Command(async () => 
            {
                if (await UserAdd() == true)
                {
                    await Preference();
                }
                 });
        }
    }
}
