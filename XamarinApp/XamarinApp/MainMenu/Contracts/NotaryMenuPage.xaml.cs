using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.MainMenu.Contracts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotaryMenuPage : ContentPage, IBackButton
    {
        private readonly Page owner;

        private static readonly SortedDictionary<string, SortedDictionary<string, string>> ContractTypesPerCategory =
            new SortedDictionary<string, SortedDictionary<string, string>>()
            {
                {
                    "Declaracion Jurada",
                    new SortedDictionary<string,string>()
                    {
                        { "Cesantia", "269b35ba-d12c-1323-f412-0cc066805dcd@legal.cybercity.online" },
                        { "Salvoconducto Mudanza", "26df9fb1-181f-6a06-fc0b-d67146cf5171@legal.cybercity.online" },
                        { "Patente Titulo", "26f36882-5fbb-a83f-d804-30caffdca4c1@legal.cybercity.online"}
                    }
                } 
            };

        public NotaryMenuPage(Page Owner)
        {
            this.owner = Owner;
            this.BindingContext = this;
            InitializeComponent();
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            App.ShowPage(this.owner, true);
        }

		private void NewContract_Clicked(object sender, EventArgs e)
		{
            App.ShowPage(new NewContractPage(App.Configuration, App.CurrentPage, ContractTypesPerCategory), false);
        }

        public bool BackClicked()
        {
            this.BackButton_Clicked(this, new EventArgs());
            return true;
        }

    }
}