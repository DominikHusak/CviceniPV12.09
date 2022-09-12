using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniPV12._09
{
    internal class Interval
    {
        public int leftBorder { get; set; }

        public int rightBorder { get; set; }

        public Interval(int leftBorder, int rightBorder)
        {
            this.leftBorder = leftBorder;
            this.rightBorder = rightBorder;
        }

        public override string ToString()
        {
            return "Interval: [" + leftBorder + " " + rightBorder + "]";
        }


        public bool Numfind(int num)
        {
            return num >= leftBorder && num <= rightBorder;
        }
        //public Interval? PrunikIntervalu()
        //{
        //}

    }
}
