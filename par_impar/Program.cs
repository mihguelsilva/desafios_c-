for (int c = 1; c <= 100; c++) {
    int operacao = c % 2;
    if (operacao == 0) {
	Console.WriteLine($"{c} é um número par");
    } else {
	Console.WriteLine($"{c} é um número ímpar");
    }
}
