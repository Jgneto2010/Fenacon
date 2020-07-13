using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.User
{
    public enum Office 
    {
        [Description("Estagiário")]
        Estagiario = 0,
        [Description("Tecnico")]
        Tecnico = 1,
        [Description("Analista")]
        Analista = 2,
        [Description("Gerente")]
        Gerente = 3
    }
}
