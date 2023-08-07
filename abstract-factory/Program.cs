using AbstractFactoryCSharp;

Country country = Country.Spain;
IInternationalFactory factory = InternationalProvider.Create(country);
ILanguage language = factory.CreateLanguage();
ICapitalCity capital = factory.CreateCapital();

Console.WriteLine(country);
Console.WriteLine(capital.GetType().Name);
language.Greet();
Console.WriteLine("Total Population: " + capital.GetPopulation());
Console.WriteLine("Top Attractions: " + string.Join(", ", capital.ListTopAttractions()));
