﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Interfaces
{
    internal interface IEntity<T>
    {
        T Id { get; set; }
    }
}
