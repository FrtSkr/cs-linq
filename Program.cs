using System;
using  personel;
namespace cs_linQ{
    internal class Program {
        static void Main(string[] args){
#region LINQ
// LinQ, programlama dili içerisinde sql sorguları yazmamızı sağlayan ve bunu daha da basitleştiren bir teknolojidir.

// var sayilar = new int[] {1, 2, 3, 11, 12, 13};
//Orjinal syntax bu şekildedir. Bİr yazım syntax'ı daha var.
// var sonuc = from x in sayilar where x < 10 select x;

// foreach(var say in sonuc){
//     Console.WriteLine(say);
// }

//Bu da diğer syntax biçimidir. Yukarda yazdığımız sorguyla aynıdır.
// var sonuc = sayilar.Where(x => x < 10);

// foreach(var say in sonuc){
//     Console.WriteLine(say);
// }

        var personeller =new List<personel.Personel> {
        new Personel() {Ad = "TestAd1", Soyad = "TestSoyad1", PersonelNo = 1},
        new Personel() {Ad = "TestAd2", Soyad = "TestSoyad2", PersonelNo = 2},
        new Personel() {Ad = "TestAd4", Soyad = "TestSoyad4", PersonelNo = 1},
        new Personel() {Ad = "TestAd3", Soyad = "TestSoyad3", PersonelNo = 3}};

        //personeller içerisindeki herbir personele ait Ad alanına ulaşıp aldık.
        // var sonuc = from x in personeller select x.Ad;
        //Bu da bir diğer syntax tipi. Aynı sorguyu yapıyor. Aralarında bir performans farkı yoktur sadece daha kısa ve kullanışlı.
        // var sonuc2 = personeller.Select(x => x.Ad);

        //PersonelNo su 1 e eşit olan personelin adı.
        // var sonuc = from x in personeller where x.PersonelNo == 1 select x.Ad;
        //PersonelNo su 1 ve Adı TestAd2 olan personelin adını getirecektir. Aynı şekilde && ile de kullanılabilir.
        // var sonuc2 = personeller.Where(x => x.PersonelNo == 1 || x.Ad == "TestAd2").Select(x => x.Ad);
        
        //Order By
        // var sonuc = from x in personeller orderby x.Ad descending select x.Ad;
        // var sonuc2 = personeller.OrderBy(x => x.Ad).Select(x => x.Ad);

        //Sonuçları tersine verir fakat bir sıraya sokmadan.
        // var sonuc = personeller.Select(x => x.Ad).Reverse();

        // var sonuc = personeller.OrderBy(x=> x, new ComparePersonel()).Select(x => x.Ad);


        //Group By
        //PersonelNo ya göre veriler gruplandı.
        // var sonuc = from x in personeller group x by x.PersonelNo;

        //  foreach(var x in sonuc){
        //     Console.WriteLine("GROUP: "+ x.Key);
        //     foreach(var y in x){
        //         Console.WriteLine(y.Ad+' '+y.Soyad);
        //     }
        // }



        //into
        //Geçici tabloda gruplanan verilerin Key değerlerini tutar.
        // var sonuc = from x in personeller group x by x.PersonelNo into id select id.Key;
    
        //  foreach(var x in sonuc){
        //     Console.WriteLine(x);
        // }

        //PersonelNo 1 olanlara göre grupladık
        // var sonuc = from x in personeller group x by x.PersonelNo == 1;

        var sonuc = personeller.GroupBy(x => x, new CompareEqualityPersonel());

         foreach(var x in sonuc){
            Console.WriteLine("GROUP: "+ x.Key.PersonelNo);
            foreach(var y in x){
                Console.WriteLine(y.Ad+' '+y.Soyad);
            }
        }








        #endregion

    }
}

}



