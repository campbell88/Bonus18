using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Car
    {
        private string MakeOfCar;
        private string ModelOfCar;
        private int YearOfCar;
        private double PriceOfCar;

        public string PropMakeOfCar
        {
            get
            {
                return MakeOfCar;
            }

            set
            {
                MakeOfCar = value;
            }
        }

        public string PropModelOfCar
        {
            get
            {
                return ModelOfCar;
            }

            set
            {
                ModelOfCar = value;
            }
        }

        public int PropYearOfCar
        {
            get
            {
                return YearOfCar;
            }

            set
            {
                YearOfCar = value;
            }
        }

        public double PropPriceOfCar
        {
            get
            {
                return PriceOfCar;
            }

            set
            {
                PriceOfCar = value;
            }
        }


        #region Constructors
        //constructor with four arguements
        public Car(string MakeOfCarInput,
        string ModelOfCarInput,
       int YearOfCarInput,
       double PriceOfCarInput)
    {
        MakeOfCar = MakeOfCarInput;
        ModelOfCar = ModelOfCarInput;
        YearOfCar = YearOfCarInput;
        PriceOfCar = PriceOfCarInput;

    }
    // no-arguement constructor
    public Car()   
    {
        MakeOfCar = "---";
        ModelOfCar = "---";
        YearOfCar = 2000;
        PriceOfCar = 1000;

    }
        #endregion


    }  //to enter the default car in this scenario, just enter Car = New Car()
}

