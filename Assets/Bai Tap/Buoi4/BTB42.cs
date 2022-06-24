using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DA.HameWorks.buoi4
{
    /*
     1) Tìm các số giống nhau trong mảng in ra màn hình 0
     2) Tìm các số duy nhất trong mảng in ra màn hình
     3) Tìm các số chẵn trong mảng in ra màn hình  0
     4) Tìm các số lẻ trong mảng in ra màn hình 0
     5) Tính tổng tất cả các số trong mảng in ra màn hình 0
     6) Tính tích tất cả các số trong mảng in ra màn hình. 0
    */

    public class BTB42 : MonoBehaviour
    {
        int[,] array2 =
      {
        { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5},
        {7, 3, 0, 9, 1, 8, 6, 10, 11, 17 },
        {10, 21, 1, 3, 5, 9, 2, 4, 12, 18 }
      };

        // Start is called before the first frame update
        void Start()
        {
            /*TimSGN2(array2);

            var temArr = TimSGN2TraVe(array2);
            for (int i = 0; i < temArr.Length; i++)
            {
                Debug.Log(temArr[i]);
            }*/


            // CacSC2(array2);
            // CacSL2(array2);
            //TongCacPT2(array2);
            TichCacPT2(array2);

        }

       void TimSGN2(int[,]array2)
        {
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    var pt01 = array2[i, j];

                    for (int k = 0; k < array2.GetLength(0); k++)
                    {
                        for (int l = 0; l < array2.GetLength(1); l++)
                        {
                            var pt02 = array2[k, l];

                            if (pt01 == pt02 && i != k && j != l)

                                Debug.Log($"Phan tu giong nhau {pt01}");

                        }
                    }
                } 
            }
        }


        int[] TimSGN2TraVe(int[,] array2)
        {
            int[] ketqua = new int[array2.GetLength(0)];
            int count = 0; 

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    var pt01 = array2[i, j];

                    for (int k = 0; k < array2.GetLength(0); k++)
                    {
                        for (int l = 0; l < array2.GetLength(1); l++)
                        {
                            var pt02 = array2[k, l];

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


        void CacSC2(int[,] array2)
        {
            
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    var pt01 = array2[i, j];

                    if (pt01 % 2 == 0)
                    {
                        Debug.Log("so chan tra ve" + pt01 + " ");
                    } 
                }  
            }
        }


        void CacSL2(int[,] array2)
        {

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    var pt01 = array2[i, j];

                    if (pt01 % 2 != 0)
                    {
                        Debug.Log("so LE tra ve" + pt01 + " ");
                    }
                }
            }
        }


        void TongCacPT2(int[,] array2)
        {
             int sum = 0;
            for (int i = 0; i < array2.GetLength(0); i++)
            {

                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    var pt01 = array2[i, j];

                    sum += pt01;
                    Debug.Log($"tong :{sum}");
                }
             
            }
        }


        void TichCacPT2(int[,] array2)
        {
            int tich = 1;
            for (int i = 0; i < array2.GetLength(0); i++)
            {

                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    var pt01 = array2[i, j];

                    tich *= pt01;
                   
                }
                Debug.Log($"tong :{tich}");
            }
        }
    }
}
