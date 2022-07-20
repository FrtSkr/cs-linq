using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using personel;
namespace cs_linQ
{
    public class CompareEqualityPersonel : IEqualityComparer<Personel>
    {   
        //PersonelNo ya göre gruplama işleminin genelleştirilmiş hali.
        bool IEqualityComparer<Personel>.Equals(Personel? x, Personel? y)
        {
        
            if(x.PersonelNo == y.PersonelNo) return true;

            else return false;
        }


        int IEqualityComparer<Personel>.GetHashCode(Personel obj)
        {
           return obj.PersonelNo.GetHashCode();
        }
    }
}