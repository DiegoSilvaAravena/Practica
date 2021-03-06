﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Persona
    {
        int id_personas;
        String rut;
        String first_name;
        String last_name;
        char tipo;
        char estado;
        string correo;
        string numero_cuenta;
        string banco;

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

        public string Rut
        {
            get
            {
                return rut;
            }

            set
            {
                rut = value;
            }
        }

        public string First_name
        {
            get
            {
                return first_name;
            }

            set
            {
                first_name = value;
            }
        }

        public string Last_name
        {
            get
            {
                return last_name;
            }

            set
            {
                last_name = value;
            }
        }

        public char Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public char Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Numero_cuenta
        {
            get
            {
                return numero_cuenta;
            }

            set
            {
                numero_cuenta = value;
            }
        }

        public string Banco
        {
            get
            {
                return banco;
            }

            set
            {
                banco = value;
            }
        }

        public override string ToString()
        {
            return Rut + " | " + First_name + " " + Last_name;
        }
    }
}