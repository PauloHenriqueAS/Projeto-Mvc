using System;
using System.Collections.Generic;

namespace projetoFinalUdemy.Models
{
    public class Department //modificador de acesso public para que na view ele consiga acessar a classe
    {
        public int Id { get; set; }
        public string  Name { get; set; }
       // public List<Seller> Sellers { get; set; }
        public int getId(){
            return this.Id;
        }
        public string getName(){
            return this.Name;
        }
        public Department(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /*public void addSeler(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            double totalS = 0.0;
            
            return 0.0;
        }*/
    }
}