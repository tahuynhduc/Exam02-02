using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IEnemy.IEnemy; 

namespace IEnemy
{
    public enum Enemy_type
    {
        GOBLIN,
        BOSS,
        ORC,
    }
    public enum Attack_type
    {
        RANGE,
        MELEE,
    }

    interface IEnemy
    {
        long Id { get; set; }
        string Name { get; set; }
        Enemy_type Type { get; set; }
        int Health { get; set; }
        Attack_type AttackType { get; set; }
        float Damage { get;}
        void ShowInfo();
    }
    public class Enemy : IEnemy
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }

        public float Damage { get; }

        public Enemy_type Type { get; set; }
        public Attack_type AttackType { get; set ; }

        public void ShowInfo()
        {
            throw new NotImplementedException();

            Console.WriteLine("id:" +Id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Health:" + Health);
            Console.WriteLine("Damage:" + Damage);
            Console.WriteLine("Type" +Type);
            Console.WriteLine("AttackType" + AttackType);


        }
        public List<float> DamageList = new List<float>();

        public float this[int i]
        {
            get { return DamageList[i]; }
            set { DamageList[i] = value; }
        }

        public void CalDamage()
        {
            int max = 0;
            float Damage = 0;
            foreach (int i in DamageList)
            {
                if(Damage < DamageList[i])
                {
                    Damage = max;
                }
                
            }

        }
    }
}
