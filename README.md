# Итоговая проверочная работа

## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 

## Решение:
Для написания программы необходимо написать следующие методы:
1. Функция ввода исходного массива - `string[] InputArray() `;

2. Функция нахождения и вывода элементов массива длина которых меньше или равна "n" - `void ProductArray(string[] array, int n)`,

   где `string[] array` - это рассматриваемый массив;

   `int n` - максимальная длина элемента массива, который выводим на печать.

### Алгоритм:

С помощью цикла `for` перебираем все элементы массива и выводим на печать те, длина которых меньше трёх.

### Решение задачи на языке С#:

```C#
//Функция ввода исходного массива.
string[] InputArray()
{
    Console.WriteLine("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

//Функция нахождения и вывода элементов массива длина которых меньше или равна "n"
void ProductArray(string[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            Console.Write(array[i] + ", ");
        }
    }

}

string[] array = InputArray();
ProductArray(array, 3);
```
### Блок-схема:

![Блок-схема](https://github.com/PurosovMV/Test_1/blob/main/Flowchart/%D0%91%D0%BB%D0%BE%D0%BA-%D1%81%D1%85%D0%B5%D0%BC%D0%B0.jpg?raw=true)


P.S. 
В папке `Flowchart` находится файл с блок-схемой;
В папке `Program` находится файл программа для решения данной задачи.
