using System;
using System.Collections.Generic;
using System.Text;

namespace Object_OrientedProgrammingExercise
{
    class Entity
    {
        public double health = 50;

        public double defense = 0;
        public virtual void TakeDamage(double damagePoints)
        {
            health -= damagePoints*(1-defense);
            if (health <= 0) {
                health = 0;
            }
        }

        public double attack = 10;

        public bool IsDefeated
        {
            get
            {
                // TODO how do we know if the entity is defeated?
                if (health <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
