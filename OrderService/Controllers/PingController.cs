using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers;

[ApiController]
[Route("[controller]")]
public class PingController : ControllerBase
{
    private readonly IConfiguration configuration;

    public PingController(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    [HttpGet]
    public string Get()
    {
        return $"Hello from OrderService ({configuration["name"]})";
    }
}