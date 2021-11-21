using System;
using System.Collections.Generic;
using System.Text;

namespace Church.App.Domains
{
    class MemberCar
    {
        public MemberCar(string make, string model, string plate,string carowner)
        {
            Make = make;
            Model = model;
            Plate = plate;
            CarOwner = carowner;
        }

        public string Make 
        { get; set; }
         public string Model
        { get; set; }
        public string Plate
        { get; set; }
        public string CarOwner
        { get; set; }
    }
}
