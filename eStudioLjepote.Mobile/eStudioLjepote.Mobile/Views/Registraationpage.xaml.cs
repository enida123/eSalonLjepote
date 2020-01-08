using eStudioLjepote.Mobile.ViewModels;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eStudioLjepote.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registraationpage : ContentPage
    {
        private Registracija model = null;
        private readonly APIService service = new APIService("Klijenti");

        public Registraationpage ()
		{
			InitializeComponent ();
            BindingContext = model = new Registracija();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            
        }
      
        private async void Snimi_Clicked(object sender, EventArgs e)
        {
            KlijentiUpsertRequest klijent = new KlijentiUpsertRequest()
            {
                Ime = model.Ime,
                Prezime = model.Prezime,
                Spol = model.Spol,
                BrojTelefona = model.BrojTelefona,
                Email = model.Email,
                GradId = model.SelectedGrad.Id,
                Username = model.Username,
                Password = model.Password,
                PasswordConfirmation = model.PasswordConfirmation
                
        };
            await service.Insert<eStudioLjepote.Model.Klijent> (klijent);
            Application.Current.MainPage = new LoginPage();

        }
    }
}