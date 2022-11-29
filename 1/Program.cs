// Seminar3

// 1 метод, ничего не принимает и ничего не возвращает, просто что то делает из того, что в нем есть

void Method1()
{
    Console.WriteLine("к примеру всегда в конце пишет какой то текст");
}

Method1();  // вызвать метод 

// 2 метод, чтото  принимает но ничего не возвращает, просто что то делает из того, что в него отправить и выдаст какой то результат

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "какой то текст");

// пример:

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);    // вызвать метод 
// или 
Method21(msg: "Текст", count: 4);   // вызвать метод 

// 3 метод, ничего не принимает но что то возвращает, просто что то делает из того, что в нем есть и отправляет результат туда, куда указать

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();     // вызвать метод 
Console.WriteLine(year);    // вызвать метод 

// 4 метод, что то принимает и что то возвращает, принял, обработал, куда то отправил

string Method4(int count, string c)   
{
    int i = 0;
    string result = string.Empty;   // result задаем изначально как пустая строка (типо если написать вместо String.Empty любое число)
    while (i < count)
    {
        result = result + c ;
        i++;
    }
    return result;
}
string res =  Method4(10, "123");    // вызвать метод 
Console.WriteLine(res);     // вызвать метод 


string Method41(int count, string c)   
{
    string result = string.Empty;   
    for (int i=0; i<count; i++)
    {
        result = result + c ;
    }
    return result;
}
string res =  Method41(10, "123");   
Console.WriteLine(res);     


// создание таблици умножения через цикл for
for (int i = 2; i<=10; i++)
{
    for (int j=0;j<=10; j++)
    {
        Console.WriteLine($"{i}x{j}={i*j}");
    }
    Console.WriteLine();
}


// работа с текстом

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012345
// // s[3]      =    r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;  
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);

// работа с сортировкой

int[] arr ={1,2,3,4,5,6,7,8,1,1,1}; // перемещение массива в цифру

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
      Console.Write($"{array[i]} ");  
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // сортировка
{
    
    for (int i = 0; i < array.Length -1; i++)
    {
        int min = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j]> array[min]) min = j;
        }
        int temporary = array[i];
        array[i] = array[min];
        array[min] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);