using System;
using System.Collections.Generic;
using System.Linq;

namespace projetoFinalUdemy.Models
{
    public class Department 
     //modificador de acesso public para que na view ele consiga acessar a classe
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        //forma mais generica
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
      // public List<Seller> lista { get; set; } = new List<Seller>();
       
        public Department(){}
        public Department(int id, string name){
            this.Id = id;
            this.Name = name;
        }
        public int getId(){
            return this.Id;
        }
        public string getName(){
            return this.Name;
        }

        public void addSeler(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            //return Sellers.Where(sr => sr.BirthDate >= initial && sr.BirthDate <= final).Sum(sr => sr);
            return Sellers.Sum(sr => sr.totalSales(initial, final));
        }

    }
}