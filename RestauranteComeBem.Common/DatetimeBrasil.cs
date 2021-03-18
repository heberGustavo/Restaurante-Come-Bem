using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteComeBem.Common
{
     public static class DateTimeBrasil
    {
        public static DateTime Now { get => DateTime.UtcNow.AddHours(-3); }
    }
}
