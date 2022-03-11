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
            dictionaryKey = new T[0];
            dictionaryValue = new U[0];
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

                keyTempArray = dictionaryKey;//yedek diziye aktarılıyor..
                dictionaryKey = new T[dictionaryKey.Length+1];//dictionarykey eleman sayısı bir arttırılıyor.
                for (int i = 0; i < (dictionaryKey.Length-1); i++)//Keyleri eklemek için döngü..
               
                keyTempArray = dictionaryKey;//yedek diziye aktarılıyor..
                dictionaryKey = new T[dictionaryKey.Length+1];//dictionarykey eleman sayısı bir arttırılıyor.
                for (int i = 0; i < dictionaryKey.Length-1; i++)//Keyleri eklemek için döngü..
                {
                    dictionaryKey[i] = keyTempArray[i];//kopya diziyi aktarıyor..
                }
                dictionaryKey[dictionaryKey.Length - 1] = key;//yeni girilen keyi ekliyor..

                valueTempArray = dictionaryValue;//Değerleri yedekliyor..
                dictionaryValue = new U[dictionaryValue.Length + 1];

                
                for (int i = 0; i < dictionaryValue.Length-1; i++)//elemanalrı eklemek için döngü..

                {
                      dictionaryValue[i] = valueTempArray[i];//kopya diziyi aktarıyor..
                }
                dictionaryValue[dictionaryValue.Length - 1] = value;//girilen yeni değeri ekliyor..
            }
        }
        public void Yazdır()
        {
            for (int i = 0; i < dictionaryKey.Length; i++)
            {
                Console.WriteLine(dictionaryKey[i].ToString() + dictionaryValue[i].ToString());
            }
            
        }
    }
}
