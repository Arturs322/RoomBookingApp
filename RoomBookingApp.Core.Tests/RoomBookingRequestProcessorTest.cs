using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;
using Xunit;

namespace RoomBookingApp.Core.Tests
{
    public class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void ShouldReturnRoomBookingResponseWithRequestValues()
        {
            //Arrange
            var bookingRequest = new RoomBookingRequest
            {
                FullName = "Test Name",
                Email = "test@test.com",
                Date = new DateTime(2022, 12, 12)
            };
            var processor = new RoomBookingRequestProcessor();

            //Act
            RoomBookingResult result = processor.BookRoom(bookingRequest);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(bookingRequest.FullName, result.FullName);
            Assert.Equal(bookingRequest.Email, result.Email);
            Assert.Equal(bookingRequest.Date, result.Date);
        }
    }
}
