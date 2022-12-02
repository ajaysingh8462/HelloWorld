// See https://aka.ms/new-console-template for more information
class Employee
{
    public int id;
    public string? name;
    public int age;
    public int birthday;
    public string? Gender;

    public void SetData(int id, string name, int age, int birthday, string gender)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.birthday = birthday;
        this.Gender = gender;

    }
    public void GetData()
    {
        Console.WriteLine("id : {0}, name : {1}, age : {2}, birthday :{3}, gender : {4}",
            id, name, age, birthday, Gender);

    }
    public static class Program
    {
        public static void Main(string[] args)
        {
            Employee employee= new Employee();
            employee.SetData(1, "ajay", 23, 13101999, " male");
            employee.GetData();
        } 
    }
    



}
