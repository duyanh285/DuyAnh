using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LTB91 : MonoBehaviour
{
    private ArrayList studentArr;

    // Start is called before the first frame update
    void Start()
    {
        studentArr = new ArrayList();
        studentArr.Add(new Student("A", 12, 5));
        studentArr.Add(new Student("T", 11, 2));
        studentArr.Add(new Student("C", 19, 0));
        studentArr.Add(new Student("B", 13, 2));
        studentArr.Add(new Student("E", 15, 4));
        studentArr.Sort(new StudentSort());

        foreach(Student student in studentArr)
        {
            //Debug.Log(student.age);
            Debug.Log(student.name);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public class Student
    {
        public string name;
        public int age;
        public int classRoom;


        public Student()
        {

        }

        public Student(string name, int age, int classRoom)
        {
            this.name = name;
            this.age = age;
            this.classRoom = classRoom;
        }
    }

    public class StudentSort : IComparer
    {
        public int Compare(object x, object y)
        {
            Student s1 = x as Student;
            Student s2 = y as Student;

            /*  if (s1.age < s2.age)
                  return -1;
              else if (s1.age > s2.age)
                  return 1;
              else
                  return 0;*/

            if (string.Compare( s1.name,s2.name)<0)
                return -1;
            else if (string.Compare(s1.name, s2.name) > 0)
                return 1;
            else
                return 0;
        }
    }
}
