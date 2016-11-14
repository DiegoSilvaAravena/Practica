using Domain;
using System;
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
            return database.WriteDB("INSERT INTO Personas (rut,first_name,last_name,tipo) VALUES ('" + persona.Rut + "','" + persona.First_name + "','" + persona.Last_name + "','"+persona.Tipo+"')");
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

                persona_list.Add(persona);
            }
            database.Close_Database();
            return persona_list;
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

                producto_list.Add(producto);
            }
            database.Close_Database();
            return producto_list;
        }

        //Controladores de Movimientos
        public void InsertMovimiento(Movimiento movimiento)
        {
            Database database = new Database();
            database.WriteDB("INSERT INTO Movimientos (fecha,dinero,id_personas) VALUES ('" + movimiento.Fecha + "'," + movimiento.Dinero + "," + movimiento.Id_personas + ")");
        }
    }
}