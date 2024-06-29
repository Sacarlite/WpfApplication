﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factories
{
    public interface IWindowVievModelsFactory<TResult>
    {
        TResult Create();
    }
}
