using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public class ResearchTeam
    {
        private string researchTopic;
        private string organizationName;
        private int registrationNumber;
        private TimeFrame researchDuration;
        private List<Paper> publications = new List<Paper>();

        public ResearchTeam(string researchTopic, string organizationName, int registrationNumber, TimeFrame researchDuration)
        {
            this.researchTopic = researchTopic;
            this.organizationName = organizationName;
            this.registrationNumber = registrationNumber;
            this.researchDuration = researchDuration;
        }

        public ResearchTeam()
        {
            researchTopic = "Тема по умолчанию";
            organizationName = "Организация по умолчанию";
            registrationNumber = 0;
            researchDuration = TimeFrame.Year;
        }

        public string ResearchTopic
        {
            get { return researchTopic; }
            set { researchTopic = value; }
        }

        public string OrganizationName
        {
            get { return organizationName; }
            set { organizationName = value; }
        }

        public int RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        public TimeFrame ResearchDuration
        {
            get { return researchDuration; }
            set { researchDuration = value; }
        }

        public Paper[] Publications
        {
            get { return publications.ToArray(); }
        }

        public Paper LatestPublication
        {
            get
            {
                if (publications.Count == 0) return null;
                publications.Sort((p1, p2) => p2.PublicationDate.CompareTo(p1.PublicationDate));
                return publications[0];
            }
        }

        public bool this[TimeFrame timeframe]
        {
            get { return researchDuration == timeframe; }
        }

        public void AddPapers(params Paper[] papers)
        {
            publications.AddRange(papers);
        }

        public override string ToString()
        {
            string papersInfo = publications.Count > 0 ? string.Join(", ", publications) : "Нет публикаций";
            return $"Тема: {researchTopic}, Организация: {organizationName}, Номер: {registrationNumber}, Продолжительность: {researchDuration}, Публикации: {papersInfo}";
        }

        public string ToShortString()
        {
            return $"Тема: {researchTopic}, Организация: {organizationName}, Номер: {registrationNumber}, Продолжительность: {researchDuration}";
        }
    }
}
