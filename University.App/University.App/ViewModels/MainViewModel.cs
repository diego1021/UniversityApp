using System.Collections.ObjectModel;
using System.Threading.Tasks;
using University.App.Helpers;
using University.App.ViewModels.Forms;
using University.App.ViewModels.Menu;
using Xamarin.Forms;

namespace University.App.ViewModels
{
    public class MainViewModel
    {        
        public LoginViewModel Login { get; set; }
        public RegisterViewModel Register { get; set; }
        public ProfileViewModel Profile { get; set; }
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public AboutViewModel About { get; set; }
        public PQRSViewModel PQRS { get; set; }
        public CoursesViewModel Courses { get; set; }
        public ChangePasswordViewModel ChangePassword { get; set; }

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.LoadMenu();

            this.Login = new LoginViewModel();
            this.Register = new RegisterViewModel();
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            this.Menu = new ObservableCollection<MenuItemViewModel>
            {
                new MenuItemViewModel
                {
                    Icon = "ic_exit_to_app",
                    PageName = "ProfilePage",
                    Title = Languages.ProfilePage
                },
                new MenuItemViewModel
                {
                    Icon = "ic_exit_to_app",
                    PageName = "CoursesPage",
                    Title = Languages.CoursesPage
                },
                new MenuItemViewModel
                {
                    Icon = "ic_exit_to_app",
                    PageName = "AboutPage",
                    Title = Languages.AboutPage
                },
                new MenuItemViewModel
                {
                    Icon = "ic_exit_to_app",
                    PageName = "PQRSPage",
                    Title = Languages.PQRSPage
                },
                new MenuItemViewModel
                {
                    Icon = "ic_exit_to_app",
                    PageName = "ChangePasswordPage",
                    Title = Languages.ChangePasswordPage
                },
                new MenuItemViewModel
                {
                    Icon = "ic_exit_to_app",
                    PageName = "LoginPage",
                    Title = Languages.LogOut
                }
            };
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
                return new MainViewModel();

            return instance;
        }
        #endregion
    }
}
