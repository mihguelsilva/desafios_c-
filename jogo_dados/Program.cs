Random game = new();
int dice1 = game.Next(1,7);
int dice2 = game.Next(1,7);
int dice3 = game.Next(1,7);
int sumDices = dice1 + dice2 + dice3;
int points = 0;
int sumPoints = 0;
Console.WriteLine("Hello there! This is an simple dice's game!");
Console.WriteLine("The rule is very simple, if your points are higher than 15, you win, if not, then you lose");
Console.WriteLine("Ready? Let's start it!");
Console.WriteLine("What's your name, pal?");
string namePerson = Console.ReadLine();
Console.WriteLine($"{namePerson} had play game dice");
Console.WriteLine($"dice1 has {dice1}");
Console.WriteLine($"dice2 has {dice2}");
Console.WriteLine($"dice3 has {dice3}");
Console.WriteLine($"The sum of dices reach {sumDices}");
/*
if (dice1 == dice2 && dice1 == dice3) {
    points += 6;
    Console.WriteLine($"Congratulation, {namePerson}!");
    Console.WriteLine("You've got 3 equal dices!");
  } else if (dice1 == dice2 && dice1 != dice3 ||
	   dice1 == dice3 && dice1 != dice2 ||
	   dice2 == dice3 && dice2 != dice1 ||
	   dice2 == dice3 && dice3 != dice1) {
	   Fiz dessa forma, contudo, foi instruído a realizar da
	   maneira abaixo. Tranquilo.
  } else if ((dice1 == dice2) || (dice1 == dice2) || (dice2 == dice3)) {
    points += 2;
    Console.WriteLine($"Congratulation, {namePerson}!");
    Console.WriteLine("You've got 2 equal dices!");
} else {
    Console.WriteLine($"Unfortunately, none of dices are equals, {namePerson}!");
}
Da maneira como contruí o código, não foi a melhor. Interessante a lógica do
Microsoft Learn
*/
if ((dice1 == dice2) || (dice1 == dice3) || (dice2 == dice3)) {
    if ((dice1 == dice2) && (dice2 == dice3)) {
	Console.WriteLine($"Congratulations, {namePerson}, you've got triples!");
	points += 6;
    } else {
	Console.WriteLine($"Congratulations, {namePerson}, you've got doubles!");
	points += 2;
    }
} else {
    Console.WriteLine($"{namePerson}, unfortunately, you've got nothing!");
}
sumPoints = sumDices + points;
Console.WriteLine($"{namePerson}, you've got {sumPoints} points");
if (sumPoints >= 15) {
    Console.WriteLine("Congratulations!\nYou've wonned the game!");
} else {
    Console.WriteLine("Unfortunately, you've losed the game!");
}
