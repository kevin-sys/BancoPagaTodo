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
                if (repository.Buscar(consignacion.NumeroRecibo) == null)
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

        public static IList<Consignacion> ConsultarTodos()
        {
            return repository.Consultar();
        }

        public static IEnumerable<Consignacion> ListarGasCaribe()
        {
            return repository.ListarGasCaribe();
        }

        public static IEnumerable<Consignacion> ListarEmdupar()
        {
            return repository.ListarEmdupar();
        }

        public static IEnumerable<Consignacion> ListarElectricaribe()
        {
            return repository.ListarElectricaribe();
        }

        public int TotalizarGasCaribe()
        {
            return repository.TotalizarGasCaribe();
        }

        public int TotalizarEmdupar()
        {
            return repository.TotalizarEmdupar();
        }

        public int TotalizarElectricaribe()
        {
            return repository.TotalizarElectricaribe();
        }

        public int TotalizarTodos()
        {
            return repository.TotalizarTodos();
        }

        public double ValorTotalGasCaribe()
        {
            return repository.ValorTotalGasCaribe();
        }

        public double ValorTotalEmdupar()
        {
            return repository.ValorTotalEmdupar();
        }

        public double ValorTotalElectricaribe()
        {
            return repository.ValorTotalElectricaribe();
        }

        public double ValorTotalconsignaciones()
        {
            return repository.ValorTotalconsignaciones();
        }

        public IList<Consignacion> ConsultarTodosFecha(DateTime fecha)
        {
            return repository.ConsultarTodosFecha(fecha);
        }

        public IList<Consignacion> ConsultarElectricaribeFecha(DateTime fecha)
        {
            return repository.ConsultarElectricaribe(fecha);
        }

        public IList<Consignacion> ConsultarGasCaribeFecha(DateTime fecha)
        {
            return repository.ConsultarGasCaribeFecha(fecha);
        }

        public IList<Consignacion> ConsultarEmdupar(DateTime fecha)
        {
            return repository.ConsultarEmdupar(fecha);
        }

    }
}


