using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            availableCones.Sort(new ConeComparer());

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.

            foreach (Flavor f in availableFlavors)
            {
                Console.WriteLine(f.ToString() + "\n");
                foreach (string a in f.Allergens)
                {
                    Console.WriteLine("   * " + a);
                }
                Console.WriteLine("\n");
            }

            foreach (Cone c in availableCones)
            {
                foreach (string a in c.Allergens)
                {
                    Console.WriteLine(c.ToString() + a + "\n");
                }   
            }
        }
    }
}
