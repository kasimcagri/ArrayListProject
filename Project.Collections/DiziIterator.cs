using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Collections
{
    public class DiziIterator : IDiziIterator
    {
        private readonly object[] dizi;
        private int pozisyon;

        public DiziIterator(object[] dizi)
        {
            this.dizi = dizi;
            this.pozisyon = -1;
        }
        public object SimdikiKonum => dizi[pozisyon];

        public bool İlerle()
        {
            if (++pozisyon == dizi.Length) return false;
            return true;
        }
    }
}
