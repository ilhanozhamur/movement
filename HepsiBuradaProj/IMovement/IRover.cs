using HepsiBuradaProj.Enum;
using HepsiBuradaProj.IMovement;

namespace HepsiBuradaProj.IMovement
{
    public interface IRover
    {
        IPlateau RoverPlateau { get; set; }
        IPosition RoverPosition { get; set; }
        Direction RoverDirection { get; set; }
        void Process (string commands);
        string ToString();
    }
}