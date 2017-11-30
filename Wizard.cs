using System;
namespace wizard_ninja_samurai{
    public class Wizard : Human{
        public Wizard(string n) : base(n){
            //Wizard should have a default health of 50 and intelligence of 25
            health =100;
            intelligence=25;
        }
        //Wizard should have a method called heal,
         //which when invoked, heals the Wizard by 10 * intelligence
        public void heal(){
            health+=10*intelligence;
        }
        //Wizard should have a method called fireball, 
        //which when invoked, decreases the health of 
        //whichever object it attacked by some random integer between 20 and 50
        public void fireball(object target){
            Human enemy= target as Human;
            if(enemy != null){
                Random rand = new Random();
                enemy.health -= rand.Next(20,51);

            } 
        }
    }
}