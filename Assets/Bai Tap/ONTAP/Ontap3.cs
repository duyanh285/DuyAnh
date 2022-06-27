using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontap3 : MonoBehaviour
{
    //mang
    // 12 34 2 5 8 0 10

    //int[] mang = new int[100];
    int[] mang2 = new int[] { 1, 2, 2, 5, 8, 2, 10 };
    int[] mang3 = { 12, 34, 2, 5, 8, 0, 10, 9 };

    float[,] mang2chieu =
    {
    {2f,4f,6f,7f},
    {6f,4f,5f,8f},
    {9f,4f,6f,7f} ,
    {10f,4f,6f,7f}
    };


    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(mang3[0]);

        /* for (int i = 0; i < mang3.Length; i++)
         {
             Debug.Log(mang3[i]);
         }*/

        int dem = 0;
        int tong = 0;
        /* while (dem < mang2.Length)
         {
             tong += mang2[dem];

             Debug.Log(mang2[dem]);
             dem++;
             Debug.Log("tong = " + tong);
         }*/

        /* while (dem < mang2.Length)
         {
             if (mang2[dem] % 2 == 0)
             {
                 Debug.Log("so chan" + mang2[dem]);
             }
         }*/


        //vong lap 1 duyet mang 1
        //vong lap 2 duyet mang 2
        //vong lap n duyet mang n
        float tong2 = 0;
        /* for (int i = 0; i < mang2chieu.GetLength(0); i++)
         {

             for (int j = 0; j < mang2chieu.GetLength(1); j++)
             {
                 tong2 = tong2 + mang2chieu[i, j];
                // Debug.Log(mang2chieu[i, j]);

                 Debug.Log(tong2);
             }
         }*/

        int dong = 0;
        int cot = 0;

        while (dong < mang2chieu.GetLength(0))
        {
            cot = 0;
            while (cot < mang2chieu.GetLength(1))
            {
                Debug.Log(mang2chieu[dong, cot]);
                cot++;
            }
            dong++;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
