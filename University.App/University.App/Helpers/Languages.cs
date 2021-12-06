using University.App.Interfaces;
using University.App.Resources;
using Xamarin.Forms;

namespace University.App.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept { get { return Resource.Accept; } }
        public static string Notification { get { return Resource.Notification; } }
        public static string NoInternetConnection { get { return Resource.NoInternetConnection; } }
        public static string FieldsRequired { get { return Resource.FieldsRequired; } }
        public static string LoginPageDontHaveAccount { get { return Resource.LoginPageDontHaveAccount; } }
        public static string LoginPageLoginMember { get { return Resource.LoginPageLoginMember; } }
        public static string Login { get { return Resource.Login; } }
        public static string University { get { return Resource.University; } }
        public static string NewPasswordvsOldPassword { get { return Resource.NewPasswordvsOldPassword; } }
        public static string ConfirmationPassNew { get { return Resource.ConfirmationPassNew; } }
        public static string ProcessSuccesful { get { return Resource.ProcessSuccesful; } }
        public static string FountPhoto { get { return Resource.FountPhoto; } }
        public static string TakePhoto { get { return Resource.TakePhoto; } }
        public static string FromGallery { get { return Resource.FromGallery; } }
        public static string RegisterSuccesful { get { return Resource.RegisterSuccesful; } }
        public static string Name { get { return Resource.Name; } }
        public static string Surname { get { return Resource.Surname; } }
        public static string Direction { get { return Resource.Direction; } }
        public static string Phone { get { return Resource.Phone; } }
        public static string Email { get { return Resource.Email; } }
        public static string Message { get { return Resource.Message; } }
        public static string RateService { get { return Resource.RateService; } }
        public static string TypeRequest { get { return Resource.TypeRequest; } }
        public static string UserName { get { return Resource.UserName; } }
        public static string Password { get { return Resource.Password; } }
        public static string Register { get { return Resource.Register; } }
        public static string CreateNewAccount { get { return Resource.CreateNewAccount; } }
        public static string RepeatPassword { get { return Resource.RepeatPassword; } }
        public static string Petition { get { return Resource.Petition; } }
        public static string Complain { get { return Resource.Complain; } }
        public static string Claim { get { return Resource.Claim; } }
        public static string Suggestion { get { return Resource.Suggestion; } }
        public static string Bad { get { return Resource.Bad; } }
        public static string Regular { get { return Resource.Regular; } }
        public static string Well { get { return Resource.Well; } }
        public static string Acceptable { get { return Resource.Acceptable; } }
        public static string Excellent { get { return Resource.Excellent; } }
        public static string YouHaveAnAccount { get { return Resource.YouHaveAnAccount; } }
        public static string Send { get { return Resource.Send; } }
        public static string AboutUs { get { return Resource.AboutUs; } }
        public static string MeetUs { get { return Resource.MeetUs; } }
        public static string SeeMore { get { return Resource.SeeMore; } }
        public static string ChangePassword { get { return Resource.ChangePassword; } }
        public static string OldPassword { get { return Resource.OldPassword; } }
        public static string NewPassword { get { return Resource.NewPassword; } }
        public static string RepeatNewPassword { get { return Resource.RepeatNewPassword; } }
        public static string LoginPage { get { return Resource.LoginPage; } }
        public static string ProfilePage { get { return Resource.ProfilePage; } }
        public static string CoursesPage { get { return Resource.CoursesPage; } }
        public static string AboutPage { get { return Resource.AboutPage; } }
        public static string PQRSPage { get { return Resource.PQRSPage; } }
        public static string ChangePasswordPage { get { return Resource.ChangePasswordPage; } }
        public static string LogOut { get { return Resource.LogOut; } }

    }
}
