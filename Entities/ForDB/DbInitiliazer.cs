using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class DbInitiliazer
    {
        public static void Initialize()
        {
            Context context = new Context();
            

            var goods = new Good[]
            {
                new Good {Name = "Food", Height = 50, Width = 100, Weight = 250},
                new Good {Name = "Electronic", Height = 75, Width = 100, Weight = 150},
                new Good {Name = "Alcohol", Height = 100, Width = 100, Weight = 50},
                new Good {Name = "Mechanic", Height = 150, Width = 100, Weight = 250},
            };

            if (context.Goods.Count() > goods.Length)
            {
                return;
            }

            foreach (Good g in goods)
            {
                context.Goods.Add(g);
            }

            context.SaveChanges();

            var transports = new Transport[]
            {
                new Transport {Name = "Foot", MaxHeight = 50, MaxWidth = 100, MaxWeight = 50, Speed = 5},
                new Transport {Name = "Bike", MaxHeight = 150, MaxWidth = 200, MaxWeight = 250, Speed = 25},
                new Transport {Name = "Car", MaxHeight = 350, MaxWidth = 400, MaxWeight = 450, Speed = 75},
                new Transport {Name = "Ship", MaxHeight = 750, MaxWidth = 1000, MaxWeight = 650, Speed = 150},
            };
            if (context.Transports.Count() > transports.Length)
            {
                return;
            }

            foreach (Transport t in transports)
            {
                context.Transports.Add(t);
            }

            context.SaveChanges();

            var destinations = new Destination[]
            {
                new Destination {Name = "Pink", Distance = 50},
                new Destination {Name = "Blue", Distance = 70},
                new Destination {Name = "Purple", Distance = 10},
                new Destination {Name = "Green", Distance = 150},
            };
            if (context.Destinations.Count() > destinations.Length)
            {
                return;
            }

            foreach (Destination d in destinations)
            {
                context.Destinations.Add(d);
            }
            context.SaveChanges();
        }
    }
}
