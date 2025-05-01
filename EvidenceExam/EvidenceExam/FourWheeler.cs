namespace EvidenceExam
{
      class FourWheeler : Vehicle, IInterior
      {
            public int NumberOfDoor { get; set; }
            public int NumberOfGear { get; set; }
            public void DesignInterior(Car Car)
            {
                  Console.WriteLine("---------------------------------------------------");
                  Console.WriteLine("Designing interior for the car.");
                  Console.WriteLine("Design " + Car.vehicleTypes + " Car !!\n");
                  Console.WriteLine
                  (
                        Car.ModelNo + " Y" + Car.YearMake + " Seat" + Car.NumberOfSeat +
                        " Color" + Car.Color + " Engine" + Car.EngineCapacityCC +
                        " GEAR" + Car.NumberOfGear
                        + " DOOR" + Car.NumberOfDoor
                  );
            }
      }
}