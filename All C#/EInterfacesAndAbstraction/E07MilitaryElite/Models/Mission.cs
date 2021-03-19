using E07MilitaryElite.Enums;
using E07MilitaryElite.Interfaces;

namespace E07MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, MissionStatus status)
        {
            this.CodeName = codeName;
            this.Status = status;
        }
        public string CodeName { get; private set; }

        public MissionStatus Status { get; private set; }

        public void CompleteMission()
        {
            this.Status = MissionStatus.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {Status}";
        }
    }
}
