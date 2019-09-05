using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MercaLibre58
{
    class MySQL_ADO:DbContext

    {
      public Dbset<Compra> Compra
        { get; set; }
        public int MyProperty { get; set; }
    }
}
