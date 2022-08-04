using System.Threading.Tasks;
using Acme.Concat.Concats;
using Acme.Concat.Web.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Web.Pages.Concats
{
    public class CreateModalModel : ConcatPageModel
    {
        [BindProperty]
        public CreateUpdateConcatDto Concat { get; set; }

        private readonly IConcatAppService _concatAppService;

        public CreateModalModel(IConcatAppService concatAppService)
        {
            _concatAppService = concatAppService;
        }

        public void OnGet()
        {
            Concat = new CreateUpdateConcatDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _concatAppService.CreateAsync(Concat);
            return NoContent();
        }
    }
}