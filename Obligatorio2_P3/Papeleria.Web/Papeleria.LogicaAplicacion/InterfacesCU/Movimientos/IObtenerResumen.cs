﻿using Papeleria.LogicaAplicacion.DataTransferObjects.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCU.Movimientos
{
    public interface IObtenerResumen
    {
        public IEnumerable<ResumenDto> ObtenerResumen();
    }
}
