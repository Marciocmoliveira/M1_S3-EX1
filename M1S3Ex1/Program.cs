using M1S3Ex1;

Produto produto1 = new Produto("calculadora", 5.99, 199);
Produto produto2 = new Produto();

Console.WriteLine($" O produto tem nome: {produto1.nome}, valor: {produto1.preco}, quantidade: {produto1.quantidade}" );
Console.WriteLine($" O produto tem nome: {produto2.nome}, valor: {produto2.preco}, quantidade: {produto2.quantidade}");
