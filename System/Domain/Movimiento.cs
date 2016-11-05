﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Movimiento
    {
        int id_movimientos;
        DateTime fecha;
        float dinero;
        int id_personas;

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
    }
}