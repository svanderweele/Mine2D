﻿using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Tick.Services
{
    [Meta, Unique]
    public class TickServiceComponent : IComponent
    {
        public ITickService instance;
    }
}