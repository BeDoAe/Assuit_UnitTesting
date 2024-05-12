using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_Lab1_test
{
    public class Lab_ToyotaTests
    {
        [Fact]
        public void IsStopped_Moving_False()
        {
            //Arrange 
            Toyota toyota = new Toyota();
            toyota.velocity = 5;

            //Act

            bool result = toyota.IsStopped();

            //Assert

            Assert.False(result);
        }

        [Fact]
        public void TimeToCoverDistance_Time_30Dist10Veloctiy_3Time()
        {
            //Arrange 
              
            Toyota toyota = new Toyota();
            toyota.velocity = 10;
            double Distance = 30;

            //Act

            double Time = toyota.TimeToCoverDistance(Distance);

            //Assert
            Assert.InRange(Time, 1, 3);
            Assert.NotInRange(Distance, 4, 5);
        }


        [Fact]
        public void GetDirection_Backward_Backward()
        {
            //Arrange 
            Toyota toyota = new Toyota();
            toyota.drivingMode=DrivingMode.Backward;

            //Act
            string Direction = toyota.GetDirection();

            //Assert
            //1
            Assert.StartsWith("B", Direction);
            //2
            Assert.EndsWith("d", Direction);
            //3
            Assert.Contains("a", Direction);
            //4
            Assert.DoesNotContain("b", Direction);
          

        }
        [Fact]
        public void GetDirection_Stopped_Stopped()
        {
            //Arrange 
            Toyota toyota = new Toyota();
            toyota.drivingMode = DrivingMode.Stopped;

            //Act
            string Direction = toyota.GetDirection();

            //Assert
            //1
            Assert.StartsWith("S", Direction);
            //2
            Assert.EndsWith("d", Direction);
            //3
            Assert.Contains("p", Direction);
            //4
            Assert.DoesNotContain("a", Direction);


        }

      
    }
}
