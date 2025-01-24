/*
INICIALMENTE UTILIZEI O TIPO INT
CONTUDO, NOTAS PODEM VARIAR PARA 7.5
8.6 E ASSIM POR DIANTE
int nota1 = 7;
int nota2 = 7;
int mediaAluno = (nota1 + nota2)/2;
if (mediaAluno >= 7) {
    Console.WriteLine("Parabéns!\nVocê foi aprovado!");
} else {
    Console.WriteLine("Infelizmente você não passou!");
}
*/
/*
double nota1 = 7.5;
double nota2 = 6.6;
double mediaAluno = (nota1 + nota2) / 2;
if (mediaAluno >= 7) {
    Console.WriteLine("Parabéns\nVocê foi aprovado!");
} else {
    Console.WriteLine("Infelizmente você foi reprovado!");
}
*/
Console.WriteLine("Escreva o nome do aluno:");
string nomeAluno = Console.ReadLine();
Console.WriteLine("Escreva a sua primeira nota:");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escreva a segunda nota do aluno:");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());
decimal mediaAluno = (nota1 + nota2) / 2;
if (mediaAluno >= 7)
{
    Console.WriteLine($"O(a) aluno(a) {nomeAluno} foi aprovado(a)!");
} else
{
    Console.WriteLine($"O(a) aluno(a) {nomeAluno} foi reprovado(a)!");
}
