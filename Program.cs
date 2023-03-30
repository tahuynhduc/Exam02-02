using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IEnemy.IEnemy;

using IEnemy;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using System.IO;

namespace exam2
{
    class program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy();

            Hashtable openWith = new Hashtable();
            openWith.Add(enemy.Id, enemy);

            Console.WriteLine("—----------------------------------------—----------------------------------------");
            Console.WriteLine("1.Insert new enemy…");
            Console.WriteLine("2.Display all the enemy list…");
            Console.WriteLine("3.Calculate the enemy damage…");
            Console.WriteLine("4.Find enemy");
            Console.WriteLine("5.Exit.");
            Console.WriteLine("—----------------------------------------—----------------------------------------");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    //Console.WriteLine("Input enemy Id:");
                    //enemy.Id = long.Parse(Console.ReadLine());
                    //Console.WriteLine("Input enemy name:");
                    //enemy.Name = Console.ReadLine();
                    //Console.WriteLine("Input enemy type:");
                    //enemy.Type = (Enemy_type)int.Parse(Console.ReadLine());
                    //Console.WriteLine("Input enemy health:");
                    //enemy.Health = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Input enemy AttackType:");
                    //enemy.AttackType = (Attack_type)int.Parse(Console.ReadLine());
                    //Console.WriteLine("Input enemy damages list count:");

                    foreach (float aPart in DamageList)
                    {
                        Console.WriteLine(aPart);
                    }



                    Console.Write("Input damage 1:");
                    float DamageList1 = int.Parse(Console.ReadLine());
                    enemy[0] = DamageList1;
                    float DamageList2 = int.Parse(Console.ReadLine());
                    enemy[1] = DamageList2;
                    float DamageList3 = int.Parse(Console.ReadLine());
                    enemy[2] = DamageList3;
                    

                    break;
                case 2:
                    foreach (var item in openWith)
                    {
                        Console.WriteLine(openWith);
                    }
                    foreach (DictionaryEntry de in openWith)
                    {
                        Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
                    }

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    return;
            }
        }
    }
}