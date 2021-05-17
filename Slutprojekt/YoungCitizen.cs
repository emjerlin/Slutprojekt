using System;

namespace Slutprojekt
{
    public class YoungCitizen: Citizen
    {
        private string ageGroup;
        public string AgeGroup
        {
            get { return ageGroup; }
        }
        private int healthLevel;
        public int HealthLevel
        {
            get { return healthLevel; }
        }
        public YoungCitizen()
        {
            Random generator = new Random();
            ageGroup = "young";
            float healthLevelBase = generator.Next(3); //0=really good health 1=normal 2=bad health. Kommer påverka hur mycket sjukvård de behöver (skattepengar som går åt)
            float aMod = 0.7f;
            float healthLevelFloat = healthLevelBase * aMod;
            healthLevel = (int)Math.Round(healthLevelFloat);
        }
    }
}
