using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DA.Homeworks.buoi4
{
/*
 1) Tìm các số giống nhau trong mảng in ra màn hình 0
 2) Tìm các số duy nhất trong mảng in ra màn hình
 3) Tìm các số chẵn trong mảng in ra màn hình  0
 4) Tìm các số lẻ trong mảng in ra màn hình 0
 5) Tính tổng tất cả các số trong mảng in ra màn hình 0
 6) Tính tích tất cả các số trong mảng in ra màn hình. 0
*/

}

public class BTB4 : MonoBehaviour
{
    //tìm các số giống nhau trong mảng 
    int[] Array1 = new int[] { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5 };

    int[,] Array2 = new int[,]
    {
        { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5},
        {7, 3, 0, 9, 1, 8, 6, 10, 11, 17 },
        {10, 21, 1, 3, 5, 9, 2, 4, 12, 18 }
    };
    // Start is called before the first frame update
    void Start()
    {
      /*  SoGiongNhau();
        TongCacPhanTu();
        CacSoChan();
        CacSoLe();
        TichCacPhantu();*/

        //SoPhanTuDuyNhat();

        /* for (int i = 0; i < Array2.GetLength(0); i++)
         {
             for (int j = 0; j < Array2.GetLength(1); j++)
             {
                 Debug.Log(Array2[i, j]);
             }
         }*/
    }

    void SoGiongNhau()
    {
        int  j,  count = 0;
        for (int i = 0; i < Array1.Length; i++)
        {
            for (j = i + 1; j < Array1.Length; j++)
            {
                if (Array1[i]==Array1[j])
                {
                    count++;
                    break;
                }
            }
        }
        Debug.Log($"So giong nhau : {count}");
    }


    void CacSoChan()
    {
        for (int i = 0; i < Array1.Length; i++)
        {
            if (Array1[i] % 2 == 0)
            {
                Debug.Log("so chan"+ Array1[i] + " ");
            }
        }
    }

    void CacSoLe()
    {
        for (int i = 0; i < Array1.Length; i++)
        {
            if (Array1[i] % 2 != 0)
            {
                Debug.Log("so le" + Array1[i] + " ");
            }
        }
    }


    void TongCacPhanTu()
    {
        int i, sum = 0;
        for (i = 0; i < Array1.Length; i++)
        {
            sum += Array1[i];
        }
        Debug.Log($"tong :{sum}");
    }

    void TichCacPhantu()
    {
        int i, temp = 1;
        for (i = 0; i < Array1.Length; i++)
        {
            temp *= Array1[i];

        }
        Debug.Log($"tong :{temp}");
    }

    /*void SoPhanTuDuyNhat()
    {
        int count = 0;
        int i, j, k;

        for (i = 0; i < Array1.Length; i++)
        {
            count = 0;

            for (j = 0; j < i - 1; j++)
            {
                if (Array1[i] == Array1[j])
                {
                    count++;
                }
            }               
        }

        for (k = i + 1; k < Array1.Length; k++)
        {
            if (Array1[i] == Array1[k])
            {
                count++;
            }
        }


        if (count == 0)
        {
            Debug.Log($"So giong nhau : {Array1[i]}");
        }


    }*/



}
