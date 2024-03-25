using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using SocialMedia.Core.Entities;
using SocialMedia.Data;

namespace API.services.controllers;

[ApiController]
public class DemoController : ControllerBase
{
    private readonly MongoDBContext _dbContext;

    public DemoController(MongoDBContext mongoDBContext)
    {
        _dbContext = mongoDBContext;
    }
    [HttpGet]
    [Route("getData")]
    public IActionResult getDummyData()
    {
        User user = new User();
        user.Id = ObjectId.GenerateNewId().ToString();
        user.Name = "harshad";
        _dbContext.UserCollection.InsertOne(user);
        return Ok("User created");
    }
}