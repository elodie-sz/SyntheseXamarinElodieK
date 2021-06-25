using ExerciceSynthese.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExerciceSynthese.Models;
using System.ComponentModel;


namespace ExerciceSynthese
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreerTache : ContentPage
    {
        public CreerTache()
        {
            InitializeComponent();
        }

        private void btnRetour_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void btnValider_Clicked(object sender, EventArgs e)
        {
            Tache tache = new Tache();
            tache.Title = Title.Text;
            tache.Date = dtpDate.Date;
            tache.Description = Description.Text;
           
            new TacheDal().Sauvegarder(tache);

            Navigation.PopModalAsync();
        }
    }
}