using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру задания ");
            // ввод числа 
            int Zifra = Convert.ToInt32(Console.ReadLine());
            // проверка числа на задания 
            if (Zifra == 1)
            {
                Repository repository = new Repository(20);

                // Печать в консоль всех сотрудников
                repository.Print("База данных до преобразования");

                // Увольнение всех работников с именем "Агата"
                repository.DeleteWorkerByName("Агата");

                repository.Print("База данных после преобразования");

            }
            else if (Zifra == 2)
            {
                Repository repository = new Repository(40);

                // Печать в консоль всех сотрудников
                repository.Print("База данных до преобразования");

                // Увольнение всех работников с именем "Агата"
                repository.DeleteWorkerByName("Агата");

                // Увольнение всех работников с именем "Аделина"
                repository.DeleteWorkerByName("Аделина");

                // Увольнение всех работников с именем "Аделина"
                repository.DeleteWorkerByName("Агнес");
                // Увольнение всех работников с именем "Аманда"
                repository.DeleteWorkerByName("Аманда");
                // Печать в консоль сотрудников, которые не попали под увольнение

                repository.Print("База данных после преобразования");
            }
            else if (Zifra == 3)
            {
                Repository repository = new Repository(50);

                // Печать в консоль всех сотрудников
                repository.Print("База данных до преобразования");

                // Увольнение всех работников  чья зарплата превышает 30000руб
                repository.DeleteWorkerBySalary(30000);

                // Печать в консоль сотрудников, которые не попали под увольнение
                repository.Print("База данных после преобразования");

            }
            else
            {
                Console.WriteLine("нет такого задания");
            }
            Console.ReadKey();

            #region Домашнее задание

            // Уровень сложности: просто
            // Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников

            // Уровень сложности: средняя сложность
            // * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
            //              которых в отделе болжно остаться не более 30 работников

            // Уровень сложности: сложно
            // ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
            //               чья зарплата превышает 30000руб



            #endregion

        }
    }
}
