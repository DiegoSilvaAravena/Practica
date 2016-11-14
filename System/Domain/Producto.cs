using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Producto
    {
        int id_productos;
        int codigo;

        public int Id_productos
        {
            get
            {
                return id_productos;
            }

            set
            {
                id_productos = value;
            }
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public override string ToString()
        {
            return Codigo.ToString();
        }
    }
}