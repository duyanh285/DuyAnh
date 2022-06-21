using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LTb3 : MonoBehaviour
{
    int a= 5;
    int b = 6;
    int c;

    string velue = "109";
    object objecValue;
    int newValue;

    // Start is called before the first frame update
    void Start()
    {

      /*  a = b == 5 ? 5 : 9;
        Debug.Log(a);
*/
        if (a == 5)
        {
            Debug.Log("dung rooi");
        }
       
        else
            Debug.Log("sai");
        /* if (a == 3)
         {
             Debug.Log("truong hop a = 3");
         }
         else if (a == 7)
         {
             Debug.Log("Truong hop a ko bang 3 va bang 7");
         }

         else
         {
             Debug.Log("truong hop a ko bang 3 va b cung ko = 7");
         }*/
        //toan tu 3 ngoi
        /* c = a == 4 ? 6 : 9;
         Debug.Log(c);*/
        c = a == 5 ? 5 : 9;
        Debug.Log(c);

        switch (a + b)
        {
            case 4:
                Debug.Log("Truong hop tong 2 so la 4 ");
                break;
            case 5:
            case 9:
                Debug.Log("truong hop tong 2 so la 9");
                break;
            case 8:
                break;
            default:
                Debug.Log("Tat ca deu sai");
                break;
        }



    }


}
