using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramQuix
{
    internal class Atomic
    {
        // This is a property of the class, hence its position
        Dictionary<string, int> atomicweights = new Dictionary<string, int>()
        {
            {"hydrogen", 1 },
            {"helium", 2},
            {"lithium", 3},
            {"beryllium", 4}
        };

        public void Start()
        {
            Console.WriteLine($"Our database has {atomicweights.Count} records.");
        }
    }
}
