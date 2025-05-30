using Xunit;

namespace Acme.WhileLabelApp.EntityFrameworkCore;

[CollectionDefinition(WhileLabelAppTestConsts.CollectionDefinitionName)]
public class WhileLabelAppEntityFrameworkCoreCollection : ICollectionFixture<WhileLabelAppEntityFrameworkCoreFixture>
{

}
