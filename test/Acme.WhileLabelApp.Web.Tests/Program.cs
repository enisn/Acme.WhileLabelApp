using Microsoft.AspNetCore.Builder;
using Acme.WhileLabelApp;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Acme.WhileLabelApp.Web.csproj"); 
await builder.RunAbpModuleAsync<WhileLabelAppWebTestModule>(applicationName: "Acme.WhileLabelApp.Web");

public partial class Program
{
}
