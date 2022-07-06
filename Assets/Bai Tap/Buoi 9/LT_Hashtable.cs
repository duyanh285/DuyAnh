using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace DA.LT.B9
{
    public class LT_Hashtable : MonoBehaviour
    {
        private Hashtable hashtableDemo;
        private Hashtable hashtableDemo2;
        private Hashtable hashtableDemo3;

        // Start is called before the first frame update
        void Start()
        {
            hashtableDemo = new Hashtable();//chuyen suc chua hoac hashtable khac
            //hashtableDemo = new Hashtable(hashtableDemo2);//chuyen suc chua hoac hashtable khac
            hashtableDemo.Add("udev", 10);
            hashtableDemo.Add("siro","ten cua siro");
            hashtableDemo.Add("tung",12f);

            // Debug.Log(hashtableDemo["tung"]);

            var keys = hashtableDemo.Keys;
            var values = hashtableDemo.Values;

            /* foreach(var key in keys)
             {
                 Debug.Log(key);
             }


             foreach (var value in values)
             {
                 Debug.Log(value);
             }*/
            foreach (DictionaryEntry temp in hashtableDemo)
            {
                Debug.Log($"Key{temp.Key},Value{temp.Value}");
            }

            hashtableDemo.Add("hai", 4);

            foreach (DictionaryEntry temp in hashtableDemo)
            {
                Debug.Log($"Key{temp.Key},Value{temp.Value}");
            }

        }

    }
}
