using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHUABT : MonoBehaviour
{
    void TinhToan(int a,int b,int pheptinh)
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
                ketqua = (float) a / b;
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


    float TinhToanTraVe(int a, int b, int pheptinh)
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
              //  Debug.Log("khong co phep tinh nay");
                break;
        }
        Debug.Log($"Ket qua phep tinh : {ketqua}");
        return ketqua;
    }
    // Start is called before the first frame update
    void Start()
    {
        //TinhToan(4, 8 , 6);
        float ketqua = TinhToanTraVe(4, 8, 1);
        Debug.Log(ketqua);
    }

    // Update is called once per frame
    
}
