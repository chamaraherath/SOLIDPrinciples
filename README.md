# SOLIDPrinciples
Pet project for practice SOLID Principles


The SOLID principles are five key design principles in object-oriented programming that help make code more maintainable,
scalable, and testable. Here's a breakdown with an interview-friendly explanation:

1. Single Responsibility Principle (SRP)
👉 “A class should have only one reason to change.”

Explanation: Each class should have only one job or responsibility. If a class is responsible for multiple things,
changes in one area can impact other functionalities, making it harder to maintain.
Example (Without Code): Suppose you have a Report class that both generates and saves reports.
If the saving mechanism changes (e.g., from saving to a file to saving in a database),
the class must be modified. Instead, these responsibilities should be separated into different classes (e.g., ReportGenerator and ReportSaver).


2. Open/Closed Principle (OCP)
👉 “A class should be open for extension but closed for modification.”

Explanation: You should be able to extend a class's behavior without modifying its existing code. 
This is typically achieved through abstraction (interfaces, base classes) and polymorphism.
Example: If a PaymentProcessor class supports credit card payments but you want to add PayPal support,
modifying the existing class violates OCP. Instead, create an interface (e.g., IPaymentMethod) 
and implement different payment methods without modifying the original processor.


3. Liskov Substitution Principle (LSP)
👉 “Subtypes must be substitutable for their base types.”

Explanation: A derived class should be usable wherever its base class is used, without breaking functionality.
It ensures that the subclass maintains the behavior expected by the parent class.
Example: If a Bird class has a Fly() method, and you derive a Penguin class from it, 
calling penguin.Fly() would be incorrect because penguins can’t fly. Instead, 
the base class should be structured to avoid such violations, like having a separate IFlyingBird interface.

4. Interface Segregation Principle (ISP)
👉 “Clients should not be forced to depend on interfaces they do not use.”

Explanation: Instead of having large, bloated interfaces, break them into smaller, more specific ones.
This prevents classes from implementing unnecessary methods.
Example: If an IMachine interface has methods Print(), Scan(), and Fax(),
a simple printer that only prints would be forced to implement unused methods.
Instead, separate interfaces like IPrinter, IScanner, and IFaxMachine should be created.

5. Dependency Inversion Principle (DIP)
👉 “High-level modules should not depend on low-level modules. Both should depend on abstractions.”

Explanation: Instead of high-level classes directly depending on low-level implementations, 
both should depend on an abstraction (e.g., an interface or abstract class). This promotes loose coupling.
Example: If a NotificationService directly depends on EmailSender, 
switching to an SMS sender would require modifying the service.
Instead, define an INotificationSender interface and make EmailSender and SmsSender implement it. 
Now, the service can work with any sender.