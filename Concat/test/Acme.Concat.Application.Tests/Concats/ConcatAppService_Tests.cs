using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace Acme.Concat.Concats
{
    public class ConcatAppService_Tests:ConcatApplicationTestBase
    {
        private readonly IConcatAppService _concatAppService;
        public ConcatAppService_Tests()
        {
            _concatAppService = GetRequiredService<IConcatAppService>();
        }

        [Fact]
        public async Task Should_Get_List_Of_Concats()
        {
            var result = await _concatAppService.GetListAsync(
                new PagedAndSortedResultRequestDto());
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(b=>b.Name=="Serhat");
        }
    }
}
