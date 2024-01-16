using MathService;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Here is Factorial(5) = " + FactorialService.GetFactorialValueOf(5));

app.Run();
