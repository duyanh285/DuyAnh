using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ot2 : MonoBehaviour
{
    /*   duyệt in ra màn hình dãy số 10 9 8 7 6 5 4 3 2 1
   Viết hàm Tính tổng tất cả các số trong dãy số trên(Trả về giá trị và Ko trả về giá trị)
   Viết hàm Tính tổng tất cả các số chẵn trong dãy số trên(Trả về giá trị và Ko trả về giá trị)
   Viết hàm Tính tổng tất cả các số lẻ trong dãy số trên(Trả về giá trị và Ko trả về giá trị)

   Tìm tất cả các số lẻ và nhỏ hơn 7 in ra màn hình.
   Tìm tất cả các số chẵn và lớn hơn 8 in ra mình hình.*/
    // Start is called before the first frame update
    void Start()
    {
        // 1 2 3 4 5 6  8
        // 5 9 13 17 21 25 29

        //int tong = 0;

        // while (dem < 10) ;
        //TinhTongSo();

        // dayso1();

        // dayso2();

        //bt11();
        // bt12();

       // bt21();
       // bt22();

       // bt31();
      //  bt32();

        bt41();
        bt51();
    }

    void bt11()
    {
        int dem1 = 0;
        {
            for (int i = 10; i > 0; i--)
            {
                dem1 = dem1 + i;
                Debug.Log(dem1);
            }
        }
    }


    int bt12()
    {
        int kp = 0;
        int dem1 = 0;
        {
            for (int i = 10; i > 0; i--)
            {
                dem1 = dem1 + i;
                kp = dem1;
                Debug.Log(" tra ve = " + dem1);
            }
        }
        return kp;
    }


    void bt21()
    {
        int dem1 = 0;
        {
            for (int i = 10; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    
                    Debug.Log(i);
                }
            }
        }
    }


    int bt22()
    {
        int kp = 0;
        int dem1 = 0;
        {
            for (int i = 10; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                   
                    kp = i;
                    Debug.Log(" tra ve = " + i);
                }
            }
        }
        return kp;
    }

    void bt31()
    {
        int dem1 = 0;
        {
            for (int i = 10; i > 0; i--)
            {
                if (i % 2 != 0)
                {

                    Debug.Log(i);
                }
            }
        }
    }


    int bt32()
    {
        int kp = 0;
        
        {
            for (int i = 10; i > 0; i--)
            {
                
                    if (i % 2 != 0)
                    {
                        kp = i;
                        Debug.Log(" tra ve = " + i);
                    }
                
            }
        }
        return kp;
    }


    void bt41()
    {
     
        {
            for (int i = 10; i > 0; i--)
            {
                if (i < 7)
                {
                    if (i % 2 != 0)
                    {

                        Debug.Log( " so le nho hon 7 = " +i);
                    }
                }
            }
        }
    }


    void bt51()
    {

        {
            for (int i = 10; i > 0; i--)
            {
                if (i > 8)
                {
                    if (i % 2 == 0)
                    {

                        Debug.Log(" so chan lon hon 8 = " + i);
                    }
                }
            }
        }
    }

    void TinhTongSo()
    {
        /*  int dem = 1;
          while (dem < 29)
          {
              dem = dem + 4;
              Debug.Log(dem);
          }*/

        int kq = 0;
        for (int dem = 10; dem > 0; dem--)
        {
            kq = kq + dem;
            //Debug.Log(i + "");
            Debug.Log("tra ve = " + kq);

        }
    }


    void dayso1()
    {
        int tong = 0;
        for (int i = 1; i <= 12; i++)
        {
         /*   if (i < 6)
            {
                
            }*/

            if (i % 2 == 0)
            {
                tong = tong + i;
                Debug.Log(i);

                //Debug.Log(tong);
            }
        }

        /*int dem = 0;
        while (dem < 12)
        {
            dem++;
            Debug.Log(dem);
        }*/
    }

    void dayso2()
    {
        int dem = 0;
        while (dem < 12)
        {
            dem++;
            if (dem % 2 == 0)
            {
                Debug.Log(dem);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
