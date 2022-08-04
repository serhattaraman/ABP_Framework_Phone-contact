using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.Concat.Pages;

public class Index_Tests : ConcatWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
