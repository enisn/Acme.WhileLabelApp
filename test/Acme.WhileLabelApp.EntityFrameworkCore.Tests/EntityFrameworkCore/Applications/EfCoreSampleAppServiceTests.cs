using Acme.WhileLabelApp.Samples;
using Xunit;

namespace Acme.WhileLabelApp.EntityFrameworkCore.Applications;

[Collection(WhileLabelAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<WhileLabelAppEntityFrameworkCoreTestModule>
{

}
