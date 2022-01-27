using MellowoodMedical.MyTest.CMSService;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MellowoodMedical.MyTest.Tests
{
    public class CMSServiceTest: MyTestAppServiceBase
    {
        private readonly ICMSServices _cmsService;

        //public CMSServiceTest()
        //{
        //    _cmsService = Resolve<ICMSServices>();
        //}

        //[Fact]
        //public async Task Should_Get_Contents()
        //{
        //    var output = await _cmsService.GetAll();
        //    output.Items.Count.ShouldBe(1);
        //}

        //[Fact]
        //public async Task Should_Create_Contents()
        //{
        //    //Arrange
        //    var pageName = "FAQ";

        //    //Act
        //    await _cmsService.InsertOrUpdateCMSContent(new CMSService.Dto.CreateContentDto
        //    {

        //        PageName = "FAQ",
        //        PageContent = "Fre Asked Q"
        //    });

        //    //Assert
        //    UsingDbContext(context =>
        //    {
        //        context. .FirstOrDefault(e => e.PageName == pageName).ShouldNotBe(null);
        //    });
        //}

        private void UsingDbContext(Action<object> p)
        {
            throw new NotImplementedException();
        }
    }
}
