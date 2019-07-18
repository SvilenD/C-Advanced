namespace PetClinics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Clinic
    {
        private string name;
        private int roomsCount;
        private readonly SortedDictionary<int, Pet> roomsPets;

        public Clinic(string name, int rooms)
        {
            this.Name = name;
            this.RoomsCount = rooms;
            this.roomsPets = new SortedDictionary<int, Pet>();
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int RoomsCount
        {
            get
            {
                return this.roomsCount;
            }
            set
            {
                if (value % 2 == 0)
                {
                    throw new InvalidOperationException("Invalid Operation!");
                }

                this.roomsCount = value;
            }
        }

        public bool AddPet(Pet pet)
        {
            int middle = roomsCount / 2 + 1;
            if (this.roomsCount == roomsPets.Count)
            {
                return false;
            }

            if (roomsPets.ContainsKey(middle) == false)
            {
                roomsPets.Add(middle, pet);
                return true;
            }

            for (int i = 1; i <= middle; i++)
            {
                if (roomsPets.ContainsKey(middle - i) == false)
                {
                    roomsPets.Add(middle - i, pet);
                    return true;
                }
                else if (roomsPets.ContainsKey(middle + i) == false)
                {
                    roomsPets.Add(middle + i, pet);
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            if (this.roomsCount > roomsPets.Count)
            {
                return true;
            }
            return false;
        }

        public bool Release()
        {
            int middle = roomsCount / 2 + 1;

            for (int i = middle; i <= roomsCount; i++)
            {
                if (roomsPets.ContainsKey(i))
                {
                    roomsPets.Remove(i);
                    return true;
                }
            }

            for (int i = middle; i > 0; i--)
            {
                if (roomsPets.ContainsKey(i))
                {
                    roomsPets.Remove(i);
                    return true;
                }
            }

            return false;
        }

        public string PrintRoom(int roomNumber)
        {
            if (this.roomsPets.ContainsKey(roomNumber))
            {
                return this.roomsPets[roomNumber].ToString();
            }
            else
            { 
                return "Room empty";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= roomsCount; i++)
            {
                if (this.roomsPets.ContainsKey(i))
                {
                    result.AppendLine(roomsPets[i].ToString());
                }
                else
                {
                    result.AppendLine("Room empty");
                }
            }
            return result.ToString().TrimEnd();
        }
    }
}