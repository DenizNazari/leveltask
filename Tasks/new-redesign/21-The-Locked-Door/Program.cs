namespace LevelTask.Task21
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Door door = new Door("1234");
            door.closeDooor();
            door.lockDoor("1234");
            door.unlockDoor("1234");
            door.openDoor();
        }
    }

    class Door
    {
        private string Password { get; set; }
        public DoorStateEnum State { get; private set; } = DoorStateEnum.Open;
        public Door(string password)
        {
            Password = password;
        }

        public void openDoor()
        {
            if (State == DoorStateEnum.Closed)
            {
                State = DoorStateEnum.Open;
                Console.WriteLine("The door is now open.");
            }
            else if (State == DoorStateEnum.Locked)
            {
                Console.WriteLine("The door is locked. You need to unlock it first.");
            }
            else
            {
                Console.WriteLine("The door is already open.");
            }
        }
        public void closeDooor()
        {
            if (State == DoorStateEnum.Open)
            {
                State = DoorStateEnum.Closed;
                Console.WriteLine("The door is now closed.");
            }
            else if (State == DoorStateEnum.Locked)
            {
                Console.WriteLine("The door is locked. You need to unlock it first.");
            }
            else
            {
                Console.WriteLine("The door is already closed.");
            }
        }
        public void lockDoor(string password)
        {
            if (State == DoorStateEnum.Closed)
            {
                if (password == Password)
                {
                    State = DoorStateEnum.Locked;
                    Console.WriteLine("The door is now locked.");
                }
                else
                {
                    Console.WriteLine("Incorrect password. The door remains closed.");
                }
            }
            else if (State == DoorStateEnum.Open)
            {
                Console.WriteLine("The door is open. You need to close it first before locking.");
            }
            else
            {
                Console.WriteLine("The door is already locked.");
            }
        }

        public void unlockDoor(string password)
        {
            if (State == DoorStateEnum.Locked)
            {
                if (password == Password)
                {
                    State = DoorStateEnum.Closed;
                    Console.WriteLine("The door is now unlocked and closed.");
                }
                else
                {
                    Console.WriteLine("Incorrect password. The door remains locked.");
                }
            }
            else if (State == DoorStateEnum.Open)
            {
                Console.WriteLine("The door is open. You don't need to unlock it.");
            }
            else
            {
                Console.WriteLine("The door is already closed and unlocked.");
            }
        }
        public void changePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == Password)
            {
                Password = newPassword;
                Console.WriteLine("Password changed successfully.");
            }
            else
            {
                Console.WriteLine("Incorrect old password. Password change failed.");
            }
        }
    }

    enum DoorStateEnum
    {
        Open,
        Closed,
        Locked
    }
    enum doorStateTransitionEnum
    {
        OpenToClosed,
        ClosedToOpen,
        ClosedToLocked,
        LockedToClosed
    }
}
