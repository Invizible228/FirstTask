using System;
using System.Collections;
using System.IO;
using System.Threading;

namespace InvdividualexS7
{
    class Program
    {
        static void Main(string[] args)
        {
            //abc#d##c 
            Stack s = new Stack();
            StreamWriter sw = new StreamWriter("Text.txt");
            char check = '#';
            bool c = true;
            Console.Write("Введите текст:");
            string st = Console.ReadLine(); //Ввод текста
            Console.WriteLine("Ищу...");
            Thread.Sleep(1000); //Ожидание
            for (int i = 0;i < st.Length; i++)
            {
                if (st[i] == check)
                {
                    try //Вылавливание ошибок
                    {
                        st = st.Remove(i - 1, 2); //Цикл удаления
                        i = i - 2;
                }
                    catch { c = false; }
            }
                
            }
            s.Push(st);
            sw.WriteLine(st); //Запись в файл
            sw.Close();
            if (c == true) { Console.Write("Преобразованный текст:" + s.Pop()); } //Вывод из стека
            else { Console.WriteLine("Ваш текст является пустым или нерешаемым"); }
        }
    }
}
