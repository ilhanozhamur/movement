namespace HepsiBuradaProj.Movement
{
    public static class Validation
    {
        public static bool isValid(Position plateauSize, Position roverPoint)
        {
            var isValidX = roverPoint.XCoordinate >= 0 && roverPoint.XCoordinate <= plateauSize.XCoordinate;
            var isValidY = roverPoint.YCoordinate >= 0 && roverPoint.YCoordinate <= plateauSize.YCoordinate;
            return isValidX && isValidY;
        }
    }
}