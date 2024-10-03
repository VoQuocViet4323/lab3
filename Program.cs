internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap chieu rong hinh chu nhat");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu cao hinh chu nhat");
        double height = double.Parse(Console.ReadLine());  
        double chuvi = (width + height) * 2;
        double dientich = width * height;
        Console.WriteLine($"Chu vi hinh chu nhat la: {chuvi}");
        Console.WriteLine($"Dien tich hinh chu nhat la: {dientich}");
    }
}