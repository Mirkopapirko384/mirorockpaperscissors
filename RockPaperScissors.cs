Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors");
int k = 0;
Random random = new Random();
int computerRandomNumber = random.Next(1, 4);
string a = Console.ReadLine();
string computermove = " ";
const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
if (a == "r" || a == "rock")
{
    a = "Rock";
}
else if (a == "p" || a == "paper")
{
    a = "Paper";
}
else if (a == "s" || a == "scissors")
{
    a = "Scissors";
}
else
{
    Console.WriteLine("invalid input, try again");
}
switch (computerRandomNumber)
{
    case 1;
        computermove = Rock;
        break;
    case 2;
        computermove = Paper;
        break;
    case 3;
        computermove = Scissors;
        if ((a == Rock && computermove == Scissors) || (a == Paper && computermove == Rock) || (a == Scissors && computermove == Paper))
        {
            Console.WriteLine("You win.");
        }else if((a == Rock && computermove == Paper) || (a == Paper && computermove == Scissors) || (a == Scissors && computermove == Rock))
        {
            Console.WriteLine("You lose.");
        }
        else
        {
            Console.WriteLine("this game is a draw.");
        }
        


}
