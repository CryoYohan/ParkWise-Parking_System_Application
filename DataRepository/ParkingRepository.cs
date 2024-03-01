using ParkingSystemGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemGUI.DataRepository
{
    public class ParkingRepository
    {
        private readonly List<Vehicle> vehicles;
        public ParkingRepository()
        {
            vehicles = [];
        }

        public bool RegisterParking(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            return true;
        }

        public Vehicle GetParkedVehicleById(int id)
        {
            return vehicles.Where(v => v.Id == id).FirstOrDefault() ?? new() { Id = -1 };
        }

        public Vehicle GetParkedVehicleByPlateNumber(string pN)
        {
            return vehicles.Where(v => v.PlateNumber == pN).FirstOrDefault() ?? new() { Id = -1 };
        }



        public Vehicle? UpdateParkOut(int id)
        {
            Vehicle foundVehicle = vehicles.Where(a => a.Id == id).FirstOrDefault() ?? new() { Id = -1 };

            if (foundVehicle.Id == -1)
            {
                return null;
            }

            foundVehicle.ParkOutTime = DateTime.Now;
            return foundVehicle;
        }


    }
}
