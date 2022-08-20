/*
Задайте массив из 12 элементов, заполненный 
случайными числами из промежутка [-9, 9]. Найдите сумму 
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна 
-20
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


int[] RandomArraySum()
{
    int[] array=new int[12];
    int[] answer=new int[2];
    int sum_pos=0;
    int sum_neg=0;

    for(int i=0;i<12;i++)
    {
        array[i]=new Random().Next(-9,8);
        if(array[i]<0) {sum_neg+=array[i];}
        if(array[i]>0) {sum_pos+=array[i];}

    }
    PrintArray(array);
    answer[0]=sum_pos;
    answer[1]=sum_neg;

    return answer;


}

int[] array=RandomArraySum();
System.Console.WriteLine($"positive and negative numbers sums are: {array[0]} and {array[1]}");
