﻿Console.WriteLine("Welcome to the battle simulator. Please choose 1 of the Charatores.  1 for Pirate, 2 for Stone Chewer, 3 for Ghost Warrior, 4 for Outworlder, 5 for  Monster Knight, 6 for goblin");
int Player1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Player 2 please choose your Character");
int Player2 = int.Parse(Console.ReadLine()!);

 double Player1Speed = 0;
 double Player1Attack = 0;
 double Player2Speed = 0;
 double Player2Attack = 0;


double Player1Health = 0;
double Player2Health = 0;
if (Player1 == Player2){
    Console.WriteLine("It is a draw please try again");
}


    switch(Player1){
    case 1:
        Player1Health = 23;
        Player1Speed = 3;
        Player1Attack = 3;
        break;
    case 2:
        Player1Speed = 1;
        Player1Attack = 8;
        Player1Health = 60;
        break;
    case 3:
        Player1Speed = 5;
        Player1Attack = 2;
        Player1Health = 22;
        break;
    case 4:
        Player1Speed = 10;
        Player1Attack = 1;
        Player1Health = 16;
            break;
    case 5:
    Player1Speed = 3;
    Player1Attack = 4;
    Player1Health = 18;
    break;
    case 6:
    Player1Speed = 3;
    Player1Attack = 1;
    Player1Health = 18;
    break;
}

switch(Player2){
    case 1:
        Player2Health = 23;
        Player2Speed = 3;
        Player2Attack = 3;
        break;
    case 2:
        Player2Speed = 1;
        Player2Attack = 8;
        Player2Health = 60;
        break;
    case 3:
        Player2Speed = 5;
        Player2Attack = 2;
        Player2Health = 22;
        break;
     case 4:
        Player2Speed = 10;
        Player2Attack = 1;
        Player2Health = 16;
        break;
    case 5:
        Player2Speed = 3;
        Player2Attack = 4;
        Player2Health = 18;
        break;
    case 6:
        Player2Speed = 3;
        Player2Attack = 1;
        Player2Health = 18;
    break;
}




while(Player1Health > 0 && Player2Health > 0){
    int number1 = Random.Shared.Next(-15, 15);
    double damage = number1 / 100d;
    double prozent1 = (Player1Attack * Player1Speed) * damage;
    int number2 = Random.Shared.Next(-15, 15);
    double damage2  = number2 / 100d;
    double prozent2 = (Player2Attack * Player2Speed) * damage2;
    Player2Health -= prozent2;
    Player1Health -= prozent1;
    //Console.WriteLine(Player1Health);
    //Console.WriteLine(Player2Health);
   
   
    
}
if (Player1Health > 0){
    Console.WriteLine("The Winner is  Player 1");

}
else if (Player2Health > 0){
    Console.WriteLine("The winner is Player 2");
}

