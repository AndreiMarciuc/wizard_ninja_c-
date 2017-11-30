using System;
namespace wizard_ninja_samurai{
    public class Samurai : Human{
        //Samurai should have a default health of 200
        
        public Samurai(string n): base(n){
        
            health=200;
        }
        public void death_blow(object target) {
            Human enemy = target as Human;
            if(enemy != null) {
                if(enemy.health < 50) {
                    enemy.health = 0;
                }
            }
        }

        public void meditate() {
            health = 200;
        }

        
    }
}