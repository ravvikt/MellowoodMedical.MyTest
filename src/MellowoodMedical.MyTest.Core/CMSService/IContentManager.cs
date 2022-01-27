using Abp.Domain.Services;
using System.Threading.Tasks;

namespace MellowoodMedical.MyTest.CMSService
{
    public interface IContentManager: IDomainService
    {
        Task<Content> InsertOrUpdateAsync(Content content);
    }
}
