using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LTB6 : MonoBehaviour
{
    //oop
    //class
    //pham vi truy cap
    // TU KHOA GET VA SET
    //static

    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy = new Enemy(1,7,9);
        enemy.Move();
        Debug.Log(Enemy.lifeTime);
        Enemy.lifeTime = 5.4f;
        Enemy.Caculate();
        enemy.Bouns = 5;
        Debug.Log(enemy.Bouns);
        Helper.GetDamge();
        
    }

    public static class Helper
    {
        public static float damge;

        public static float GetDamge()
        {
            return damge;
        }
    }
    public class Enemy
    {
        public float moveSpeed;
        public float head;
        public float damge;

        private int bouns;
        protected float skillReate;
        public static float lifeTime;

        public int Bouns
        {
            get
            {
                return bouns;//get=>bouns;
            }
            set
            {
                 if (value > 5)  
                bouns = value;                //set=> bouns =value ;

            }
        }
        public  static void Caculate()
        {

        }

      
        static Enemy()
        {
          
            Debug.Log("Day la phuong thuc ko tham so");
        }

        public Enemy(float moveSpeed)
        {
            this.moveSpeed = moveSpeed;
            Debug.Log("Phuong thuc khoi tao move speed");
        }

        ~Enemy()
        {
            Debug.Log("huy bo");
        }

        public Enemy(float moveSpeed, float head, float damge)
        {
            this.moveSpeed = moveSpeed;
            this.head = head;
            this.damge = damge;
            Debug.Log("pt khoi tao co tham so");
        }
        public void Move()
        {

        }

        static void Head()
        {
            
        }

        public void Dagme()
        {
            //Head = 0;

        }
        protected void skillCount()
        {

        }   
    }

   /* public class Boos : Enemy
    {
        public void Testing()
        {
            skillReate = 6;
        }
    }*/

    public class AI
    {
        public static float move;

        public float atkTime; 

        public static void Attack()
        {
            
        } 
        public AI(float a)
        {
            Debug.Log("FLOAT A");
        }

        public AI(int b)
        {    
            Debug.Log("INT B");
        }
    }
}
