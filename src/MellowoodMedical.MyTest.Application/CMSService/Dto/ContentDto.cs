using Abp.AutoMapper;
using Abp.Domain.Entities;

namespace MellowoodMedical.MyTest.CMSService.Dto
{
    [AutoMapFrom(typeof(Content))]
    public class ContentDto: Entity<int>
    {
        public override int Id { get; set; }
        public string PageName { get; set; }
        public string PageContent { get; set; }
    }
}
