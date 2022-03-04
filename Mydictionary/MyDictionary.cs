using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mydictionary
{
    internal class MyDictionary<T, U>
    {
        T[] dictionaryKey;
        U[] dictionaryValue;
        T[] keyTempArray;
        U[] valueTempArray;

        public MyDictionary()
        {
            dictionaryKey = new T[2];
            dictionaryValue = new U[2];
        }
        public void Add(T key, U value)
        {
            bool varmi = dictionaryKey.Contains(key);//Girilen anahtar değerini dizide arıyor..
            if (varmi)
            {
                Console.WriteLine("Bu öge zaten var");
            }
            else
            {
                Console.WriteLine(keyTempArray[1]);
                Console.WriteLine(keyTempArray[1]);
                keyTempArray = dictionaryKey;//yedek diziye aktarılıyor..
                dictionaryKey = new T[dictionaryKey.Length+1];//dictionarykey eleman sayısı bir arttırılıyor.
                for (int i = 0; i < dictionaryKey.Length; i++)//Keyleri eklemek için döngü..
                {
                    dictionaryKey[i] = keyTempArray[i];//kopya diziyi aktarıyor..
                }
                dictionaryKey[dictionaryKey.Length - 1] = key;//yeni girilen keyi ekliyor..

                valueTempArray = dictionaryValue;//Değerleri yedekliyor..
                dictionaryValue = new U[dictionaryValue.Length + 1];
                for (int i = 0; i < dictionaryValue.Length; i++)//elemanalrı eklemek için döngü..
                {
                      dictionaryValue[i] = valueTempArray[i];//kopya diziyi aktarıyor..
                }
                dictionaryValue[dictionaryValue.Length - 1] = value;//girilen yeni değeri ekliyor..
            }
        }
    }
}
