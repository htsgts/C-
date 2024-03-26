using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //입력
            /*
            String input = Console.ReadLine();
            //Console.WriteLine(input);
            Console.WriteLine(input + input); // 문자열 연결연산자
            //Console.WriteLine("input" + "input");
            Console.WriteLine();*/

            //자료형 변환
            //강제 자료형 변환
            /*            var a = (int)10.0;
                        var b = (float)10;
                        var c = (double)10;

                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);


                        //다른 자료형을 숫자로 변환
                        //문자열을 숫자로 변환할 시 오류 발생 주의

                        String numberString = "52273"; 
                        //int intNumber = (int)numberString;

                        //문자열을 숫자로 변환 : Parse
                        Console.WriteLine(int.Parse("52"));
                        Console.WriteLine(long.Parse("273"));
                        Console.WriteLine(float.Parse("52.273"));
                        Console.WriteLine(double.Parse("52.273"));

                        Console.WriteLine(double.Parse("52.273").GetType());

                        Console.WriteLine(int.Parse("abc"));*/

            //다른 자료형을 문자열로 변환
            /*            Console.WriteLine(52.ToString());
                        Console.WriteLine((52).ToString());

                        //소숫점 제거
                        double number = 52.273103;
                        Console.WriteLine(number.ToString("0.0"));
                        Console.WriteLine(number.ToString("0.00"));
                        Console.WriteLine(number.ToString("0.000"));

                        //숫자와 문자열 덧셈 : 숫자가 자동으로 문자열로 변환
                        Console.WriteLine(52+273); //325, 덧셈 연산자
                        Console.WriteLine("52" + 273); //52273, 문자열 연결 연산자
                        Console.WriteLine("52" + "273"); //52273
                        Console.WriteLine('a' + 'b'); //195 
            */
            //문 inch 단위를 입력받아 cm 단위를 구하는 코드를 작성하시오.
            //1 inch = 2.54cm
            Console.WriteLine("inch 단위를 입력하세요");
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch + "inch는 " + (inch * 2.54) + "cm입니다." );
            Console.WriteLine("{0}inch는 {1}cm입니다.", inch, inch*2.54);
            Console.WriteLine($"{inch}inch는 {inch*2.54}cm입니다.");


        }
    }
}
