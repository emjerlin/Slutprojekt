using System;

namespace Slutprojekt
{
    public class OldCitizen : Citizen
    {
        private string ageGroup;
        public string AgeGroup{
            get{return ageGroup;}
        }
        private int healthLevel;
        public int HealthLevel{
            get{return healthLevel;}
            set{healthLevel=value;}
        }
    public OldCitizen(){
        Random generator = new Random();
            ageGroup = "old";
            float healthLevelBase = generator.Next(3); //0=really good health 1=normal 2=bad health. Kommer påverka hur mycket sjukvård de behöver (skattepengar som går åt)
            float aMod =1.3f;
            float healthLevelFloat = healthLevelBase * aMod;
            healthLevel = (int)Math.Round(healthLevelFloat);
        
    }
    }
}
