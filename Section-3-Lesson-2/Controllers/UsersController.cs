using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// switched to file-scoped name space, instead of encapsulating all in brace
namespace Section_3_Lesson_2.Controllers;

// RESTful way is to call controller name with verb
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase // file was plural, but class name set singular, why?
{
    // more on readonly collections: https://www.youtube.com/watch?v=7hBPI0xYezo
    private readonly static List<string> Users = new() // no paranthesis ? if List<string>()
    {
        "Ali",
        "Aisha",
        "Alex",
        "Sue"
    };

    // The {id} in the annotation binds to the variable in function parameter
    // GET: api/users<controller>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        // GerRange: from Index, Items Including Index
        // ..Next(): minimum include, max exclude
        return Users.GetRange(0, Random.Shared.Next(1, 5));
    }

    // GET: api/users<controller>/1
    [HttpGet("{id}")]
    public string Get(int id)
    {
        try
        {
            return Users[id];
        }
        catch (Exception ex)
        {
            return $"Requested ID: {id}, but returns Error: {ex.Message}";
        }

    }

    // POST: api/users<controller>/value
    [HttpPost]
    public void Post([FromBody] string value)
    { // Remove once hit, new VS feature
        Users.Add(value);
    }

    // DELETE: api/users<controller>/1
    [HttpDelete("{id}")]
    public HttpStatusCode Delete(int id)
    {
        try
        {
            Users.RemoveAt(id);
            return HttpStatusCode.OK;
        }
        catch {
            return HttpStatusCode.InternalServerError;
        }
    }

    // PUT: api/users<controller>/1
    [HttpPut("{id}")]
    public HttpStatusCode Put(int id, [FromBody] string value)
    {
        try
        {
            Users[id] = value;
            return HttpStatusCode.OK;
        }
        catch {
            return HttpStatusCode.InternalServerError;
        }
    }

    // PATCH: api/users<controller>/1
    // Update part of a record
    /* It's Possible to have multiple Patch for each Parameter
        eg: api/users/email/1, api/users/phone/1 */
    [HttpPatch("{id}")]
    public void Patch(int id, [FromBody] string emailAddress)
    {
        // PUT updates whole record,
        // PATCH updates part of a record
    }
}