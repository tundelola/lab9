using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcCircArea
{
    class Circle
    {
        private double radius;
        private object πr;
        

        public Circle()
        {
            //creating a constructor

        }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }
        

        public Circle(double rad)
        {
            radius = rad;//This is when it makes the new radius

        }
        public double getCircumference()
        {
            return Math.PI*2*Radius;// gets the circumsference of a radius

        }
        public double getArea()
        {
            return Math.PI*Radius*Radius;// gets the area of a radius
           

        }

        private String formatNumber(double radi)
        {
        
            return  Math.Round(radius, 2).ToString();//format radius number passed in
        }

        public String getFormatedCircumference()
        {

            return formatNumber(getCircumference());//format the circumsference of a radius
        }

        public String getFormatedArea()
        {

           return  formatNumber(getArea());//format the area of a radius

        }

        
    }

}
