using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // tính trung bình 4 số
        int a = 8;
        float b = 7.5f;
        int c = 9;
        float d = 8.5f;
        float tbc = (a + b + c + d) / 4;
        Debug.Log("TRUNG BINH CONG = " + tbc);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
