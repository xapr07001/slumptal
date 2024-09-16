Random rng = new Random();
int number = rng.Next(1,101);
int guess = 0;

for(int tries = 1;guess != number;tries++){
    guess = int.Parse(Console.ReadLine());
    
    if(guess < number){
        Console.WriteLine("Ditt tal är för litet.");
    }
    else if(guess > number){
        Console.WriteLine("Ditt tal är för stort.");
    }
    else{
        Console.WriteLine("Du gissade rätt och det tog " + tries+ " försök.");
    }
}