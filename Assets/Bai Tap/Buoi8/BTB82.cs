using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DA.HomeWorks.buoi8
{


    // abstract

    public abstract class AnimalB3
    {
        public string name;
        public string enviroment;
        public string food;
        public abstract void Move();
        public abstract void Eat();
        public abstract void EatWhat();
        public abstract void Sound();
    }

    public class Meo : AnimalB3
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

    public class Chim : AnimalB3
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
    public class Ca : AnimalB3
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
            Debug.Log("An to ,vi sinh");
        }
        public override void Sound()
        {
            Debug.Log("Quay nuoc");
        }
    }

}
