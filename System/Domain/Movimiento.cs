using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Movimiento
    {
        int id_movimientos;
        int factura;
        DateTime fecha;
        float dinero;
        int id_personas;
        string rut_personas;

        public Movimiento()
        {
        }

        public int Id_movimientos
        {
            get
            {
                return id_movimientos;
            }

            set
            {
                id_movimientos = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public float Dinero
        {
            get
            {
                return dinero;
            }

            set
            {
                dinero = value;
            }
        }

        public int Id_personas
        {
            get
            {
                return id_personas;
            }

            set
            {
                id_personas = value;
            }
        }

        public int Factura
        {
            get
            {
                return factura;
            }

            set
            {
                factura = value;
            }
        }

        public string Rut_personas
        {
            get
            {
                return rut_personas;
            }

            set
            {
                rut_personas = value;
            }
        }
    }
}