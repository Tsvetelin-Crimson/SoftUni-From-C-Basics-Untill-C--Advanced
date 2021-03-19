using E07MilitaryElite.Enums;

namespace E07MilitaryElite.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }

        MissionStatus Status { get; }

        void CompleteMission();
    }
}
