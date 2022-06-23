using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTB4 : MonoBehaviour
{
    //tìm các số giống nhau trong mảng 
    int[] scoreArray = new int[] { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5 };

    int[,] secondArray = new int[,]
    {
        { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5},
        {7, 3, 0, 9, 1, 8, 6, 10, 11, 17 },
        {10, 21, 1, 3, 5, 9, 2, 4, 12, 18 }
    };
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(scoreArray[4]);
        Debug.Log($"dong{secondArray.GetLength(0)},"+
            $"cot{secondArray.GetLength(1)}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
