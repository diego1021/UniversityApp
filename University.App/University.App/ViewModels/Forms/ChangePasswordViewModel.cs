using System;
using System.Collections.Generic;
using System.Text;
using University.App.Helpers;
using University.BL.DTOs;
using University.BL.Services.Implements;
using Xamarin.Forms;

namespace University.App.ViewModels.Forms
{
    public class ChangePasswordViewModel : BaseViewModel
    {
        #region Attributes
        private string _oldPassword;
        private string _newPassword;
        private string _confirmNewPassword;
        private bool _isRunning;
        private bool _isEnabled;
        private ApiService _apiService;
        private UserDTO _userId;
        #endregion

        #region Properties
        public UserDTO UserId
        {
            get { return this._userId; }
            set { this.SetValue(ref this._userId, value); }
        }
        public string OldPassword
        {
            get { return this._oldPassword; }
            set { this.SetValue(ref this._oldPassword, value); }
        }
        public string NewPassword
        {
            get { return this._newPassword; }
            set { this.SetValue(ref this._newPassword, value); }
        }
        public string ConfirmNewPassword
        {
            get { return this._confirmNewPassword; }
            set { this.SetValue(ref this._confirmNewPassword, value); }
        }
        public bool IsEnabled
        {
            get { return this._isEnabled; }
            set { this.SetValue(ref this._isEnabled, value); }
        }
        public bool IsRunning
        {
            get { return this._isRunning; }
            set { this.SetValue(ref this._isRunning, value); }
        }
        #endregion

        #region Commands
        public Command ChangePasswordCommand { get; set; }
        #endregion

        #region Methods
        async void ChangePassword()
        {
            try
            {
                this.IsRunning = true;
                this.IsEnabled = true;

                if (!await _apiService.CheckConnection())
                {
                    this.IsRunning = false;
                    this.IsEnabled = true;

                    await Application.Current.MainPage.DisplayAlert(Languages.Notification, Languages.NoInternetConnection, Languages.Accept);
                    return;
                }

                

                if (NewPassword == OldPassword)
                {
                    this.IsRunning = false;
                    this.IsEnabled = true;

                    await Application.Current.MainPage.DisplayAlert(Languages.Notification, Languages.NewPasswordvsOldPassword, Languages.Accept);
                    return;
                }
                if (NewPassword != ConfirmNewPassword)
                {
                    this.IsRunning = false;
                    this.IsEnabled = true;

                    await Application.Current.MainPage.DisplayAlert(Languages.Notification, Languages.ConfirmationPassNew, Languages.Accept);
                    return;
                }

                var userID = Helpers.Settings.UserID;
                var changePasswordDTO = new ChangePasswordDTO
                {
                    UserId = userID,
                    OldPassword = this.OldPassword,
                    NewPassword = this.NewPassword,
                    ConfirmPassword = this.ConfirmNewPassword
                };

                var responseDTO = await _apiService.RequestAPI<ResponseDTO>(Helpers.Endpoints.URL_BASE_UNIVERSITY_AUTH,
                    Helpers.Endpoints.CHANGE_PASSWORD,
                    changePasswordDTO,
                    ApiService.Method.Post,
                    true);

                UserId = (UserDTO)responseDTO.Data;

                if (responseDTO.Code == 200)
                    await Application.Current.MainPage.DisplayAlert(Languages.Notification, Languages.ProcessSuccesful, Languages.Accept);                        
                else
                    await Application.Current.MainPage.DisplayAlert(Languages.Notification, responseDTO.Message, Languages.Accept);

                this.IsRunning = false;
                this.IsEnabled = true;
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Notification, ex.Message, Languages.Accept);

                this.IsRunning = false;
                this.IsEnabled = true;
            }
        }
        #endregion

        #region Constructor
        public ChangePasswordViewModel()
        {
            this.IsRunning = false;

            this._apiService = new ApiService();
            this.ChangePasswordCommand = new Command(ChangePassword);
            //this.RegisterCommand = new Command(Register);

        }
        #endregion

    }
}
