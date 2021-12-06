﻿using System;
using System.Collections.Generic;
using System.Text;
using University.App.Helpers;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace University.App.ViewModels.Forms
{
    public class AboutViewModel : BaseViewModel
    {
        #region Constructor
        public AboutViewModel()
        {
            this.NavigateSiteCommand = new Command(NavigateSite);
            this.NavigateYTCommand = new Command(NavigateYT);
        }

        #endregion

        #region Commands
        public Command NavigateSiteCommand { get; set; }
        public Command NavigateYTCommand { get; set; }
        #endregion

        #region Methods
        async void NavigateYT()
        {
            try
            {
                await Launcher.TryOpenAsync(new Uri(string.Format("https://www.youtube.com/watch?v={0}", "FGpqfpdB6PE")));
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Notification, ex.Message, Languages.Accept);
            }
        }

        async void NavigateSite()
        {
            try
            {
                await Launcher.TryOpenAsync(new Uri(string.Format("https://waze.com/ul?q={0}&navigate=yes", "Centro Comercial Unico")));
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Notification, ex.Message, Languages.Accept);
            }
        }
        #endregion
    }
}
