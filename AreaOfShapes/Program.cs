
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

            }
            case 2:
            {

            }
            case 3:
            {

            }
            case 4:
            {

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


