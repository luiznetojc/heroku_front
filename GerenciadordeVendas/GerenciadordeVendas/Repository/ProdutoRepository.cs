using GerenciadordeVendas.Context;
using GerenciadordeVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadordeVendas.Repository
{
    public class ProdutoRepository: CrudRepository<Produto>, IProdutoRepository
    {
        private readonly DataContext _context;
        public ProdutoRepository(DataContext context): base(context)
        {
            this._context = context;
        }
    }
}
