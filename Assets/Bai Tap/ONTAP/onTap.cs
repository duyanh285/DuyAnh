using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTap : MonoBehaviour
{
   /* int a = 4;
    int b = 2;
    int c = 7;*/
    // Start is called before the first frame update
    void Start()
    {
        /* if (c == 3)
         {
             int tong = a + b;
             Debug.Log("Giai tri cua c = 3 la dung " + "tong = "+ tong);
         }
         else if (c == 7)
         {
             int hieu = a - b;
             Debug.Log("Giai tri cua c = 7 la sai "+"hieu = " + hieu);
         }
         else
         {
             int tich = a * b;
             Debug.Log("Giai tri cua a ko biet " + tich);
         }*/

        //TinhToan(2, 5, 1);
        tinhtong(2,1,1);
        bt2(1, 1);//chuyen a va b 
        float ketqua = Tinhtich(2,3);
        // Tinhtich(2, 6);
        Debug.Log(ketqua);
    }

    //ham 
    void TinhToan(int a, int b, int pheptinh)
    {
        float ketqua = 0;
        switch (pheptinh)
        {
            case 1:
                ketqua = a + b;
                //Debug.Log(ketqua);
                break;
            case 2:
                ketqua = a - b;
                // Debug.Log(ketqua);
                break;
            case 3:
                ketqua = (float)a / b;
                // Debug.Log(ketqua);
                break;
            case 4:
                ketqua = a * b;
                // Debug.Log(ketqua);
                break;
            default:
                Debug.Log("khong co phep tinh nay");
                break;
        }
        Debug.Log($"Ket qua phep tinh : {ketqua}");
    }

    const float bt = 1;

    void tinhtong( int a, int b, int pheptinh)
    {
        int ketqua = 0;
        switch (pheptinh)
        {
            case 1:
               // var tinhtong = (a + b);
                ketqua = a + b;
                break;
        }
        Debug.Log(ketqua);         
    }

    void bt2(int a,int b)
    {
        if (a == b)
            Debug.Log("xin chao");
        else
            Debug.Log("xin loi");
    }

    /*int tinhtong(int tinhtong, int a, int b)
    {
        Debug.Log("TINH TONG " + tinhtong);
    }*/

    float Tinhtich(int a,int b)
    {
        float ketqua = 0;
        ketqua = a * b;
        return ketqua;       
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
