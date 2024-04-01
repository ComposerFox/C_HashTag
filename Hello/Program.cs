// 주석
/*
 * 범위 주석 
*/

// namespace => java에서 package 역할(폴더)
//              클래스를 모아 놓는 역할
//              클래스 명이 namespace 별로 겹치지만 않으면 된다

// System 을 생략할수 있게 해준다(import)
using System;

namespace sec01.ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");

            // 0100 : 4
            // 0010 : 2
            int i = 4;
            int i2 = 0b0100;
            int i16 = 0x04;

            // >> << 시프트 연산자
            // 2진수 상태의 값을 좌우로 비트를 밀어내는 연산자
            Console.WriteLine(i16 >> 1);
            Console.WriteLine(i16 << 1);

            if( (i16 & 0b0001) == 0b0001 )
            {
                Console.WriteLine("첫번째 bit 가 1");
            }
            else
            {
                Console.WriteLine("첫번째 bit 가 1이 아님");
            }

            if( (i16 & 0b0100) == 0b0100 )
            {
                Console.WriteLine("세번째 bit 가 1");
            }

            Console.WriteLine(i2 | 0b1000);
        }
    }
}