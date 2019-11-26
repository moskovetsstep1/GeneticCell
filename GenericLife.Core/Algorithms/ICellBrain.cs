﻿using System.Collections.Generic;
using GenericLife.Core.CellAbstractions;

namespace GenericLife.Core.Algorithms
{
    public interface ICellBrain
    {
        List<int> CommandList { get; }
        void MakeTurn(IGenericCell cell);
    }
}