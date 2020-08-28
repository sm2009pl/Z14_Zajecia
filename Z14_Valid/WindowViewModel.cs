using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Z14_Valid
{
    public class WindowViewModel
    {
        public RegistrationModel Registration { get; set; }
        public ICommand RegisterCommand { get; set; }
        public WindowViewModel()
        {
            Registration = new RegistrationModel();
            RegisterCommand = new RegisterCommand();
        }
    }
}
