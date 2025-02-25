#Below are the principles implemented in the project:

##1. DRY (Don't Repeat Yourself)

The DRY principle is implemented as follows:

-Product class (./lab1/Product.cs) contains logic for handling product operations like price reduction and quantity changes, avoiding code duplication.
-Warehouse class (./lab1/Warehouse.cs) handles the list of products and operations like adding, removing, and finding products.
-Reporting class (./lab1/Reporting.cs) centralizes the reporting logic without code duplication.

##2. KISS (Keep It Simple, Stupid)

The KISS principle is ensured by:

Each class has a clear responsibility, making the code easier to maintain and understand:
-Product class manages product data, price, and quantity (./lab1/Product.cs).
-Warehouse class manages the collection of products and operations with them (./lab1/Warehouse.cs).
-Reporting class generates reports (./lab1/Reporting.cs)

##3.  S - Single Responsibility Principle (SRP)

-Product class has one responsibility — storing and operating on product data (./lab1/Product.cs).
-Warehouse class manages the list of products, handling adding, removing, and finding products (./lab1/Warehouse.cs).
-Reporting class handles report generation without mixing in other functionalities (./lab1/Reporting.cs)

##4. O - Open/Closed Principle (OCP)

-The Warehouse class can be extended without modifying its existing logic by implementing new methods via the IProductManager interface (./lab1/IProductManager.cs).
-The Reporting class can be modified to include new types of reports without changing its main logic (./lab1/Reporting.cs)

##5. L - Liskov Substitution Principle (LSP)

The Warehouse class inherits from the IProductManager interface and can be replaced with any other class that implements this interface without violating the correctness of the program (./lab1/Warehouse.cs)

##6. I - Interface Segregation Principle (ISP)

The IProductManager (./lab1/IProductManager.cs) and IReporting (./lab1/IReporting.cs) interfaces clearly separate concerns. IProductManager is responsible only for product operations, while IReporting is responsible only for generating reports

##7. D - Dependency Inversion Principle (DIP)

The Reporting class depends on the abstraction (IProductManager interface), not the concrete implementation of the Warehouse class. This allows the warehouse implementation to be changed without affecting the reporting class (./lab1/Reporting.cs)

##8. Composition Over Inheritance

The Composition Over Inheritance principle is implemented through the use of interfaces:

The Warehouse class (./lab1/Warehouse.cs) implements the IProductManager interface, allowing the implementation to be changed without inheritance. This allows for the replacement of implementations without modifying the Reporting class or other parts of the program

##9. Program to Interfaces, not Implementations

The Program to Interfaces principle is realized through:

The Reporting class (./lab1/Reporting.cs) works with the IProductManager interface rather than the concrete implementation of the Warehouse class. This allows the warehouse implementation to be swapped without changing the reporting class or the main program
