Console.WriteLine("Player 1 choose a character (pirate, stone chewer, ghost warrior, outworlder, monster knight, dark goblin)");
string Charakter1 = Console.ReadLine()!;

Console.WriteLine("Player 2 choose a character (pirate, stone chewer, ghost warrior,  outworlder, monster knight, dark goblin)");
string Charakter2 = Console.ReadLine()!;

int piratehealth = 20;
int pirateattack = 3;
int piratespeed = 3;
int pirateamore = 3;

int stonechewerhealth = 50;
int stonechewerattack = 8;
int stonechewerspeed = 1;
int stonecheweramore = 10;

int ghostwarriorhealth = 20;
int ghostwarriorattack = 2;
int ghostwarriorspeed = 5;
int ghostwarriorramore = 2;

int outworlderhelth = 15;
int outworlderattack = 1;
int outworlderspeed = 10;
int outworlderamore = 2;

int monsterknighthelth = 15;
int monsterknightattack = 4;
int monsterknightspeed = 3;
int monsternightamore = 3;

int darkgoblinhelth = 10;
int darkgoblinattack = 1;
int darkgoblinspeed = 3;
int darkgoblinamore = 8;

int health = 0;
int health2 = 0;

while (health >= 0 && health2 >= 0)
{
    if (Charakter1 == "pirate")
    {
        if (Charakter2 == "stone chewer")
        {
            piratehealth = piratehealth + pirateamore - (stonechewerattack * stonechewerspeed);
            stonechewerhealth = stonechewerhealth + stonecheweramore - (pirateattack * piratespeed);
            health = piratehealth;
            health2 = stonechewerhealth;
        }
        else if (Charakter2 == "ghost warrior")
        {
            piratehealth = piratehealth + pirateamore - (ghostwarriorattack * ghostwarriorspeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (pirateattack * piratespeed);
            health = piratehealth;
            health2 = ghostwarriorhealth;
        }
        else if (Charakter2 == "pirate")
        {
            piratehealth = piratehealth + piratehealth - (pirateattack * piratespeed);
            piratehealth = piratehealth + pirateamore - (pirateattack * piratespeed);
            health = piratehealth;
            health2 = piratehealth;
        }
        else if (Charakter2 == "outworlder")
        {
            outworlderhelth = outworlderhelth + outworlderamore - (pirateattack * piratespeed);
            piratehealth = piratehealth + pirateamore - (piratespeed * pirateattack);
            health = piratehealth;
            health2 = outworlderhelth;
        }
        else if (Charakter2 == "monster knight")
        {
            monsterknighthelth = monsterknighthelth + monsternightamore - (pirateattack * piratespeed);
            piratehealth = piratehealth + pirateamore - (monsterknightattack * monsterknightspeed);
            health = piratehealth;
            health2 = outworlderhelth;
        }
        else if (Charakter2 == " dark goblin")
        {
            darkgoblinhelth = darkgoblinhelth + darkgoblinamore - (pirateattack * piratespeed);
            piratehealth = piratehealth + pirateamore - (darkgoblinattack * darkgoblinspeed);
            health = piratehealth;
            health2 = outworlderhelth;
        }


    }
    if (Charakter1 == "stone chewer")
    {
        if (Charakter2 == "stone chewer")
        {
            stonechewerhealth = stonechewerhealth + stonecheweramore - (stonechewerattack * stonechewerspeed);
            stonechewerhealth = stonechewerhealth + stonecheweramore - (stonechewerattack * stonechewerspeed);
            health = stonechewerhealth;
            health2 = stonechewerhealth;
        }
        else if (Charakter2 == "ghost warrior")
        {
            piratehealth = piratehealth + pirateamore - (ghostwarriorattack * ghostwarriorspeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (pirateattack * piratespeed);
            health = stonechewerhealth;
            health2 = ghostwarriorhealth;
        }
        else if (Charakter2 == "pirate")
        {
            stonechewerhealth = stonechewerhealth + stonecheweramore - (pirateattack * piratespeed);
            piratehealth = piratehealth + pirateamore - (stonechewerattack * stonechewerspeed);
            health = stonechewerhealth;
            health2 = piratehealth;
        }
        else if (Charakter2 == "outworlder")
        {
            stonechewerhealth = stonechewerhealth + stonecheweramore - (outworlderattack * outworlderspeed);
            outworlderhelth = outworlderhelth + outworlderspeed - (stonechewerattack * stonechewerspeed);
            health = stonechewerhealth;
            health2 = outworlderhelth;
        }
        else if (Charakter2 == "monster knight")
        {
            monsterknighthelth = monsterknighthelth + monsternightamore - (stonechewerattack * stonechewerspeed);
            stonechewerhealth = stonechewerhealth + stonecheweramore - (monsterknightattack * monsterknightspeed);
            health = stonechewerhealth;
            health2 = outworlderhelth;
        }
        else if (Charakter2 == " dark goblin")
        {
            darkgoblinhelth = darkgoblinhelth + darkgoblinamore - (stonechewerattack * stonechewerspeed);
            piratehealth = piratehealth + pirateamore - (darkgoblinattack * darkgoblinspeed);
            health = stonechewerhealth;
            health2 = outworlderhelth;
        }
    }
    if (Charakter1 == "ghost warrior")
    {
        if (Charakter2 == "stone chewer")
        {
            piratehealth = piratehealth + pirateamore - (ghostwarriorattack * ghostwarriorspeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (pirateattack * piratespeed);
            health = ghostwarriorhealth;
            health2 = stonechewerhealth;
        }
        else if (Charakter2 == "ghost warrior")
        {
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (ghostwarriorattack * ghostwarriorspeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (ghostwarriorattack * ghostwarriorspeed);
            health = ghostwarriorhealth;
            health2 = ghostwarriorhealth;
        }
        else if (Charakter2 == "pirate")
        {
            piratehealth = piratehealth + pirateamore - (ghostwarriorattack * ghostwarriorspeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (pirateattack * piratespeed);
            health = ghostwarriorhealth;
            health2 = piratehealth;
        }
        else if (Charakter2 == "outworlder")
        {
            outworlderhelth = outworlderhelth + outworlderamore - (ghostwarriorattack * ghostwarriorspeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (piratespeed * pirateattack);
            health = ghostwarriorhealth;
            health2 = outworlderhelth;
        }
        else if (Charakter2 == "monster knight")
        {
            monsterknighthelth = monsterknighthelth + monsternightamore - (ghostwarriorattack * ghostwarriorspeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (monsterknightattack * monsterknightspeed);
            health = ghostwarriorhealth;
            health2 = monsterknighthelth;
        }
        else if (Charakter2 == " dark goblin")
        {
            darkgoblinhelth = darkgoblinhelth + darkgoblinamore - (ghostwarriorattack * ghostwarriorspeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (darkgoblinattack * darkgoblinspeed);
            health = darkgoblinhelth;
            health2 = outworlderhelth;
        }


    }
    if (Charakter1 == " outworlder")
    {
        if (Charakter2 == "stone chewer")
        {
            outworlderhelth = outworlderhelth + outworlderamore - (stonechewerattack * stonechewerspeed);
            stonechewerhealth = stonechewerhealth + stonecheweramore - (outworlderattack * outworlderspeed);
            health = outworlderhelth;
            health2 = stonechewerhealth;
        }
        else if (Charakter2 == "ghost warrior")
        {
            outworlderhelth = outworlderhelth + outworlderamore - (ghostwarriorattack * ghostwarriorspeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (outworlderattack * outworlderspeed);
            health = outworlderhelth;
            health2 = ghostwarriorhealth;
        }
        else if (Charakter2 == "pirate")
        {
            outworlderhelth = outworlderhelth + outworlderamore - (pirateattack * piratespeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (outworlderattack * outworlderspeed);
            health = outworlderhelth;
            health2 = piratehealth;
        }
        else if (Charakter2 == "outworlder")
        {
            outworlderhelth = outworlderhelth + outworlderamore - (outworlderattack * outworlderspeed);
            outworlderhelth = outworlderhelth + outworlderamore - (outworlderattack * outworlderspeed);
            health = outworlderhelth;
            health2 = outworlderhelth;
        }
        else if (Charakter2 == "monster knight")
        {
            monsterknighthelth = monsterknighthelth + monsternightamore - (outworlderattack * outworlderspeed);
            outworlderhelth = outworlderhelth + outworlderamore - (monsterknightattack * monsterknightspeed);
            health = ghostwarriorhealth;
            health2 = monsterknighthelth;
        }
        else if (Charakter2 == " dark goblin")
        {
            darkgoblinhelth = darkgoblinhelth + darkgoblinamore - (outworlderattack * outworlderspeed);
            outworlderhelth = outworlderhelth + outworlderamore - (outworlderattack * outworlderspeed);
            health = outworlderhelth;
            health2 = darkgoblinhelth;
        }


    }
    if (Charakter1 == " monster knight")
    {
        if (Charakter2 == "stone chewer")
        {
            monsterknighthelth = monsterknighthelth + monsternightamore - (stonechewerattack * stonechewerspeed);
            stonechewerhealth = stonechewerhealth + stonecheweramore - (monsterknightattack * monsterknightspeed);
            health = monsterknighthelth;
            health2 = stonechewerhealth;
        }
        else if (Charakter2 == "ghost warrior")
        {
            monsterknighthelth = monsterknighthelth + monsternightamore - (ghostwarriorattack * ghostwarriorspeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (monsterknightattack * monsterknightspeed);
            health = monsterknighthelth;
            health2 = ghostwarriorhealth;
        }
        else if (Charakter2 == "pirate")
        {
            monsterknighthelth = monsterknighthelth + monsternightamore - (pirateattack * piratespeed);
            piratehealth = piratehealth + pirateamore - (monsterknightattack * monsterknightspeed);
            health = monsterknighthelth;
            health2 = piratehealth;
        }
        else if (Charakter2 == "outworlder")
        {
            monsterknighthelth = monsterknighthelth + monsternightamore - (outworlderattack * outworlderspeed);
            outworlderhelth = outworlderhelth + outworlderamore - (monsterknightattack * monsterknightspeed);
            health = monsterknighthelth;
            health2 = outworlderhelth;
        }
        else if (Charakter2 == "monster knight")
        {
            monsterknighthelth = monsterknighthelth + monsternightamore - (monsterknightattack * monsterknightspeed);
            monsterknighthelth = monsterknighthelth + monsternightamore - (monsterknightattack * monsterknightspeed); 
            health = monsterknighthelth;
            health2 = monsterknighthelth;
        }
        else if (Charakter2 == " dark goblin")  
        {
            darkgoblinhelth = darkgoblinhelth + darkgoblinamore - (monsterknightattack * monsterknightspeed);
            monsterknighthelth = monsterknighthelth + monsternightamore - (outworlderattack * outworlderspeed);
            health = monsterknighthelth;
            health2 = darkgoblinhelth;
        }


    }
    if (Charakter1 == " dark goblin")
    {
        if (Charakter2 == "stone chewer")
        {
            darkgoblinhelth = darkgoblinhelth + darkgoblinamore - (stonechewerattack * stonechewerspeed);
            stonechewerhealth = stonechewerhealth + stonecheweramore - (darkgoblinattack * darkgoblinspeed);
            health = darkgoblinspeed;
            health2 = stonechewerhealth;
        }
        else if (Charakter2 == "ghost warrior")
        {
            darkgoblinhelth = darkgoblinhelth + darkgoblinamore - (ghostwarriorattack * ghostwarriorspeed);
            ghostwarriorhealth = ghostwarriorhealth + ghostwarriorramore - (darkgoblinattack * darkgoblinspeed);
            health = monsterknighthelth;
            health2 = ghostwarriorhealth;
        }
        else if (Charakter2 == "pirate")
        {
            darkgoblinhelth = darkgoblinhelth + darkgoblinhelth - (pirateattack * piratespeed);
            piratehealth = piratehealth + pirateamore - (darkgoblinattack * darkgoblinspeed);
            health = monsterknighthelth;
            health2 = piratehealth;
        }
        else if (Charakter2 == "outworlder")
        {
            monsterknighthelth = monsterknighthelth + monsternightamore - (outworlderattack * outworlderspeed);
            outworlderhelth = outworlderhelth + outworlderamore - (monsterknightattack * monsterknightspeed);
            health = monsterknighthelth;
            health2 = outworlderhelth;
        }
        else if (Charakter2 == "monster knight")
        {
            monsterknighthelth = monsterknighthelth + monsternightamore - (monsterknightattack * monsterknightspeed);
            monsterknighthelth = monsterknighthelth + monsternightamore - (monsterknightattack * monsterknightspeed); 
            health = monsterknighthelth;
            health2 = monsterknighthelth;
        }
        else if (Charakter2 == " dark goblin")
        {
            darkgoblinhelth = darkgoblinhelth + darkgoblinamore - (monsterknightattack * monsterknightspeed);
            monsterknighthelth = monsterknighthelth + monsternightamore - (outworlderattack * outworlderspeed);
            health = monsterknighthelth;
            health2 = darkgoblinhelth;
        }


    }
}

if (health <= 0 && health2 <= 0)
{
    Console.WriteLine("Nobody winns try again");
}
else if (health > 0)
{
    Console.WriteLine("Player 1 winns!!!");
}
else if (health2 > 0)
{
    Console.WriteLine("Player 2 winns !!!");
}

