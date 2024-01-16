using System.Text;
using DrawTeams.Classes;

string str ;
    
try
{
Console.WriteLine("Please give the names of the teams and seprate with ( , Or . Or -) Maximum is 8 Teams ---");
str=(Console.ReadLine()??"");
Console.WriteLine("Done >>>\n");
Console.BackgroundColor=ConsoleColor.Green;
Console.WriteLine("Home ----------- Away\n");
Console.ResetColor();
string[] spearator = { ",", ".","-" }; 
string[] Teams = str.Split(spearator,100,StringSplitOptions.TrimEntries); 
string[] Games =(Convert.ToString(TeamsGame.Games(Teams)))!.Split("\n");  
StringBuilder RHgame = new();
for (int i = 0; i < Games.Length-1; i++)
{
    RHgame.Append(RandomHome.RandomHomeGame(Games[i])+"\n");
}
string[] RandomHomegame = (Convert.ToString(RHgame))!.Split("\n"); 
StringBuilder  Randomgame = new();
for (int i = 0; i < RandomHomegame.Length-1; i++)
{
   Randomgame.Append(RandomHomegame[i]+"\n");
} 

Console.WriteLine(RandomMath.RandomMathes(Randomgame));
Console.BackgroundColor=ConsoleColor.Red;
Console.WriteLine("It all depends on your luck");
Console.ResetColor();
}
catch (Exception e)
{
    Console.WriteLine($"Error is : {e.Message}");
}
