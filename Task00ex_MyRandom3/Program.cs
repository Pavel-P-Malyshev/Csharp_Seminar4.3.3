int MyRandom3()
{
    Random rnd= new Random();
    int answer=rnd.Next(-999,1000);
    return answer;
}


Console.WriteLine(MyRandom3());