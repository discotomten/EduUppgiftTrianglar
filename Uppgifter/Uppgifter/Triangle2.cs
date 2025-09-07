using System.Text;

public static class Triangle2
{
    public static string CreateWithSize(int size)
    {
        
        string star = ("*");

        for (int i = size; i >= 1; i--)
        {
            
            string stars = ("");
            for (int j = 1; j <= i; j++)
            {
                stars += star;
            }
            Console.Write($"{stars}\n");
                  
        }

            return "";
    }
}