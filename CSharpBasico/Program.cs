using CSharpBasico.Construtores;
using CSharpBasico.Metodos;
using System.Globalization;

#region GeradorAleatorio
//var numeroRange = GeradorNumeroAleatorio.GeradorRange();
//var numeroConcatenado = GeradorNumeroAleatorio.GeradorConcat();
//Console.WriteLine(numeroRange);
//Console.WriteLine(numeroConcatenado);

#endregion
#region Trabalhando Com Datas
//var dataAtual = DateTime.Now;
//var subtraiDia = ManipulacaoDatas.SubtraiDias(dataAtual, 1);
//var AcrescentaDia = ManipulacaoDatas.AcrescentaDias(dataAtual, 1);
//var subtraiMes = ManipulacaoDatas.SubtraiMeses(dataAtual, 1);
//var AcrescentaMes = ManipulacaoDatas.AcrescentaMeses(dataAtual, 1);
//var subtraiAno = ManipulacaoDatas.SubtraiAnos(dataAtual, 1);
//var AcrescentaAno = ManipulacaoDatas.AcrescentaAnos(dataAtual, 1);

//Console.WriteLine(subtraiDia);
//Console.WriteLine(AcrescentaDia);
//Console.WriteLine(subtraiMes);
//Console.WriteLine(AcrescentaMes);
//Console.WriteLine(subtraiAno);
//Console.WriteLine(AcrescentaAno);
#endregion
#region Construtores

Console.WriteLine("Entre os dados do produto:");

Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine());

//Construtor
Produto p = new Produto(nome, preco, quantidade);
//Construtor sobrecarga
Produto p2 = new Produto(nome, preco);

Console.WriteLine();
Console.WriteLine("Dados do produto: " + p);
Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);
Console.WriteLine();
Console.Write("Digite o número de produtos a ser removido do estoque: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

#endregion