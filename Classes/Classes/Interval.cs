using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Interval
    {
        private int min;
        private int max;

        public Interval(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public int Min
        { 
            get { return min; }
            set { min = value; }
        }

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public bool IsInInterval(int value)
        {
            if(value >= min && value <= max) 
            { 
                return true; 
            }
            return false;
        }

        public Interval Pen(Interval interval)
        {
            int penMin = 0;
            int penMax = 0;

            for(int i = min; i <= max + 1; i++)
            {
                if(i == interval.min)
                {
                    penMin = i; 
                }
                else if(i == interval.max)
                {
                    penMax = i;
                }

            }

            if (penMin != 0 && penMax != 0)
            {
                return new Interval(penMin, penMax);
            }
            throw new Exception("prunik neexistuje");
        }

        public string ToString()
        {
            string interval = "";
            for (int i = min; i < max + 1; i++)
            {
                 interval += i + " ";
            }
            return interval;
        }
        
            
        


    }
}
