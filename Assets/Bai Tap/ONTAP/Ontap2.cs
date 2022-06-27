using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontap2 : MonoBehaviour
{
    // Start is called before the first frame update
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

        int a = 1;
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
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
