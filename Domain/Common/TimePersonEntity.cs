using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Domain.Common
{
    public class TimePersonEntity
    {
        public DateTime DatumVerstuurd { get; set; }
        public Employee VerstuurdDoor { get; set; }
    }
}
