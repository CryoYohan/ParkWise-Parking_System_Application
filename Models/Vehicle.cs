using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemGUI.Models
{
    public class Vehicle
    {
        public int Id { get; set; } = 0;
        public string PlateNumber { get; set; } = string.Empty;
        public string VehicleType { get; set; } = string.Empty;
        public string VehicleBrand { get; set; } = string.Empty;
        public DateTime ParkInTime { get; set; } = DateTime.Now;
        public DateTime? ParkOutTime { get; set; } = null;
    }
}
