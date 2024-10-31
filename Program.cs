using System;

public class Program
{
    public static void Main(string[] args)
    {
       // Out Parametreler
        string sayi="997";
        bool sonuc = int.TryParse(sayi, out int outSayi); // outSayi yı dışarıda da tanımlayabiliriz.
        if(sonuc)
        {
            Console.WriteLine("Başarılı");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Başarılı değil");
        }

        Metotlar instance= new Metotlar();
        instance.Topla(4,5, out int toplamSonuc);
        Console.WriteLine(toplamSonuc);

        //Metot Overloading / Aşırı Yükleme

        int ifade = 999;
        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir(ifade);

        instance.EkranaYazdir("Merhaba","Dünya");

        // Metot İmzası
        // metot adi + parametre sayisi + parametre tipi  
        // (Erişim belirteci, geri dönüş tipi metot imzasına dahil değildir.)
    }
    class Metotlar
    {
        public void Topla (int a, int b, out int toplam)
        {
            toplam=a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}