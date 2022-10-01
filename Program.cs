//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения 
//алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string [] ReadData(string line)
{
    string[] arr = new string[5];
    for (int i=0;i<arr.Length;i++){
        Console.WriteLine(line);
        arr[i]=Console.ReadLine();
    }
    return arr;
}

string [] RecreateArr (string []arr)
{
    string [] newarr=new string [5];
    for (int i=0;i<arr.Length;i++){
        if (arr[i].Length<=3){
        newarr[i]=arr[i];
    }}
    return newarr;
}

void PrintData(string []newarr)
{
    for (int i=0;i<newarr.Length;i++){
        if (newarr[i]!=null){
            Console.Write(newarr[i]+", ");}}
}

string []arr = ReadData("Input any symbol, text or number five times: ");
string [] newarr=RecreateArr(arr);
Console.WriteLine("New array:");
PrintData(newarr);

