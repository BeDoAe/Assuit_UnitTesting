using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_Lab1_test
{
    public class CarFactory_Lab_tests
    {
        [Fact]
        public void NewCar_CarTypesBMW_BMW()
        {
            //Arrange
            BMW BMW = new BMW(); 

            //Act
          Car? car=  CarFactory.NewCar(CarTypes.BMW);

            Car car2 = BMW.GetMyCar();




            //Assert
            Assert.Equal(BMW, car);

            Assert.Same(BMW, car2);
            Assert.NotNull(car2);

        

        }
        [Fact]
        public void NewCar_CarTypeToyota_Toyota()
        {
            

            //Act
            Car? car = CarFactory.NewCar(CarTypes.Toyota);





            //Assert
  
            Assert.IsType<Toyota>(car);
            Assert.IsNotType<Car>(car);
            Assert.IsNotType<BMW>(car);
        }

        [Fact]
        public void NewCar_CarTypeBuggati_Exception()
        {
            //Assert





            //Assert

            Assert.Throws<NotImplementedException>(() =>
            {
                //Act
                Car? car = CarFactory.NewCar(CarTypes.Buggati);
            });
        }
    }
}
