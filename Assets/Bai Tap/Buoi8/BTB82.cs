using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btb82 : MonoBehaviour
{
    public abstract class Animal2
    {
        public string name;
        public string enviroment;
        public string food;
        public abstract void Move();
        public abstract void Eat();
        public abstract void EatWhat();
        public abstract void Sound();
    }

    public class Meo : Animal2
    {
        public override void Move()
        {
            Debug.Log("Di bang bon chan");
        }
        public override void Eat()
        {

        }
        public override void EatWhat()
        {
            Debug.Log("An thit");
        }
        public override void Sound()
        {
            Debug.Log("Keu meo meo");
        }
    }

    public class Chim : Animal2
    {
        public override void Move()
        {
            Debug.Log("bay");
        }
        public override void Eat()
        {

        }
        public override void EatWhat()
        {
            Debug.Log("An sau");
        }
        public override void Sound()
        {
            Debug.Log("hot");
        }
    }
    public class Ca : Animal2
    {
        public override void Move()
        {
            Debug.Log("boi");
        }
        public override void Eat()
        {

        }
        public override void EatWhat()
        {
            Debug.Log("An tao ,vi sinh");
        }
        public override void Sound()
        {
            Debug.Log("Quay nuoc");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
