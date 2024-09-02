using System.Globalization;

Console.Clear();

decimal value = 10342.24m; // Geralmente utilizamos o decimal para trabalhar com valores

Console.WriteLine("=======================");
Console.WriteLine("  Usando Culture Info  ");
Console.WriteLine("=======================");

// Convertendo os valores para uma cultura especifica.
// Para mais detalhes de cultura, podemos ir no Repo WorkingWithDates
// que cabe para os dois, datas e moedas.
Console.WriteLine(value.ToString(CultureInfo.CreateSpecificCulture("en-US")));

// Utilizando formatadores numericos

// Numerico
Console.WriteLine(value.ToString(
    "G",
    CultureInfo.CreateSpecificCulture("pt-BR")
    )
);

// Currency
Console.WriteLine(value.ToString(
    "C",
    CultureInfo.CreateSpecificCulture("pt-BR")
    )
);
Console.WriteLine(value.ToString(
    "C",
    CultureInfo.CreateSpecificCulture("en-US")
    )
);
Console.WriteLine(value.ToString(
    "C",
    CultureInfo.CreateSpecificCulture("es-ES")
    )
);

// Outra forma de formatar, porém não tão comum.
Console.WriteLine(string.Format("{0:C}", value));

// Formatação numero grande
Console.WriteLine(value.ToString(
    "E04",
    CultureInfo.CreateSpecificCulture("pt-BR")
    )
);

// Precisão maior 
Console.WriteLine(value.ToString(
    "F",
    CultureInfo.CreateSpecificCulture("pt-BR")
    )
);

// Também formata para numero sem o cifrão na frente
Console.WriteLine(value.ToString(
    "N",
    CultureInfo.CreateSpecificCulture("pt-BR")
    )
);

// Porcentagem 
Console.WriteLine(value.ToString(
    "P",
    CultureInfo.CreateSpecificCulture("pt-BR")
    )
);


Console.WriteLine("======================");
Console.WriteLine(" Conversão de valores");
Console.WriteLine("======================");

// Conversão de valores 
Console.WriteLine(Math.Round(value)); // Arredonda
Console.WriteLine(Math.Ceiling(value)); // Arredonda pra cima
Console.WriteLine(Math.Floor(value)); // Arredonda pra baixo

