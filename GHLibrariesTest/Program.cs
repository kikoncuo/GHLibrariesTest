using GHLibrariesTest.DataStructures;
using System;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Json;

namespace GHLibrariesTest
{
    class Program
    {
     static void Main(string[] args)
        {
            //Creates the Character manually instead of doing it from file
            /*
            //Create abilities
            Skill Hook = new Skill()
            {
                cooldown = "6 sec cooldown",
                description = "Brings enemy in front",
                icon = "hook_icon",
                id = 8056,
                name = "Hook",
                cost = "5% of base mana",
                range = "25 mt range"
            };

            Skill Slam = new Skill()
            {
                cooldown = "2 sec cooldown",
                description = "Hits the floor in a cone shape",
                icon = "hook_icon",
                id = 8056,
                name = "Slam",
                cost = "5% of base mana",
                range = "25 mt range"
            };
            //Add them to array
            Skill[] skills = new Skill[] {Hook, Slam};
            //Create character with the created abilities array as a property
            Character Stiches = new Character()
            {
                id = 1,
                name = "Stiches",
                model = "PathToModel",
                abilities = skills,
            };*/

            //Deserialize the json file in path to a character object
            string readJson = File.ReadAllText(@"C:\Users\enriq\Documents\Visual Studio 2015\Projects\GHLibrariesTest\GHLibrariesTest\Jsons\Stiches.json");
            Character deserializedCharacter = JsonConvert.DeserializeObject<Character>(readJson);

            deserializedCharacter.name = "Stiches 2.0";

            //Serialize to json print in console and in a new json
            string toWriteJson = JsonConvert.SerializeObject(deserializedCharacter, Formatting.Indented);
            Console.WriteLine(toWriteJson);
            File.WriteAllText(@"C:\Users\enriq\Documents\Visual Studio 2015\Projects\GHLibrariesTest\GHLibrariesTest\Jsons\EmptyJsonToBeWritten.json", toWriteJson);
           
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }
    }
}
