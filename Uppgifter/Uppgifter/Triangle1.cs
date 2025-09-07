using System.Text;

public static class Triangle1
{
    public static string CreateWithSize(int size)
    {
        string stars = ("");
        string star = ("*");

        for (int i = 1; i <= size; i++)
        {
            stars += star;

            if(i >= 1)
                Console.Write($"{stars}\n");
        }


        return "";
    }
}