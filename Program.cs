Console.WriteLine($"ola seja bem vindo !");
Console.WriteLine($"vamos calcular a media 5 notas? ");
Console.WriteLine($"Lembre-se de digitar a tecla enter apos adiconar cada nota");

//entradas
Console.WriteLine($"digite nota 1:");
int nota1= int.Parse (Console.ReadLine());

Console.WriteLine($"digite nota 2:");
int nota2= int.Parse (Console.ReadLine());


Console.WriteLine($"digite nota 3:");
int nota3= int.Parse (Console.ReadLine());


Console.WriteLine($"digite nota 4:");
int nota4= int.Parse (Console.ReadLine());

Console.WriteLine($"digite nota 5:");
int nota5= int.Parse (Console.ReadLine());


int media = nota1+nota2+nota3+nota4+nota5 / 5;
Console.WriteLine($"A media das 5 notas e: {media}");

