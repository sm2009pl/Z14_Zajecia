using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Z14_Zajecia
{
    public class RegisterCommand : ICommand
    {
        private RegModelValid validator = new RegModelValid();
        public event EventHandler CanExecuteChanged // przy przypisaniu event hendlera do  canexectueChange przepisujemy ten event hendler to requery suggested
        {
            add { CommandManager.RequerySuggested += value; } //
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {

            var model = parameter as RegistrationModel;
            if (model is null)
            {
                return false;
            }
            var result = validator.Validate(model);
            model.Errors = string.Join(" ", result.Errors);
            return result.IsValid;
        }

        public void Execute(object parameter)
        {
            var model = parameter as RegistrationModel;
            MessageBox.Show($"Użytkownik zarejestrowany {model.Email}", "Rejestracja pomyślna", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
