using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class BTB8 : MonoBehaviour
    {
        //bt1
        public class Animal1
        {
            public string ten;
            public string moitruong;
            public string thucan;
            public string gioitinh;

            public virtual void DiChuyen()
            {

            }
            public virtual void An()
            {

            }
            public virtual void AnGi()
            {

            }
            public virtual void Keu()
            {

            }



            public class chim : Animal1
            {
                public override void DiChuyen()
                {
                    Debug.Log("bay bang canh");
                }
                public override void An()
                {
                    Debug.Log("an sau bo");
                }
                public override void Keu()
                {
                    Debug.Log("hot");
                }
            }

            public class meo : Animal1
            {
                public override void DiChuyen()
                {
                    Debug.Log("di 4 chan");
                }
                public override void An()
                {
                    Debug.Log("an thit");
                }
                public override void Keu()
                {
                    Debug.Log("meo meo ");
                }
            }

            public class ca : Animal1
            {
                public override void DiChuyen()
                {
                    Debug.Log("boi");
                }
                public override void An()
                {
                    Debug.Log("an tao");
                }
                public override void Keu()
                {
                    Debug.Log("quay nuoc ");
                }
            }
        }
       
    }
