using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class LTB5 : MonoBehaviour
{
    //STRING
    // ENUM KIEU LIET KE 
    string s1 = "acabdasb1";
    string s2 = "abc123";

    string s3 = null;
    StringBuilder s4;


    // Start is called before the first frame update
    void Start()
    {
        /*  Debug.Log($"do dai cau choi s1 la{s1.Length}");

          if (String.Compare(s1, s2) == 0)
          {
              Debug.Log("chuoi s1 bang chuoi s2");
          }
          else if (String.Compare(s1, s2) > 0)
          {
              Debug.Log("chuoi s1 lon hon chuoi s2");
          }
          else
          {
              Debug.Log("chuoi s1 nho hon chuoi s2");
          }*/
        /* Debug.Log(String.Concat(s1, s2));//so sanh
         Debug.Log(s1.IndexOf("b")); //vi tri b dau tien
         Debug.Log(s1.Insert(1, "x"));//them chu
         Debug.Log(String.IsNullOrEmpty(s3));//tra gia trij
         Debug.Log(s1.LastIndexOf("b"));//vi tri b cuoi cung
         Debug.Log(s1.Remove(1, 3));// xoa
         Debug.Log(s1.Replace("ab", "tec"));//thay the*/

        /*   var s1SplitArray = s1.Split(new char[] { 'b', 'c' });
           for (int i = 0; i < s1SplitArray.Length; i++)
           {
               Debug.Log(s1SplitArray[i]);//cat chuoi

           }*/

        /*s3 = " buon qua di";
        Debug.Log(s3.IndexOf("ss"));*/
        //Debug.Log(s1.Substring(3, 4));
        /* var charArray = s1.ToCharArray();//mang cac ky tu
         for(int i = 0; i < charArray.Length; i++)
         {
             Debug.Log(charArray[i]);
         }*/

        /*s4 = new StringBuilder("acvbca");
        var s4Copy = s4.ToString();
        Debug.Log(s4.Length);
        Debug.Log(s4.Append("dvc"));
        Debug.Log(s4.Clear());*/
        
        //EMUN
        Debug.Log((int)GameState.win);
        Debug.Log((GameState).2);
        if (GameState.win == (GameState)1)
        {

        }

    }

    enum GameState
    {
        strting,
        play ,
        stop,
        win
    }
    // Update is called once per frame
    void Update()
    {

    }
}
