using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class LTB2 : MonoBehaviour
{
    //hang ko thay doi gia tri
    //const int Dien_cao_nhat= 8;
    /*int a;
    float b;
    object c;*/

    string a = "5";
    float b;
    int temp;
    float c;
    long d;

    private void Start()
    {
        /*c = 9.05f;
        d = 127;

        b = 10;
        b = Convert.ToInt16(1);
        d = Convert.ToInt64(c);
        b = Convert.ToInt16(b);

        Debug.Log(b);
        Debug.Log(d);*/

       /* bool isSuccess = false;
        isSuccess = float.TryParse(a, out b);*/

        b = float.Parse(a);
        Debug.Log(b);

        /*a = 2;
        b = 4.5f;
        c = 5;
        //b = a;
        a = (int) b;
        a = (int) c;
        c = b;

        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);*/

        // a = Dien_cao_nhat;
        // Debug.Log(a);
    }
}
