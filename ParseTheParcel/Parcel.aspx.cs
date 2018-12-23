using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ParcelLibrary;

namespace ParseTheParcel
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            formatInputOutput();
        }
        void formatInputOutput()
        {
            try
            {
                int lenght = Int32.Parse(txtLen.Text);
                int breadth = Int32.Parse(txtBrd.Text);
                int height = Int32.Parse(txtHgt.Text);
                double weight = Int32.Parse(txtwght.Text);
                ParcelService obj = new ParcelService(lenght, breadth, height, weight);
                ParcelType resultobj = new ParcelType();
                resultobj = obj.CalculateParcelCost();
                decimal resultCost = resultobj._cost;
                string resultType = resultobj._type;

                if (resultType == string.Empty && resultCost == 0)
                {
                    Label3.Text = "Invalid Item - Cannot find type and cost";
                    Label3.Visible = true;
                    lblParcelType.Visible = false;
                    Label1.Visible = false;
                    lblParcelCost.Visible = false;
                    Label2.Visible = false;
                }

                else
                {
                    lblParcelType.Text = resultType;
                    lblParcelType.Visible = true;
                    Label1.Visible = true;
                    lblParcelCost.Text = resultCost.ToString();
                    lblParcelCost.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}