using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default_HeroMonsterClass1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Jedi";
            hero.Health = 40;
            hero.DamageMaximum = 10;
            hero.AttackBonus = true;
            
            Character monster = new Character();
            monster.Name = "Rancor";
            monster.Health = 20;
            monster.DamageMaximum = 20;
            monster.AttackBonus = false;

            int damage = hero.Attack();
            monster.Defend(damage);

            damage = monster.Attack();
            hero.Defend(damage);



            ///int monsterDamage = monster.Attack();

            //statsLabel.Text = String.Format("{0} - {1} - {2} - {3}", hero.Name, hero.Health, hero.DamageMaximum, hero.AttackBonus);
            //monsterStatsLabel.Text = String.Format("{0} - {1} - {2} - {3}", monster.Name, monster.Health, monster.DamageMaximum, monster.AttackBonus);
            statsOut(hero);
            statsOut(monster);

        }

        private void statsOut(Character character)
        {
            statsLabel.Text += String.Format("Name: {0} -- Health: {1} -- Damage: {2} -- AttackBonus: {3}</br>", 
                character.Name,
                character.Health,
                character.DamageMaximum,
                character.AttackBonus);
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack() //randomly determine the amount of damage this Character object inflicted.
        {
            Random random = new Random();
            int damage = random.Next(DamageMaximum);
            return damage;
        }   

        public int Defend(int damage) //deducts the damage from this Character's health
        {

            Health -= damage;
            //damage = DamageMaximum; 
            /*
            monster.Health -= heroDamage;
            hero.Health -= monsterDamage;
            return 0;
            */
            return 0;
        }


    }
    /*
    internal class random
    {
        internal static int Next(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
    */
}