﻿using System;

namespace Business
{
    public class Produto
    {
        public Guid Id { get; set; }
        
        public string Nome { get; set; }
        
        public string Descricao { get; set; }
        
        public decimal Valor { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        public bool Ativo { get; set; }
    }
}
