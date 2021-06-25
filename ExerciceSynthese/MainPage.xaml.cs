using ExerciceSynthese.Dal;
using ExerciceSynthese.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExerciceSynthese
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			lblDate.Text = DateTime.Today.ToShortDateString(); 
            List<Tache> taches = new List<Tache>();
            taches = new TacheDal().SelectAll();
            lstTaches.ItemsSource = taches;

        }

        private void lstTaches_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Tache tache = (Tache)e.Item;


            Navigation.PushModalAsync(new PageDetailTache(tache));
        }

        private void btnProfil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PageProfil());
        }

        private void btnTache_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CreerTache());
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            Tache tache = (Tache)((Switch)sender).BindingContext;
            tache.Etat = e.Value;
            new TacheDal().Sauvegarder(tache);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
