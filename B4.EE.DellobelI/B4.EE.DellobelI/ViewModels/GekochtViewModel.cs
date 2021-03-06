﻿using B4.EE.DellobelI.Domain.Models;
using B4.EE.DellobelI.Domain.Services.Abstract;
using FreshMvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace B4.EE.DellobelI.ViewModels
{
    public class GekochtViewModel : FreshBasePageModel
    {
        private IKlantenService klantenService;
        private IVoertuigenService voertuigenService;
        private Voertuigen voertuigenLijst;
        private Auto editAuto;



        public GekochtViewModel(IKlantenService klantenService, IVoertuigenService voertuigenService)
        {
            this.klantenService = klantenService;
            this.voertuigenService = voertuigenService;

        }

        private ObservableCollection<Auto> voertuigenGekocht;
        public ObservableCollection<Auto> VoertuigenGekocht
        {
            get { return voertuigenGekocht; }
            set
            {
                voertuigenGekocht = value;
                RaisePropertyChanged(nameof(VoertuigenGekocht));
            }
        }

        private string merk;
        public string Merk
        {
            get { return merk; }
            set
            {
                merk = value;
                RaisePropertyChanged(nameof(Merk));
            }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
                RaisePropertyChanged(nameof(Model));
            }
        }

        private string bouwjaar; // int geeft 0
        public string Bouwjaar
        {
            get { return bouwjaar; }
            set
            {
                bouwjaar = value;
                RaisePropertyChanged(nameof(Bouwjaar));
            }
        }

        private string prijs;


        public string Prijs
        {
            get { return prijs; }
            set
            {
                prijs = value;
                RaisePropertyChanged(nameof(Prijs));
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);


            voertuigenLijst = initData as Voertuigen;

            voertuigenGekocht = new ObservableCollection<Auto>(voertuigenLijst.Autoos as List<Auto>);



        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
            //if (returnedData is Voertuigen)
            //{
            //    RefreshVoertuigenlijst();
            //}
        }

        private void RefreshVoertuigenlijst()
        {
            var voertuigen = voertuigenGekocht;
            //VoertuigenAanbod = null;
            VoertuigenGekocht = new ObservableCollection<Auto>(voertuigen);

            foreach (Auto a in VoertuigenGekocht)
            {
                Merk = a.Merk;
                Model = a.Model;
                Bouwjaar = a.Bouwjaar.ToString();
                Prijs = a.Prijs.ToString();

            }
        }
        //protected override void ViewIsAppearing(object sender, EventArgs e)
        //{
        //    base.ViewIsAppearing(sender, e);
        //    RefreshVoertuigenlijst();
        //}

        public ICommand ToEditGekochtCommand => new Command<Auto>(
          async (Auto auto) =>
          {
              editAuto = auto;

              await CoreMethods.PushPageModelWithNewNavigation<EditGekochtViewModel>(editAuto, true);


          }
          );

        public ICommand TerugOverzichtVerkoopPageCommand => new Command(
          async () =>
          {


              await CoreMethods.PushPageModelWithNewNavigation<OverzichtVerkoopViewModel>(true);


          }
          );
    }
}
