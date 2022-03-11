int number;
double sum=0;
int counter=-1;

do
{

System.Console.WriteLine("nomre bede");
number=Convert.ToInt32(Console.ReadLine());

sum=sum+number;
counter++;

    
} while (number!=0);


System.Console.WriteLine(sum/counter);