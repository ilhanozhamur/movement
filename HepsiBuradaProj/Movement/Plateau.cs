using HepsiBuradaProj.IMovement;

namespace HepsiBuradaProj.Movement
{
    public class Plateau : IPlateau
    {
        public Position PlateauPosition { get; set; }

        public Plateau (Position position)
        {
            PlateauPosition = position;
        }
    }
}