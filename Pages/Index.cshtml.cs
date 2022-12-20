using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoComplete.Pages;

[IgnoreAntiforgeryToken(Order = 1001)]
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    string[] result = {"Neville", "Hermione", "Harry Potter", "Dumbledore", "Gandalf the Gray", "Radagast", "Merlin"};

    public JsonResult OnPostPartial([FromBody] string data)
    {
        return new JsonResult(result);
    }
}

