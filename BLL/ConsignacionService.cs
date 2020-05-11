using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
namespace BLL
{
    public class ConsignacionService
    {
        private static ConsignacionRepository repository = new ConsignacionRepository();
        public ConsignacionService()
        {
            repository = new ConsignacionRepository();
        }

        public string Guardar(Consignacion consignacion)
        {
            try
            {
                if (repository.Buscar(consignacion.NumeroRecibo)==null)
                {
                    repository.Guardar(consignacion);
                    return "Los Datos han sido guardados satisfactoriamente";

                }
                else
                {
                    return $"El numero de consignacion: {consignacion.NumeroRecibo} Ya se encuentra registrado en el sistema";

                }
            }
            catch (Exception e)
            {

                return "Error de Datos: " + e.Message;
                
            }
        }
    }
}
