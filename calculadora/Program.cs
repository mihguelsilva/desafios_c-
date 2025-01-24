// See https://aka.ms/new-console-template for more information
int num1 = 5;
int num2 = 10;
char op = '+';

if (op == '+') {
    Console.WriteLine(num1 + num2);
} else if (op == '-') {
    Console.WriteLine(num1 - num2);
} else if (op == '*') {
    Console.WriteLine(num1 * num2);
} else if (op == '/') {
    if(num2 == 0) {
	Console.WriteLine("Nenhum número é divisível por zero!");
    } else {
	Console.WriteLine(num1 / num2);
    }
} else {
    Console.WriteLine("Esta operação não existe!");
}
