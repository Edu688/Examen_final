using System;

namespace MiApiClientes.Models
{
    public class InformacionGeneral
    {
        public int Id { get; set; }
        public string TipoInformacion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int ClienteId { get; set; }

        // Relación con Cliente
        public Cliente Cliente { get; set; }
    }
}
