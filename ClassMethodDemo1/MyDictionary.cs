using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo1
{
    public class MyDictionary<T,K>
    {
        KeyValuePair<T, K>[] items; //KeyValuePair --> veri türü

        public MyDictionary() 
        {
            items = new KeyValuePair<T, K>[0];      
        }

        public void Add (T myKey, K myValue)
        {
            if (Control(myKey))
            {
                Configuration(myKey);
                items[items.Length - 1] = new KeyValuePair<T, K>(myKey, myValue); // "En son bize gelen değeri dizimize aktarıp işi bitirdik."
            }
            else
            {
                Console.WriteLine("Girdiğiniz key değeri özel olmalı. Yani daha önceden eklenmiş bir key değerini tekrardan kullanamassınız.");
            }

        }

        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }





        private void Configuration(T myKey)
        {
            KeyValuePair<T, K>[] tempArray = items;  // Geçici dizimizi oluşturduk
            items = new KeyValuePair<T, K>[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  //Geçici dizideki elemanları alıp asıl dizimize gri koyduk.
            }
        }

        private bool Control(T myKey)
        {
            bool control = true;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Key.ToString() == myKey.ToString())
                {
                    control = false;
                }
            }
            return control;
        }



        //Thanks to Tahiri


    }
}
