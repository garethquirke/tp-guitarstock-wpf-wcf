using GuitarSOA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarClient
{
    public class GuitarViewModel
    {
        public IEnumerable<Guitar> Guitars { get; set; }
        public virtual Guitar Guitar { get; set; }

        private ServiceReference1.GuitarServiceClient service = new ServiceReference1.GuitarServiceClient();


        public GuitarViewModel()
        {
            ServiceReference1.GuitarServiceClient service = new ServiceReference1.GuitarServiceClient();

            Guitars = service.FindAll();
        }

        public void AddGuitar(Guitar g)
        {
            service.Add(g);
        }

        public void SaveEdit(Guitar g)
        {
            ServiceReference1.GuitarServiceClient service = new ServiceReference1.GuitarServiceClient();
            service.SaveEdit(g);

        }

        public void DeleteGuitar(int id)
        {
            service.Delete(id);
        }
    }
}
