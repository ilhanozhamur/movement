using HepsiBuradaProj.Enum;
using HepsiBuradaProj.Movement;

namespace HepsiBuradaProj.IMovement
{
    public interface IStrategy 
    {
        Direction doOperation(Direction RoverDirection);
    }
}