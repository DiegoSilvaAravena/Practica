using Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    public class Controllers
    {
        //Controladores de Personas
        public bool InsertPersona(Persona persona)
        {
            Database database = new Database();

            if (SelectPersonaDelete(persona))
            {
                return database.WriteDB("UPDATE Personas SET first_name = '" + persona.First_name + "', last_name = '"+ persona.Last_name + "', tipo = '" + persona.Tipo + "', estado = '" + persona.Estado + "' WHERE rut = '" +persona.Rut+"'");
            }
            else
            {
                return database.WriteDB("INSERT INTO Personas (rut,first_name,last_name,tipo,estado) VALUES ('" + persona.Rut + "','" + persona.First_name + "','" + persona.Last_name + "','" + persona.Tipo + "','"+ persona.Estado +"')");
            } 
        }

        public List<Persona> SelectPersona()
        {
            List<Persona> persona_list = new List<Persona>();
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Personas");
            while (reader.Read())
            {
                Persona persona = new Persona();
                persona.Id_personas = Convert.ToInt32(reader["id_personas"].ToString());
                persona.Rut = reader["rut"].ToString();
                persona.First_name = reader["first_name"].ToString();
                persona.Last_name = reader["last_name"].ToString();
                persona.Tipo = Convert.ToChar(reader["tipo"].ToString());
                persona.Estado = Convert.ToChar(reader["estado"].ToString());

                persona_list.Add(persona);
            }
            database.Close_Database();
            return persona_list;
        }

        public bool SelectPersonaDelete(Persona persona)
        {
            bool exist = false;
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Personas WHERE rut = '"+ persona.Rut + "' AND estado = 'E'");
            while (reader.Read())
            {
                exist = true;
            }

            database.Close_Database();
            return exist;
        }

        public Persona GetPersona(string rut)
        {
            Persona persona = new Persona();
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Personas WHERE rut = '"+rut+"'");
            while (reader.Read())
            {
                persona.Id_personas = Convert.ToInt32(reader["id_personas"].ToString());
                persona.Rut = reader["rut"].ToString();
                persona.First_name = reader["first_name"].ToString();
                persona.Last_name = reader["last_name"].ToString();
                persona.Tipo = Convert.ToChar(reader["tipo"].ToString());
            }
            database.Close_Database();
            return persona;
        }

        public string GetRUT(int id_personas)
        {
            string rut = null;
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT rut FROM Personas WHERE id_personas = "+id_personas);
            while (reader.Read())
            {
                rut = reader["rut"].ToString();
            }
            database.Close_Database();
            return rut;
        }

        public bool DeleteCliente(int id_personas)
        {
            Database database = new Database();
            return database.WriteDB("UPDATE Personas SET estado = 'E' WHERE id_personas = " + id_personas);
        }


        //Controladores de Productos
        public List<Producto> SelectProducto()
        {
            List<Producto> producto_list = new List<Producto>();
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Productos");
            while (reader.Read())
            {
                Producto producto = new Producto();
                producto.Id_productos = Convert.ToInt32(reader["id_productos"].ToString());
                producto.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                producto.Cantidad = Convert.ToInt32(reader["cantidad"].ToString());

                producto_list.Add(producto);
            }
            database.Close_Database();
            return producto_list;
        }

        //Controladores de Movimientos
        public bool InsertMovimiento(Movimiento movimiento)
        {
            Database database = new Database();
            return database.WriteDB("INSERT INTO Movimientos (factura,fecha,dinero,id_personas) VALUES ('" + movimiento.Factura + "','" + movimiento.Fecha + "'," + movimiento.Dinero + "," + movimiento.Id_personas + ")");
        }

        public bool InsertMovimiento_Productos(ArrayList producto_list)
        {
            Database database = new Database();
            string id_movimientos = GetID();
            for (int i = 0; i < producto_list.Count; i++)
            {
                if (database.WriteDB("INSERT INTO Movimientos_Productos (id_movimientos,id_productos) VALUES ("+ id_movimientos + "," + producto_list[i] + ")"))
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public Movimiento GetMovimiento(string id_movimientos)
        {
            Movimiento movimiento = new Movimiento();
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Movimientos WHERE id_movimientos = " + id_movimientos);
            while (reader.Read())
            {
                movimiento.Id_movimientos = Convert.ToInt32(reader["id_movimientos"].ToString());
                movimiento.Factura = Convert.ToInt32(reader["factura"].ToString());
                movimiento.Fecha = Convert.ToDateTime(reader["fecha"].ToString());
                movimiento.Dinero = Convert.ToSingle(reader["dinero"].ToString());
                movimiento.Id_personas = Convert.ToInt32(reader["id_personas"].ToString());
            }
            database.Close_Database();
            return movimiento;
        }

        public string GetID()
        {
            string id_movimientos = null;
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT TOP 1 id_movimientos FROM Movimientos ORDER BY id_movimientos DESC");
            while (reader.Read())
            {
                id_movimientos = reader["id_movimientos"].ToString();
            }
            database.Close_Database();
            return id_movimientos;
        }

        public List<Movimiento> SelectMovimiento()
        {
            List<Movimiento> movimiento_list = new List<Movimiento>();
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Movimientos ORDER BY id_movimientos ASC");
            while (reader.Read())
            {
                Movimiento movimiento = new Movimiento();
                movimiento.Id_movimientos = Convert.ToInt32(reader["id_movimientos"].ToString());
                movimiento.Factura = Convert.ToInt32(reader["factura"].ToString());
                movimiento.Fecha = Convert.ToDateTime(reader["fecha"].ToString());
                movimiento.Dinero = Convert.ToSingle(reader["dinero"].ToString());
                movimiento.Id_personas = Convert.ToInt32(reader["id_personas"].ToString());

                movimiento_list.Add(movimiento);
            }
            database.Close_Database();
            return movimiento_list;
        }
    }
}