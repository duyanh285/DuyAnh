using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_sort : MonoBehaviour
{
    //kieu sort dong bo 1 kieu du lieu
    private ArrayList arrListDemo;
    private ArrayList arrListDemo2;


    // Start is called before the first frame update
    void Start()
    {
        arrListDemo = new ArrayList();
        arrListDemo.Add(10);
        arrListDemo.Add(12);
        arrListDemo.Add(123);

        arrListDemo2 = new ArrayList();
        arrListDemo2.Add(15);
        arrListDemo2.Add(15);
        arrListDemo2.Add(23);


        arrListDemo.Sort();

        foreach (var temp in arrListDemo)
        {
            Debug.Log(temp);
        }

        foreach (var temp in arrListDemo2)
        {
            Debug.Log(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
