using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Composite
    {
    }

    public class FileComposite : IComposite
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public FileComposite(string name)
        {
            this.Name = name;
        }

        public void Add(IComposite composite)
        {
            Console.WriteLine("Não é possível");
        }
        public override string ToString()
        {
            return String.Format("{0}{1}\n",
                new String(' ', this.Level),
                this.Name);
        }
    }

    public class FolderComposite : IComposite
    {
        public List<IComposite> conteudo;
        public string Name { get; set; }
        public int Level { get; set; }

        public FolderComposite(string name)
        {
            this.Name = name;
            this.conteudo = new List<IComposite>();
        }

        public void Add(IComposite composite)
        {
            composite.Level = this.Level + 1;
            this.conteudo.Add(composite);
        }

        public override string ToString()
        {
            String retorno = String.Format("{0}{1}\n",
                new String(' ', this.Level),
                this.Name);

            foreach (var item in this.conteudo)
            {
                retorno += item;
            }

            return retorno;
        }
    }
}
