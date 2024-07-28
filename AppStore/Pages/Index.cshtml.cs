using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppStore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Used OnGet";
            int test=1;  //test breakpoint

        } 
        public void OnPost()
        {
            Message = "Used OnPost";
            int test = 1;

        }
    }
}
