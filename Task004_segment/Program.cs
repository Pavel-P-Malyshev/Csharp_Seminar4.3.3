/*
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в 
отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/




int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

//распечатка массива
void PrintArray (int[] col)
{

    int count=col.Length;
    int position=0;

    Console.Write("[ ");
    while(position<count) 
    {
        if(position==count-1)  {Console.Write($"{col[position]}");}
        else {Console.Write($"{col[position]}, ");}
        
        position++;
    }
    Console.WriteLine("] ");

}


int RandomArraySegment(int size, int min, int max)
{
    int[] array=new int[size];
    int answer=0;

    Random rnd=new Random();

    for(int i=0;i<array.Length;i++)
    {
        array[i]=rnd.Next(min,max+1);
        if ((array[i]>=10)&&(array[i]<=99)) {answer++;}
        

    }
    PrintArray(array);
       

    return answer;


}


int count=RandomArraySegment(Prompt("enter array size: "),Prompt("Enter min threshold: "), Prompt("Enter max threshold: "));
System.Console.WriteLine($"We found {count} elements in [10,99] range!");





