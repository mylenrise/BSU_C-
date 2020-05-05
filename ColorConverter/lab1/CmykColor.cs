using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class CmykColor
    {
        public int c;
        public int m;
        public int y;
        public int k;

        public CmykColor(int c_, int m_, int y_,int k_)
        {
            setC(c_);
            setM(m_);
            setY(y_);
            setK(k_);
            setK(k_);
        }

        public void setC(int v)
        {
            this.c = v;
        }
        public void setM(int v)
        {
            this.m = v;
        }
        public void setY(int v)
        {
            this.y = v;
        }
        public void setK(int v)
        {
            this.k = v;
        }
        public int getR()
        {
            return c;
        }
        public int getG()
        {
            return m;
        }
        public int getB()
        {
            return y;
        }
    }
}
