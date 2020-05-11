using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class ConsignacionRepository
    {
        private string ruta = @"Consignacion.txt";
        private IList<Consignacion> consignaciones;
        public ConsignacionRepository()
        {
            consignaciones = new List<Consignacion>();
        }
        public void Guardar(Consignacion consignacion)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine(consignacion.ToString());
            writer.Close();
            fileStream.Close();
        }

        public IList<Consignacion> Consultar()
        {
            consignaciones.Clear();
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);
            string linea = string.Empty;
            Consignacion consignacion = new Consignacion();
            while ((linea = streamReader.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');
                consignacion.EntidadServicios = datos[0];
                consignacion.NumeroRecibo = datos[1];
                consignacion.FechaPago = DateTime.Parse(datos[2]);
                consignacion.ValorPagado = double.Parse(datos[3]);
                consignaciones.Add(consignacion);
            }
            fileStream.Close();
            streamReader.Close();
            return consignaciones;
        }

        public Consignacion Buscar(string numeroRecibo)
        {
            consignaciones.Clear();
            consignaciones = Consultar();
            foreach (var item in consignaciones)
            {
                if (item.NumeroRecibo.Equals(numeroRecibo))
                {
                    return item;

                }
            }
            return null;

        }

        public IEnumerable<Consignacion>ListarEmdupar()
        {
            return consignaciones.Where(c => c.EntidadServicios.Equals("Emdupar"));

        }

        public IEnumerable<Consignacion> ListarGasCaribe()
        {
            return consignaciones.Where(c => c.EntidadServicios.Equals("GasCaribe"));

        }

        public IEnumerable<Consignacion> Electricaribe()
        {
            return consignaciones.Where(c => c.EntidadServicios.Equals("Electricaribe"));

        }

        public int TotalizarEmdupar()
        {
            return consignaciones.Where(c => c.EntidadServicios.Equals("Emdupar")).Count();
        }

        public int TotalizarGasCaribe()
        {
            return consignaciones.Where(c => c.EntidadServicios.Equals("GasCaribe")).Count();
        }

        public int TotalizarElectricaribe()
        {
            return consignaciones.Where(c => c.EntidadServicios.Equals("Electricaribe")).Count();
        }

        public int TotalizarTodos()
        {
            return consignaciones.Count();
        }

        public double ValorTotalEmdupar()
        {
            return consignaciones.Where(c => c.EntidadServicios.Equals("Emdupar") && c.ValorPagado.Equals(c.ValorPagado)).Sum(c => c.ValorPagado);
        }

        public double ValorTotalGasCaribe()
        {
            return consignaciones.Where(c => c.EntidadServicios.Equals("GasCaribe") && c.ValorPagado.Equals(c.ValorPagado)).Sum(c => c.ValorPagado);
        }

        public double ValorTotalElectricaribe()
        {
            return consignaciones.Where(c => c.EntidadServicios.Equals("Electricaribe") && c.ValorPagado.Equals(c.ValorPagado)).Sum(c => c.ValorPagado);
        }

        public double ValorTotalconsignaciones()
        {
            return consignaciones.Sum(c => c.ValorPagado);
        }
    }
}
