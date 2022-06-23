using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DA.HomeWorks.Day3
{
    /* Tính tổng số chẵn số, lẻ trong dãy số có số lớn nhất là n, in ra màn hình kết quả.
  Tính tổng các số trong dãy số có số lớn nhất là n, in ra màn hình kết quả
  Tìm số nguyên tố trong dãy số có số lớn nhất la n, in ra màn hình kết quả
  (Mỗi bài giải lần lượt với 3 vòng lặp - for, while, dowhile)*/

}



public class BTB32 : MonoBehaviour
{
    int[] scoredAr = { 1, 2, 4, 5, 7, 9, 11 };
    int[] scoredAr2 = { 1, 2, 3, 4, 5 };

    // Start is called before the first frame update
    void Start()
    {
        TongsoCL();

        tongSo();

        SoNguyenTo();
    }
    void TongsoCL()
    {
        //for
        int tsChan = 0;
        int tsLe = 0;
        int count = 0;
        for (int i = 0; i < scoredAr.Length; i++)
        {
            if (scoredAr[i] % 2 == 0)
                tsChan += scoredAr[i];
            else
                tsLe += scoredAr[i];
        }

        Debug.Log($" for: Tong so chan la 1 = {tsChan}");
        Debug.Log($" for:Tong so le la  1= {tsLe}");


        //while
        tsChan = 0;
        tsLe = 0;
        count = 0;
        while (count < scoredAr.Length)
        {
            if (scoredAr[count] % 2 == 0)
                tsChan += scoredAr[count];
            else
                tsLe += scoredAr[count];
            count++;
        }
        Debug.Log($" while: Tong so chan la 2= {tsChan}");
        Debug.Log($" while: Tong so le la2 = {tsLe}");

        //do-while

        tsChan = 0;
        tsLe = 0;
        count = 0;
        do
        {
            if (scoredAr[count] % 2 == 0)
                tsChan += scoredAr[count];
            else
                tsLe += scoredAr[count];
            count++;
        }
        while (count < scoredAr.Length);
        Debug.Log($"do-while: Tong so chan la 3 = {tsChan}");
        Debug.Log($"do-while: Tong so le la 3 = {tsLe}");
    }

    void tongSo()
    {
        //for
        int tong = 0;
        int count = 0;
        for (int i = 0; i < scoredAr.Length; i++)
        {
            tong += scoredAr[i];
        }

        Debug.Log($"for:Tong cac so 1 ={tong}");

        //while
        tong = 0;
        count = 0;
        while (count < scoredAr.Length)
        {
            tong += scoredAr[count];
            count++;
        }
        Debug.Log($"while:Tong cac co 2 = {tong}");


        tong = 0;
        count = 0;
        do
        {
            tong += scoredAr[count];
            count++;
        }
        while (count < scoredAr.Length);
        Debug.Log($"do-while:Tong cac co 3 = {tong}");
    }


    void SoNguyenTo()
    {
        //for
        string tapSNT = "";
        for (int i = 0; i < scoredAr.Length; i++)
        {
            if (scoredAr[i] < 2) continue;
            if (scoredAr[i] == 2 || scoredAr[i] == 3)
            {
                tapSNT += scoredAr[i] + ",";
                continue;
            }

            for (int j = 2; j < scoredAr[i]; j++)
            {
                if (scoredAr[i] % j == 0)
                    break;
                if (j == scoredAr[i] - 1)
                    tapSNT += scoredAr[i] + ","
                        ;
            }
        }
        Debug.Log($"For: So nguyen to la: [{tapSNT}]");

        //while
        tapSNT = "";
        int count = 0;
        while (count < scoredAr.Length)
        {
            if (scoredAr[count] < 2)
            {
                count++;
                continue;
            }
            if (scoredAr[count] == 2 || scoredAr[count] == 3)
            {
                tapSNT += scoredAr[count] + ",";
                count++;
                continue;
            }
            int i = 2;
            while (i < scoredAr[count])
            {
                if (scoredAr[count] % i == 0) break;
                if (i == scoredAr[count] - 1) tapSNT += scoredAr[count] + ",";
                i++;
            }
            count++;
        }
        Debug.Log($"While: So nguyen to la: [{tapSNT}]");

        //do-while
        tapSNT = "";
        count = 0;
        do
        {
            if (scoredAr[count] < 2)
            {
                count++;
                continue;
            }
            if (scoredAr[count] == 2 || scoredAr[count] == 3)
            {
                tapSNT += scoredAr[count] + ",";
                count++;
                continue;
            }
            int i = 2;
            while (i < scoredAr[count])
            {
                if (scoredAr[count] % i == 0) break;
                if (i == scoredAr[count] - 1) tapSNT += scoredAr[count] + ",";
                i++;
            }
            count++;
        }
        while (count < scoredAr.Length);
        Debug.Log($"do-While: So nguyen to la: [{tapSNT}]");
    }

}
