﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// switched to file-scoped name space, instead of encapsulating all in brace
namespace Section_3_Lesson_2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase // file was plural, but class name set singular, why?
{
    // more on readonly collections: https://www.youtube.com/watch?v=7hBPI0xYezo
    private readonly static List<string> users = new() // no paranthesis ? if List<string>()
    {
        "Ali",
        "Aisha",
        "Alex",
        "Sue"
    };

    // GET: api/users<controller>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return users;
    }

    // GET: api/users<controller>/1
    [HttpGet("{id}")]
    public string Get(int id)
    {
        try
        {
            return users[id];
        }
        catch (Exception ex)
        {
            return ex.Message;
        }

    }

    // POST: api/users<controller>/value
    [HttpPost]
    public void Post([FromBody] string value)
    {
        users.Add(value);
    }

    // DELETE: api/users<controller>/1
    [HttpDelete("{id}")]
    public HttpStatusCode Delete(int id)
    {
        try
        {
            users.RemoveAt(id);
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
            users[id] = value;
            return HttpStatusCode.OK;
        }
        catch {
            return HttpStatusCode.InternalServerError;
        }
    }
}