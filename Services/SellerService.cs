using System;
using System.Linq;
using System.Collections.Generic;
using projetoFinalUdemy.Models;

namespace projetoFinalUdemy.Services
{
    public class SellerService
    {
        private readonly projetoFinalUdemyContext _context;

        public SellerService(projetoFinalUdemyContext context){
            _context = context;
        }   

        public List<Seller> FindAll()
        {
            //acessa a tabela do banco de dados seller e retorna todos os itens em uma lista
            return _context.Seller.ToList();
            //context do arquivo projetofinalUdemyContext tem uma referencia para as tabelas no bd das classes
        }
    }
}