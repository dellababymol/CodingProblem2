using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcelLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {      

        [TestMethod]
        public void Morehan25Kg_WontFindParcel()
        {          
            int lenght = 1;
            int breadth = 1;
            int height = 1;
            double weight = 26;
            ParcelService obj = new ParcelService(lenght, breadth, height, weight);
            ParcelType resultobj = new ParcelType();
            resultobj = obj.CalculateParcelCost();
            Assert.AreEqual(resultobj._type,string.Empty);
            Assert.AreEqual<decimal>(resultobj._cost,0);
        }

        [TestMethod]
        public void TooBigLength_WontFindPackage()
        {
            int lenght = 900;
            int breadth = 600;
            int height = 250;
            double weight = 20;
            ParcelService obj = new ParcelService(lenght, breadth, height, weight);
            ParcelType resultobj = new ParcelType();
            resultobj = obj.CalculateParcelCost();
            Assert.AreEqual(resultobj._type, string.Empty);
            Assert.AreEqual<decimal>(resultobj._cost, 0);
        }

        [TestMethod]
        public void TooBigBreadth_WontFindPackage()
        {
            int lenght = 200;
            int breadth = 900;
            int height = 250;
            double weight = 20;
            ParcelService obj = new ParcelService(lenght, breadth, height, weight);
            ParcelType resultobj = new ParcelType();
            resultobj = obj.CalculateParcelCost();
            Assert.AreEqual(resultobj._type, string.Empty);
            Assert.AreEqual<decimal>(resultobj._cost, 0);
        }

        [TestMethod]
        public void TooBigHeight_WontFindPackage()
        {
            int lenght = 900;
            int breadth = 300;
            int height = 900;
            double weight = 20;
            ParcelService obj = new ParcelService(lenght, breadth, height, weight);
            ParcelType resultobj = new ParcelType();
            resultobj = obj.CalculateParcelCost();
            Assert.AreEqual(resultobj._type, string.Empty);
            Assert.AreEqual<decimal>(resultobj._cost, 0);
        }
        [TestMethod]
        public void FindSmallPackage()
        {         

            int lenght = 200;
            int breadth = 300;
            int height = 150;
            double weight = 20;
            ParcelService obj = new ParcelService(lenght, breadth, height, weight);
            ParcelType resultobj = new ParcelType();
            resultobj = obj.CalculateParcelCost();
            Assert.AreEqual<string>(resultobj._type,Constants.SMALL_Type);
            Assert.AreEqual<decimal>(resultobj._cost, Constants.SMALL_COST);
        }

        [TestMethod]
        public void FindMediumPackage()
        {

            int lenght = 300;
            int breadth = 400;
            int height = 200;
            double weight = 20;
            ParcelService obj = new ParcelService(lenght, breadth, height, weight);
            ParcelType resultobj = new ParcelType();
            resultobj = obj.CalculateParcelCost();
            Assert.AreEqual<string>(resultobj._type, Constants.MEDIUM_Type);
            Assert.AreEqual<decimal>(resultobj._cost, Constants.MEDIUM_COST);
        }

        [TestMethod]
        public void FindLargePackage()
        {

            int lenght = 400;
            int breadth = 600;
            int height = 250;
            double weight = 20;
            ParcelService obj = new ParcelService(lenght, breadth, height, weight);
            ParcelType resultobj = new ParcelType();
            resultobj = obj.CalculateParcelCost();
            Assert.AreEqual<string>(resultobj._type, Constants.LARGE_Type);
            Assert.AreEqual<decimal>(resultobj._cost, Constants.LARGE_COST);
        }        
    }
}
