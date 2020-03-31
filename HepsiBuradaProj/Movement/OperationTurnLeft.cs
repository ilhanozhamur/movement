using HepsiBuradaProj.Enum;
using HepsiBuradaProj.IMovement;

namespace HepsiBuradaProj.Movement
{
    public class OperationTurnLeft : IStrategy
    {
        public Direction doOperation(Direction roverDirection)
        {
            roverDirection = (roverDirection - 1) < Direction.N ? Direction.W : roverDirection - 1;
            return roverDirection;
        }
    }
}