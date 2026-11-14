using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlefieldCSharp.Model
{
    public class Unit
    {
        public event EventHandler? HealthChanged;
        public string Name { get; set; }
        public string Role { get; set; }
        private int _health;
        public int Health {
            get
            {
                return _health;
            }
            private set 
            {
                int newHealth = Math.Clamp(value, 0, MaxHealth);
                _health = newHealth;
                HealthChanged?.Invoke(this, EventArgs.Empty);
            } 
        }
        public int MaxHealth { get; }
        public Unit(string name, string role, int health)
        {
            Name = name;
            Role = role;
            MaxHealth = health;
            Health = health;
        }
        public bool IsAlive()
        {
            return Health == 0;
        }
        public void Heal(int heal)
        {
            if(IsAlive() ==  false) return;
            else
            {
                Health = Math.Min(MaxHealth, Health + heal);
            }
        }
        public void TakeDamage(int potentialDamage)
        {
            Health -= potentialDamage;
        }
    }
}
