using System.Collections;
using System.Collections.Generic;
using
    UnityEngine;

public class LTB4 : MonoBehaviour
{
    //mang 2 chieu
    // float[,]secondArray =  new float[2,5];
    /* float[,] secondArray = new float[,]
     {
        {1.2f,1.5f },
        {3.2f,2.5f },
        {6.2f,3.5f },

     };*/

    /*float[,] secondArray =
    {
       {1.2f,1.5f },
       {3.2f,2.5f },
       {6.2f,3.5f },
     };*/

    //float[,] secondArray;
    int[] secondArray = { 1, 5, 4, 67, 9 };

   // int[] scoreArray;
    //int[] scoreArray2;
    //int[] scoreArray = new int[10];
    //int[] scoreArray = new int[] { 1, 2, 3 };
    // int[] scoreArray = { 1, 2, 3 };

    // Start is called before the first frame update
    void Start()
    {

     /*   secondArray = new float[1, 5];
        secondArray = new float[,]
        {
             {1.2f,1.5f },
             {3.2f,2.5f },
             {6.2f,3.5f }
        };*/

        /* Debug.Log(secondArray.Length);

         Debug.Log($"so daong cua mang {secondArray.GetLength(0)},"+
             $"so cot cua mang {secondArray.GetLength(1)}");
         scoreArray = new int[] { 23, 58, 43, 99 };
         scoreArray = new int[] { 23, 58, 43, 99 };*/

        /* for (int i = 0; i < secondArray.GetLength(0); i++)
         {
             for(int j= 0; j < secondArray.GetLength(1); j++)
             {
                 Debug.Log(secondArray[i, j
                     ]);
             }
         }*/

        /*int row = 0;
       int col = 0;
        while (row < secondArray.GetLength(0))
        {
            col = 0;
            while (col < secondArray.GetLength(1))
            {
                Debug.Log(secondArray[row, col]);
                col++;
            }
            row++;
        }*/




        //scoreArray2 = new int[] { 1, 2, 3, 6 };
        /*        for (int i = 0; i < scoreArray.Length; i++)
                {
                    Debug.Log(scoreArray[i]);
                }*/

        int count = 0;
        /*  while(count<scoreArray.Length)
          {
              Debug.Log(scoreArray[count]);
              count++;
          }*/

        /* int count2 = 0;
         do
         {
             Debug.Log(scoreArray[count]);
             count2++;
         }
         while (count < scoreArray.Length);*/
        //Debug.Log(scoreArray2.Length);

        /*foreach(float temp in secondArray)
        {
            Debug.Log(temp);
        }
*/
        /*foreach ( temp in secondArray)
        {
            Debug.Log(temp);
        }*/

        for (int i = secondArray.Length-1; i >= 0; i--)
        {
            //Debug.Log(secondArray[i]);
            if (i > 0)
            {
                Debug.Log($"phan tu lien truoc cua {secondArray[i]} la: {secondArray[i - 1]}");
            }
            if(i<secondArray.Length-1)
            {
                Debug.Log($"phan tu lien sau cua {secondArray[i]} la: {secondArray[i + 1]}");
            }
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
