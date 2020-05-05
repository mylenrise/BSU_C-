using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace lab1
{

    class Converter
    {
        const int UNDEFINED = -1;
        public Converter() { }
        public RgbColor cmykToRgb(int c_, int m_, int y_, int k_)
        {

            float c = (float)c_ / 100;
            float m = (float)m_ / 100;
            float y = (float)y_ / 100;
            float k = (float)k_ / 100;
            var r = (int)(255 * (1 - c) * (1 - k));
            var g = (int)(255 * (1 - m) * (1 - k));
            var b = (int)(255 * (1 - y) * (1 - k));
            return new RgbColor(r, g, b);

        }
        public CmykColor rgbToCmyk(int r, int g, int b)
        {

            if (r == 0 && g == 0 && b == 0)
            {
                return new CmykColor(0, 0, 0, 100);
            }

            float c = 1 - ((float)r / 255);
            float m = 1 - ((float)g / 255);
            float y = 1 - ((float)b / 255);


            float minCMY = Math.Min(c, Math.Min(m, y));

            c = ((c - minCMY) / (1 - minCMY)) * 100;
            m = ((m - minCMY) / (1 - minCMY)) * 100;
            y = ((y - minCMY) / (1 - minCMY)) * 100;
            var k = (int)(minCMY * 100);

            return new CmykColor((int)c, (int)m, (int)y, (int)k);

        }

        public static HlsColor RgbToHls(int r, int g, int b)
        {
            double h, l, s;
            
            double double_r = r / 255.0;
            double double_g = g / 255.0;
            double double_b = b / 255.0;

            
            double max = double_r;
            if (max < double_g) max = double_g;
            if (max < double_b) max = double_b;

            double min = double_r;
            if (min > double_g) min = double_g;
            if (min > double_b) min = double_b;

            double diff = max - min;
            l = (max + min) / 2;
            if (Math.Abs(diff) < 0.00001)
            {
                s = 0;
                h = 0; 
                MessageBox.Show("Achromatic case");
            }
            else
            {
                if (l <= 0.5) s = diff / (max + min);
                else s = diff / (2 - max - min);

                double r_dist = (max - double_r) / diff;
                double g_dist = (max - double_g) / diff;
                double b_dist = (max - double_b) / diff;

                if (double_r == max) h = b_dist - g_dist;
                else if (double_g == max) h = 2 + r_dist - b_dist;
                else h = 4 + g_dist - r_dist;

                h = h * 60;
                if (h < 0) h += 360;
            }
            return new HlsColor((int)h, (int)(l * 100), (int)(s * 100));
        }

        // Convert an HLS value into an RGB value.
        public static RgbColor HlsToRgb(int hi, int li, int si)

        {
            int r, g, b;
            double h = (double)hi;
            double l = (double)li/100;
            double s = (double)si/100;
            double p2;
            if (l <= 0.5) p2 = l * (1 + s);
            else p2 = l + s - l * s;

            double p1 = 2 * l - p2;
            double double_r, double_g, double_b;
            if (s == 0)
            {
                double_r = l;
                double_g = l;
                double_b = l;
                MessageBox.Show("Achromatic case");
            }
            else
            {
                double_r = QqhToRgb(p1, p2, h + 120);
                double_g = QqhToRgb(p1, p2, h);
                double_b = QqhToRgb(p1, p2, h - 120);
            }

            // Convert RGB to the 0 to 255 range.
            r = (int)(double_r * 255.0);
            g = (int)(double_g * 255.0);
            b = (int)(double_b * 255.0);
            return new RgbColor(r, g, b);
        }

        private static double QqhToRgb(double q1, double q2, double hue)
        {
            if (hue > 360) hue -= 360;
            else if (hue < 0) hue += 360;

            if (hue < 60) return q1 + (q2 - q1) * hue / 60;
            if (hue < 180) return q2;
            if (hue < 240) return q1 + (q2 - q1) * (240 - hue) / 60;
            return q1;
        }

        //public float hueTorgb(float p, float q, float t)
        //{
        //    if (t < 0) t += 1;
        //    if (t > 1) t -= 1;
        //    if (t < 1 / 6) return p + (q - p) * 6 * t;
        //    if (t < 1 / 2) return q;
        //    if (t < 2 / 3) return p + (q - p) * (2 / 3 - t) * 6;
        //    return p;
        //}

        //static float VAL_RGB(float n1, float n2, int hue)
        //{

        //    float otw;
        //    if (hue < 0)
        //        hue += 360;


        //    hue = hue - ((int)(hue / 360)) * 360;
        //    if (hue < 60)
        //        otw = n1 + (n2 - n1) * hue / 60;
        //    else
        //    if (hue < 180)
        //        otw = n2;
        //    else
        //    if (hue < 240.0)
        //        otw = n1 + (n2 - n1) * (240 - hue) / 60;
        //    else
        //        otw = n1;
        //    return (otw);
        //}


        //public RgbColor V_HLSRGB(int hue, int lig, int sat)

        //{
        //    int otw;
        //    float m1, m2,r=0,g=0,b=0;

        //    otw = 0;
        //    if (sat == 0.0)
        //    {            /* Ахроматический случай */
        //        if (hue == UNDEFINED)
        //        {
        //            r = lig; b = lig; g = lig;
        //        }
        //        else ++otw;
        //    }
        //    else
        //    {                     /* Хроматический случай */
        //        if ((m2 = lig) > 0.5)
        //            m2 = 1 - lig;
        //        m2 = lig + sat * m2;
        //        m1 = 2 * lig - m2;
        //        r = VAL_RGB(m1, m2, hue + 120);
        //        g = VAL_RGB(m1, m2, hue);
        //        b = VAL_RGB(m1, m2, hue - 120);
        //    }
        //    return new RgbColor((int)r, (int)g, (int)b);
        //}
        //public RgbColor hlsToRgb(int h_, int s_, int l_)
        //{
        //    float r, g, b;
        //    float h = (float)h_ / 360;
        //    float l = (float)l_ / 360;
        //    float s = (float)s_ / 360;

        //    if (s == 0)
        //    {
        //        r = g = b = 0; // achromatic
        //    }
        //    else
        //    {

        //        var q = l < 0.5 ? l * (1 + s) : l + s - l * s;
        //        var p = 2 * l - q;
        //        r = hueTorgb(p, q, h + 1 / 3);
        //        g = hueTorgb(p, q, h);
        //        b = hueTorgb(p, q, h - 1 / 3);
        //    }

        //    return new RgbColor((int)(r * 255), (int)(g * 255), (int)(b * 255));
        //}
        //public HlsColor rgbToHls(int r_, int g_, int b_)
        //{
        //    float r = (float)r_ / 255;
        //    float g = (float)g_ / 255;
        //    float b = (float)b_ / 255;
        //    float max = Math.Max(r, Math.Max(g, b));
        //    float min = Math.Min(r, Math.Min(g, b));
        //    float h, s, l;
        //    h = s = l = (max + min) / 2;

        //    if (max == min)
        //    {
        //        h = s = 0; // achromatic
        //    }
        //    else
        //    {
        //        var d = max - min;
        //        s = l > 0.5 ? d / (2 - max - min) : d / (max + min);

        //        if (max == r)
        //        {
        //            h = (g - b) / d + (g < b ? 6 : 0);
        //        }
        //        else if (max == g)
        //        {
        //            h = (b - r) / d + 2;
        //        }
        //        else
        //            h = (r - g) / d + 4;

        //        h /= 6;
        //    }

        //    return new HlsColor((int)(h * 360), (int)(l * 360), (int)(s * 360));
        //}
    }
}
