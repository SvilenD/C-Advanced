namespace PetClinics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int commandsCount = int.Parse(Console.ReadLine());
            var pets = new List<Pet>();
            var clinics = new List<Clinic>();
            for (int i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Create")
                {
                    if (command[1] == "Pet")
                    {
                        string name = command[2];
                        int age = int.Parse(command[3]);
                        string kind = command[4];
                        var pet = new Pet(name, age, kind);
                        pets.Add(pet);
                    }
                    else if (command[1] == "Clinic")
                    {
                        string name = command[2];
                        int rooms = int.Parse(command[3]);
                        try
                        {
                            var clinic = new Clinic(name, rooms);
                            clinics.Add(clinic);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                else if (command[0] == "Add")
                {
                    string petName = command[1];
                    string clinicsName = command[2];
                    var pet = pets.FirstOrDefault(p => p.Name == petName);
                    var clinic = clinics.FirstOrDefault(c => c.Name == clinicsName);
                    bool result = clinic.AddPet(pet);
                    Console.WriteLine(result);
                }
                else if (command[0] == "Release")
                {
                    string clinicsName = command[1];
                    var clinic = clinics.FirstOrDefault(c => c.Name == clinicsName);
                    if (clinic != null)
                    {
                        bool result = clinic.Release();
                        Console.WriteLine(result);
                    }
                }
                else if (command[0] == "HasEmptyRooms")
                {
                    string clinicsName = command[1];
                    var clinic = clinics.FirstOrDefault(c => c.Name == clinicsName);
                    bool result = clinic.HasEmptyRooms();
                    Console.WriteLine(result);
                }
                else if (command[0] == "Print")
                {
                    string clinicsName = command[1];
                    var clinic = clinics.FirstOrDefault(c => c.Name == clinicsName);
                    if (command.Length == 2)
                    {
                        Console.WriteLine(clinic);
                    }
                    else
                    {
                        int roomNumber = int.Parse(command[2]);
                        Console.WriteLine(clinic.PrintRoom(roomNumber));
                    }
                }
            }
        }
    }
}