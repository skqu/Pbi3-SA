using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var app = new WebApp(args);
app.Run();

/// <summary>
/// The WebApp class is responsible for setting up and running a basic web application.
/// It creates a web application using the ASP.NET Core framework, and maps a simple GET request.
/// 
/// <para>Mermaid Diagram:</para>
/// \startuml
/// graph TD
///     A[Start] --> B[Opret WebApp med args]
///     B --> C[Initialiser WebApplication Builder]
///     C --> D[Map "/" til "Hello World!"]
///     D --> E[Kør WebApp med Run-metoden]
///     E --> F[WebApp lytter til HTTP-anmodninger]
/// \enduml
/// </summary>
public class WebApp
{
    /// <summary>
    /// Stores the WebApplication instance that handles the HTTP requests and responses.
    /// </summary>
    private WebApplication _app;

    /// <summary>
    /// Initializes a new instance of the <see cref="WebApp"/> class.
    /// </summary>
    /// <param name="args">Command-line arguments passed to the web application, typically from Main method.</param>
    public WebApp(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        _app = builder.Build();
        
        // Maps the root endpoint ("/") to return a "Hello World!" response.
        _app.MapGet("/", () => "Hello World!");
    }

    /// <summary>
    /// Runs the web application and listens for incoming HTTP requests.
    /// </summary>
    public void Run()
    {
        _app.Run();
    }
}


public class Animal
{

}

public class Dog : Animal
{

}

public class Cat : Animal
{
    
}