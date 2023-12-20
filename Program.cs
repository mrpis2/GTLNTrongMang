using System.ComponentModel.DataAnnotations;

class Program
{
    private static void Main(string[] args)
    {
        int n = 0;
        do
        {
            Console.WriteLine("Nhap chieu dai mang");
            n = int.Parse(Console.ReadLine());
            if (n > 20) Console.WriteLine("Nhap Lai");

        } while (n > 20);
        int[] mang = new int[n];
        Console.WriteLine("Nhap cac gia tri trong mang: ");
        for (int i = 0; i <= mang.Length-1; i++)
        {
            mang[i] = int.Parse (Console.ReadLine());
        }
        Console.WriteLine("Cac gia tri trong mang la: ");
        for (int i = 0; i <= mang.Length - 1; i++)
        {
            Console.Write(mang[i] + "  ");
        }
        Console.WriteLine(" ");
        int max = 0;
        int x = 0;
        for (int i = 0;i <= mang.Length - 1;i++)
        {
            if (mang[i] > max)
            {
                max = mang[i];
                x= i;
            }
        }
        Console.WriteLine("Gia tri lon nhat trong mang la: " +max + ", vi tri so: "+ (x+1));



    }
}