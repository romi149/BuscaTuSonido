using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MPP
{
    public class MapperUsuario
    {
        /// <summary>
        /// Retorna todos los usuarios de la Bd
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ListarUsuarios()
        {
            try
            {
                BTSDataContext BaseDeDatos = new BTSDataContext();
                List<Usuario> usuarios = (from tblUsuarios in BaseDeDatos.Usuario
                                          select tblUsuarios).ToList();
                return usuarios;
            }
            catch (Exception e)
            {

                return new List<Usuario>();
            }
        }

        /// <summary>
        /// Inserta un usuario en Bd
        /// </summary>
        /// <param name="usuario">Tipo Usuario</param>
        /// <returns>Devuelve si se inserto o no</returns>
        public bool InsertarUsuario(Usuario usuario)
        {
            BTSDataContext BaseDeDatos = new BTSDataContext();
            int filasAFECTADAS= BaseDeDatos.InsertarUsuario(usuario.Usuario1, usuario.Nombre,
                usuario.Apellido, 
                usuario.Pass, usuario.Estado,
                usuario.IdIdioma, usuario.Dni);
            if (filasAFECTADAS > 0)
            {
                return true;
            }            
            
            return false;
        }


        /// <summary>
        /// Actualiza un usuario en Bd
        /// </summary>
        /// <param name="usuario">Tipo Usuario</param>
        /// <returns>Devuelve si se actualiza o no</returns>
        public bool Actualizar(Usuario usuario)
        {
            BTSDataContext BaseDeDatos = new BTSDataContext();
            int filasAFECTADAS = BaseDeDatos.ActualizarUsuario(usuario.IdUsuario,usuario.Usuario1,
                usuario.Nombre,
                usuario.Apellido,
                usuario.Pass, usuario.Estado,
                usuario.IdIdioma, usuario.Dni);
            if (filasAFECTADAS > 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Elimina un usuario en Bd
        /// </summary>
        /// <param name="usuario">Tipo Usuario</param>
        /// <returns>Devuelve si se elimino o no</returns>
        public bool Borrar(Usuario usuario)
        {
            BTSDataContext BaseDeDatos = new BTSDataContext();
            int filasAFECTADAS = BaseDeDatos.EliminarUsuario(usuario.IdUsuario, 1);
        
            if (filasAFECTADAS > 0)
            {
                return true;
            }

            return false;
        }




    }
}
