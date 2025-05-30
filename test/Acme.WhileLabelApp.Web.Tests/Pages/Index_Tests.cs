using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.WhileLabelApp.Pages;

[Collection(WhileLabelAppTestConsts.CollectionDefinitionName)]
public class Index_Tests : WhileLabelAppWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
