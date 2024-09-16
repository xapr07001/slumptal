Random rng = new Random();
int number = rng.Next(1,101);   //slumpat tal
int guess = 0;                  //antal gissningar
int tries = 0;                  //antal försök

while(guess != number){
    Console.WriteLine("Gissa på ett tal mellan 1 och 100:");
    guess = int.Parse(Console.ReadLine());
    tries++;

    if(guess < number){
        Console.WriteLine("Ditt tal är för litet.");
    }
    else{
        Console.WriteLine("Ditt tal är för stort.");
    }

}
Console.WriteLine("Du gissade rätt och det tog "+tries+" försök.");
