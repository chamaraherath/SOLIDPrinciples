using SOLIDPrinciple;
using SOLIDPrinciple.Liskov;
using SOLIDPrinciple.SingleReponsibility;
using SOLIDPrinciples;

Console.WriteLine("Welcome to Solid Principles!");

Console.WriteLine("Single Reponsiblity Principle...");
Console.WriteLine("================================ \n");

Employee employee = new Employee("Chamara Herath", 55000);
employee.ToString();

SalaryCalculator salaryCalculator = new SalaryCalculator(employee);
salaryCalculator.Calc();

PaySlipPrinter payslipPrint = new PaySlipPrinter(employee);
payslipPrint.PrintPaySlip();

Console.WriteLine("\n");
Console.WriteLine("Open Close Principle...");
Console.WriteLine("======================== \n");

List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car(),
            new Moterbike(),
            new Bicycle() 
        };

foreach (var vehicle in vehicles)
{
    vehicle.Move();
};

Console.WriteLine("\n");
Console.WriteLine("Liskov Substitution Principle...");
Console.WriteLine("======================== \n");

List<IFlyingBird> flyingBirds = new List<IFlyingBird>
{
    new Sparrow("Sparrow")
};

foreach (var bird in flyingBirds)
{
    bird.Fly();  // No risk of breaking LSP
}

ISwimmingBird penguin = new Penguin ("Penguin");
penguin.Swim();

Console.WriteLine("\n");
Console.WriteLine("Interface Segregation Principle...");
Console.WriteLine("======================== \n");


BasicPrinter basicPrinter = new BasicPrinter();
IntermediatePrinter intermediatePrinter = new IntermediatePrinter();
AdvancePrinter advancePrinter = new AdvancePrinter();


basicPrinter.Print();

intermediatePrinter.Print();
intermediatePrinter.Scan();

advancePrinter.Print();
advancePrinter.Scan();
advancePrinter.Fax();

Console.WriteLine("\n");
Console.WriteLine("Dependency Inversion Principl...");
Console.WriteLine("======================== \n");

IEmailSender gmailSender = new GmailSender();
IEmailSender outlookSender = new OutlookSender();
EmailService emailService1 = new EmailService(gmailSender);
EmailService emailService2 = new EmailService(outlookSender);

emailService1.NotifyUser();
emailService2.NotifyUser();