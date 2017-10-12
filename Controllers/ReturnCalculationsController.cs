using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class ReturnCalculationsController : Controller {

    public IActionResult Get() {
        return Ok("Dees werkt");
    }

}