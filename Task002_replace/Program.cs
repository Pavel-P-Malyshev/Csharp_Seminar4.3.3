/*
Задача 2: Напишите программу замены элементов массива: 
положительные элементы замените на соответствующие 
отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
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


int[] RandomArrayReplace(int size, int min, int max)
{
    int[] array=new int[size];
    int[] answer=new int[size];
    Random rnd=new Random();

    for(int i=0;i<array.Length;i++)
    {
        array[i]=rnd.Next(min,max+1);
        answer[i]=array[i]*(-1);
        

    }
    PrintArray(array);
    PrintArray(answer);
   

    return answer;


}


int[] array=RandomArrayReplace(Prompt("enter array size: "),Prompt("Enter min threshold: "), Prompt("Enter max threshold: "));


