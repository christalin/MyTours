using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTours.Models
{
    public interface IWorldRepository
    {
        IEnumerable<Trip> GetAllTrips();
    }
}
