using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace E_CommerceSystemV2.API.Controllers.Texts;

[Route("api/[controller]")]
[ApiController]
public class TextsController : ControllerBase
{
    private readonly IStringLocalizer<TextsController> _localizer;

    public TextsController(IStringLocalizer<TextsController> localizer)
    {
        _localizer = localizer;
    }
    [HttpGet]
    public ActionResult GetMessage()
    {
        return Ok(_localizer["WelcomeMessage"]);
    }
    [HttpGet]
    [Route("GetPasswordMessage")]
    public ActionResult GetUserPasswordMessage(string email)
    {
        var localizedMessage = _localizer["PasswordRetrievalMessage",email];
        return Ok(localizedMessage);
    }
}
