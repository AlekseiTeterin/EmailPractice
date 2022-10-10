using EmailPractice;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IMailKit, MailKitEmailSender>();
builder.Services.AddHostedService<BackgroundMessageSender>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/email_sender", (IMailKit sender) =>
    sender.Send(
    "TestProgram",
    "asp2022pd011@rodion-m.ru",
    "alexey_teterin@mail.ru",
    "Testing",
    "<h1>Some text for testing!!!</h1>"
    ));

app.Run();
