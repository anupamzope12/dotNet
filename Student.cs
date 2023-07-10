using HR;
namespace LMS;
public class Student:Person{
    //member variable
    private int prn;
    private String course;
    private DateTime registrationdate;

    //member function

    public Student()
    {
        count++;
    }
    public Student(int prn , String course , DateTime registrationdate,
                   string firstName , string lastName , string email ,string contactNumber , DateTime birthDate)
                  :base(firstName,lastName,birthDate,contactNumber,email)
                //   string firstName, string lastName , DateTime birthDate, string contactNumber,string email
    {
        this.prn=prn;
        this.course=course;
        this.registrationdate=registrationdate;
        count++;
    }

    public static int count;
    public int getcount()
    {
        return count;
    }

    public override string ToString()
    {
        string data=base.ToString();
        return data + this.prn + " " + this.course + " " + this.registrationdate;
    }

}