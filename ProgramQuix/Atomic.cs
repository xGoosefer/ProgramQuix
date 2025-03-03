using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ProgramQuix
{
    internal class Atomic
    {
        // This is a property of the class, hence its position

        Dictionary<string, string> names = new Dictionary<string, string>()
        {
            {"hippo", "Hippopotamus Amphibius"},
            {"bear", "Euarctos Americanus"},
            {"chipmunk", "Eutamias"},
            {"gopher", "Thomomys"},
            {"muskrat", "Ondatra Zibethica"}
        };

        private string Find(string item)
        {
            if (names.ContainsKey(item))
            {
                return names[item];
            }
            return "Sorry, that animal was not found in our database.";
        }

        public void Start()
        {
            Clear();
            WriteLine("Enter an animal name (example: hippo)");
            string input = ReadLine();
            WriteLine(Find(input));
            WriteLine("Press x to exit, any other key to enter another request...");
            input = ReadLine();
            if (input.ToLower() == "x")
            {
                //forces window to close, but not needed here
                //Environment.Exit(0);
            }
            else
            {
                Start();
            }
        }
    }
}
