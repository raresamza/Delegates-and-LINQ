using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_and_linq
{
    public static class Extensions
    {
        public static string NameAndAge(this Person person)
        {
            return $"The person {person.Name} is {person.Age} years old";
        }
    }
}
