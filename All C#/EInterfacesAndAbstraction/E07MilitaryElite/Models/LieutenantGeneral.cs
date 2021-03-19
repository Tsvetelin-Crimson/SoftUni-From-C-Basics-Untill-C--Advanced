using E07MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace E07MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly List<Private> privates;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<Private>();
        }

        public IReadOnlyCollection<IPrivate> Privates => privates.AsReadOnly();

        public void AddPrivate(Private prPrivate)
        {
            privates.Add(prPrivate);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (Private prPrivate in privates)
            {
                sb.AppendLine("  " + prPrivate.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
