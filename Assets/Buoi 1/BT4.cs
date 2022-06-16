using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Tính vận tốc quãng đường dài 20km, thời gian để đi hết quãng đường là 5 phút
        int s = 20;
        int t = 5;

        int Vt = (s / t);
        Debug.Log("VAN TOC =" + Vt);

    }

}
