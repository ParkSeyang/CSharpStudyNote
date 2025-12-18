using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNote
{
    internal class CapsuleTest
    {
        // 간단한 캡슐화 연습
        private class Animal
        {
            private int number;
            private string name;
            private bool isTrue;

            public int Number { get { return number; } }
            public string Name { get { return name; } }

            public bool Istrue { get { return isTrue; } }

            // 생성자.
            public Animal(int animalnumber, string animalname)
            {
                number = animalnumber;
                name = animalname;
            }


            public bool CheckZooAnimal(int checkNum, string checkName)
            {
                if (number == checkNum && name == checkName)
                {
                    return isTrue = true;
                }
                else
                {
                    return isTrue = false;
                }

            }


        }

        // 캡슐화 연습 2
        private class StudyClassA
        {
            private int studentNum;
            private string studentName;
            private Dictionary<int, string> StudentList = new Dictionary<int, string>();
            public int StudentNumber { get { return studentNum; } }
            public string StudentName { get { return studentName; } }

            public StudyClassA(int number, string name)
            {
                studentNum = number;
                studentName = name;
            }

            public void StudentAddList(int studentnum, string studentname)
            {
                StudentList.Add(studentnum, studentname);

                Console.WriteLine($"A반에 번호 : {studentnum} 학생 : {studentname} 이가 새로 등록 되었습니다.");

            }

            public void StudentChange(int studentnum, string studentname)
            {
                studentNum = studentnum;
                studentName = studentname;

                Console.WriteLine($"A반에 번호 : {studentNum} 학생 : {studentName} 이가 변경되었습니다.");
            }


            public void DeleteStudentList(int studentnum, string studentname)
            {
                if (StudentList.Count == 0)
                {
                    return;
                }

                if (StudentList.ContainsKey(studentnum) && StudentList.ContainsValue(studentname))
                {
                    StudentList.Remove(studentnum);
                }
                else
                {
                    Console.WriteLine("해당 학생을 찾을수가 없습니다.");
                }

            }

            public void AllCountStudent()
            {
                Console.WriteLine($"A반 총 학생 인원수는 {StudentList.Count} 입니다.");
            }


            public bool CheckStudentName(string studentname)
            {
                if (StudentList.ContainsValue(studentname) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }


        }

       // public void Note()
       // {
       //     Animal testAnimal = new Animal(5, "기린");
       //     Console.WriteLine("추가한 동물이 있나요? : " + testAnimal.CheckZooAnimal(5, "기린"));
       //
       //
       //     StudyClassA studentAClass = new StudyClassA(35, "도도");
       //     studentAClass.StudentAddList(studentAClass.StudentNumber, studentAClass.StudentName);
       //     studentAClass.StudentChange(15, "레레");
       //     studentAClass.StudentAddList(studentAClass.StudentNumber, studentAClass.StudentName);
       //
       //
       //     Console.WriteLine("도도라는 학생이 있나요? " + studentAClass.CheckStudentName("도도"));
       //     Console.WriteLine("레레라는 학생이 있나요? " + studentAClass.CheckStudentName("레레"));
       // }
    }
}
