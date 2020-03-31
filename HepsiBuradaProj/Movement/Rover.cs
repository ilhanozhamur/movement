using System;
using HepsiBuradaProj.Enum;
using HepsiBuradaProj.Helper;
using HepsiBuradaProj.IMovement;

namespace HepsiBuradaProj.Movement
{
    public class Rover : IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public IPosition RoverPosition { get; set; }
        public Direction RoverDirection { get; set; }

        public Rover(IPlateau roverPlateau, IPosition roverPosition, Direction roverDirection)
        {
            RoverPlateau = roverPlateau;
            RoverPosition = roverPosition;
            RoverDirection = roverDirection;
        }
        public void Process(string commands)
        {
            if (Validation.isValid(RoverPlateau.PlateauPosition, new Position (RoverPosition.XCoordinate, RoverPosition.YCoordinate)))
            {
                Context context = new Context();
                foreach (var command in commands)
                {
                    switch(command)
                    {
                        case('L'):
                            context = new Context(new OperationTurnLeft());
                            RoverDirection = context.executeStrategy(RoverDirection);
                            break;
                        case('R'):
                            context = new Context(new OperationTurnRight());
                            RoverDirection = context.executeStrategy(RoverDirection);
                            break;
                        case('M'):
                            Move();
                            break;
                        default:
                            var exceptionMessage = string.Format("Invalid Value: {0}", command);
                            throw new RoverDeployException(exceptionMessage);
                    }
                }
            }
            else{
                var exceptionMessage = String.Format("Oops! Position can not be beyond bounderies (0 , 0)" + 
                $" and ({RoverPlateau.PlateauPosition.XCoordinate} , {RoverPlateau.PlateauPosition.YCoordinate })");

                throw new RoverDeployException(exceptionMessage);
            }
        }

        private void Move()
        {
            if (RoverDirection == Direction.N)
            {
                RoverPosition.YCoordinate++;
            }
            else if (RoverDirection == Direction.E)
            {
                RoverPosition.XCoordinate++;
            }
            else if (RoverDirection == Direction.S)
            {
                RoverPosition.YCoordinate--;
            }
            else if (RoverDirection == Direction.W)
            {
                RoverPosition.XCoordinate--;
            }
            
            throwDeployException();
        }

        private void throwDeployException()
        {
            if (!Validation.isValid(RoverPlateau.PlateauPosition, new Position (RoverPosition.XCoordinate, RoverPosition.YCoordinate)))
            {
                var exceptionMessage = String.Format("Oops! Position can not be beyond bounderies (0 , 0)" + 
                $" and ({RoverPlateau.PlateauPosition.XCoordinate} , {RoverPlateau.PlateauPosition.YCoordinate })");

                throw new RoverDeployException(exceptionMessage);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", RoverPosition.XCoordinate, RoverPosition.YCoordinate, RoverDirection);
        }
    }
}