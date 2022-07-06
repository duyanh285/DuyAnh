using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LTB9 : MonoBehaviour
{
    private ArrayList arrListDemo;
    private ArrayList arrListDemo2;


    // COLLECTION
    // Start is called before the first frame update
    void Start()
    {
        arrListDemo = new ArrayList();
        arrListDemo.Add(10);
        arrListDemo.Add(12.5f);
        arrListDemo.Add("DA");

        arrListDemo2 = new ArrayList();
        arrListDemo2.Add(15);
        arrListDemo2.Add(15.5f);
        arrListDemo2.Add("DA2");


        //Debug.Log(arrListDemo.Count);

        // Debug.Log(arrListDemo.Capacity);

        arrListDemo.AddRange(arrListDemo2);
       //arrListDemo.Clear();

       // Debug.Log(arrListDemo.Contains(15.5f));

        var arrCopy = arrListDemo.GetRange(2, 3);
       // Debug.Log(arrCopy.Count);
        //Debug.Log(arrListDemo.IndexOf("DA"));
        arrListDemo.Insert(4, "100");
         arrListDemo.Remove("DA2");
         arrListDemo.Reverse();

         var arr = arrListDemo.ToArray();

         var arrClone = (ArrayList)arrListDemo.Clone();

         arrListDemo.Sort();

        foreach (var temp in arrListDemo)
        {
            Debug.Log(temp);
        }

       /* for (int i = 0; i < arrListDemo.Count; i++)
        {
            var arrIteam = arrListDemo[i];
            Debug.Log(arrListDemo[i]);
        }*/

       
    }

    public class Student
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
