using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using multiple_files.Settings;

namespace multiple_files.Controllers;

[ApiController]
[Route("[controller]")]
public class AppController : ControllerBase
{
    private readonly ILogger<AppController> _logger;
    private readonly MyCustomSettings _myCustomSettings;

    public AppController(IOptions<MyCustomSettings> myCustomSettings, ILogger<AppController> logger)
    {
        _logger = logger;
        _myCustomSettings = myCustomSettings.Value;
    }

    [HttpGet]
    public string Get()
    {
        return $"{_myCustomSettings.MyName} + {_myCustomSettings.MyWindowsVariable}";
    }
}