namespace wizard_ninja_samurai{
    public class Ninja:Human{
        //Ninja should have a default dexterity of 175
        public Ninja(string n):base(n){
            dexterity= 175;
        }
        //Ninja should have a steal method, 
        //which when invoked, attacks an object and increases the Ninjas 
        //health by 10
        public void Steal(object target){
            Human enemy = target as Human ;
            if(enemy!=null){
                attack(enemy);
                health += 10;

            }
        }
        //Ninja should have a get_away method,
        // which when invoked, decreases its health by 15
        public void get_away(){
            health -= 15;
        }
    }
}