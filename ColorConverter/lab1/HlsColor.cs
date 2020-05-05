using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class HlsColor
    {
        public int h;
        public int l;
        public int s;

        public HlsColor(int h_, int l_, int s_)
        {
            setH(h_);
            setL(l_);
            setS(s_);
        }

        public void setH(int v)
        {
            this.h = v;
        }
        public void setL(int v)
        {
            this.l = v;
        }
        public void setS(int v)
        {
            this.s = v;
        }
        public int getH()
        {
            return h;
        }
        public int getL()
        {
            return l;
        }
        public int getS()
        {
            return s;
        }
    }
}

