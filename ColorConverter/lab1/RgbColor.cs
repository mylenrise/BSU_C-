using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class RgbColor
    {
        public int r;
        public int g;
        public int b;

        public RgbColor(int r_, int g_, int b_)
        {
            setR(r_);
            setG(g_);
            setB(b_);
        }

        public void setR(int v)
        {
            this.r = v;
        }
        public void setG(int v)
        {
            this. g= v;
        }
        public void setB(int v)
        {
            this.b = v;
        }
        public int getR()
        {
            return r;
        }
        public int getG()
        {
            return g;
        }
        public int getB()
        {
            return b;
        }
    }
}
