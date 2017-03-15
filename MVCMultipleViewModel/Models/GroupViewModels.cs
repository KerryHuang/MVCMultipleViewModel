using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMultipleViewModel.Models
{
    public class GroupViewModels
    {
        public LoginViewModels Login { get; set; }
        public RegisterViewModels Register { get; set; }
    }
}