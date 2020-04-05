using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyEntities();

            context.spAddVideo("Code with Mosh 1", DateTime.UtcNow.AddDays(-1), 2, 3);
            context.spAddVideo("Code with Mosh 2", DateTime.UtcNow.AddDays(-2), 2, 3);
            context.spAddVideo("Code with Mosh 3", DateTime.UtcNow.AddDays(-3), 2, 3);

        }
    }
}
