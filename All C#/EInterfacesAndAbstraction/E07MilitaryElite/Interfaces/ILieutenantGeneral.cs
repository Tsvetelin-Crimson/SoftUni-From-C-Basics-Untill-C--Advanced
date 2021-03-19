using E07MilitaryElite.Models;
using System.Collections.Generic;

namespace E07MilitaryElite.Interfaces
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void AddPrivate(Private prPrivate);
    }
}
