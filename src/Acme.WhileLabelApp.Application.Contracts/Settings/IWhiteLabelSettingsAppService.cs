using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.WhileLabelApp.Settings;

public interface IWhiteLabelSettingsAppService : IApplicationService
{
    Task<WhiteLabelSettingsDto> GetAsync();
    Task UpdateAsync(WhiteLabelSettingsDto input);
}

public class WhiteLabelSettingsDto
{
    [DisplayName("AppName")]
    public string? AppName { get; set; }
    public string? AppLogo { get; set; }
    public string? Theme { get; set; }
    public string? PrimaryColor { get; set; }
}
