using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using personel;

namespace cs_linQ
{
    internal class ComparePersonel : IComparer<Personel>
    {
        public int Compare(Personel? x, Personel? y)
        {
            //Adlar aynı değilse adlara göre karşılaştırma yapar.
            //Aynıysa soyadlara göre yapacak. dİREK OrderBy içerisinde yapsaydık tüm verileri gezmemiz gerekirdi ama 
            //Bu yöntem ile sadece ilgili veri için burası kullanılacak.
            if(x.Ad != y.Ad){
                return string.Compare(x.Ad, y.Ad);
            }else{
                return string.Compare(x.Soyad, y.Soyad);
            }
        }
    }
}