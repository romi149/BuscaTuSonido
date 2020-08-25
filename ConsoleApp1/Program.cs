using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var resultado = new MapperUsuario().ListarUsuarios();
            //resultado.ForEach(x => Console.WriteLine($"Nombre de Usuario; {x.Nombre}"));

            //Console.WriteLine(new string('*',50));
            //Console.WriteLine(new string('*',50));
            //Console.WriteLine(new string('*',50));
            //bool realizado=new MapperUsuario().InsertarUsuario(new DAL.Usuario { Nombre = "Adrian" });

            //var resultados = new MapperUsuario().ListarUsuarios();
            //resultados.ForEach(x => Console.WriteLine($"Nombre de Usuario; {x.Nombre}"));
            //Console.WriteLine(new string('*', 50));
            //Console.WriteLine(new string('*', 50));
            //Console.WriteLine(new string('*', 50));
            //bool realizado2 = new MapperUsuario().Actualizar(new DAL.Usuario {IdUsuario=4, Nombre = "Adrian" });
            //resultados = new MapperUsuario().ListarUsuarios();
            //resultados.ForEach(x => Console.WriteLine($"Nombre de Usuario; {x.Nombre}"));
            Console.WriteLine(new string('*', 50));
            Console.WriteLine(new string('*', 50));
            Console.WriteLine(new string('*', 50));
            bool realizado3 = new MapperUsuario().Borrar(new DAL.Usuario { IdUsuario = 4 });
            var resultados = new MapperUsuario().ListarUsuarios();
            resultados.ForEach(x => Console.WriteLine($"Nombre de Usuario; {x.Nombre}"));
            Console.ReadLine();
        }
    }
}
