using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontap2 : MonoBehaviour
{
    // Start is called before the first frame update

    //123456789 10 11 12
    // tim so chan
    // so chan chia cho 2
    void Start()
    {
        //while
        /* float dem = 0;
         while (dem < 1)
         {
             dem++;
             Debug.Log(dem);
         }

         //do - while
         float dem2 = 0;
         do
         {
             dem2++;
             Debug.Log(dem2);
         }
         while (dem2 < 10);*/

        /* int a = 1;
         int b = 1;

         int dem3 = 1;
         while ((a+b) < 29)
         {
             a += 4;
             b += 2;
             // dem3 = dem3 + 4;
             //dem++;
             //Debug.Log(dem3);
             Debug.Log(a + b);
         }*/
        //12345678
        /* for (int i = 0; i < 8; i++)
         {
             Debug.Log(i);
         }*/

        /* int kq = 0;
         for (int d = 5; d < 29; d = d + 4)
         {

             kq = kq + d;
             Debug.Log(kq);
         }*/

        /*int dem = 0;
        while (dem < 12)
        {
            dem++;
            Debug.Log("v1"+ dem);
        }*/

        /*for (int i = 0; i < 12; i++)
        {
            Debug.Log("v2"+ i);
        }*/


        for (int i = 1; i <= 12; i++)
        {
            if (i % 2 != 0)
            {
                Debug.Log("ko chia cho 2 =" + i);
              }
        }

        /* int a = 0;
         while (a < 12)
         {
             a++;
             if (a % 2 == 0)
             {
                 Debug.Log(a);
             }
         }*/
    }

    // Update is called once per frame
    void Update()
    {

    }
}
