using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ElevatorManager
    {
        List<Elevator> elevators = new List<Elevator>();
        public bool MoveElevator(Direction direction, int destinationFloor)
        {
            Elevator elevator = elevators.Where(x => x.CurrentState == ElevatorState.Waiting).FirstOrDefault();
            if (elevator != null)
            {
                return elevator.GoTo(destinationFloor);
            }

            ElevatorState requiredState = (direction == Direction.Up) ? ElevatorState.GoingUp: ElevatorState.GoingDown;
            elevator = elevators.Where(x => x.CurrentState == requiredState).FirstOrDefault();

            if (elevator != null)
            {
                return elevator.GoTo(destinationFloor);
            }

            requiredState = (requiredState == ElevatorState.GoingUp) ? ElevatorState.GoingDown : ElevatorState.GoingUp;
            elevator = elevators.Where(x => x.CurrentState == requiredState).FirstOrDefault();

            if (elevator != null)
            {
                return elevator.GoTo(destinationFloor);
            }

            return false;                        
        }
    }
}
