namespace EvidenceExam
{
      class Motorcycle : TwoWheeler
      {
            public Motorcycle()
            {
                  vehicleTypes = VehicleType.TwoWheeler;
                  NumberOfSeat = 2;
                  Color = "Black";
            }
            public int BHP { get; set; }
      }
}