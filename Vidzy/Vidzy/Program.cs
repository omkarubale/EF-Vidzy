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

            context.AddVideo("Code with Mosh 4", DateTime.UtcNow.AddDays(-1), "Action", Classification.Platinum);
            context.AddVideo("Code with Mosh 5", DateTime.UtcNow.AddDays(-2), "Action", Classification.Gold);
            context.AddVideo("Code with Mosh 6", DateTime.UtcNow.AddDays(-3), "Action", Classification.Silver);

        }
    }
}
