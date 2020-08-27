using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace MPP
{
    public class MapperModelo
    {
        /// <summary>
        /// Retorna todos los modelos de la Bd
        /// </summary>
        /// <returns></returns>
        public List<Modelo> ListarModelos()
        {
            try
            {
                BTSDataContext BaseDeDatos = new BTSDataContext();
                List<Modelo> modelos = (from tblModelo in BaseDeDatos.Modelo
                                        select tblModelo).ToList();
                return modelos;
            }
            catch (Exception e)
            {

                return new List<Modelo>();
            }
        }

        /// <summary>
        /// Inserta un modelo en Bd
        /// </summary>
        /// <param name="modelo">Tipo Modelo</param>
        /// <returns>Devuelve si se inserto o no</returns>
        public bool InsertarModelo(Modelo modelo)
        {
            BTSDataContext BaseDeDatos = new BTSDataContext();
            int filasAFECTADAS = BaseDeDatos.InsertarModelo(modelo.Nombre, modelo.Descripcion);
            if (filasAFECTADAS > 0)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// Actualiza un modelo en Bd
        /// </summary>
        /// <param name="modelo">Tipo Modelo</param>
        /// <returns>Devuelve si se actualiza o no</returns>
        public bool Actualizar(Modelo modelo)
        {
            BTSDataContext BaseDeDatos = new BTSDataContext();
            int filasAFECTADAS = BaseDeDatos.ActualizarModelo(modelo.IdModelo, modelo.Nombre,modelo.Descripcion);
            if (filasAFECTADAS > 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Elimina un modelo en Bd
        /// </summary>
        /// <param name="modelo">Tipo Modelo</param>
        /// <returns>Devuelve si se elimino o no</returns>
        public bool Borrar(Modelo modelo)
        {
            BTSDataContext BaseDeDatos = new BTSDataContext();
            int filasAFECTADAS = BaseDeDatos.EliminarModelo(modelo.IdModelo);

            if (filasAFECTADAS > 0)
            {
                return true;
            }

            return false;
        }
    }
}
