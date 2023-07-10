// See https://aka.ms/new-console-template for more information
using LMS;
Console.WriteLine("Hello, World!");
Console.WriteLine("My name is anupam");
Console.WriteLine("Anupam ,Zope");
int x=20;
Console.WriteLine(x);
int y=30;
Console.WriteLine(y);
int add=x+y;
Console.WriteLine("Add = " + add);
DateTime currenttime=DateTime.Now;
Console.WriteLine(currenttime);
String cdac="IACSD";
Console.WriteLine(cdac);
bool t=true;
Console.WriteLine(t);
DateTime birthdate=new DateTime(1999,02,02);
DateTime registrationdate = new DateTime(2023,03,16);
Console.WriteLine(birthdate);
Console.WriteLine(registrationdate);

//int PRN , String course , DateTime registrationdate,
// string firstName , string lastName , string email ,string contactNumber , DateTime birthDate)
//base:(firstName,lastName,email,contactNumber,birthDate)

Student sd1=new Student(12354,"DAC",registrationdate,"Anupam","Zope","anupam12@gmail.com","7507159875",birthdate);
Console.WriteLine(sd1);
