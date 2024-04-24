using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Harjutused // пространство имен 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////* Loo  juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni. Trüki arvude ruudud ekraanile.
            ////N ja M arvud on vahemikus (-100,100).
            //Random rand = new Random(); //новый объект типa Random 
            //int N = rand.Next(-100, 100);
            //int M = rand.Next(-100, 100);

            //int[] arvud = new int[Math.Abs(M - N) + 1]; // кол-во элементов в массиве с учетом последнего числа
            //for (int i = 0; i < arvud.Length; i++)
            //{
            //    arvud[i] = N + i;//Заполнение от N + i
            //    Console.WriteLine("Arv: {0}, Ruut: {1}", arvud[i], Math.Pow(arvud[i], 2)); //Возведение в степень 2 
            //}

            //*Küsi kasutajalt viis arvu, salvesta neid massiivi ning väljasta nende summa, aritmeetiline keskmine ja korrutis.

            //int[] user_input = new int[5];
            //int sum = 0;
            //float kesk = 0;
            //int kor = 1;
            //for (int i = 0; i < 5; i++)
            //{                
            //        Console.WriteLine("Sisesta arv {0}: ", i + 1);
            //        user_input[i] = int.Parse(Console.ReadLine());
            //        sum = sum + user_input[i];  
            //        kor = kor * user_input[i];
            //}

            //kesk = (float)sum / user_input.Length;
            //Console.WriteLine("Arvude summa on {0}: , Aritmeetiline keskmine on {1}, Korrutis on {2} ", sum,kesk,kor);


            //*Küsi viielt kasutajalt nimed ja vanused,
            //salvesta nende andmeid massiivi
            //ning väljasta summaarne vanus, aritmeetiline keskmine, vaanema ja noorema inimeste nimed ja vanused.

            //string[] nimed = new string[5];
            //int[] vanused = new int[5];
            //int summaarneVanus = 0;
            //float aritmeetilineKeskmine = 0;
            //string vanemNimi = "";
            //int vanemVanus = 0; // начальное значение для сравнения с реальными значениями -2147483648
            //string nooremNimi = "";
            //int nooremVanus = 0; // начальное значение для сравнения с реальными значениями +2147483648

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("{0}.\nSisesta kasutaja nimi: ", i+1);
            //    nimed[i] = Console.ReadLine();

            //    Console.Write("{0}.\nSisesta kasutaja vanus: ", i + 1);
            //    vanused[i] = int.Parse(Console.ReadLine());

            //    summaarneVanus += vanused[i];

            //    // Находим самое старшее и самое младшее имена и возрасты
            //    if (vanused[i] > vanemVanus)
            //    {
            //        vanemVanus = vanused[i]; //после сравнения присвает значение [i], как самое большое/старшее
            //        vanemNimi = nimed[i];
            //    }

            //    if (vanused[i] < nooremVanus)
            //    {
            //        nooremVanus = vanused[i];
            //        nooremNimi = nimed[i];
            //    }
            //}

            //aritmeetilineKeskmine = (float)summaarneVanus / vanused.Length;

            //Console.WriteLine("Summaarne vanus: {0}", summaarneVanus);
            //Console.WriteLine("Aritmeetiline keskmine: {0}", aritmeetilineKeskmine);
            //Console.WriteLine("Vanim inimene: {0} ({1} aastat)", vanemNimi, vanemVanus);
            //Console.WriteLine("Noorim inimene: {0} ({1} aastat)", nooremNimi, nooremVanus);

            //* Ütle kasutajale "Osta elevant ära!".
            //Senikaua korda küsimust, kuni kasutaja lõpuks ise kirjutab "elevant".
            //bool lause = true;
            //while (lause)
            //{
            //    Console.WriteLine("Osta elevant ära!");
            //    string answer_from_user = Console.ReadLine();
            //    if (answer_from_user == "elevant")
            //    {
            //        lause = false;
            //    }

            //}
            //*Mis arv mõtles välja arvuti? Kasuta vähemalt 5 katset, et seda teada.
            //Random nmb = new Random();
            //int number = nmb.Next(-50,50);
            //int user_input;
            //for (int i = 0; i < 5; i++) { 
            //    Console.WriteLine("Arva ära number!");
            //    user_input = int.Parse(Console.ReadLine());
            //    if (user_input == number)
            //    {
            //        Console.WriteLine("Õige, number on leitud!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Vale, sul jäänud {0} katse!",5-i-1);
            //    }
            //}
            //Console.WriteLine("Number oli {0}", number);
            //*Küsi kasutajalt 4 arvu ning väljasta nendest koostatud suurim neliarvuline arv.
            //int[] numbers = new int[4];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Sisesta number {0}", i + 1);
            //    numbers[i] = int.Parse(Console.ReadLine());

            //}
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[3] * 1000 + numbers[2]*100 + numbers[1]*10 + numbers[0]*1);

            //*Korrutustabel väljata ekraanile sellisel kujul:
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        for (int j = 1; j <= 10; j++)
        //        {
        //            Console.Write("{0,4}", i * j); // выровнять результат по правому краю и использовать ширину поля в 4 символа.
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
