using System;
using System.Collections.Generic;
using System.Text;

namespace Object_OrientedProgrammingExercise
{
    class Zombie : Entity
    {


        // Accepts an attack with the given number of damage points
        public virtual void TakeDamage(float damagePoints)
        {
            healthPoints -= damagePoints;
        }
        public virtual float Attack(float zAttack)
        {
            return zAttack;
        }

        public bool IsDefeated
        {
            get
            {
                // TODO when is the zombie defeated?
                return false;
            }
        }
    }
}
