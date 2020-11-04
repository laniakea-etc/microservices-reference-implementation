﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrikam.DroneDelivery.Drone
{
    public static class Extentions
    {
        public static T ConvertType<T>(this object o)
        {
            var json = JsonConvert.SerializeObject(o);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
