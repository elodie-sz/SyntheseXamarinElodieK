using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExerciceSynthese.Dal;
using ExerciceSynthese.Models;
using System.ComponentModel;

namespace ExerciceSynthese
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageProfil : ContentPage
    {
        private Profil ProfilGeneral;
        public PageProfil()
        {
            InitializeComponent();
            ProfilGeneral = new ProfilDal().Select(1);
            if(ProfilGeneral != null)
            {
                entNom.Text = ProfilGeneral.Nom;
                entPrenom.Text = ProfilGeneral.Prenom;
                entAge.Text = ProfilGeneral.Age.ToString();
            }
        }

        private void btnRetour_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void btnValider_Clicked(object sender, EventArgs e)
        {
            if (ProfilGeneral == null) 
                ProfilGeneral = new Profil();
                ProfilGeneral.Nom = entNom.Text;
                ProfilGeneral.Prenom = entPrenom.Text;
                ProfilGeneral.Age = Convert.ToInt16(entAge.Text);

            new ProfilDal().Sauvegarder(ProfilGeneral);
        }

        private void lstInfos_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}