using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.Models
{
    public class Ativo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public string Tipo { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}