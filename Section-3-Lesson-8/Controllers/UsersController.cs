using Microsoft.AspNetCore.Mvc;

// research ?? -.controllers-
namespace Section_3_Lesson_8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "TEST - API from WebApp";
    }
    
    // id:int not covered yet, route parameter constraint
    // shows 404 when constraint broken, otherwise error
    [HttpGet("{id:int}")]
    public string Get(int id)
    {
        return $"Entered {id}";
    }
}
