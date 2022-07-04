using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DA.HomeWorks.B8
{
    public class Btt : MonoBehaviour
    {

        void Start()
        {
            Item item = new Item("item", 1, 4, "start");
            Item item1 = new Item("item1", 2, "start1");
            Item item2 = new Item("item2", 2 ,8);
            Item item3 = new Item("item3", 9);


        }

        public class Baseltem
        {
            public string id;
            public int unlocked;
            public Baseltem()//khoi tao ko tham so
            {

            }

            public Baseltem(string id)//kt 1 tham so
            {
                Debug.Log($"khoi tao cha : {id}");
            }

            public Baseltem(string id, int unlocked)//kt 2 tham so
            {
                Debug.Log($"khoi tao cha : \n id: {id} , unlocked:{unlocked}");
            }
        }


        class Item : Baseltem
        {
            public int amount;
            public string start;

            public Item(string id, int unlocked, int amount, string start) : base(id, unlocked)
            {
                Debug.Log($"khoi tao con : \n amount: {amount}, start: {start}");
            }


            public Item(string id, int unlocked, string start) : base(id, unlocked)
            {
                Debug.Log($"khoi tao con : \n , start: {start}");
            }

            public Item(string id, int unlocked, int amount) : base(id, unlocked)
            {
                Debug.Log($"khoi tao con : \n amount: {amount}");
            }

            public Item(string id, int unlocked) : base(id, unlocked)
            {
                Debug.Log($"khoi tao con : \n {id} ,{unlocked}");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}