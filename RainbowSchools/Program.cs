// See https://aka.ms/new-console-template for more information

doWork();

void doWork()
{
    string [] studentdetails = File.ReadAllLines(@"C:\Venkata\trunk\simplilearn\section2.1.9\RainbowSchools\data\student.txt");
    foreach(string studentdetail in studentdetails)
    {
        Console.WriteLine(studentdetail);
    }
}