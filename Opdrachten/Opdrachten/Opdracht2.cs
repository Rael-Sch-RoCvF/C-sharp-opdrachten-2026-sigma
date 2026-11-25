using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{

    class Item
    {
        string name;
        string description;
        public string room;
        public bool collected = false;
        public Item(string name, string description, string room)
        {
            this.name = name;
            this.description = description;
            this.room = room;
        }

        public void GetInfo()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Item: {name}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Room: {room}");
            Console.WriteLine("-------------------------------");
            collected = true;
        }
    }
    public class Opdracht2
    {
        public string[,] rooms = new string[6, 4]
        {
            {"Hallway", "Kitchen", "Living room", "Upstairs hallway"},
            {"Kitchen", "Hallway", "Living room", "None"},
            {"Living room", "Hallway", "Living room", "Kitchen"},
            {"Bathroom", "Hallway", "Bedroom", "None"},
            {"Bedroom", "Upstairs hallway", "Bathroom", "None"},
            {"Upstairs hallway", "Hallway", "Bedroom", "Bathroom"}
        };

        string[] roomsID =
        {
            "Hallway",
            "Kitchen",
            "Living room",
            "Bathroom",
            "Bedroom",
            "Upstairs hallway"
        };

        public void Start()
        {
            string[] Interaction =
            {
                "Check for items",
                "Check the next rooms",
                "Return to previous room",
                ""
            };

            List<string> availableRooms = new List<string>{};


            int currentRoomID = 0;
            string currentRoom = rooms[currentRoomID, 0];
            string lastRoom = rooms[currentRoomID, 0];

            Item key = new Item("Key", "Opens the front door", "Bedroom");

            void InteractionPrompts()
            {
                int interactionamount = (currentRoomID == 0) ? 4 : 3;
                for (int i = 0; i < interactionamount; i++)
                {
                    Console.WriteLine($"{i + 1}: {Interaction[i]}");
                }

            }

            void Main()
            {
                availableRooms.Clear();

                for (int i = 1; i <= 3; i++)
                { 
                    availableRooms.Add(rooms[currentRoomID, i]);
                }

                if (currentRoom == rooms[0, 0])
                {
                    Interaction[3] = "Exit";
                }
                else
                {
                    Interaction[3] = "";
                }

                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Current room: {currentRoom} ({currentRoomID})");
                Console.WriteLine("Choose what you want to do: ");
                InteractionPrompts();
                int choice = (int.TryParse(Console.ReadLine(), out choice) ? choice : 0);
                switch (choice)
                {
                    case 1:
                        if (currentRoom == key.room)
                        {
                            Console.WriteLine("You Collected the key:");
                            key.GetInfo();
                        }

                        switch (currentRoomID)
                        {
                            case 1:
                                Console.WriteLine("You tried to grab a knife but I (the game developer) am evil so you kinda accidentally stabbed yourself and died");
                                return;

                            case 2:
                                Console.WriteLine("An alien jumps out of the TV and zaps you causing you to implode (c'mon you could've seen this coming)");
                                return;

                            case 3:
                                Console.WriteLine("You tried to find something in the baththub but a high pressured water stream shot you and you died (fuck you)");
                                return;

                            default:
                                Console.WriteLine(" ");
                                break;
                        }
                        break;

                    case 2:
                        foreach (string room in availableRooms)
                        {
                            Console.WriteLine($"- {room}");
                        };

                        Console.WriteLine("");
                        Console.WriteLine("Choose where you want to go: ");
                        StringBuilder rmc = new StringBuilder(Console.ReadLine());
                        for (int i = 0; i < rmc.Length; i++)
                        {
                            if (i == 0)
                            {
                                rmc[i] = char.ToUpper(rmc[i]);
                            }
                            else
                            {
                                rmc[i] = char.ToLower(rmc[i]);
                            }
                        }
                        string roomChoice = rmc.ToString();
                        if (availableRooms.IndexOf(roomChoice) != -1 && roomChoice != "None")
                        {
                            lastRoom = currentRoom;
                            currentRoomID = Array.IndexOf(roomsID, roomChoice);
                            currentRoom = roomChoice;
                        }
                        else
                        {
                            Console.WriteLine("That room is not available, please try again");
                        }

                        break;

                    case 3:
                        string temp = currentRoom;
                        currentRoomID = Array.IndexOf(roomsID, lastRoom);
                        currentRoom = lastRoom;
                        lastRoom = temp;
                        break;

                    case 4:
                        if (currentRoom == rooms[0, 0])
                        {
                            if (key.collected)
                            {
                                Console.WriteLine("You have exited the house, you win!");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("You still need to find the key");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("That option is not available, please try again");
                        }
                        break;

                    case 1978:
                        key.GetInfo();
                        break;

                    default:

                        break;
                }
                Main();
            }


            Main();

        }
    }
}
