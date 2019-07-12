using System;

namespace DesignPatterns
{
    public interface IComposite
    {
        string Name { get; set; }
        int Level { get; set; }

        void Add(IComposite composite);
    }
}
