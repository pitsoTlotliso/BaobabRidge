using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace BoababRidge
{
    //Handler to save animal records to text file
    public class AnimalFileService
    {
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");

        //adding a new animal record to the end of the data file
        public void AddAnimal(Animal animal)
        {
            string line = $"{animal.AnimalID} | {animal.Name} | {animal.Species} | {animal.Age} | {animal.RecoveryScore} | {animal.Status} | {animal.HousingUnit}";
            File.AppendAllText(filePath, line + Environment.NewLine, Encoding.UTF8);
        }

        // Checks whether an animal ID already exists in the data file.
        public bool AnimalIDExists(string animalID)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            

            foreach (string line in lines)
            {
                string[] fields = line.Split('|').Select(field=>field.Trim()).ToArray();

                if (fields.Length == 7 &&
                    fields[0].Equals(animalID, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        
        // Loads all valid animal records from the text file.
        public List<Animal> LoadAnimals()
        {
            List<Animal> animals = new List<Animal>();

            if (!File.Exists(filePath))
            {
                return animals;
            }

            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            foreach (string line in lines)
            {
                string[] fields = line.Split('|')
                                      .Select(field => field.Trim())
                                      .ToArray();

                if (fields.Length != 7)
                {
                    continue;
                }

                if (!int.TryParse(fields[3], out int age) ||
                    !int.TryParse(fields[4], out int score))
                {
                    continue;
                }

                Animal animal = new Animal
                {
                    AnimalID = fields[0],
                    Name = fields[1],
                    Species = fields[2],
                    Age = age,
                    RecoveryScore = score,
                    Status = fields[5],
                    HousingUnit = fields[6]
                };

                animals.Add(animal);
            }

            return animals;
        }

        
        // Updates an existing animal record in the text file.
        public void UpdateAnimal(Animal updatedAnimal)
        {
            List<Animal> animals = LoadAnimals();

            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].AnimalID.Equals(
                    updatedAnimal.AnimalID,
                    StringComparison.OrdinalIgnoreCase))
                {
                    animals[i] = updatedAnimal;
                    break;
                }
            }

            List<string> lines = new List<string>();

            foreach (Animal animal in animals)
            {
                lines.Add(
                    $"{animal.AnimalID}|{animal.Name}|{animal.Species}|{animal.Age}|{animal.RecoveryScore}|{animal.Status}|{animal.HousingUnit}");
            }

            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }
    }
}
