namespace EvidenceExam
{
      abstract class Vehicle
      {
            public VehicleType vehicleTypes { get; set; }
            public string? VehicleName { get; set; }
            public string? ModelNo { get; set; }
            public int YearMake { get; set; }
            public int NumberOfSeat { get; set; }
            public string? Color { get; set; }
            public int EngineCapacityCC { get; set; }
            public decimal MilagePowerNM { get; set; }
      }
}