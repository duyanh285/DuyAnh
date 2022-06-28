using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
            /* SoGiongNhau(Array1);
             SoGiongNhauTraVe(Array1);*/

            /*  SoPhanTuDuyNhat(Array1);
              SoPhanTuDuyNhatTraVe(Array1);*/

            /* CacSoChan();
             CacSoChanTraVe(Array1);*/

            /* CacSoLe();
              CacSoLeTraVe(Array1);*/

            /* TongCacPhanTu();
             TongCacPhanTuTraVe(Array1);

             TichCacPhantu();
             TichCacPhantuTraVe(Array1);
 */

            /* for (int i = 0; i < Array2.GetLength(0); i++)
             {
                 for (int j = 0; j < Array2.GetLength(1); j++)
                 {
                     Debug.Log(Array2[i, j]);
                 }
             }*/

            SoGiongNhau2c(Array2);
            var temArr = SoGiongNhau2TV(Array2);
            for (int i = 0; i < temArr.Length; i++)
            {
                Debug.Log(temArr[i]);
            }

        }
        int[] SoGiongNhau2TV(int[,] Array2)
        {
            int[] kp = new int[Array2.GetLength(0)];

            int count = 0;

            for (int i = 0; i < Array2.GetLength(0); i++)
            {
                for (int j = 0; j < Array2.GetLength(1); j++)
                {
                    var pt1 = Array2[i, j];

                    for (int k = 0; k < Array2.GetLength(0); k++)
                    {
                        for (int l = 0; l < Array2.GetLength(1); l++)
                        {
                            var pt2 = Array2[k, l];

                            if (pt1 == pt2 && (i != k && j != l))
                            {
                                Array.Resize(ref kp, count+1);
                                kp[count] = pt1;
                                count++;
                            }
                        }
                    }
                }
            }
            return kp;
        }

        void SoGiongNhau2c(int[,] Array2)
        {
            for (int i = 0; i < Array2.GetLength(0); i++)
            {
                for (int j = 0; j < Array2.GetLength(1); j++)
                {
                    var pt1 = Array2[i, j];

                    for (int k = 0; k < Array2.GetLength(0); k++)
                    {
                        for (int l = 0; l < Array2.GetLength(1); l++)
                        {
                            var pt2 = Array2[k, l];
                            if (pt1 == pt2 && (i != k && j != l))
                                Debug.Log($"Phan tu giong nhau la : {pt1} ");

                        }
                    }
                }
            }
        }
           

        void SoGiongNhau(int[] Array1)
        {
            //1c
            for (int i = 0; i < Array1.Length; i++)
            {
                var pt01 = Array1[i];
                for (int j = 0; j < Array1.Length; j++)
                {
                    var pt02 = Array1[j];
                    if (pt01 == pt02 && i == j)
                        Debug.Log($"So giong nhau : {pt01}");
                }
            }
        }

        int SoGiongNhauTraVe(int[] Array1)
        {
            int ketqua = 0;
            int j, count = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
                for (j = i + 1; j < Array1.Length; j++)
                {
                    if (Array1[i] == Array1[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Debug.Log($"So giong nhau tra ve : {count}");
            return ketqua;
        }


        void SoPhanTuDuyNhat(int[] Array1)
        {
            for (int i = 0; i < Array1.Length; i++)
            {
                var pt01 = Array1[i];
                int count = 0;

                for (int j = 0; j < Array1.Length; j++)
                {
                    var pt02 = Array1[j];
                    if (i != j && pt01 == pt02)
                    {
                        count++;
                    }
                }
                if (count == 0)
                    Debug.Log($"SO day nhat trong mang la {pt01}");
            }
        }

        int SoPhanTuDuyNhatTraVe(int[] Array1)
        {
            int ketqua = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
                var pt01 = Array1[i];
                int count = 0;

                for (int j = 0; j < Array1.Length; j++)
                {
                    var pt02 = Array1[j];
                    if (i != j && pt01 == pt02)
                    {
                        count++;
                    }
                }
                if (count == 0)
                    Debug.Log($"SO day nhat trong mang la {pt01}");
            }
            return ketqua;
        }

        void CacSoChan()
        {
            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[i] % 2 == 0)
                {
                    Debug.Log("so chan" + Array1[i] + " ");
                }
            }
        }
        int CacSoChanTraVe(int[] Array)
        {
            int ketqua = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[i] % 2 == 0)
                {
                    Debug.Log("so chan tra ve" + Array1[i] + " ");
                }
            }
            return ketqua;
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


        int CacSoLeTraVe(int[] Array1)
        {
            int ketqua = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[i] % 2 != 0)
                {
                    Debug.Log("so le tra ve " + Array1[i] + " ");
                }
            }
            return ketqua;
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


        int TongCacPhanTuTraVe(int[] Array1)
        {
            int ketqua = 0;
            int i, sum = 0;
            for (i = 0; i < Array1.Length; i++)
            {
                sum += Array1[i];
            }
            Debug.Log($"tong tra ve :{sum}");
            return ketqua;
        }


        void TichCacPhantu()
        {
            int i, temp = 1;
            for (i = 0; i < Array1.Length; i++)
            {
                temp *= Array1[i];

            }
            Debug.Log($"tich  :{temp}");
        }

        int TichCacPhantuTraVe(int[] Array1)
        {
            int ketqua = 0;
            int i, temp = 1;
            for (i = 0; i < Array1.Length; i++)
            {
                temp *= Array1[i];

            }
            Debug.Log($"tich tra ve :{temp}");
            return ketqua;
        }

    }

}
