using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DA.HomeWorks.Day3
{

}
public class BTB31 : MonoBehaviour
{

    /*   Viết chương trình thực hiện các phép tính 2 số theo tham số truyền vào như sau:
   1 - Tính tổng
   2 - Tính hiệu
   3 - Tính thương
   4 - Tính tích
   (Switch Case)*/
    const int TONG = 1;
    const int HIEU = 2;
    const int THUONG = 3;
    const int TICH = 4;
    const int sai = 0;

    int a = 8;
    int b = 4;

    // Start is called before the first frame update
    void Start()
    {
        Perform(a, b, TONG);
        Perform(a, b, HIEU);
        Perform(a, b, THUONG);
        Perform(a, b, TICH);
        Perform(a, b, sai);

    }
    
    void Perform(int a, int b, int phepTinh)
    {
        switch (phepTinh)
        {
            case TONG:
                Debug.Log($"Tong: {a} + {b} = {a + b}");
                break;
            case HIEU:
                Debug.Log($"Hieu: {a} - {b} = {a - b}");
                break;
            case THUONG:
                Debug.Log($"Thuong: {a} / {b} = {a / b}");
                break;
            case TICH:
                Debug.Log($"Tich: {a} * {b} = {a * b}");
                break;
            default:
                Debug.Log("Phep tinh khong ton tai");
                break;
        }

    }
}

   


