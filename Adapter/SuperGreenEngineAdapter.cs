using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
     public class SuperGreenEngineAdapter:AbstractEngine
    {
        public SuperGreenEngineAdapter(SuperGreenEngine greenEngine) : base(greenEngine.Size, false) { }
    }
}
