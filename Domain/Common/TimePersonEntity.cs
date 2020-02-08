using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Domain.Entities;
using Domain.Enum;

namespace Domain.Common
{
    public class TimePersonEntity
    {
        public DateTime DatumVerstuurd { get; set; }
        public Employee VerstuurdDoor { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
