﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
   public  class SalasEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int  NumeroComputadores { get; set; }
        public bool IsLab { get; set; }
        public int NumeroCadeiras{ get; set; }
        public bool Disponivel { get; set; }
    }
}
