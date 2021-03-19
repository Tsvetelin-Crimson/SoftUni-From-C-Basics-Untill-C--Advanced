using E07MilitaryElite.Enums;
using E07MilitaryElite.Interfaces;
using E07MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E07MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engineer engineer = new Engineer("12", "first", "last", 1000M, Enums.Corps.Airforces);
            //engineer.AddRepair(new Repair("partName", 4));

            //Console.WriteLine(engineer.ToString());

            //Commando commando = new Commando("15", "commFirst", "commLast", 1500M, Enums.Corps.Marines);
            //commando.AddMission(new Mission("Frenzy", Enums.MissionStatus.inProgress));
            //commando.Missions.FirstOrDefault(k => k.CodeName == "Frenzy").CompleteMission();
            //Console.WriteLine(commando.ToString());
;
            List<Private> privates = new List<Private>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string soldierRank = tokens[0];
                string ID = tokens[1],
                    firstName = tokens[2],
                    lastName = tokens[3];

                switch (soldierRank)
                {
                    case "Private":
                        decimal salary = decimal.Parse(tokens[4]);
                        Private prPrivate = new Private(ID, firstName, lastName, salary);
                        Console.WriteLine(prPrivate.ToString());
                        privates.Add(prPrivate);
                        break;
                    case "LieutenantGeneral":
                        salary = decimal.Parse(tokens[4]);
                        LieutenantGeneral lieutenant = new LieutenantGeneral(ID, firstName, lastName, salary);
                        AddPrivates(privates, tokens, lieutenant);

                        Console.WriteLine(lieutenant.ToString());
                        break;
                    case "Engineer":
                        salary = decimal.Parse(tokens[4]);
                        Corps corp = Corps.neither;
                        if (tokens[5] == "Airforces")
                        {
                            corp = Corps.Airforces;
                        }
                        else if (tokens[5] == "Marines")
                        {
                            corp = Corps.Marines;
                        }

                        if (!(corp == Corps.neither))
                        {
                            Engineer engineer = new Engineer(ID, firstName, lastName, salary, corp);
                            AddRepairs(tokens, engineer);

                            Console.WriteLine(engineer.ToString());
                        }
                        break;
                    case "Commando":
                        salary = decimal.Parse(tokens[4]);
                        corp = Corps.neither;
                        corp = ValidateCorps(tokens, corp);

                        if (!(corp == Corps.neither))
                        {
                            Commando commando = new Commando(ID, firstName, lastName, salary, corp);
                            AddValidMissions(tokens, commando);
                            Console.WriteLine(commando.ToString());
                        }
                        break;
                    case "Spy":
                        int codeNumber = int.Parse(tokens[4]);
                        Spy spy = new Spy(ID, firstName, lastName, codeNumber);
                        Console.WriteLine(spy.ToString());
                        break;
                    default:
                        break;
                }
            }


        }

        private static void AddValidMissions(string[] tokens, Commando commando)
        {
            for (int i = 6; i < tokens.Length; i += 2)
            {
                string codeName = tokens[i];
                string missionState = tokens[i + 1];
                MissionStatus missionStatus = MissionStatus.invalid;
                missionStatus = ValidateMission(missionState, missionStatus);
                if (!(missionStatus == MissionStatus.invalid))
                {
                    Mission mission = new Mission(codeName, missionStatus);
                    commando.AddMission(mission);
                }
            }
        }

        private static MissionStatus ValidateMission(string missionState, MissionStatus missionStatus)
        {
            if (missionState == MissionStatus.inProgress.ToString())
            {
                missionStatus = MissionStatus.inProgress;
            }
            else if (missionState == MissionStatus.Finished.ToString())
            {
                missionStatus = MissionStatus.Finished;
            }

            return missionStatus;
        }

        private static Corps ValidateCorps(string[] tokens, Corps corp)
        {
            if (tokens[5] == Corps.Airforces.ToString())
            {
                corp = Corps.Airforces;
            }
            else if (tokens[5] == Corps.Marines.ToString())
            {
                corp = Corps.Marines;
            }

            return corp;
        }

        private static void AddRepairs(string[] tokens, Engineer engineer)
        {
            for (int i = 6; i < tokens.Length; i += 2)
            {
                string partName = tokens[i];
                int hoursWorked = int.Parse(tokens[i + 1]);
                Repair repair = new Repair(partName, hoursWorked);
                engineer.AddRepair(repair);
            }
        }

        private static void AddPrivates(List<Private> privates, string[] tokens, LieutenantGeneral lieutenant)
        {
            for (int i = 5; i < tokens.Length; i++)
            {
                lieutenant.AddPrivate(privates.FirstOrDefault(k => k.ID == tokens[i]));
            }
        }
    }
}
