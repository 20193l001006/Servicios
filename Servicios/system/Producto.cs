﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios
{
    public class Producto
    {
        public int idproducto { get; set; }

        public string nombre { get; set; }

        public double precio { get; set; }

        public int stock { get; set; }
    }
}