using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/", 
Description="A Simple Web Monthly Mortgage Calculator Service",
Name ="MortgageCalculatorWebService")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public double calculate(double p, double i, double n){
        i = (i*.01)/12;
        n = n * 12; 
        double a = Math.Pow((1+i),n);
        double b = p*((i*a)/(a-1));
        b = Math.Round(b,2);
        return b;
    }
    
}