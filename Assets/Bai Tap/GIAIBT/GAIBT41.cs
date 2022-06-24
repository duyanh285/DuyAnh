using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAIBT41 : MonoBehaviour
{
    int[] array = { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5 };
    // Start is called before the first frame update
    void Start()
    {
        //TimSoGiongNhau(array);
       TimSoDuyNhat(array);
    }
    void TimSoGiongNhau(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            var pt01 = array[i];
            //int count = array[i];

            for (int j = 0; j < array.Length; j++)
            {
                var pt02 = array[j];

                if (pt01 == pt02 && i != j)
                    Debug.Log($"Cac so giong nhau la {pt01}");
            }

            /* if (count > 0)
                 Debug.Log($"Cac so giong nhau la {pt01}");*/
        }
    }

    void TimSoDuyNhat(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            var pt01 = array[i];
            int count = 0;

            for (int j = 0; j < array.Length; j++)
            {
                var pt02 = array[j];
                if (i != j && pt01 == pt02)
                    count++;            
            }
            if (count == 0)
                Debug.Log($"So duy nhat trong mang la {pt01}");
        }
    }
   
}
