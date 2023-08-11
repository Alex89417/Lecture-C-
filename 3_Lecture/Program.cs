//                                   Виды методов
//                              Вид 1 - нечего не получают 

/* void Method1()                                // тип метода/ название метода
{
    Console.WriteLine("Автор ...");
}
Method1();                                       // так вызываются такие методы */




//                              Вид 2 - принимает аргумент

/* void Method2(string msg)                      //тип метода/ название метода(вид метода/название аргумента)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");     */               // так вызываются такие методы (что будет выводиться)*/

/* void Method2(string msg, int count)           //тип метода/ название метода(вид метода/название аргумента, вид метода/название аргумента)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method2("Текст", 4);                             // так вызываются такие методы (что будет выводиться, сколько раз)
Method2(count: 4, msg: "Текст");   */              // Можно указывать через : что какому аргументу присваеваем и даже не по порядку



//                               Вид 3 - Чтото возвращают но не чего не принимает    

/* int Method3()                                      // тип метода(int, double) название метода()
{
    return DateTime.Now.Year;
}

int year = Method3();                             // вызывается метод присваеванием его переменной 
Console.WriteLine(year);    */                      // выводится в консоль через переменную 



//                                Вид 4 - что-то принимает и что-то возвращает

/* string Method4(int count, string text)    // тип файлов который вернется/название Метода(тип/аргумент - которые будут приниматься методом)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result += text;                 // result = result + text
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res); */

//----------------------------------------------------------------------------------------------------------------------------------


//                                      // Можно использовать цикл в цикле

/* for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/



/* Task 1. Работа с текстом
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


string Replase(string text, char oldValue, char newValue)
{
string result = String.Empty;
int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result += newValue;
        else result += text[i];
    }
    return result;
}

Console.WriteLine(text);

Console.WriteLine();

string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replase(newText, 'с', 'С');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
*/


// Task 2. Отсортировка элементов массива от меньшего к большему:

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);


int[] Array = { 23, 255, 56, 41, 76, 83, 8 };

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


// метод сортировки стаканом
/* void SelectArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int arrMin = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[arrMin]) arrMin = j;
        }    

        int temp = array[i];
        array[i] = array[arrMin];
        array[arrMin] = temp;
    }
}
*/


// метод сортировки пузырьком
void SelectArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if  (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}


PrintArr(Array);
SelectArr(Array);

PrintArr(Array);
























