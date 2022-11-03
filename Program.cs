Console.WriteLine("Welcome to the battle simulator. Please choose 1 of the Charatores.  1 for Pirate, 2 for Stone Chewer, 3 for Ghost Warrior, 4 for Outworlder, 5 for  Monster Knight, 6 for goblin");
int Player1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Player 2 please choose your Character");
int Player2 = int.Parse(Console.ReadLine()!);

 int Player1Speed = 0;
 int Player1Attack = 0;
 int Player2Speed = 0;
 int Player2Attack = 0;


int Player1Health = 0;
int Player2Health = 0;
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
    Player2Health -= (Player1Attack * Player1Speed);
    Player1Health -= (Player2Attack * Player2Speed);
    
}
if (Player1Health > 0){
    Console.WriteLine("The Winner is  Player 1");

}
else if (Player2Health > 0){
    Console.WriteLine("The winner is Player 2");
}

