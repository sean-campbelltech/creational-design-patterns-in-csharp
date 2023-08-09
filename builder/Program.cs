// Director
using Builder;

Email email = new EmailBuilder()
        .AddFrom("info@campbelltech.co.za")
        .AddTo("john@gmail.com")
        .AddTo("jane@yahoo.com")
        .AddCc("jones@campbelltech.io")
        .WithSubject("Builder Design Pattern Tutorial")
        .WithBody("Check out this awesome blog on the Builder Pattern")
        .AddAttachment("Builder-Pattern.pdf")
        .Build();

email.Send();
