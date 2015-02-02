using System;

namespace hGem.Core.Cqrs
{
    public interface ICommand
    {
        Guid Id { get; set; }
    }
}