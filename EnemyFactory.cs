using System;
using System.Collections.Generic;

namespace CommandoPproject
{
    internal  class EnemyFactory
    {
        private  List<Enemy> listEnemy = new List<Enemy>();
        private  List<string> namesEnemy = new List<string>
        {
            "mohamd", "aboo", "sinowar", "m2", "m3", "m5", "m6"
        };

        public  void GetEnemy(int num)
        {
            listEnemy.Clear(); 
            for (int i = 0; i < num && i < namesEnemy.Count; i++)
            {
                listEnemy.Add(new Enemy(namesEnemy[i]));
            }
        }

        public  List<Enemy> GetListEnemy()
        {
            return listEnemy;
        }
    }
}
