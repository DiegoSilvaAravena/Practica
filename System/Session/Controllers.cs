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
        //Controladores de Personas ---------------------------------------------------
        public bool InsertPersona(Persona persona)
        {
            Database database = new Database();

            if (SelectPersonaExiste(persona)) //¿La persona ya existe y esta eliminado?
            {
                return database.WriteDB("UPDATE Personas SET first_name = '" + persona.First_name + "', last_name = '" + persona.Last_name + "', tipo = '" + persona.Tipo + "', estado = '" + persona.Estado + "' WHERE rut = '" + persona.Rut + "'");
            }
            else
            {
                return database.WriteDB("INSERT INTO Personas (rut, first_name, last_name, tipo, estado) VALUES ('" + persona.Rut + "','" + persona.First_name + "','" + persona.Last_name + "','" + persona.Tipo + "','" + persona.Estado + "')");
            }
        }

        public List<Persona> SelectPersona() //Un select de personas.
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

        public bool UpdatePersona(Persona persona)
        {
            Database database = new Database();
            return database.WriteDB("UPDATE Personas SET rut = '" + persona.Rut + "', first_name = '" + persona.First_name + "', last_name = '" + persona.Last_name + "', tipo = '" + persona.Tipo + "', estado = '" + persona.Estado + "' WHERE id_personas = " + persona.Id_personas);
        }

        public bool SelectPersonaExiste(Persona persona) //Valida si existe una persona el mismo RUT.
        {
            bool exist = false;
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Personas WHERE rut = '" + persona.Rut + "' AND estado = 'E'");
            while (reader.Read())
            {
                exist = true;
            }

            database.Close_Database();
            return exist;
        }

        public Persona GetPersonaRUT(string rut) //Obtiene una persona con un RUT.
        {
            Persona persona = new Persona();
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Personas WHERE rut = '" + rut + "'");
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

        public Persona GetPersonaID(string id_personas) //Obtiene una persona con un ID.
        {
            Persona persona = new Persona();
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Personas WHERE id_personas = " + id_personas);
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

        public bool DeleteCliente(int id_personas)
        {
            Database database = new Database();
            return database.WriteDB("UPDATE Personas SET estado = 'E' WHERE id_personas = " + id_personas);
        }


        //Controladores de Productos ---------------------------------------------------
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
                producto.Estado = Convert.ToChar(reader["estado"].ToString());

                producto_list.Add(producto);
            }
            database.Close_Database();
            return producto_list;
        }

        public bool SelectProductoExiste(Producto producto)
        {
            bool exist = false;
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Productos WHERE codigo = " + producto.Codigo + " AND estado = 'E'");
            while (reader.Read())
            {
                exist = true;
            }

            database.Close_Database();
            return exist;
        }

        public bool InsertProducto(Producto producto)
        {
            Database database = new Database();

            if (SelectProductoExiste(producto)) //¿El producto ya existe y esta eliminado?
            {
                return database.WriteDB("UPDATE Productos SET codigo = " + producto.Codigo + " , cantidad = " + producto.Cantidad + ", estado = '" + producto.Estado + "' WHERE codigo = " + producto.Codigo);
            }
            else
            {
                return database.WriteDB("INSERT INTO Productos (codigo,cantidad,estado) VALUES (" + producto.Codigo + "," + producto.Cantidad + ",'" + producto.Estado + "')");
            }

        }
        public bool DeleteProducto(int id_productos)
        {
            Database database = new Database();
            return database.WriteDB("UPDATE Productos SET estado = 'E' WHERE id_productos = " + id_productos);
        }

        //Controladores de Movimientos ---------------------------------------------------
        public bool InsertMovimiento(Movimiento movimiento)
        {
            Database database = new Database();
            return database.WriteDB("INSERT INTO Movimientos (factura,fecha,dinero,id_personas) VALUES ('" + movimiento.Factura + "','" + movimiento.Fecha + "'," + movimiento.Dinero + "," + movimiento.Id_personas + ")");
        }
        // - Producto
        public bool InsertMenosMovimiento_Productos(ArrayList producto_id_list, ArrayList producto_cantidad_list)
        {
            Database database = new Database();
            string id_movimientos = GetID();
            for (int i = 0; i < producto_id_list.Count; i++)
            {
                if (database.WriteDB("INSERT INTO Movimientos_Productos (id_movimientos,id_productos,cantidad) VALUES (" + id_movimientos + "," + producto_id_list[i] + "," + producto_cantidad_list[i] + ")"))
                {
                    database.WriteDB("UPDATE Productos SET cantidad = (cantidad - " + producto_cantidad_list[i] + ") WHERE id_productos = " + producto_id_list[i]);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        // + Producto
        public bool InsertMasMovimiento_Productos(ArrayList producto_id_list, ArrayList producto_cantidad_list)
        {
            Database database = new Database();
            string id_movimientos = GetID();
            for (int i = 0; i < producto_id_list.Count; i++)
            {
                if (database.WriteDB("INSERT INTO Movimientos_Productos (id_movimientos,id_productos,cantidad) VALUES (" + id_movimientos + "," + producto_id_list[i] + ","+ producto_cantidad_list[i] + ")"))
                {
                    database.WriteDB("UPDATE Productos SET cantidad = (cantidad + " + producto_cantidad_list[i] + ") WHERE id_productos = " + producto_id_list[i]);
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

        public List<Movimiento> SelectMovimientoConRUT()
        {
            List<Movimiento> movimiento_list = new List<Movimiento>();
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Movimientos INNER JOIN Personas ON Movimientos.id_personas = Personas.id_personas ORDER BY id_movimientos ASC");
            while (reader.Read())
            {
                Movimiento movimiento = new Movimiento();
                movimiento.Id_movimientos = Convert.ToInt32(reader["id_movimientos"].ToString());
                movimiento.Factura = Convert.ToInt32(reader["factura"].ToString());
                movimiento.Fecha = Convert.ToDateTime(reader["fecha"].ToString());
                movimiento.Dinero = Convert.ToSingle(reader["dinero"].ToString());
                movimiento.Id_personas = Convert.ToInt32(reader["Movimientos.id_personas"].ToString());
                movimiento.Rut_personas = reader["rut"].ToString();

                movimiento_list.Add(movimiento);
            }
            database.Close_Database();
            return movimiento_list;
        }

        public List<Producto> SelectMovimientos_Productos(int id_movimientos)
        {
            List<Producto> movimiento_producto_list = new List<Producto>();
            Database database = new Database();

            System.Data.OleDb.OleDbDataReader reader = database.ReadDB("SELECT * FROM Movimientos_Productos INNER JOIN Productos ON Movimientos_Productos.id_productos = Productos.id_productos WHERE Movimientos_Productos.id_movimientos = " + id_movimientos);
            while (reader.Read())
            {
                Producto producto = new Producto();
                producto.Id_productos = Convert.ToInt32(reader["Productos.id_productos"].ToString());
                producto.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                producto.Cantidad = Convert.ToInt32(reader["Movimientos_Productos.cantidad"].ToString());
                producto.Estado = Convert.ToChar(reader["estado"].ToString());

                movimiento_producto_list.Add(producto);
            }
            database.Close_Database();
            return movimiento_producto_list;
        }

        public bool DeleteMovimiento(int id_movimientos)
        {
            Database database = new Database();
            database.WriteDB("DELETE FROM Movimientos_Productos WHERE id_movimientos = " + id_movimientos);
            return database.WriteDB("DELETE FROM Movimientos WHERE id_movimientos = " + id_movimientos);
        }

    }
}