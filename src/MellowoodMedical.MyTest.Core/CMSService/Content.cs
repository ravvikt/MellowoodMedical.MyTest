using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace MellowoodMedical.MyTest.CMSService
{
    [Table("CMSContents")]
    public class Content:Entity<int>
    {
        public const int MaxTitleLength = 128;
        public const int MaxDescriptionLength = 2048;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(MaxTitleLength)]
        public virtual string PageName { get; set; }

        [StringLength(MaxDescriptionLength)]
        public virtual string PageContent { get; set; }

        public Content()
        {

        }

        public static Content CreateCMSContent(int id, string pageName, string pageContent)
        {
            var content = new Content()
            {
                Id = id,
                PageName = pageName,
                PageContent = pageContent
            };

            return content;
        }

        public static Content UpdateCMSContent(string pageName, string pageContent)
        {
            var content = new Content()
            {
                PageName = pageName,
                PageContent = pageContent
            };

            return content;
        }
    }
}
