namespace DrawTeams.Classes
{
    public class RandomHome
    {
        public static string RandomHomeGame(string game){
            String[] Game = game.Split(" VS "); 
            Random random = new();
            byte ran =(byte)random.Next(0,2);
            int t1 =ran==0?0:1;
            int t2 =t1 ==0?1:0;
            return ($"{Game[t2]} VS {Game[t1]}");
        }
    }
}