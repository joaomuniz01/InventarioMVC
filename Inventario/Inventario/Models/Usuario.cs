﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual ICollection<Ativo> Ativos { get; set; }
    }
}