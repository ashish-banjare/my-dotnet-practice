namespace EvidenceExam
{
      sealed class Car : FourWheeler
      {
            public Car()
            {
                  vehicleTypes = VehicleType.FourWheeler;
                  NumberOfSeat = 5;
                  Color = "Red";
            }
      }
}