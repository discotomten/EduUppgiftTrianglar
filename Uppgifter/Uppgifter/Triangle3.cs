using System.Text;

public static class Triangle3
{
    public static string CreateWithSize(int size)
    {

        string star = ("*");
        string space = (" ");

        for (int i = 1; i <= size; i++)
        {

            string line = ("");

            for (int j = 1; j <= size - i; j++)
            {
                line += space;
                
            }    
            
            for(int j = 1; j <=(2 * i - 1); j++)
            {
                line += star;
            }

            Console.Write($"{line}\n");
            
        }
        return "";
    }
}