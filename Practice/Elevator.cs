using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public enum ElevatorState
    {
        GoingUp,
        GoingDown,
        Waiting,
        NotWorking
    }

    public class Elevator
    {
        public ElevatorState CurrentState { get; private set; }

        public int CurrentFloor { get; private set; }

        public bool GoTo(int floor)
        {
            // how to serve floor requests from within elevator

            if (CurrentFloor < floor)
            {
                while(CurrentFloor < floor)
                {
                    if (MoveUp())
                    {
                        CurrentFloor++;
                    }
                }
            }
            else if (CurrentFloor > floor)
            {
                while (CurrentFloor > floor)
                {
                    if (MoveDown())
                    {
                        CurrentFloor--;
                    }
                }
            }
            return !Convert.ToBoolean(CurrentFloor - floor);
        }

        private bool MoveUp()
        {
            // moves 1 floor up.
            this.CurrentState = ElevatorState.GoingUp;
            System.Threading.Thread.Sleep(1000);
            this.CurrentState = ElevatorState.Waiting;
            return true;
        }

        private bool MoveDown()
        {
            // moves 1 floor down

            this.CurrentState = ElevatorState.GoingDown;
            System.Threading.Thread.Sleep(1000);
            this.CurrentState = ElevatorState.Waiting;
            return true;
        }
    }
}
