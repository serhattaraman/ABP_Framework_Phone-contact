using System;
using System.Threading.Tasks;
using Acme.Concat.Concats;
using Acme.Concat.Web.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Acme.Concat.Web.Pages.Concats
{
    public class EditModalModel : ConcatPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateConcatDto Concat { get; set; }

        private readonly IConcatAppService _concatAppService;

        public EditModalModel(IConcatAppService concatAppService)
        {
            _concatAppService = concatAppService;
        }

        public async Task OnGetAsync()
        {
            var concatDto = await _concatAppService.GetAsync(Id);
            Concat = ObjectMapper.Map<ConcatDto, CreateUpdateConcatDto>(concatDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _concatAppService.UpdateAsync(Id, Concat);
            return NoContent();
        }
    }
}