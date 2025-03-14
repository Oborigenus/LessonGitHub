float ParallelepipedArea(float height, float width, float length)
{
    var parallelepipedarea = height * length * width;
    return parallelepipedarea;
}

double ConeArea(double radius, double slantheight)
{
    var conearea = radius * slantheight * Math.PI;
    return Math.Round(conearea);
}

double CylinderArea(double radius, double height)
{
    var cylinderarea = radius * radius * Math.PI * 2 + 2 * height * Math.PI * radius;
    return Math.Round(cylinderarea);
}

void AreaFinder()
{
    while (true)
    {
        Console.WriteLine("1 - parallelepiped  ; 2 - cone ; 3 - cylinder ; 4 - exit");
        var choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
            {
                Console.WriteLine(
                    "For parallepiped you need to write down its width , length , height in one line with commas without spaces");
                var par = Console.ReadLine();
                var pararray = par?.Split(',').Select(float.Parse).ToArray();
                if (pararray != null) Console.WriteLine(ParallelepipedArea(pararray[0], pararray[1], pararray[2]));
                continue;
            }
            case 2:
            {
                Console.WriteLine(
                    "For cone you need to write down its radius and slant height in one line with commas without spaces in this order");
                var par = Console.ReadLine();
                var pararray = par?.Split(',').Select(double.Parse).ToArray();
                if (pararray != null) Console.WriteLine(ConeArea(pararray[0], pararray[1]));
                continue;
            }
            case 3:
            {
                 Console.WriteLine(
                    "For cylinder you need to write down its radius and height in one line with commas without spaces in this order");
                var par = Console.ReadLine();
                var pararray = par?.Split(',').Select(double.Parse).ToArray();
                if (pararray != null) Console.WriteLine(CylinderArea(pararray[0], pararray[1]));
                continue;
            }
            case 4:
            {
                Console.WriteLine("Thank you for using this application!");
                Console.WriteLine("Goodbye!");
                return; 
            }

        }

    }
}
Console.WriteLine("Enter your name");
var name = Console.ReadLine();
string[] namearray = ["Hello ", "!"];
var nameanswer = string.Join( name , namearray);
Console.WriteLine(nameanswer);
Console.WriteLine("Now you must choose a shape for which we will find its area");
tryAgain:
try
{
    AreaFinder();
}
catch (Exception)
{
    Console.WriteLine("Wrong input, please try again");
    goto tryAgain;
}