using System;
using  personel;
using proje;
namespace cs_linQ{
    internal class Program {
        static void Main(string[] args){
#region LINQ
// LinQ, programlama dili içerisinde sql sorguları yazmamızı sağlayan ve bunu daha da basitleştiren bir teknolojidir.

var sayilar = new int[] {1, 2, 3, 11, 12, 13};
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

        var personeller =new List<Personel> {
        new Personel() {Ad = "TestAd1", Soyad = "TestSoyad1", PersonelNo = 1},
        new Personel() {Ad = "TestAd1", Soyad = "TestSoyad2", PersonelNo = 2},
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

        // var sonuc = personeller.GroupBy(x => x, new CompareEqualityPersonel());
        
        //  foreach(var x in sonuc){
        //     Console.WriteLine("GROUP: "+ x.Key.PersonelNo);
        //     foreach(var y in x){
        //         Console.WriteLine(y.Ad+' '+y.Soyad);
        //     }
        // }


     var projeler =new List<Proje> {
        new Proje() {ProjeAd = "ProjeAd1", ProjeId = 1},
        new Proje() {ProjeAd = "ProjeAd2", ProjeId = 2},
        new Proje() {ProjeAd = "ProjeAd4", ProjeId = 1},
        new Proje() {ProjeAd = "ProjeAd3", ProjeId = 3}};

    //Join
    //Aşağıdaki join işleminden dönecek sonuç için yeni bir özelleştirilmiş obje kullandık. Dinamik model.
    // var sonuc = from x in personeller 
    //             join y in projeler on x.ProjeId equals y.ProjeId
    //             select new {Ad = x.Ad + ' ' + x.Soyad, ProjeAd = y.ProjeAd};

    // var sonuc2 = personeller.Join(projeler, x => x.ProjeId, y => y.ProjeId, (x, y) => new {Ad = x.Ad + ' ' + x.Soyad, ProjeAd = y.ProjeAd});


//!!! Aşağıda sonuc değişkenine linQ sorgumuzdan dönen cevabı kaydettik daha sonra sayilar değişkeninin değerleriyle oynadık ve sonuc değişkenini foreach ile çağırıp kullandık
//LinQ sorgusu sonuc değişkenine atandı fakat hemen çağrılmadı. Çağrılması için sonuc değişkenini kullanmamız gerekir. 
//Bu yüzden sayilar değişkeninin değeri değiştiğinde sonuc değişken değerleri de değişecektir. !!!
    // var sonuc = from x in sayilar where x < 10 select x;
    //Aşağıdaki şekilde kullanırsak, sorgunun yazıldığı noktada süreç işleyecek ve sonuçlar sonuc2 değişkenine kayıt olacaktır.
    // var sonuc2 = (from x in sayilar where x < 10 select x).ToList();

    // for(int i = 0; i < sayilar.Length; i++){
    //     sayilar[i] = sayilar[i] - 10;
    // }


    //Baştan iki veri Adını getirir.
    // var sonuc = (from x in personeller select x.Ad).Take(2);
    // var sonuc2 = personeller.Take(2).Select(x => x.Ad);

    //İki tane atladıktan sonra kalan verilerin Adını getir.
    // var sonuc = (from x in personeller select x.Ad).Skip(2);

    //PersonelNo 4 ten küçük olan kayda kadar getir.
    // var sonuc = (from x in personeller select x).TakeWhile(x => x.PersonelNo < 4);

    //Personelleri Ad'a göre unicleştirir yani birden fazla aynı değerder varsa tek'e indirger.
    var sonuc = (from x in personeller select x.Ad).Distinct();
    
    foreach (var x in sonuc)
    {
        Console.WriteLine(x);
        
    }





#endregion

    }
}

}



