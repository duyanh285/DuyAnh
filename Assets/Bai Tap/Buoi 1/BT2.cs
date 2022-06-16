using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // tính chu vi , diênk tích tam giác 

        int a = 5;
        float b = 3.5f;
        int c = 4;
        float  h= 3.5f;

        float Cv = (a + b + c);
        float Dt = (a * h) / 2;

        Debug.Log("CHU VI TAM GIAC =" + Cv);
        Debug.Log("DIEN TICH TAM GIAC =" + Dt);

    }


}
