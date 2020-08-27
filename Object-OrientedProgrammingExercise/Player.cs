using System;
using System.Collections.Generic;
using System.Text;

namespace Object_OrientedProgrammingExercise
{
    class Player
    {
        public float healthPoints = 100;
        
        // Accepts an attack with given number of damage points
        public void TakeDamge (float damagePoints)
        {
            healthPoints -= damagePoints;
        }
        
        public float Attack(float pAttack)
        {
            return pAttack;
        }

        public bool IsDefeated
        {
            get
            {
                // TODO how do we know if the player is defeated?
                return false;
            }
        }
    }
}
