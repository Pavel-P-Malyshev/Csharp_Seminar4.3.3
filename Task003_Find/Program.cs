/*
Задача 3: Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
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


bool RandomArrayFind(int size, int min, int max, int find)
{
    int[] array=new int[size];
    bool answer=false;

    Random rnd=new Random();

    for(int i=0;i<array.Length;i++)
    {
        array[i]=rnd.Next(min,max+1);
        if (array[i]==find) {answer=true;}
        

    }
    PrintArray(array);
       

    return answer;


}


bool array=RandomArrayFind(Prompt("enter array size: "),Prompt("Enter min threshold: "), Prompt("Enter max threshold: "), Prompt("which value do we search? "));
if(array) System.Console.WriteLine("We found it!");
else System.Console.WriteLine("We couldn't find it!");


