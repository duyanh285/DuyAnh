using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHUABT2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TongChanLe(5);
        TongCacSo(5);
       Debug.Log( SoNguyenTo(5));
    }
    void TongChanLe(int n)
    {
        int tongChan = 0;
        int tongLe = 0;
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
                tongChan = tongChan + i;
            else
                tongLe = tongLe + i;
        }

        Debug.Log($"Tong cac so chan la {tongChan}");
        Debug.Log($"Tong cac so le la {tongLe}");

    }
   
    void TongCacSo(int n)
    {
        int tong = 0;
        for (int i = 0; i <= n; i++)
        {
            tong = tong + i;
        }
        Debug.Log($"Tong cac so la {tong}");
    }

    string SoNguyenTo(int n)
    {
        string tapSNT = "";
        for (int i = 0; i <= n; i++)
        {
            if (i < 2) continue;
            if (i == 2 || i == 3)
            {
                tapSNT += i + ",";
                continue;
            }

            for (int j = 2; j <= i; j++)
            {
                if (i % j == 0)
                    break;
                if (j == i - 1)
                    tapSNT += i + "," ;
            }
        }
        return tapSNT;
        //Debug.Log($"For: So nguyen to la: [{tapSNT}]");
    }
}
