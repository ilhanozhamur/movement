using HepsiBuradaProj.Enum;
using HepsiBuradaProj.IMovement;

namespace HepsiBuradaProj.Movement
{
    public class OperationTurnRight : IStrategy
    {
        public Direction doOperation(Direction roverDirection)
        {
            roverDirection = (roverDirection + 1) > Direction.W ? Direction.N : roverDirection + 1;
            return roverDirection;
        }
    }
}