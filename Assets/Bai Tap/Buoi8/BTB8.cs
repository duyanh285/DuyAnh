using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DA.HomeWorks.Buoi8
{
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
                    Debug.Log("Bay bang canh");
                }
                public override void An()
                {
                    Debug.Log("An sau bo");
                }
                public override void Keu()
                {
                    Debug.Log("Hot");
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
                    Debug.Log("An thit");
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
                    Debug.Log("Boi");
                }
                public override void An()
                {
                    Debug.Log("An tao");
                }
                public override void Keu()
                {
                    Debug.Log("quay nuoc ");
                }
            }
        }
       
    }
}