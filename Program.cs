namespace SalaryCalc;
class Program
{
    //https://how2b.am/ashxatavardzi-hashvich/

    static void Main(string[] args)
    {

        float gross_salary = 900000f;

        Console.WriteLine("Gross to net: " + Gross_to_NetSalary(gross_salary)); //method
        Console.WriteLine("-----------------------");
        Console.WriteLine("Ekamtayin - " + Ekamtayin(gross_salary));
        Console.WriteLine("Social vjar - " + SocVjar(gross_salary));
        Console.WriteLine("Kensatoshak - " + Kensatoshak(gross_salary));
        Console.WriteLine("Droshmanish - " + Droshmanish(gross_salary));

        Console.WriteLine();

        float net_salary = 625000.0f;

        Console.WriteLine("Net to gross: " + Net_to_GrossSalary(net_salary));
        Console.WriteLine("-----------------------");
        gross_salary = Net_to_GrossSalary(net_salary);

        Console.WriteLine("Ekamtayin - " + Ekamtayin(gross_salary));
        Console.WriteLine("Social vjar - " + SocVjar(gross_salary));
        Console.WriteLine("Kensatoshak - " + Kensatoshak(gross_salary));
        Console.WriteLine("Droshmanish - " + Droshmanish(gross_salary));
        Console.ReadKey();
    }
    public static float Gross_to_NetSalary (float gross_salary)
    {
        return gross_salary - Ekamtayin(gross_salary) - SocVjar(gross_salary) - Kensatoshak(gross_salary) - Droshmanish(gross_salary);

    }

    public static int Net_to_GrossSalary(float net_salary)
    {
        int gross_salary;

        for (gross_salary = 50000; gross_salary < 5000000; gross_salary += 1)
        {
            if ((int)(gross_salary - (float)Ekamtayin(gross_salary) - (float)SocVjar(gross_salary) - (float)Kensatoshak(gross_salary) - (float)Droshmanish(gross_salary)) == net_salary)

            {
                return gross_salary;
            }
        }

        return gross_salary;
    }

    public static float Ekamtayin (float gross_salary)
    {
        return gross_salary * 0.21f;
    }

    public static float SocVjar(float gross_salary)
    {
        if (gross_salary > 1000020)
        {
            return 69500;
        }
        else if (gross_salary > 500001)
        {
            return 20000;
        }
        else
        {
            return gross_salary * 0.035f;
        }
    }

    public static float Kensatoshak (float gross_salary)
    {
        if (gross_salary > 1000020)
        {
            return 69500;
        }
        else if (gross_salary > 500001)
        {
            return gross_salary * 0.1f - 32500;
        }
        else 
        {
            return gross_salary * 0.5f;
        }
    }

    public static int Droshmanish(float gross_salary)
    {

        if(gross_salary > 1000001)
        {
            return 15000;
        }
        else if(gross_salary > 500001)
        {
            return 8500;
        }
        else if (gross_salary > 200001)
        {
            return 5500;
        }
        else if (gross_salary > 100001)
        {
            return 3000;
        }
        else
        {
            return 1500;
        }


    }





}
