using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DA.HomeWorks
{
    /*Viết hàm tính tổng 2 số a và b theo 2 cách:
   1) Không trả về giá trị(void)
   2)Trả về giá trị

   Bài 02:
   Viết hàm 2 tham số a và b.
   Nếu a lớn hơn b tính a + a x b;
   Nếu a nhỏ hơn b tính a x b - b;
   làm theo 2 cách:
   1) Không trả về giá trị(void)
   2)Trả về giá trị

   Bài 03: 
   Viết hàm 2 tham số a, b và một số c.
   nếu:
   c = 2 Tính tổng 3 số trên
   c = 7 tính tích 3 số trên
   c = 1 tính hiệu 3 số trên
   c = 10 tính thương 3 số trên.
   c = 12 tính tổng c và a.
   làm theo 2 cách:
   1) Không trả về giá trị (void)
   2)Trả về giá trị
   */

    public class ot1 : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            // bt1();
            /* float ketqua = bt12();
             Debug.Log(ketqua);*/


            // bt2();
            /*  float kq2 = bt22(2, 2);
              Debug.Log(kq2);*/

            bt3(3, 3, 12);
            bt32(3, 3, 10);
            bt33(3, 3, 12);

        }

        public void bt1(int a = 2, int b = 4)
        {
            int ketqua = a + b;
            Debug.Log(ketqua);
        }

        float bt12(float a = 5f, float b = 4.5f)
        {
            float ketqua = 0;
            ketqua = a * b;
            return ketqua;
        }


        public void bt2(int a = 4, int b = 4, int pheptinh = 0)
        {
            if (a > b)
            {
                pheptinh = a + a * b;
                Debug.Log(pheptinh);
            }
            else if (a < b)
            {
                pheptinh = a * b - b;
                Debug.Log("a < b : " + pheptinh);
            }
            else
            {
                Debug.Log("Thuc hien phep tinh khac");
            }

        }

        float bt22(int a, int b)
        {
            float kq2 = 0;
            if (a > b)
            {
                kq2 = ((a + a) * b);
            }

            else if (a < b)
            {
                kq2 = (a * a - b);
            }
            return kq2;

        }
        void bt33(int a, int b, int c)
        {

            float kq3 = 0;

            if (c == 2)
            {
                kq3 = a + b + c;
                Debug.Log(kq3);
            }

            else if (c == 7)
            {
                kq3 = a * b * c;
                Debug.Log(kq3);
            }

            else if (c == 1)
            {
                kq3 = a - b - c;
                Debug.Log(kq3);
            }

            else if (c == 10)
            {
                kq3 = (a + b + c) / 3;
                Debug.Log(kq3);
            }

            else if (c == 12)
            {
                kq3 = c + a;
                Debug.Log(kq3);
            }
            else
                Debug.Log("thuc hien phep tinh khac");
        }

        void bt3(int a, int b, int c)
        {

            float kq3 = 0;
            switch (c)
            {
                case 2:
                    kq3 = a + b + c;
                    //  Debug.Log(kq3);
                    break;
                case 7:
                    kq3 = a * b * c;
                    // Debug.Log(kq3);
                    break;
                case 1:
                    kq3 = a - b - c;
                    // Debug.Log(kq3);
                    break;
                case 10:
                    kq3 = (a + b + c) / 3;
                    // Debug.Log(kq3);
                    break;
                case 12:
                    kq3 = c + a;
                    // Debug.Log(kq3);
                    break;
                default:
                    Debug.Log("khong co phep tinh nay");
                    break;
            }
            Debug.Log($"Ket qua phep tinh : {kq3}");
        }


        float bt32(int a, int b, int c)
        {

            float kq3 = 0;
            switch (c)
            {
                case 2:
                    kq3 = a + b + c;
                    //  Debug.Log(kq3);
                    break;
                case 7:
                    kq3 = a * b * c;
                    // Debug.Log(kq3);
                    break;
                case 1:
                    kq3 = a - b - c;
                    // Debug.Log(kq3);
                    break;
                case 10:
                    kq3 = (a + b + c) / 3;
                    // Debug.Log(kq3);
                    break;
                case 12:
                    kq3 = c + a;
                    // Debug.Log(kq3);
                    break;
                default:
                    Debug.Log("khong co phep tinh nay");
                    break;
            }
            Debug.Log($"Ket qua phep tinh : {kq3}");
            return kq3;
        }


        // Update is called once per frame
        void Update()
        {

        }
    }
}