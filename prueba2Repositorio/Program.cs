public class Program
{
    private static void Main(string[] args)
    {

        double seg1, seg2, seg3, suma;
        bool isTriangle;
        string msj;

        Console.Write("INgrese el primer segmento: ");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("INgrese el segundo segmento: ");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("INgrese el tercer segmento: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        if ((seg1 + seg2) > seg3)
        {
            if ((seg1 + seg3) > seg2)
            {
                if ((seg1 + seg3) > seg1)
                {
                    isTriangule = true;
                }
                else
                {
                    isTriangule = false;
                }
            }
            else
            {
                isTriangule = false;
            }
        }
        else
        {
            isTriangule = false;
        }
    }
}
