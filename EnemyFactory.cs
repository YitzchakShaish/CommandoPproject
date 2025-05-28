using System;
using System.Collections.Generic;

namespace CommandoProject
{
    internal  class EnemyFactory
    {
        private  List<Enemy> listEnemy = new List<Enemy>();

        public  void GetEnemy(string namesEnemy)
        {
                listEnemy.Add(new Enemy(namesEnemy));
        }

        public  List<Enemy> GetListEnemy()
        {
            return listEnemy;
        }
    }
}
