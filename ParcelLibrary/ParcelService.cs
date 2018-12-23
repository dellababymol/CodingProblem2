using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelLibrary
{
    public class ParcelService: IParcelService
    {       
       private ParcelEntity inputOrder = new ParcelEntity();
       private ParcelType parceltypeobj = new ParcelType();

       public ParcelService( int lenght, int breadth, int height, double weight)
        {
            inputOrder.Length = lenght;
            inputOrder.Breadth = breadth;
            inputOrder.Height = height;
            inputOrder.Weight = weight;         
            
        }

       public ParcelType CalculateParcelCost()
      {       

          try
          {
              if (!CheckOverweight())
              {

                  if (ValidateDimensions())
                  {
                      if (inputOrder.Length <= Constants.SMALL_LENGTH &&
                          inputOrder.Breadth <= Constants.SMALL_BREADTH &&
                          inputOrder.Height <= Constants.SMALL_HEIGHT)
                      {
                          parceltypeobj._cost = Constants.SMALL_COST;
                          parceltypeobj._type = Constants.SMALL_Type;
                      }
                      else if (inputOrder.Length <= Constants.MEDIUM_LENGTH &&
                               inputOrder.Breadth <= Constants.MEDIUM_BREADTH &&
                               inputOrder.Height <= Constants.MEDIUM_HEIGHT)
                      {
                          parceltypeobj._cost = Constants.MEDIUM_COST;
                          parceltypeobj._type = Constants.MEDIUM_Type;
                      }
                      else if (inputOrder.Length <= Constants.LARGE_LENGTH &&
                               inputOrder.Breadth <= Constants.LARGE_BREADTH &&
                               inputOrder.Height <= Constants.LARGE_HEIGHT)
                      {
                          parceltypeobj._cost = Constants.LARGE_COST;
                          parceltypeobj._type = Constants.LARGE_Type;
                      }
                  }
              }
          }
          catch (Exception ex)
          {
              throw ex;
          }
          return parceltypeobj;
      }

       private bool CheckOverweight()
      {
          try
          {
              if (inputOrder.Weight > 0 && inputOrder.Weight <= Constants.MAX_WEIGHT)
                  return false;
              return true;
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }

       private bool ValidateDimensions()
      {
          try
          {
              if (inputOrder.Length > 0 && inputOrder.Breadth > 0 && inputOrder.Height > 0)
                  return true;
              return false;
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }  
   }
}
