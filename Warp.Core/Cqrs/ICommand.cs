﻿using System;

namespace Warp.Core.Cqrs
{
    public interface ICommand
    {
        Guid Id { get; set; }
    }
}