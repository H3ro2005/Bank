using Bank.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bank.ViewModels
{
    public class AddVM
    {
        public ICommand Adding { get; protected set; }
        public ICommand New { get; protected set; }

        public AddVM() { 
        New = new Command(async () => { await newnav(); });
        Adding = new Command(async () => { await addnav(); });
        }

        public async Task newnav()
        {
            await AppShell1.Current.GoToAsync($"/{nameof(CardMainView)}",true);
        }
        public async Task addnav()
        {
            await AppShell1.Current.GoToAsync($"/{nameof(EnterCode)}", true);
        }
    }
}
