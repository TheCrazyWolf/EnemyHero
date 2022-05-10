using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHeroEnemy.Models
{
    internal class Enemy
    {
        private int _hp;
        private int _maxDamage;
        private bool Death;

        public Enemy()
        {
            _hp = 100; _maxDamage = 4; Death = false;
        }

        public int GetInfoHP()
        {
            return _hp;
        }

        public void GetDamage(int damage)
        {
            if (_hp >= 0)
                _hp = _hp - damage;

            if (_hp <= 0)
                Death = true;
        }

        public bool isDeath()
        {
            if (Death)
                return true;
            else
                return false;
        }
        
        public int ToDamage()
        {
            Random rnd = new Random();
            return rnd.Next(0, _maxDamage);
        }

    }
}
