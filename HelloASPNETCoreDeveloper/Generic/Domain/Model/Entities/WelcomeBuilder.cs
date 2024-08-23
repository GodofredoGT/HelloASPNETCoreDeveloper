namespace HelloASPNETCoreDeveloper.Generic.Domain.Model.Entities;

public class WelcomeBuilder
{
    public static string Build(string name)
    {
        return name == null ? "Welcome! ": $"Welcome {name}";
    }
}