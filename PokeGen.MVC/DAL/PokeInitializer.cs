using PokeGen.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeGen.MVC.DAL
{
    public class PokeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PokeContext>
    {
        protected override void Seed(PokeContext context)
        {
            GetAnimals();
            //var animals = new List<Animal>
            //{
            //     new Animal{ }
            //};
            //base.Seed(context);
        }

        private List<Animal> GetAnimals()
        {
            string text = System.IO.File.ReadAllText(@"../Content/Textfiles/AnimalTable.txt");
            return new List<Animal>();
        }
    }
}