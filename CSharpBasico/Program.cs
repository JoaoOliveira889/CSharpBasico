using CSharpMethods.Construtores;
using CSharpMethods.Dtos;
using CSharpMethods.Encapsulamento;
using CSharpMethods.Funcoes;
using CSharpMethods.Metodos;
using CSharpMethods.Properties;
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
//Console.WriteLine("Entre os dados do produto:");

//Console.Write("Nome: ");
//string nome = Console.ReadLine();

//Console.Write("Preço: ");
//double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.Write("quantidade no estoque: ");
//int quantidade = int.Parse(Console.ReadLine());

////Construtor
//Produto p = new(nome, preco, quantidade);
////Construtor sobrecarga
//Produto p2 = new Produto(nome, preco);

//Console.WriteLine();
//Console.WriteLine("Dados do produto: " + p);
//Console.WriteLine();
//Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
//int qte = int.Parse(Console.ReadLine());
//p.AdicionarProdutos(qte);
//Console.WriteLine();
//Console.WriteLine("Dados atualizados: " + p);
//Console.WriteLine();
//Console.Write("Digite o número de produtos a ser removido do estoque: ");
//qte = int.Parse(Console.ReadLine());
//p.RemoverProdutos(qte);
//Console.WriteLine();
//Console.WriteLine("Dados atualizados: " + p);
#endregion

#region Encapsulmaento
//ProdutoEncap p = new("TV", 500.00, 10);

//p.SetNome("TV 4k");

//Console.WriteLine(p.GetNome());
#endregion

#region Properties
//ProdutoProp p = new("TV", 500.00, 10);
//p.Nome = "TV 4k";
//Console.WriteLine(p.Nome);
#endregion

#region Vetores Struct
////Somar altura e exibir a media 8
//int tamanhoVetor = int.Parse(Console.ReadLine());

//double[] vect = new double[tamanhoVetor];

//for (int i = 0; i < tamanhoVetor; i++)
//{
//    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//}

//double sum = 0.0;
//for (int i = 0; i < tamanhoVetor; i++)
//{
//    sum += vect[i];
//}

//double avg = sum / tamanhoVetor;

//Console.WriteLine("Altura media é: " + avg.ToString("F2", CultureInfo.InvariantCulture));
#endregion

#region Vetores Tipo Classe
//int n = int.Parse(Console.ReadLine());

//ProdutoDto[] vect = new ProdutoDto[n];

//for (int i = 0; i < n; i++)
//{
//    string name = Console.ReadLine();
//    double price = double.Parse(Console.ReadLine());
//    vect[i] = new ProdutoDto { Name = name, Price = price };
//}

//double sum = 0.0;
//for (int i = 0; i < n; i++)
//{
//    sum += vect[i].Price;
//}

//double avg = sum / n;

//Console.WriteLine("Preço medio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
#endregion

#region Modificador de Parametros params
//int s1 = Calculator.Sum(2, 3, 4);

//Console.WriteLine(s1);
#endregion

#region Lista
//List<string> list = new();
////Método Add
//list.Add("João");
//list.Add("Alexa");
//list.Add("Siri");
////Método Insert
//list.Insert(2, "Ana");

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//string s1 = list.Find(x => x[0] == 'A') ?? "not find"; //Primeira ocorrencia com a Letra 'A' na lista
//string s2 = list.FindLast(x => x[0] == 'A') ?? "not find"; //Ultima ocorrencia com a Letra 'A' na lista
//Console.WriteLine("First 'A':" + s1);
//Console.WriteLine("Last 'A':" + s2);

//int pos1 = list.FindIndex(x => x[0] == 'A'); //possição do primeiro elemento da lista que começa com a Letra 'A'
//int pos2 = list.FindLastIndex(x => x[0] == 'A'); //possição do ultimo elemento da lista que começa com a Letra 'A'
//Console.WriteLine("First position 'A': " + pos1);
//Console.WriteLine("Last position 'A': " + pos2);

//List<string> list2 = list.FindAll(x => x.Length == 4);
//foreach (string item in list2)
//{
//    Console.WriteLine(item);
//}

//list.Remove("Alexa"); //Remove um elemento especifico
//Console.WriteLine("--------");
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//list.RemoveAll(x => x[0] == 'A'); //Remove todos os elementos com o filtro
//Console.WriteLine("--------");
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//list.RemoveAt(1); //Remove o elmento da posição informada
//Console.WriteLine("--------");
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//list.RemoveRange(2, 2); //Remove elementos de uma faixa
//Console.WriteLine("--------");
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Matrizes
//double[,] mat = new double[2, 3];
//Console.WriteLine(mat.Length); //{6} total elementos dentro da matriz
//Console.WriteLine(mat.Rank); //{2} quanto e a primeira dimensão da matriz
//Console.WriteLine(mat.GetLength(0)); //{2} a primeira dimensão da matriz tem tamanho 2
//Console.WriteLine(mat.GetLength(1)); //{2} a segunda dimensão da matriz tem tamanho 3
//#endregion
//#region Switch
//int x = int.Parse(Console.ReadLine());
//string day;

//day = x switch
//{
//    1 => "Sunday",
//    2 => "Monday",
//    3 => "Tuesday",
//    _ => "Invalid value",
//};

//Console.WriteLine("Day " + day);
#endregion

#region Condicional Ternária
//double preco = 34.5;
//double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
//Console.WriteLine(desconto);
#endregion

#region Funções string
//string original = "abcde FGET AVS asbc   ";
//string s1 = original.ToUpper();//Transforma em maiuscula
//string s2 = original.ToLower();//transforma em minuscula
//string s3 = original.Trim();//apaga os espaços em branco no final

//int n1 = original.IndexOf("bc");//procura valores dentro da string e retorna a posição da primeira ocorrencia
//int n2 = original.LastIndexOf("bc");//procura valores dentro da string e retorna a posição da ultima ocorrencia

//string s4 = original.Substring(3);//recorta parte da string a partir do indexe informado
//string s5 = original.Substring(3, 5);//recorta a string a partir do indexe informado e exibe a quantidade de caracteres informados
//string s6 = original.Replace('a', 'x');//troca o caractere informado pelo novo.
//string s7 = original.Replace("abc", "xy");//troca toda a ocorrencia da string pelo novo

//bool b1 = string.IsNullOrEmpty(original);//testa se a variavel e nulo ou vazio
//bool b2 = string.IsNullOrWhiteSpace(original);//testa se a variavel e nulo ou espaço em branco

//Console.WriteLine(s5);
#endregion

#region DateTime
//DateTime d = new(2022, 3, 17, 13, 45, 58, 276);

//Console.WriteLine(d);
//Console.WriteLine("1) Data: " + d.Date);
//Console.WriteLine("2) Dia: " + d.Day);
//Console.WriteLine("3) Dia da Semana: " + d.DayOfWeek);
//Console.WriteLine("4) Dia do Ano: " + d.DayOfYear);
//Console.WriteLine("5) Hora: " + d.Hour);
//Console.WriteLine("6) Kind: " + d.Kind);
//Console.WriteLine("7) Milesegundo: " + d.Millisecond);
//Console.WriteLine("8) Minuto: " + d.Minute);
//Console.WriteLine("9) Mes: " + d.Month);
//Console.WriteLine("10) Ticks: " + d.Ticks);
//Console.WriteLine("11) Horario do dia: " + d.TimeOfDay);
//Console.WriteLine("12) Ano: " + d.Year);

//string s1 = d.ToLongDateString(); //data em formato longo
//string s2 = d.ToLongTimeString(); //hora formato longo
//string s3 = d.ToShortDateString();//data formato curto
//string s4 = d.ToShortTimeString();//hora formato curto

//string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");//formata data
//string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");//formata data com milesegundo

//DateTime d1 = d.AddDays(5);//Acrescenta dias
//DateTime d2 = d.AddHours(2);//Acrescenta horas
//DateTime d3 = d.AddMinutes(3);//Acrescenta minutos

//DateTime da1 = new(2022, 10, 12);
//DateTime da2 = new(2022, 10, 18);
//TimeSpan t = da2.Subtract(da1);//diferenca entre data 1 e data 2
#endregion

#region TimeSpan
TimeSpan t1 = new(1, 12, 30);//hora/minuto/segundo
TimeSpan t2 = new(days: 1, 2, 11, 21);//dia/hora/minuto/segundo
TimeSpan t3 = new(1, 2, 11, 21, 321);//dia/hora/minuto/segundo/milisegundos

TimeSpan t4 = TimeSpan.FromDays(1.5);//cria um TimeSpan de 1 dia e 12 horas (1 dia e meio)
TimeSpan t5 = TimeSpan.FromHours(1.5);//cria um TimeSpan de 1 hora e 30 minutos

Console.WriteLine("Dias" + t2.Days);
Console.WriteLine("Horas" + t2.Hours);
Console.WriteLine("Minutos" + t2.Minutes);
Console.WriteLine("Total Dia" + t2.TotalDays);
Console.WriteLine("Total Hora" + t2.Hours);

TimeSpan sum = t1.Add(t2);//Soma t1 com t2
TimeSpan dif = t2.Subtract(t1);//subitrai t2 com t1
TimeSpan mult = t2.Multiply(2.0);//Multiplica t2 por 2
TimeSpan div = t2.Divide(2.0);//Divide t2 por 2
#endregion