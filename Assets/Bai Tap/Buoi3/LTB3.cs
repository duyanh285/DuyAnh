using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LTB3 : MonoBehaviour
{
    /*  dynamic dynamicValue;

      int a;
      int b;*/
    //int a;
    public string s = "b";
    // Start is called before the first frame update
    void Start()
    {
        // int a = 55;

        // hena(a,s);
        //Debug.Log(a);
        /*var temp = "udev";
        var ad = 5.5f;*/

        /* dynamicValue = "hoc tap";
         dynamicValue++;
        */

        /* for (int i = 0; i < 5; i++)
         {
             // cac cau lenh  
             Debug.Log("lan lap thu n" + i);
         }*/


        /* while( (a + b)< 20)
         {
             a++;
             b += a;
             Debug.Log($"a={a},b={b}");
         }*/
        /*  a = 5;
          b = 10;

          do
          {
              a++;
              b += a;
              Debug.Log($"A={a},b={b}");

          }
          while ((a + b) < 20);*/
        //string s = " heloo";
        int a = 1;
        int b = 2;
        int h = tinhtongSonguyen(a, b);
        Debug.Log(h);
        Debug.Log(s);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void hena( int a,string str = "helo")
    {
        // Debug.Log(str + a);
        a++;
    }
    public int tinhtongSonguyen(int a, int b)
    {
       // float c = 0;
        return a + b;
    }
}
