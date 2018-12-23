using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelLibrary
{
     public class  ParcelEntity
    {
         private int _length;
         private int _breadth;
         private int _height;
         private double _weight;        

         public int Length
         {
             get { return _length; }
             set { _length = value; }
         }
         public int Breadth
         {
             get { return _breadth; }
             set { _breadth = value; }
         }
         public int Height
         {
             get { return _height; }
             set { _height = value; }
         }
         public double Weight
         {
             get { return _weight; }
             set { _weight = value; }
         }

         public ParcelEntity()
         {
             _length = 0;
             _breadth = 0;
             _height = 0;
             _weight = 0;            
         } 
     }
}
