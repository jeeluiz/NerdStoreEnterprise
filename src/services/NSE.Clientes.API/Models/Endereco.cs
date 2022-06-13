﻿using NSE.Core.DomainObjects;

namespace NSE.Clientes.API.Models
{
    public class Endereco : Entity
    {
        public string Lougradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public Guid ClienteId { get; private set; }

        public Cliente Cliente { get; private set; }

        public Endereco(string lougradouro, string numero, string complemento, string bairro, 
            string cep, string cidade, string estado)
        {
            Lougradouro = lougradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
        }
    }
}