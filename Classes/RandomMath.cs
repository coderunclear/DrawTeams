using System.Text;

namespace DrawTeams.Classes
{
    public class RandomMath
    {
        public static string RandomMathes(StringBuilder mathes){
            StringBuilder str = new();
            string[] RMathes = (Convert.ToString(mathes))!.Split("\n"); 
            List<int> RUN=Generater.Generate( RMathes.Length-2, RMathes.Length-1);
            foreach (var item in RUN)
                {
                   str.Append("     "+ RMathes[item]+"\n\n"); 
                }
            string output=(Convert.ToString(str))!;
            return (output);
        }
    }
}