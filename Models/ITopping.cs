using System;
using System.Collections.Generic;
using System.Text;

namespace MachOneSoftware.PizzaBuddy.Models
{
    public interface ITopping
    {
        string Name { get; }
        ToppingType ToppingType { get; }
    }
}
