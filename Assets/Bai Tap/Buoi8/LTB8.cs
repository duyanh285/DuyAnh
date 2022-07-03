using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace DA.LT.B8
{
    public class LTB8 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Enemy boss = new Boss();
            boss.Move();
        }
       
        public abstract class Enemy
        {
            public  float hp;
            public float damage;
            public float moveSpeed;

          /*  public Enemy(float dmg)
            {
                Debug.Log("CHA 1 tham so");
            }

            public Enemy()
            {

            }

            public Enemy(float dmg, float dis)
            {
                Debug.Log("CHA 2 tham so");

            }*/

          /*  public virtual void Move()
            {
                Debug.Log("Move cua Enemy");
            }*/

            public abstract void Move();
            public abstract void Die();
           
        }
        public interface IEnemy
        {
           public void GetHit(int dmg);
        }
        public  interface IOther : IEnemy
        {

        }

        public class  Boss : Enemy, IEnemy,IOther
        {

            public override void Move()
            {
                Debug.Log("move cua boss");
            }

            public override void Die()
            {
                Debug.Log("move cua boss");
            }

            public Boss()
            {
                Debug.Log("CON");
            }

            public void GetHit(int dmg)
            {

            }
           /* public Boss(float hpCopy, float dmgCopy) : base(hpCopy, dmgCopy)
            {
                Debug.Log("CON");
            }

            public new float damage;
            public void Move()
            {
                base.Move();
                Debug.Log("Move cua con");
            }*/
        }
    }
}