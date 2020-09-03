using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z14_Valid
{
    public class RegistrationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string email { get; set; }
        public string password { get; set; }
        public bool accept { get; set; }
        private string errors;
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));
                }
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
                }
            }
        }
        public bool Accept
        {
            get { return accept; }
            set
            {
                if (accept != value)
                {
                    accept = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Accept"));
                }
            }
        }
        public string Errors
        {
            get { return errors; }
            set
            {
                if (errors != value)
                {
                    errors = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Errors"));
                }
            }
        }
    }
}
