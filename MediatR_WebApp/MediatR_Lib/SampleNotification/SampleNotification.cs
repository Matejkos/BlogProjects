using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR_Lib.SampleNotification
{
    public class SampleNotification : INotification
    {
        public int ValueOne { get; set; }
        public int Valuetwo { get; set; }
    }
}
