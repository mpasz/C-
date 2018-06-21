namespace Engine
{
    public class Monster : LivingCreature 
    {
        public Monster(int currentHitPoints , int maximumHitPoints,  int iD, string name, int maximumDamage, int rewardExperience, int rewardGold) : base (currentHitPoints, maximumHitPoints)
        {
            ID = iD;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }

        
    }
}
