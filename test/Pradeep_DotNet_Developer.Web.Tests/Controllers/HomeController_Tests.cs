using System.Threading.Tasks;
using Pradeep_DotNet_Developer.Models.TokenAuth;
using Pradeep_DotNet_Developer.Web.Controllers;
using Shouldly;
using Xunit;

namespace Pradeep_DotNet_Developer.Web.Tests.Controllers
{
    public class HomeController_Tests: Pradeep_DotNet_DeveloperWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}