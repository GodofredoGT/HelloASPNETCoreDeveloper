using HelloASPNETCoreDeveloper.Generic.Domain.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPNETCoreDeveloper.Generic.Interfaces.REST.Controllers;

//anotation atributes = patron decoration
[ApiController]
[Route("[controller]")]//lo que hace es que de la class controller elimina el nombre controller y pone el nombre a mostra en el dominio de la web para ser incocado por el router
public class WelcomeController: ControllerBase //en microsoft el API ->ASP.CORE-> ES UN DECESDIENE DE LA CLASE DE Framework
{
 
    [HttpGet]//esto lo convierte en action la funtion
    public string welcome()
    {
        return WelcomeBuilder.Build(null);
    }

    [HttpGet("{name}")]//idica que va los paramentros de la fucnion si es para cada fucntion pero si es globla solo 
    public string welcome(string name)
    {
        return WelcomeBuilder.Build(name);
    }
}