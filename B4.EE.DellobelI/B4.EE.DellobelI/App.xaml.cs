using B4.EE.DellobelI.ViewModels;
using FreshMvvm;
using System;

using Xamarin.Forms;

namespace B4.EE.DellobelI
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new B4.EE.DellobelI.Pages.MainPage();
            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
        private void OnHomeTapped(object sender, EventArgs e)
        {
            //await CoreMethods.PushPageModel<MainViewModel>(true);
            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>());

        }
        private void OnKaartTapped(object sender, EventArgs e)
        {
            //await CoreMethods.PushPageModel<MainViewModel>(true);
            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<KaartViewModel>());

        }
        private void OnClockTapped(object sender, EventArgs e)
        {
            //await CoreMethods.PushPageModel<MainViewModel>(true);
            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<ClockViewModel>());

        }
        private void OnStatistiekTapped(object sender, EventArgs e)
        {
            //await CoreMethods.PushPageModel<MainViewModel>(true);
            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<StatistiekViewModel>());

        }
        private void OnDatumTapped(object sender, EventArgs e)
        {
            //await CoreMethods.PushPageModel<MainViewModel>(true);
            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<DatumViewModel>());

        }
    }
}
