namespace HR;
public class Person{
    private string firstName;
    private string lastName;
    private DateTime birthDate;
    private string contactNumber;
    private String email;

    //constructor overloading
    public Person(){

    }
    public Person(string firstName, string lastName , DateTime birthDate, string contactNumber,string email)
    {
        this.firstName=firstName;
        this.lastName=lastName;
        this.contactNumber=contactNumber;
        this.birthDate=birthDate;
        this.email=email;
    }

    //override toString
    public  override string ToString(){
        string data=base.ToString();
        Console.WriteLine(data + "/n");
        return data + this.firstName + " " + this.lastName + " " + this.contactNumber + " " + this.birthDate + " " + this.email;
    }

    //destructor call GC
    ~Person()
    {}
    //setters and getters
    public void setFirstName(string name)
    {
        this.firstName=name;
    }

    public string getFirstName()
    {
        return firstName;
    }
    //property syntax
    public string FirstName
    {
        get{return this.firstName;}
        set{this.firstName=value;}
    }
}