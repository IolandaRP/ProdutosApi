using Microsoft.EntityFrameworkCore;
using Produtos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Infrasctructure.Persistence
{
    public class ProdutoDbContext
    {
        public ProdutoDbContext()
        {
            Produtos = new List<Produto>
            {
                new Produto(1,"notebook Dell i3",3500, new DateTime(01/05/2022)),
                new Produto(2,"notebook Lenovo i5",5500, new DateTime(07/07/2022)),
                new Produto(3,"teclado gamer com led",250, new DateTime(12/02/2023)),
                new Produto(4,"cadeira gamer com led",2000, new DateTime(20/01/2023)),
                new Produto(5,"fone de ouvido LG",100, new DateTime(04/02/2021))
            };
        }

        public List<Produto> Produtos { get; set;}
        //usando o Entity Framework, não seria uma List mas sim um DbSet
    }
}

