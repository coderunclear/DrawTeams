
using System.Diagnostics;
using System.Text;

namespace DrawTeams.Classes
{
  public class TeamsGame
 {
   public static StringBuilder games =new(); 

   public static StringBuilder Games(string[] Teams)
   {
    for (int i = 1; i < Teams.Length; i++)
    {
     games.Append( Teams[0]+" VS "+Teams[i]+"\n");
     switch(i) 
      {
       case 2:
         for (int b = 2; b < Teams.Length;b++)
             {
                 games.Append( Teams[1]+" VS "+Teams[b]+"\n");
             }
         break;
       case 3:
         for (int b = 3; b < Teams.Length;b++)
             {
                 games.Append( Teams[2]+" VS "+Teams[b]+"\n");
             }
       break;
       case 4:
       for (int b = 4; b < Teams.Length;b++)
           {
               games.Append( Teams[3]+" VS "+Teams[b]+"\n");
           }
       break;
       case 5:
       for (int b =5; b < Teams.Length;b++)
           {
               games.Append( Teams[4]+" VS "+Teams[b]+"\n");
           }
       break;
       case 6:
       for (int b =6; b < Teams.Length;b++)
           {
               games.Append( Teams[5]+" VS "+Teams[b]+"\n");
           }
       break;
       case 7:
       for (int b =7; b < Teams.Length;b++)
           {
               games.Append( Teams[6]+" VS "+Teams[b]+"\n");
           }
       break;
       case 8:
       for (int b =8; b < Teams.Length;b++)
           {
               games.Append(Teams[7]+" VS "+Teams[b]+"\n" );
           }
       break;
       default:
       break;
      }

    }
    return (games);
   }
 }
}