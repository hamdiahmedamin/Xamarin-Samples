﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup;
using Rg.Plugins.Popup.Extensions;
namespace Nav
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync( new Pagina01() );
        }

        private void Button_Clicked_Modal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pagina01());
        }

        private async void Button_Clicked_PluginModalRG(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new Popup());
        }
    }
}
