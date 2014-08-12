using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class FloorRequestManager
    {
        private ElevatorManager elevatorManager = new ElevatorManager();

        public void LoopingThread()
        {
           // loops forever waiting for elevator and other requests.
        }

        public void ReceiveElevatorRequest(Direction direction, int requestedFloor)
        {
            elevatorManager.MoveElevator(requestedFloor);
        }
    }
}
