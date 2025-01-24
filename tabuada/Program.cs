/*for(int a = 0; a <= 10; a++) {
    Console.WriteLine($"Tabuada do {a}");
    for (int b = 0; b <= 10; b++) {
	Console.WriteLine($"{a} x {b} = {(a * b)}");
    }
}
int c = 1;
while (c <= 10) {
    int cl = 1;
    Console.WriteLine($"Tabuada do {c}");
    while (cl <= 10) {
	Console.WriteLine($"{c} x {cl} = {(c * cl)}");
	cl++;
    }
    c++;
    Console.WriteLine();
}
*/
int c = 1;
do {
    int cl = 1;
    Console.WriteLine($"Tabuada do {c}");
    do {
	Console.WriteLine($"{c} x {cl} = {(c * cl)}");
	cl++;
    } while(cl <= 10);
    Console.WriteLine();
    c++;
} while(c <= 10);
