using System;
using Moq;
using Shouldly;
using XtendableExports.services;
using XTendableExports.Domain;
using XTendableExports.Domain.Contracts.Repositories;
using Xunit;

namespace XtendableExports.Tests.Unit
{
    public class ExportFileServiceTests
    {
        [Fact]
        public async void ShouldThrowArgumentNullExceptionWhenIdNotSentIn()
        {
            //Arrange
            var bytefile = new byte[64];
            var emptyId = "";
            var username = "todd";
            var export = new Export();
            var mockAccountRepository = new Mock<IAccountRepository>();
            var mockPatientRepository = new Mock<IPatientRepository>();
            var mockClientRepository = new Mock<IClientRepository>();
            var mockFacilityRepository = new Mock<IFacilityRepository>();
            var mockInsuranceRepository = new Mock<IInsuranceRepository>();
            var mockAccountInsuranceRepository = new Mock<IAccountInsuranceRepository>();
            var mockExportRepository = new Mock<IExportRepository>();

            mockExportRepository.Setup(m => m.GetAsync(It.IsAny<Guid>())).ReturnsAsync(export);

            var codeUnderTest = new ExportFileService(mockExportRepository.Object, mockAccountRepository.Object, mockPatientRepository.Object, mockClientRepository.Object, mockFacilityRepository.Object, mockInsuranceRepository.Object, mockAccountInsuranceRepository.Object);

            //Act
            var task = codeUnderTest.GetExportFileAsync(emptyId, username);

            //Assert
            await task.ShouldThrowAsync<ArgumentNullException>();
        }
    }
}
