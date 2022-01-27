using Abp.Application.Services.Dto;

namespace MellowoodMedical.MyTest.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

