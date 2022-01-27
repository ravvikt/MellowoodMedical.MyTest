using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.UI;
using MellowoodMedical.MyTest.CMSService.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MellowoodMedical.MyTest.CMSService
{
    [AbpAuthorize]
    public class CMSServices : MyTestAppServiceBase, ICMSServices
    {
        private readonly IRepository<Content, int> _contentRepository;
        public CMSServices(IRepository<Content, int> contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public async Task<Content> InsertOrUpdateCMSContent(CreateContentDto input)
        {
            try
            {
                var content = new Content();
                bool isExists = await _contentRepository.GetAll().AnyAsync(e => e.Id == input.Id);
                
                if (!isExists)
                {
                    content = Content.UpdateCMSContent(input.PageName, input.PageContent);
                    return await _contentRepository.InsertAsync(content);
                }
                else
                {
                    content = Content.CreateCMSContent(input.Id, input.PageName, input.PageContent);
                    return await _contentRepository.UpdateAsync(content);
                }
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException("Failed to insert the content.", ex.Message);
            }
        }

        public async Task<ContentDto> GetCMSContent(int pageId)
        {
            try
            {
                var content = await _contentRepository.GetAll().Where(e => e.Id == pageId).FirstOrDefaultAsync();

                if (content == null)
                {
                    throw new UserFriendlyException("Content is not available.");
                }

                return content.MapTo<ContentDto>();
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException("Failed to load the contents.", ex.Message);
            }
        }

        public async Task<ListResultDto<GetContentListDto>> GetAll()
        {
            try
            {
                var contents = await _contentRepository.GetAll().ToListAsync();
                if (contents == null)
                {
                    throw new UserFriendlyException("Content is not available.");
                }

                return new ListResultDto<GetContentListDto>(contents.MapTo<List<GetContentListDto>>());
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException("Failed to load the data.", ex.Message);
            }
           
        }

    }
}
