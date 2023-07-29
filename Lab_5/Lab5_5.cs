//Create a class Hospital with HospitalDetails() method.Create another
//classes Apollo, Wockhardt, Gokul_Superspeciality which overrides
//HospitalDetails() method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();
        Apollo  apollo = new Apollo();
        Wockhardt wockhardt = new Wockhardt();
        Gokul_Superspeciality gokul_Superspeciality = new Gokul_Superspeciality();

        hospital.HospitalDetails();
        apollo.HospitalDetails();
        wockhardt.HospitalDetails();
        gokul_Superspeciality.HospitalDetails();
    }
}

class Hospital
{
    public virtual void HospitalDetails()
    {
        Console.WriteLine("Hospital");
    }
}

class Apollo : Hospital
{
    override public void HospitalDetails()
    {
        Console.WriteLine("Appolo Hospital");
    }
}

class Wockhardt : Hospital
{
    override public void HospitalDetails()
    {
        Console.WriteLine("wockhardt Hospital");
    }
}
class Gokul_Superspeciality : Hospital
{
    override public void HospitalDetails()
    {
        Console.WriteLine("Gokul_Superspeciality Hospital");
    }
}