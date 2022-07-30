using Project.Collections;

public class Program 
{
    static void Main(string[] args) 
    {
        IFunctions kullan = new ArrayListFunctions();

        //liste.Ekle("Çağrı");
        //liste.Ekle("Ahmet");
        //liste.Ekle("Mehmet");
        //liste.Ekle("Arda");
        //liste.Ekle("Fikri");
        //Console.WriteLine("Eleman Sayısı: {0}", liste.ElemanSayisi);
        //Console.WriteLine("İlk Eleman: {0}", liste[0]);
        //liste.Sil(2);
        string[] dizi = { "Ahmet", "Çağrı", "Mehmet","Çağrı","Fikri" };
        //int sonuc = liste.BastanAra(dizi, "Hayri");
        //Console.WriteLine(sonuc);
        //int sonuc1 = liste.SondanAra(dizi, "Mehmet1");
        //Console.WriteLine(sonuc1);

        //liste.DiziCevir(dizi);


        //for (int i = 0; i < dizi.Length; i++)
        //{
        //    Console.WriteLine(dizi[i]);
        //}

        

        object[] yeniDizi = kullan.ElemanAraSil(dizi, "Çağrı");
        for (int i = 0; i < yeniDizi.Length; i++)
        {
            Console.WriteLine(yeniDizi[i]);
        }

        

        
        //var iterator = liste.DiziIterator();
        //while (iterator.İlerle())
        //{
        //    Console.WriteLine(iterator.SimdikiKonum);
        //}
        Console.ReadKey();
        
    }
}
