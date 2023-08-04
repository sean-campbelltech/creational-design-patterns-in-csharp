using AbstractFactoryCSharp;

Country country = Country.SPAIN;
ILanguage language = InternationalProvider.CreateLanguage(country);
ICapitalCity capital = InternationalProvider.CreateCapital(country);

Console.WriteLine(country);
Console.WriteLine(capital.GetType().Name);
language.Greet();
Console.WriteLine("Total Population: " + capital.GetPopulation());
Console.WriteLine("Top Attractions: " + string.Join(", ", capital.ListTopAttractions()));
