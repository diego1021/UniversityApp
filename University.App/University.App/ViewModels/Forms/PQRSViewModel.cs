using System;
using System.Collections.Generic;
using System.Text;
using University.App.Helpers;

namespace University.App.ViewModels.Forms
{
    public class PQRSViewModel : BaseViewModel
    {
        #region Attributes
        public class TypeRequest
        {
            public string Name { get; set; }
        }

        private List<TypeRequest> _typeRequests;

        public class RateService
        {
            public string Name { get; set; }
        }

        private List<RateService> _rateService;

        private string _name;
        private string _surname;
        private string _direction;
        private string _phone;
        private string _email;
        private string _message;
        #endregion

        #region Properties
        public List<TypeRequest> TypeRequests
        {
            get { return this._typeRequests; }
            set { this.SetValue(ref this._typeRequests, value); }
        }

        public List<RateService> RateServices
        {
            get { return this._rateService; }
            set { this.SetValue(ref this._rateService, value); }
        }

        public string Name
        {
            get { return this._name; }
            set { this.SetValue(ref this._name, value); }
        }

        public string Surname
        {
            get { return this._surname; }
            set { this.SetValue(ref this._surname, value); }
        }

        public string Direction
        {
            get { return this._direction; }
            set { this.SetValue(ref this._direction, value); }
        }

        public string Phone
        {
            get { return this._phone; }
            set { this.SetValue(ref this._phone, value); }
        }

        public string Email
        {
            get { return this._email; }
            set { this.SetValue(ref this._email, value); }
        }

        public string Message
        {
            get { return this._message; }
            set { this.SetValue(ref this._message, value); }
        }
        #endregion

        #region Constructor
        public PQRSViewModel()
        {
            this.LoadTypeRequests();
            this.LoadRateServices();
        }
        #endregion

        #region Methods
        private void LoadTypeRequests()
        {
            this.TypeRequests = new List<TypeRequest>
            {
                new TypeRequest {Name = Languages.Petition },
                new TypeRequest {Name = Languages.Complain },
                new TypeRequest {Name = Languages.Claim },
                new TypeRequest {Name = Languages.Suggestion }
            };
        }

        private void LoadRateServices()
        {
            this.RateServices = new List<RateService>
            {
                new RateService {Name = Languages.Bad },
                new RateService {Name = Languages.Regular },
                new RateService {Name = Languages.Well },
                new RateService {Name = Languages.Acceptable },
                new RateService {Name = Languages.Excellent }
            };
        }
        #endregion
    }
}
