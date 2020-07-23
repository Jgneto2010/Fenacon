using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Modelos
{
    public class UsuarioModel
    {
        public UsuarioModel(){}
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
