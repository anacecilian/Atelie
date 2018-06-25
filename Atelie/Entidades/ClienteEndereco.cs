﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Entidades
{
    public class ClienteEndereco
    {
        public ClienteEndereco()
        {
            Endereco = new Endereco();
        }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public Endereco Endereco { get; set; }
        public int ClienteId { get; set; }
    }
}
