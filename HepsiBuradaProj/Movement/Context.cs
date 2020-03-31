using HepsiBuradaProj.Enum;
using HepsiBuradaProj.IMovement;

namespace HepsiBuradaProj.Movement
{
    public class Context{
        private IStrategy strategy;

        public Context (){

        }

        public Context (IStrategy strategy){
            this.strategy = strategy;   
        }

        public Direction executeStrategy(Direction roverDirection){
            return strategy.doOperation(roverDirection);
        }

        
    }
}