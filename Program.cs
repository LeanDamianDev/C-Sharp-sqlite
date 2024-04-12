using System;
using System.Data.SQLite;
namespace Instrucciones
{
    class Program
    {
        static void Main_()
        {
            Console.WriteLine("-------------");
            Console.WriteLine();
            Console.WriteLine("---- SQL CONNECTION ----");
        }

        static void Main()
        {
            string cs = @"Data Source=db1.db;";

            SQLiteConnection con = new SQLiteConnection(cs);
            con.Open();
            string query = "SELECT * FROM usuarios";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader datos = command.ExecuteReader();
            while (datos.Read())            
            {
                int id = Convert.ToInt32(datos["id_usuario"]);
                string nombre = Convert.ToString(datos["nombre"]);
                string apellido = Convert.ToString(datos["apellido"]);
                int edad = Convert.ToInt32(datos["edad"]);
                Console.WriteLine("------- SQLite -------");
                Console.WriteLine($"id: {id}");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Apellido: {apellido}");
                Console.WriteLine($"Edad: {edad}");

                
            }
        }
    }
}
