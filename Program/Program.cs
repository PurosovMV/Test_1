
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
