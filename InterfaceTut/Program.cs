using System;

namespace InterfaceTut {
    class Program {
        static void Main(string[] args) {

            var gs = new GermanShepherd();
            gs.SetName("Sargent");
            var pg = new Pug();
            pg.SetName("Walter");
            var bh = new BassetHound();
            bh.SetName("Charlie");
            var dp = new DogParrot();
            dp.SetName("polly");

            var dogs = new IBarkable[] { gs, pg, bh, dp
            };
            foreach (var dog in dogs) {
                Console.WriteLine($"the dog {dog.GetName()} says {dog.Bark()}");
            }

        }
    }
}
