// See https://aka.ms/new-console-template for more information

// Exercicio 1
//Console.WriteLine("exercicio 1");
//Console.ReadKey();
//Console.WriteLine("programa de multiplicação");
//Console.ReadKey();
//Console.WriteLine("Informe um número");
//int number_1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe um outro número e obtenha o resultado");
//int number_2 = int.Parse(Console.ReadLine());
//int resultado = number_1 * number_2;
//Console.WriteLine(resultado);

// Exercicio 2 
//Console.WriteLine("Area de um retangulo");
//Console.WriteLine("Informe a largura do retangulo");
//int largura = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o comprimento");
//int comprimento = int.Parse(Console.ReadLine());
//int area = largura * comprimento;
//Console.WriteLine(" a area do retangulo corresponde a : " + area);

// Exercicio 3
//int a = 7;
//int b = a;
//int c = b;
//Console.WriteLine(b);

// Exercicio 4 
// Convertendo para Fahrenheit.
//Console.WriteLine("informe a temperatura de Celsius");
//float celsi = float.Parse(Console.ReadLine());
//float fahren = (celsi * 1.8f + 32);
//Console.WriteLine("Temperatura em Fahrenheit é de "  + fahren);
//Console.ReadKey();


//Exercicio 5
// número ao quadrado
//Console.WriteLine("Calculo de número ao quadrado");
//double num_quad = double.Parse(Console.ReadLine());
//double quadrado = (num_quad * num_quad);
//Console.WriteLine($"o numero {num_quad} ao quadrado é igual a {quadrado}");

//Exercicio 6 
//Console.WriteLine("Informe a nota do Aluno no projeto 1");
//double projeto_1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Informe a nota do Aluno no projeto 2");
//double projeto_2 = double.Parse(Console.ReadLine());
//Console.WriteLine("Informe a nota do Aluno no projeto 3");
//double projeto_3 = double.Parse(Console.ReadLine());
//double media_project = (projeto_1 + projeto_2 + projeto_3) /3;
//Console.WriteLine($"A média adquirida pelo aluno é de {media_project}");

//Exercicio 7 ( Calcular IMC)

//Console.WriteLine("Digite seu peso");
//double peso = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite a altura ");
//double altura = Convert.ToDouble(Console.ReadLine());
//double imc = peso / (altura * altura);
//Console.WriteLine($"O valor do seu IMC  Índice de Massa Corporal é {imc}");

////Exercicio 8 (PI)

////double pi = 3.1415;


////Console.Write("Digite o raio do círculo: ");
////double raio = Convert.ToDouble(Console.ReadLine());


////double circunf = 2 * pi * raio;


////Console.WriteLine("A circunferência do círculo é: " + circunf);

////Exercicio 9 // descontos
//Console.WriteLine("Exercicio 9. Clique em enter");
//Console.ReadKey();

//Console.WriteLine("Qual produto você quer efetuar a compra? ");
//string produto_compra = Console.ReadLine();
//string laranja = "laranja";
//string manga = "manga";
//if (produto_compra.ToLower() == laranja)
//{
//    Console.WriteLine($"laranja é 6 reais ");
//}
//else if (produto_compra.ToLower() == manga)
//{
//    Console.WriteLine($"A manga custa 10 reais");
//}
//else
//{
//    Console.WriteLine("Produto não encontrado no sistema");
//    return;
//}

//Console.WriteLine("Escolha qual cupom usar");
//Console.WriteLine("Digite o desconto em porcentagem (Exemplo: 5, 10, 25) ");
//float desconto = float.Parse(Console.ReadLine());

//float precoProduto;
//float manga_valor = 10;
//float laranja_valor = 6;
//if (produto_compra.ToLower() == laranja)
//{
//    precoProduto = laranja_valor;
//}
//else if (produto_compra.ToLower() == manga)
//{
//    precoProduto = manga_valor;
//}
//else
//{
//    Console.WriteLine("Produto não encontrado no sistema");
//    return;
//}
//float precoComDesconto = precoProduto - (precoProduto * desconto / 100);

//Console.WriteLine($"Preço com desconto é {precoComDesconto}");


//Exercicio 10 (Comptas) 

// Solicita o valor do produto ao usuário


Console.WriteLine("Digite o valor do produto: ");
double valorProduto = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Digite a quantidade comprada: ");
int quantidadeComprada = int.Parse(Console.ReadLine());


double valorTotal = valorProduto * quantidadeComprada;


Console.WriteLine($"Valor total da compra: R$ {valorTotal} reais");
Console.ReadKey();






