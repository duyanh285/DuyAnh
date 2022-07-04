using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Item item = new Item("item", 1, 5, "stat");
        Item item1 = new Item("item1", 8, "stat1");
        Item item2 = new Item("item2", 1, 8);
    }

    public class BaseItem
    {
        public string id;
        public int unlocked;
        public BaseItem() { }
        public BaseItem(string id)
        {
            Debug.Log($"Khoi tao cha: {id}");
        }
        public BaseItem(string id, int unlocked)
        {
            Debug.Log($"Khoi tao cha:\nid: {id}, unlocked: {unlocked}");
        }
    }
    public class Item : BaseItem
    {
        public int amount;
        public string stat;
        public Item(string id, int unlocked, int amount, string stat) : base(id, unlocked)
        {
            Debug.Log($"Khoi tao con:\namount: {amount},stat: {stat}");
        }
        public Item(string id, int unlocked, string stat) : base(id, unlocked)
        {
            Debug.Log($"Khoi tao con:\nstat: {stat}");
        }
        public Item(string id, int unlocked, int amount) : base(id, unlocked)
        {
            Debug.Log($"Khoi tao con:\namount: {amount}");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
