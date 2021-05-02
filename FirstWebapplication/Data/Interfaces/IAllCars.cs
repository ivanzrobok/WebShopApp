﻿using FirstWebapplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;  }
        IEnumerable<Car> GetFavCars { get;  }
        Car GetObjectCar(int carID);
    }
}
