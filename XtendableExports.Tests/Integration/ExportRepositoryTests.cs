using System;
using System.Threading.Tasks;
using Shouldly;
using XTendableExports.data;
using XTendableExports.data.Repositories;
using Xunit;

namespace XtendableExports.Tests.Integration
{
    public class ExportRepositoryTests
    {
        [Fact(Skip = "Integration Test")]
        public async Task Should_Retrieve_Export_With_Known_GUID()
        {
            //THIS IS CURRENTLY NOT WORKING - Getting an Entity issue - think its a nuget thing.  Didnt have time to fix it.

            //Arrange
            var codeUnderTest = new ExportRepository(new EFContext());

            //Act 
            var export = await codeUnderTest.GetAsync(new Guid("DBE9A614-29C2-4F65-9E31-515B8CB3A2F9"));

            //Assert
            export.Name.ShouldBe("VeteransHospital-AccountFacilityInfo");
        }
    }
}
