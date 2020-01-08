using eStudioLjepote.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eStudioLjepote.Mobile.ViewModels
{
    public class LogoutViewModel
    {
        public LogoutViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            Application.Current.MainPage = new LoginPage();
        }
    }
}
