Baobab Ridge Wildlife Rehabilitation Centre
Project Description
This is a C# Windows Forms application developed for Baobab Ridge Wildlife Rehabilitation Centre. It helps staff manage animal records and track the recovery status of animals at the centre.
Group Members
• Member 1: Oratile Jacobs– 604335
• Member 2: Shihluke Mkhabele– 604987
• Member 3: Tlotliso Pitso– 604265

Features
• Add Animal: Add a new animal record with its ID, name, species, age and recovery score.
• View Animals: Display animal records in a table.
• Update Animal: Search for an animal using its ID and update its information.
• Animal Classification: Automatically assign an animal's recovery status and housing unit based on its recovery score.
• Delete Animal: Deletes selected animal
• Summary:  Provides a brief summary of the animals in the centre and other relevant information
Technologies Used
• C#
• .NET 8 Windows Forms
• Visual Studio
• Text file storage
How to Build and Run
1. Download or clone the project repository from GitHub.
2. Open the solution file in Visual Studio.
3. Make sure animals.txt is included in the project and copied to the output directory.
4. Build the solution.
5. Run the application.
File Formats
animals.txt
This file stores animal records. Each line represents one animal, with fields separated by the pipe character (|).
The fields are:
Animal ID | Name | Species | Age | Recovery Score | Status | Housing Unit
Example:
WR-0001|Thabo|African Penguin|4|85|Release-Ready|Pre-Release Camp
summary.txt
The application may generate a summary report file containing information about the animal records.
Limitations
• Animal records are stored in a text file rather than a database.
• The application is designed for basic animal record management.
Running Requirements
• Windows operating system
• Visual Studio with .NET 8 support