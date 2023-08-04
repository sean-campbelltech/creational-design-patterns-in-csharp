using FluentBuilderCSharp;

SocialMediaPost post = new SocialMediaPostBuilder()
                            .AddTitle("The Builder Pattern")
                            .AddContent("Add the definition of a builder here")
                            .AddAuthor("Sean Campbell")
                            .AddTag("#designpatterns")
                            .AddTag("#csharp")
                            .SetPostDate(System.DateTime.Now)
                            .AddLink(new Uri("https://somelink.io"))
                            .Build();

Console.WriteLine(post.ToString());
