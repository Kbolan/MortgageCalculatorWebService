using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private string GetResult(string firstNumber, string secondNumber, string thirdNumber)
    {
        ServiceReference.MortgageCalculatorWebServiceSoapClient client =
        new ServiceReference.MortgageCalculatorWebServiceSoapClient();
        
        double a, b, c;
        string result = null;
        
        erra.Text = "";
        errb.Text = "";
        errc.Text = "";
        
        if(!double.TryParse(firstNumber, out a))
        {
            erra.Text = "Must be a valid number!";
        }
        if(!double.TryParse(secondNumber, out b))
        {
            errb.Text = "Must be a valid number!";
        }
        if(!double.TryParse(thirdNumber, out c))
        {
            errc.Text = "Must be a valid number!";
        }
        
        result = "$" + client.calculate(a,b,c) + " per month";
        return result;


    }
    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        LabelResult.ForeColor = System.Drawing.Color.Black;
        LabelResult.Text = GetResult(TextBox1.Text, TextBox2.Text, TextBox3.Text);
    }
    
}