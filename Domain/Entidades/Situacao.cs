﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Entidades
{
    public enum Situacao
    {
        [Description("Ativo")]
        Ativo = 0,
        [Description("Ferias")]
        Ferias = 1,
        [Description("Desligado")]
        Desligado = 2,
    }

}
