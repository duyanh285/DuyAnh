using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CHUABAI43 : MonoBehaviour
{
    // KHAI BAO KIEU THU 3
    int[] array = { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5 };

    int[,] array2=
      {
        { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5},
        {7, 3, 0, 9, 1, 8, 6, 10, 11, 17 },
        {10, 21, 1, 3, 5, 9, 2, 4, 12, 18 }
      };
    // Start is called before the first frame update
    void Start()
    {
        //TimSoGiongNhau2(Array2);
        var temArr = TimSoGiongNhau2Tra(array2);
        for (int i = 0; i < temArr.Length; i++)
        {
            Debug.Log(temArr[i]);
        }
    }

   /* void TimSoGiongNhau2(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                var pt01 = array[i, j];

                for (int k = 0; k < array.GetLength(0); k++)
                {
                    for (int l = 0; l < array.GetLength(1); l++)
                    {
                        var pt02 = array[k, l];

                        if (pt01 == pt02 && i != k && j != l)

                            Debug.Log($"Phan tu trung nhau la {pt01}");
                    }
                }
            }
        }
    }*/


    int[] TimSoGiongNhau2Tra (int[,] array)
    {
        int[] ketqua = new int[array.GetLength(0)];
        int count = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                var pt01 = array[i,j];

                for (int k = 0; k < array.GetLength(0); k++)
                {
                    for (int l = 0; l < array.GetLength(1); l++)
                    {
                        var pt02 = array[k, l];

                        if (pt01 == pt02 && i != k && j != l)
                        {
                            Array.Resize(ref ketqua, count + 1);
                            ketqua[count] = pt01;
                            count++;
                        }
                          
                    }
                }
            }
        }
        return ketqua;
    }
    
}
