/*
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний 
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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


int[] RandomPairMult(int size, int min, int max)
{
    int[] array=new int[size];
    int[] answer=new int[(size%2==0) ? size/2 : size/2+1];
    int idx=0;
    int rvs_idx=size-1;
    int j=0;

    Random rnd=new Random();

    for(int i=0;i<array.Length;i++)
    {
        array[i]=rnd.Next(min,max+1);
  
    }

    while((idx<=rvs_idx) && (j<answer.Length))
    {
        answer[j]=array[idx]*array[rvs_idx];
        idx++;
        rvs_idx--;
        j++;
        //if(idx>rvs_idx)
    }

    PrintArray(array);
       

    return answer;


}


int[] mults=RandomPairMult(Prompt("enter array size: "),Prompt("Enter min threshold: "), Prompt("Enter max threshold: "));
System.Console.Write ($" Multiplication of pairs array:");
PrintArray(mults);




