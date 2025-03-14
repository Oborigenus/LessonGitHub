float ParallelepipedArea(float height, float width, float length)
{
    var parallelepipedArea = height * length * width;
    return parallelepipedArea;
}

double ConeArea(double radius, double slantHeight)
{
    var coneArea = radius * slantHeight * Math.PI;
    return Math.Round(coneArea);
}

double CylinderArea(double radius, double height)
{
    var cylinderArea = radius * radius * Math.PI * 2 + 2 * height * Math.PI * radius;
    return Math.Round(cylinderArea);
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
                    "For parallelepiped you need to write down its width , length , height in one line with commas without spaces");
                var par = Console.ReadLine();
                var parArray = par?.Split(',').Select(float.Parse).ToArray();
                if (parArray != null) Console.WriteLine(ParallelepipedArea(parArray[0], parArray[1], parArray[2]));
                continue;
            }
            case 2:
            {
                Console.WriteLine(
                    "For cone you need to write down its radius and slant height in one line with commas without spaces in this order");
                var par = Console.ReadLine();
                var parArray = par?.Split(',').Select(double.Parse).ToArray();
                if (parArray != null) Console.WriteLine(ConeArea(parArray[0], parArray[1]));
                continue;
            }
            case 3:
            {
                 Console.WriteLine(
                    "For cylinder you need to write down its radius and height in one line with commas without spaces in this order");
                var par = Console.ReadLine();
                var parArray = par?.Split(',').Select(double.Parse).ToArray();
                if (parArray != null) Console.WriteLine(CylinderArea(parArray[0], parArray[1]));
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
string[] nameArray = ["Hello ", "!"];
var nameAnswer = string.Join( name , nameArray);
Console.WriteLine(nameAnswer);
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