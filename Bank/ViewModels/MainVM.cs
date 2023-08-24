using Bank.DbContext;
using Bank.Models;
using Bank.Views;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bank.ViewModels
{
    public class MainVM:prop
    {
        public ICommand Exit { get; private set; }
        public ICommand Rate { get; private set; }
        public ICommand Card { get; private set; }  
        private readonly IUserService<RegisterModel> service;
        public async void info()
        {
           var x = await service.UserEP(null,null,id);
            Surname= x.Surname;
            Name= x.Name;
        }
        public async Task Banks()
        {
           await AppShell1.Current.GoToAsync($"{nameof(BankView)}",true);
        }
        public async Task BankCards()
        {
           await  AppShell1.Current.GoToAsync($"{nameof(Add)}",true);
        }
        public async Task Leave()
        {
            Preferences.Default.Set<bool>("IsMainPage", false);

            Preferences.Default.Set<int>("id", 0);

            Application.Current.MainPage = new AppShell();
          
            
        }
        public int id { get; set; }
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
      
        
        public MainVM(IUserService<RegisterModel> service)
        {
        this.service = service;
            id = Preferences.Default.Get<int>("id",0);
            info();
            Exit = new Command(async() => { await Leave(); });
            Rate = new Command(async () => { await Banks(); });
            Card = new Command(async () => { await BankCards(); });
        }
    }
}
