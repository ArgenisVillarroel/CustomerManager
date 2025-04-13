// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bienvenido a Administrador de Clientes");

Customer customerTest = Customer.Instance(1, "Argenis", "Villarroel", "Desconocida", "Contado", Environment.UserName);

Console.WriteLine(customerTest.FullName);
Console.WriteLine(customerTest.AuditInfo);

customerTest.ChangeName("Arturo", "Davila", Environment.UserName);

Console.WriteLine(customerTest.FullName);
Console.WriteLine(customerTest.AuditInfo);

customerTest.Delete(Environment.UserName);

Console.WriteLine(customerTest.FullName);
Console.WriteLine(customerTest.AuditInfo);
