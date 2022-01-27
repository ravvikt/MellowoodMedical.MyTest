using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using System.Threading.Tasks;

namespace MellowoodMedical.MyTest.CMSService
{
    public class ContentManager: IContentManager
    {
        private readonly IRepository<Content, int> _contentRepository;

        public ContentManager(IRepository<Content, int> contentRepository)
        {
            _contentRepository = contentRepository;
        }

        [UnitOfWork(IsDisabled = true)]
        public async Task<Content> InsertOrUpdateAsync(Content content)
        {
            var response = await _contentRepository.InsertOrUpdateAsync(content);
            return response;

        }
    }
}
