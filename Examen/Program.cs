using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Examen
{

  /// <summary>
  ///   Основной метод программы 
  /// </summary>
    public class Program
    {      
        // основной модуль отвечающий лишь за вызов метода подсчёта
        static void Main(string[] args)
        {
            Actions actions = new Actions();
            actions.Perem();
            actions.Conclusion();
            Console.ReadKey();           
        }
     
        /// <summary>
        /// Класс отвечающий за два модуля:
        /// 1- подсчёт критического пути
        /// 2- вывод критического пути пользователю на экран
        /// </summary>
    public class Actions
        {
            // переменный куда будут записываться данный в случае нахождения 1 или нескольких крит. путей
            public int answer = 0; 
            public int answer1 = 0;

            /* две переменный отвечающие за показ кратчайшего пути, 
             и если крат.пути 2 то они выводяться одновременно
            */
            string reponse = "Кратчайший путь ";
            string reponse1 = "Кратчайший путь 2 ";

            public void Perem( )
            {
                // структура try catch для выведения ошибок в случае неправильного ввода
                try
                {
                    // Интерактивная консоль для пользователя для введения расстояния между определёнными точка
                    Console.Write("Введите расстояние от 1 до 2: ");
                    int one_two = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите расстояние от 1 до 3: ");
                    int one_three = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите расстояние от 1 до 4: ");
                    int one_four = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите расстояние от 2 до 4: ");
                    int two_four = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите расстояние от 3 до 4: ");
                    int three_four = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите расстояние от 4 до 5: ");
                    int four_five = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите расстояние от 4 до 6: ");
                    int four_six = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите расстояние от 5 до 6: ");
                    int five_six = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите расстояние от 6 до 7: ");
                    int six_seven = Convert.ToInt32(Console.ReadLine());

                    // все последующие структуры if else и else if нужны лишь для проверки критического пути между собой
                    if (one_two > one_three && one_two > one_four)
                    {
                        reponse += " 1 --> 2 --> ";
                        answer += one_two;
                        reponse += " 4 ";
                        answer += two_four;

                        if (four_five > four_six)
                        {
                            reponse += "5 --> ";
                            answer += four_five;
                            reponse += "6 --> ";
                            answer += five_six;
                            reponse += "7 ";
                            answer += six_seven;
                        }
                        else if (four_five < four_six)
                        {
                            reponse += "6 -->";
                            answer += four_six;
                            reponse += "7 ";
                            answer += six_seven;
                        }
                        else if (four_five == four_six)
                        {
                            reponse = " 1 --> 2 --> 4 --> 5 --> 6 --> 7";
                            answer = one_two + two_four + four_five + five_six + six_seven;
                            reponse1 = " 1 --> 2 --> 4 --> 6 --> 7";
                            answer1 = one_two + two_four + four_six + six_seven;
                        }

                    }
                    else if (one_three > one_four && one_three > one_two)
                    {
                        reponse += " 1 --> 3 --> ";
                        answer += one_three;
                        reponse += "4 --> ";
                        answer += three_four;
                        if (four_five > four_six)
                        {
                            reponse += "5 --> ";
                            answer += four_five;
                            reponse += "6  --> ";
                            answer += five_six;
                            reponse += "7 ";
                            answer += six_seven;
                        }
                        else if (four_five < four_six)
                        {
                            reponse += "6 --> ";
                            answer += four_six;
                            reponse += "7 ";
                            answer += six_seven;
                        }
                        else if (four_five == four_six)
                        {
                            reponse = " 1 --> 3 --> 4 --> 5 --> 6 --> 7";
                            answer = one_three + three_four + four_five + five_six + six_seven;
                            reponse1 = " 1 --> 3 --> 4 --> 6 --> 7";
                            answer1 = one_three + three_four + four_six + six_seven;
                        }
                    }
                    else if (one_four > one_two && one_four > one_three)
                    {
                        reponse += " 1 --> 4 --> ";
                        answer += one_four;
                        if (four_five > four_six)
                        {
                            reponse += "5 --> ";
                            answer += four_five;
                            reponse += "6 --> ";
                            answer += five_six;
                            reponse += "7 ";
                            answer += six_seven;
                        }
                        else if (four_five < four_six)
                        {
                            reponse += "6  --> ";
                            answer += four_six;
                            reponse += "7 ";
                            answer += six_seven;
                        }
                        else if (four_five == four_six)
                        {
                            reponse = " 1 --> 4 --> 5 --> 6 --> 7";
                            answer = one_four + four_five + five_six + six_seven;
                            reponse1 = " 1 --> 4 --> 6 --> 7";
                            answer1 = one_four + four_six + six_seven;
                        }
                    }
                }
                //модуль для ловли ошибок и выведения уведомления об этом
                catch (Exception)
                {
                    Console.WriteLine("Ошибка в ведении расстояния\n");
                }
              
          
            }
            // модуль вывода кратчайшего пути   
            public void Conclusion()
            {
                // конструкция if else для вывода ответа в главный модуль

                // в данном случае будет выводиться один кратчайший путь
                if (answer1 == 0)
                {
                    Console.WriteLine($"\n {reponse} = {answer}");
                    Debug.WriteLine($"\n {reponse} = {answer}");
                  
                }
                // в данном случае будут выводиться два кратчайших путь
                else
                {
                    Console.WriteLine($"\n {reponse} = {answer}\n {reponse1} = {answer1}");
                    Debug.WriteLine($"\n {reponse} = {answer}\n {reponse1} = {answer1}");
                }
            }
        }      
    }
    
}

