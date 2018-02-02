using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public abstract class AbstractGreenEngine : IGreenEngine
    {
        private int size;
        public virtual int Size
        {
            get
            {
                return size;
            }
        }

        public AbstractGreenEngine(int size)
        {
            this.size = size;
        }

        public override string ToString()
        {
            return this.GetType().Name + "(" + size + ")";
        }


    }
}
