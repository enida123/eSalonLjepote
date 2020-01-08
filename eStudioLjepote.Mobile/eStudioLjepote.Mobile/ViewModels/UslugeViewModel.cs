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
   public  class UslugeViewModel:BaseViewModel
    {
        private readonly APIService service = new APIService("Usluge");
        private readonly APIService aPIServiceVrstaUsluge = new APIService("VrsteUsluga");

        public UslugeViewModel()
        {
            InitCommand = new Command(async ()  =>await Init());
        }
        public ObservableCollection<Usluga> UslugeList { get; set; } = new ObservableCollection<Usluga>();
        public ObservableCollection<VrstaUsluge> VrsteUslugeList { get; set; } = new ObservableCollection<VrstaUsluge>();
        VrstaUsluge _SelectedVrstaUsluge = null;
        public VrstaUsluge SelectedVrstaUsluge
        {
            get { return _SelectedVrstaUsluge; }
          
            set
            {
                SetProperty(ref _SelectedVrstaUsluge, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            if (VrsteUslugeList.Count == 0)
            {
                var VrsteUslugalist = await aPIServiceVrstaUsluge.Get<List<VrstaUsluge>>(null);
                foreach (var vrstaUsluge in VrsteUslugalist)
                {
                    VrsteUslugeList.Add(vrstaUsluge);
                }
            }
            if (SelectedVrstaUsluge != null)
            {
                UslugaSearchRequest search = new UslugaSearchRequest();
                search.VrstaUslugeId = SelectedVrstaUsluge.ID;

                var list = await service.Get<List<Usluga>>(search);


                UslugeList.Clear();
                foreach (var usluga in list)
                {
                    UslugeList.Add(usluga);
                }

            }
           
        }
    }
}
