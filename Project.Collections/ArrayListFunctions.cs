using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Collections
{
    public class ArrayListFunctions : IFunctions
    {
        protected object[] _dizi;

        object[] diziIsimler = { "Ahmet", "Çağrı", "Mehmet" };
        public ArrayListFunctions() => _dizi = new object[0];

        public object this[int index] { get => _dizi[index]; set => _dizi[index] = value; }

        public int ElemanSayisi => _dizi.Length;


        public int BastanAra(object[] array, object value) //IndexOf
        {
            int result = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return result;
        }

        public void DiziCevir(object[] array)//reverse
        {
            var yedekdizi = array;
            int arrayIndex = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[arrayIndex] = yedekdizi[i];
                arrayIndex++;
            }
            Console.WriteLine(array[0]);
        }

        public void Ekle(object eleman)//add
        {
            var yedekDizi = _dizi;
            _dizi = new object[yedekDizi.Length + 1];
            _dizi[yedekDizi.Length] = eleman;
            Kopyala(_dizi, yedekDizi);

        }

        public object[] ElemanAraSil(object[] array, object eleman)//removeall
        {
            int indeks = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == eleman)
                    indeks = i;
            }

            var yedekDizi = array;
            array = new object[yedekDizi.Length - 1];
            int sayac = 0;
            for (int y = 0; y < yedekDizi.Length; y++)
            {
                if (indeks == y)
                    continue;

                array[sayac] = yedekDizi[y];
                sayac++;
            }
            return array;
        }

        public void Kopyala(object[] dizi1, object[] dizi2)//copyto
        {
            for (int i = 0; i < dizi2.Length; i++)
            {
                dizi1[i] = dizi2[i];
            }
        }


        public void Sil(int index)//remove
        {
            var yedekDizi = _dizi;
            _dizi = new object[yedekDizi.Length - 1];
            int sayac = 0;
            for (int i = 0; i < yedekDizi.Length; i++)
            {
                if (i == index)
                    continue;

                _dizi[sayac] = yedekDizi[i];
                sayac++;
            }
        }

        public int SondanAra(object[] array, object value)//lastindexof
        {
            int result = -1;
            int count = 0;
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] == value)
                {
                    return count;
                }
                count++;
            }
            return result;
        }

        public void Temizle()
        {
            _dizi = new object[0];
        }

        public IDiziIterator DiziIterator() //Iterator desig pattern
        {
            return new DiziIterator(_dizi);
        }


    }
}
