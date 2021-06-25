using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ExerciceSynthese.Dal;
using ExerciceSynthese.Models;

namespace ExerciceSynthese
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDetailTache : ContentPage
    {

        private Tache TacheGeneral;
        public PageDetailTache(Tache tache)
        {
            InitializeComponent();

                Title.Text = tache.Title;
                Date.Date = tache.Date;
                Description.Text = tache.Description;
        }

        private void btnRetour_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void btnValider_Clicked(object sender, EventArgs e)
        {
            if (TacheGeneral == null)
                TacheGeneral = new Tache();
                TacheGeneral.Title = Title.Text;
                TacheGeneral.Date = Date.Date;
                TacheGeneral.Description = Description.Text;

            new TacheDal().Sauvegarder(TacheGeneral);
        }
    }
}