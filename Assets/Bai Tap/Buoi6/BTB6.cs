using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AD.HomeWorks.oop
{
    public class BTB6 : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            PC pc1 = new PC();
            PC.ChuSoHuu = "DA";
            PC.DiaChiWF = "192.1.1";
            PC.TocDoWF = 10.2f;
            Debug.Log("chu so huu " + PC.ChuSoHuu);
            Debug.Log("dia chi wifi " + PC.DiaChiWF);
            Debug.Log("toc so wifi " + PC.TocDoWF);

            pc1.KhoiDong();
            pc1.TatMay();
            pc1.EpXung();
            pc1.TruyenDuLieu();
            pc1.NhanDuLieu();

        }

        public class PC
        {
            public static string DiaChiWF;
            public static float TocDoWF;
            public static string ChuSoHuu;

            string m_case;
            string mainBoard;
            string ram;
            string cpu;
            string nguon;
            string tannhiet;
            string fan;

            public PC(string m_case, string mainBoard, string ram, string cpu, string nguon, string tannhiet, string fan)
            {
                this.m_case = m_case;
                this.mainBoard = mainBoard;
                this.ram = ram;
                this.cpu = cpu;
                this.nguon = nguon;
                this.tannhiet = tannhiet;
                this.fan = fan;
            }

          

            public PC()
            {
                m_case = "lenovo";
                mainBoard = "lenovo";
                ram = "8g";
                cpu = "lenovo";
                nguon = "lenovo";
                tannhiet = "lenovo";
                fan = "lenovo";
            }

            

            public void KhoiDong()
            {
                Debug.Log("khoi dong may");
            }
            public void TatMay()
            {
                Debug.Log("tat may");

            }
            public void EpXung()
            {
                Debug.Log(" ep xung may");

            }
            public void TruyenDuLieu()
            {
                Debug.Log("truyen du lieu");
            }
            public void NhanDuLieu()
            {
                Debug.Log("nap du lieu vao may");

            }

            ~PC()
            {

            }

        }
    }
}