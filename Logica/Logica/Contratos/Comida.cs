﻿using Logica.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public  class Comida
    {
        public string Codigo { get; set; }
        public Receta RecetaElegida { get; set; }
        public DateTime RegistroDeComida { get; set; }

        public Comida(string codigo, Receta recetaElegida, DateTime registroDeComida)
        {
            Codigo = codigo;
            RegistroDeComida = registroDeComida;
            RecetaElegida = recetaElegida;
        }
    }
}
