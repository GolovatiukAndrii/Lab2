class Employee
{
    private string name;
    private string alias;
    private decimal salary = 3000.00m;
    // конструктор
    public Employee(string name, string alias)
    {
        // використання для зв’язки полів name та alias:
        this.name = name; this.alias = alias;
    }
    public void printemployee()
    {
        System.Console.WriteLine("Ім’я: {0}\nспевдонім: {1}", name, alias);
        System.Console.WriteLine("Податки: {0:C}", Tax.Calctax(this));
    }
    public decimal Salary
    { get { return salary; } }
}
class Tax
{
    public static decimal Calctax(Employee E)
    { return 0.08m * E.Salary; }
}
class Mainclass
{
    static void Main()
    {
        // створення обєктів:
        Employee E1 = new Employee("Лари́са Ко́сач-Кві́тка", "Леся Українка");
        E1.printemployee(); // вивід результатів
    }
}

