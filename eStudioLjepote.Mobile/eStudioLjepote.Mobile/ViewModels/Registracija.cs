using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eStudioLjepote.Mobile.ViewModels
{
    public  class Registracija: BaseViewModel
    {
        private readonly APIService serviceGradovi = new APIService("Gradovi");

        public Registracija()
        {
           InitCommand = new Command(async () => await Init());

        }


        string ime = string.Empty;
        public string Ime
        {
            get { return ime; }
            set { SetProperty(ref ime, value); }
        }



        string prezime = string.Empty;
        public string Prezime
        {
            get { return prezime; }
            set { SetProperty(ref prezime, value); }
        }

        string brojTelefona = string.Empty;
        public string BrojTelefona
        {
            get { return brojTelefona; }
            set { SetProperty(ref brojTelefona, value); }
        }

        Grad _SelectedGrad = null;
        public Grad SelectedGrad
        {
            get { return _SelectedGrad; }
            set
            {
                SetProperty(ref _SelectedGrad, value);

            }
        }
        string email = string.Empty;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }
        string grad = string.Empty;
        public string Grad
        {
            get { return grad; }
            set { SetProperty(ref grad, value); }
        }
        string username = string.Empty;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }
        string spol = string.Empty;
        public string Spol
        {
            get { return spol; }
            set { SetProperty(ref spol, value); }
        }
        string password = string.Empty;




        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }


        string passwordConfirmation = string.Empty;




        public string PasswordConfirmation
        {
            get { return passwordConfirmation; }
            set { SetProperty(ref passwordConfirmation, value); }
        }
        public ObservableCollection<Grad> GradList { get; set; } = new ObservableCollection<Grad>();
        public ICommand InitCommand { get; set; }

       public async Task Init()
        {
            var list = await serviceGradovi.Get<List<Grad>>(null);
            GradList.Clear();
            foreach (var grad in list)
            {
                GradList.Add(grad);
            }


        }


    }
}
