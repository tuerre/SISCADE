using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISCADE
{
    public class Cliente
    {

        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string DocumentoTipo { get; set; }
        public string DocumentoNumero { get; set; }
        public string Nacionalidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Ocupacion { get; set; }
        public string FuenteFondos { get; set; }


        public Cliente() { }

        public Cliente(string NombreCompleto, string DocumentoTipo, string DocumentoNumero, string Nacionalidad, string Direccion, string Telefono, string Correo, string Ocupacion, string FuenteFondos) 
        {
            this.NombreCompleto = NombreCompleto;
            this.DocumentoTipo = DocumentoTipo;
            this.DocumentoNumero = DocumentoNumero;
            this.Nacionalidad = Nacionalidad;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Correo = Correo;
            this.Ocupacion = Ocupacion;
            this.FuenteFondos = FuenteFondos;
        }

    }
}
