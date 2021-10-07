using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace eCommerce.Models.Table
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            Enderecos = new HashSet<Endereco>();
            Movimentos = new HashSet<Movimento>();
            Telefones = new HashSet<Telefone>();
        }

        public int IdPessoa { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
        public long CpfCnpj { get; set; }
        public string Email { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<Movimento> Movimentos { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
    }
}
