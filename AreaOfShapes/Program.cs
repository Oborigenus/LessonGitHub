
void AreaFinder()
{
    while (true)
    {
        
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


