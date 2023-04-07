using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// switched to file-scoped name space, instead of encapsulating all in brace
namespace Section_3_Lesson_2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
}