namespace Hurricane;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] splitinput = input.Split(" ");
        double windspeed = Convert.ToDouble(splitinput[0]);
        if (windspeed >= 157)
        {
            Console.WriteLine("Category Five Hurricane");
        }
        else if (windspeed >= 130 && windspeed < 157)
        {
            Console.WriteLine("Category Four Hurricane");
        }
        else if (windspeed >= 111 && windspeed < 130)
        {
            Console.WriteLine("Category Three Hurricane");
        }
        else if (windspeed >= 96 && windspeed < 111)
        {
            Console.WriteLine("Category Two Hurricane");
        }
        else if (windspeed >= 74 && windspeed < 96)
        {
            Console.WriteLine("Category One Hurricane");
        }
        else
        {
            Console.WriteLine("Not a Hurricane");
        }
    }
}
