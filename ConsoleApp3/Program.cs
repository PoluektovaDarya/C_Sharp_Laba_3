using System;

struct Student
{
    public string lastName;
    public string firstName;
    public string patronymic;
    public int groupNumber;
    public int[] performance; //массив успеваемости

    //метод для вычисл ср.балла
    public double CalculateAverage()
    {
        double sum = 0;
        foreach (int mark in performance)
        {
            sum += mark;
        }
        return sum / performance.Length;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[7];
        students[0] = new Student { lastName = "Шорников", firstName = "Иван", patronymic = "Иванович", groupNumber = 1, performance = new int[] { 4, 5, 3, 4, 5 } };
        students[1] = new Student { lastName = "Титов", firstName = "Илья", patronymic = "Петрович", groupNumber = 2, performance = new int[] { 5, 5, 5, 5, 5 } };
        students[2] = new Student { lastName = "Волков", firstName = "Кира", patronymic = "Вячеславович", groupNumber = 1, performance = new int[] { 3, 3, 4, 4, 4 } };
        students[3] = new Student { lastName = "Сычин", firstName = "Андрей", patronymic = "Алексеевич", groupNumber = 2, performance = new int[] { 4, 4, 4, 4, 4 } };
        students[4] = new Student { lastName = "Булкин", firstName = "Николай", patronymic = "Петрович", groupNumber = 1, performance = new int[] { 5, 5, 5, 5, 4 } };
        students[5] = new Student { lastName = "Котов", firstName = "Илья", patronymic = "Дмитриевич", groupNumber = 3, performance = new int[] { 3, 3, 3, 4, 4 } };
        students[6] = new Student { lastName = "Нефедов", firstName = "Алексей", patronymic = "Антонович", groupNumber = 3, performance = new int[] { 4, 4, 4, 5, 5 } };

        //сортируем массив по среднему баллу
        Array.Sort(students, (s1, s2) => s1.CalculateAverage().CompareTo(s2.CalculateAverage()));

        Console.WriteLine("Студенты, упорядоченные по среднему баллу:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.lastName} {student.firstName} {student.patronymic}, Группа: {student.groupNumber}, Средний балл: {student.CalculateAverage()}");
        }
    }
}
