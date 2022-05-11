using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GameHeroEnemy
{
    internal class GameEngine
    {
        private int rounds = 0;

        private Models.Hero _hero;
        private Models.Enemy _enemy;

        public GameEngine() => WriteLine("Игра запущена");

        public void StartGame(Models.Enemy enemy, Models.Hero hero)
        {
            _hero = hero;
            _enemy = enemy;

            Round();
        }

        private void Round()
        {
            if (_hero.isDeath())
                return;

            if (_enemy.isDeath())
                return;

            Result2();
            _enemy.GetDamage(_hero.ToDamage());
            _hero.GetDamage(_enemy.ToDamage());
            rounds++;

            Round();
            
        }

        public string Result() => $"Игрок Enemy {_enemy.GetInfoHP()}, Убит:{_enemy.isDeath()}. Игрок Hero {_hero.GetInfoHP()}, Убит:{_hero.isDeath()}. Раундов {rounds}";


        public void Result2()
        {
            WriteLine($"Игрок Enemy {_enemy.GetInfoHP()}, Убит:{_enemy.isDeath()}. Игрок Hero {_hero.GetInfoHP()}, Убит:{_hero.isDeath()}. Раундов {rounds}");
        }
            

    }
}
