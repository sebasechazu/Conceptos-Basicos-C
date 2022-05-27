
CuentaBancaria cuenta1 = new CuentaBancaria();
cuenta1.titularCta = "Juan Perez";
cuenta1.cuit = "20-12345678-9";
cuenta1.saldo = 1000.50;
cuenta1.numeroCBU = 123456789;

CuentaBancaria cuenta2 = new CuentaBancaria();
cuenta2.titularCta = "Maria Gomez";
cuenta2.cuit = "20-98765432-9";
cuenta2.saldo = 2000.50;
cuenta2.numeroCBU = 987654321;

Console.WriteLine("Cuenta 1: " + cuenta1.titularCta + " - " + cuenta1.cuit + " - " + cuenta1.saldo + " - " + cuenta1.numeroCBU);

Console.WriteLine("Cuenta 2: " + cuenta2.titularCta + " - " + cuenta2.cuit + " - " + cuenta2.saldo + " - " + cuenta2.numeroCBU);