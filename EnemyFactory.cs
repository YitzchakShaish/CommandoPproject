using System;
using System.Collections.Generic;

namespace CommandoPproject
{
    internal static class EnemyFactory
    {
        private static List<Enemy> listEnemy = new List<Enemy>();
        private static List<string> namesEnemy = new List<string>
        {
            "mohamd", "aboo", "sinowar", "m2", "m3", "m5", "m6"
        };

        public static void GetEnemy(int num)
        {
            listEnemy.Clear(); 
            for (int i = 0; i < num && i < namesEnemy.Count; i++)
            {
                listEnemy.Add(new Enemy(namesEnemy[i]));
            }
        }

        public static List<Enemy> GetListEnemy()
        {
            return listEnemy;
        }
    }
}
