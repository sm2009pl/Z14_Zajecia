using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Z14_Valid
{
    public class RegisterCommand : ICommand
    {
        private RegistrationModelValidation validation = new RegistrationModelValidation();
        
        public bool CanExecute(object parameter)
        {
            var model = parameter as RegistrationModel;
            if(model is null)
            {
                return false;
            }
            var results = validation.Validate(model);
            model.Errors = string.Join(" ",results.Errors);
            return results.IsValid;
        }

        public void Execute(object parameter)
        {
            var model = parameter as RegistrationModel;
            MessageBox.Show("Rejestracja pomyślna.");
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
