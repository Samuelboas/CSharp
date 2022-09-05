//Change appearance of Console
Console.Title = "Among us";
Console.WindowHeight = 40;

//Presentation
Console.WriteLine("Hello welcome to among us  ");
Console.WriteLine("Do you want to start");

string startGame = Console.ReadLine();
if (startGame == "yes")
{
    Console.WriteLine("Then we start");
}
else if (startGame == "no" )

{
    Console.WriteLine("then goodbye");
    Thread.Sleep(5000);
    Environment.Exit(0);
}
else
{
    Console.WriteLine( startGame + ", that is not yes or no you are very cringe");
    Thread.Sleep(5000);
    Environment.Exit(0);
} 

Console.WriteLine("Good then let the among us game begin!");
Thread.Sleep(1000);
Console.WriteLine("so what color do you want to be blue, red, green, yellow, black, white");

string farve = Console.ReadLine();
switch (farve) 
{
  case "blue":
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Then you are blue");
    break;
  case "red":
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("Then you are red");
    break;
  case "green":
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Then you are green");
    break;
  case "yellow":
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Then you are yellow");
    break;
  case "black":
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("Then you are black");
    break;
  case "white":
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Then you are white");
    break;
}

Console.WriteLine("You are an imposter");

Console.WriteLine("you see pink infront of you what do you do kill or walk");

String killPink = Console.ReadLine();



if (killPink == "kill") 
{
  Console.WriteLine("orange saw you kill and you got ejected and lost");
  Thread.Sleep(5000);
  Environment.Exit(0);
}
else if (killPink == "walk")
{
  Console.WriteLine("you walked by pink and luckly for you pink ended up trusting you");
  Thread.Sleep(3000);

}
else
{
  Console.WriteLine("you had to write (kill) or (walk)");
    Thread.Sleep(5000);
    Environment.Exit(0);
}

Console.WriteLine("Orange pressed the button and was sus of pink");
Thread.Sleep(3000);
Console.WriteLine("what do you do (agree) with Orange (help) Pink or (turn) on Orange");

String meeting = Console.ReadLine();
switch(meeting)
{
  case "agree":
    Console.WriteLine("you voted pink out and lost the only one who trusted you and lost");
    Thread.Sleep(5000);
    Environment.Exit(0);
  break;
  case "help":
    Console.WriteLine("you ended up keeping pink alive");
    Thread.Sleep(5000);
  break;
  case "turn":
    Console.WriteLine("you tried voting orange out but they ended op voting you out");
    Thread.Sleep(5000);
    Environment.Exit(0);
  break;

}
Console.WriteLine("it's down to a randomizer if you win type a number between 1-100");

while(true)
{



  int value = Convert.ToInt32(Console.ReadLine());
  Random rnd = new Random();
  int number = rnd.Next(1, 100);
  if (number == value)
  {
    Console.WriteLine("you won");
    break;
  }
  else
  {
    Console.WriteLine("wrong number");
    Console.WriteLine("the number was " + number);

  }

}

Console.WriteLine("nice job");
Thread.Sleep(5000);
Console.WriteLine("since you beat among us is there any thing else you want to do?");
Console.WriteLine("you can go to  prison for free. Do you want to go to prison?");
string GoToPrison = Console.ReadLine();

while(true)
{
  if(GoToPrison == "yes") 
  {
  Console.WriteLine("then welcome to you're new home you will be here for the next 16 years");
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Thread.Sleep(504576000);
  Console.WriteLine("now you are a free man");
  break;
  }
  else if (GoToPrison == "no")
  {
  Console.WriteLine("then you are not getting to have a lot of fun");
  break;
  }
  else
  {
  Console.WriteLine("you did not say yes or no now i am sad");
  break;   
  }
}

string answer = Console.ReadLine();