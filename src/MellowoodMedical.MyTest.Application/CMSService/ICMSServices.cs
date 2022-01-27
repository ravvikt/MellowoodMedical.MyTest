using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MellowoodMedical.MyTest.CMSService.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MellowoodMedical.MyTest.CMSService
{
    public interface ICMSServices: IApplicationService
    {
        Task<ContentDto> GetCMSContent(int pageId);
        Task<Content> InsertOrUpdateCMSContent(CreateContentDto contentDto);
        Task<ListResultDto<GetContentListDto>> GetAll();
    }
}
