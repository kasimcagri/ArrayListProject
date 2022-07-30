using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Collections
{
    public interface IFunctions
    {
        void Ekle(object eleman);

        void Sil(int index);

        void Temizle();

        int ElemanSayisi { get; }

        int BastanAra(object[] array, object value);

        int SondanAra(object[] array, object value);

        void DiziCevir(object[] array);

        object[] ElemanAraSil(object[] array, object eleman);

        void Kopyala(Object[] dizi1, Object[] dizi2);



        object this[int index]
        {
            get;
            set;
        }


    }
}
