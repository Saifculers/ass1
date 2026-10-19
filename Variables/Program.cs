Console.WriteLine("The mark is:");
int Mark = Convert.ToInt32(Console.ReadLine());

if (Mark > 100 || Mark < 0)
{
    Console.WriteLine("Invalid Input");
}
else if (Mark >= 50)
{
    Console.WriteLine("The student pass the exam");
}
else
{
    Console.WriteLine("The student didnt pass the exam"); 
}
// Saif Marabeh