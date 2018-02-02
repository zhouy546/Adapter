using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IEngine> engines = new List<IEngine>();
            engines.Add(new StandardEngine(1300));
            engines.Add(new StandardEngine(1300));
            engines.Add(new TurboEngine(2000));
            SuperGreenEngine greenEngine = new SuperGreenEngine(1200);
            engines.Add(new SuperGreenEngineAdapter(greenEngine));
            foreach (IEngine engine in engines)
            {
                Console.WriteLine(engine);

            }
        }
    }
}
