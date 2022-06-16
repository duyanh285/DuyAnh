using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //diện tích ,chu vi hinh tròn
        int r = 4;
        float pi = 3.14f;

        float Dt = (r* r * pi);
        float Cv = (r * 2 * pi);

        Debug.Log("DIEN TICH HINH TRON = " + Dt);
        Debug.Log("CHU VI HINH TRON = " + Cv);


    }


}
