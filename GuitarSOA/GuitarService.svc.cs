using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GuitarSOA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GuitarService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GuitarService.svc or GuitarService.svc.cs at the Solution Explorer and start debugging.
    public class GuitarService : IGuitarService
    {
        private GuitarDbContext context = new GuitarDbContext();

        public List<Guitar> FindAll()
        {
            return context.Guitars.ToList();
        }

        public void Add(Guitar g)
        {
            try
            {
                lock (context)
                {
                    context.Guitars.Add(g);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Delete(int id)
        {
            Guitar g = context.Guitars.Find(id);
            context.Guitars.Remove(g);
            context.SaveChanges();
        }

        public Guitar Edit(int id)
        {
            Guitar g = context.Guitars.Find(id);
            return g;
        }

        public void SaveEdit(Guitar g)
        {
            context.Guitars.Attach(g);

            var entry = context.Entry(g);
            entry.Property(i => i.Make).IsModified = true;
            entry.Property(i => i.Model).IsModified = true;
            entry.Property(i => i.Stock).IsModified = true;
            entry.Property(i => i.Year).IsModified = true;

            context.SaveChanges();
        }
    }
}
