using Acme.WhileLabelApp.Samples;
using Xunit;

namespace Acme.WhileLabelApp.EntityFrameworkCore.Domains;

[Collection(WhileLabelAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<WhileLabelAppEntityFrameworkCoreTestModule>
{

}
