using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers;

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
        return $"Hello from CustomerService ({configuration["name"]})";
    }
}