using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace BoababRidge
{
    public partial class frmMain : Form
    {
        private readonly AnimalFileService fileService = new AnimalFileService();
        private bool isUpdateMode = false; // to track when we edit an existing animal and preserve the original ID
        private string originalAnimalID = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAnimalSave_Click(object sender, EventArgs e)
        {
            string id = txtAnimalID.Text.Trim().ToUpper();
            string name = txtAnimalName.Text.Trim();
            string species = txtSpecies.Text.Trim();

            // Checks that required text fields are provided.
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(species))
            {
                MessageBox.Show("Animal ID, Name and Species are required.");
                return;
            }

            // Validate the animal ID format.
            if (!System.Text.RegularExpressions.Regex.IsMatch(id, @"^WR-\d{4}$"))
            {
                MessageBox.Show("Animal ID must follow the format WR-0001.");
                txtAnimalID.Focus();
                return;
            }

            // Check that age is a whole number between 0 and 100.
            if (!int.TryParse(txtAge.Text, out int age) || age < 0 || age > 100)
            {
                MessageBox.Show("Age must be a whole number between 0 and 100.");
                txtAge.Focus();
                return;
            }

            // Check that recovery score is between 0 and 100.
            if (!int.TryParse(txtRecoveryScore.Text, out int score) ||
                score < 0 || score > 100)
            {
                MessageBox.Show("Recovery Score must be between 0 and 100.");
                txtRecoveryScore.Focus();
                return;
            }

            // Prevent characters from breaking the file format.
            if (name.Length > 30 || name.Contains('|'))
            {
                MessageBox.Show("Animal Name must be 1–30 characters and cannot contain |.");
                txtAnimalName.Focus();
                return;
            }

            if (species.Length > 30 || species.Contains('|'))
            {
                MessageBox.Show("Species must be 1–30 characters and cannot contain |.");
                txtSpecies.Focus();
                return;
            }

            // Prevent duplicate IDs when adding a new animal.
            if (!isUpdateMode && fileService.AnimalIDExists(id))
            {
                MessageBox.Show("An animal with this ID already exists.");
                txtAnimalID.Focus();
                return;
            }


            // Create the animal and calculate its classification.
            Animal animal = new Animal
            {
                AnimalID = id,
                Name = name,
                Species = species,
                Age = age,
                RecoveryScore = score
            };

            animal.CalculateClassification();


            try
            {
                if (isUpdateMode)
                {
                    animal.AnimalID = originalAnimalID;
                    fileService.UpdateAnimal(animal);

                    MessageBox.Show(
                        $"Animal updated successfully!\nStatus: {animal.Status}\nHousing: {animal.HousingUnit}");

                    isUpdateMode = false;
                    originalAnimalID = "";
                    txtAnimalID.Enabled = true;
                    btnAddAnimalSave.Text = "Add Animal";
                    lblFormTitle.Text = "Add New Animal";
                }
                else
                {
                    fileService.AddAnimal(animal);

                    MessageBox.Show(
                        $"Animal saved successfully!\nStatus: {animal.Status}\nHousing: {animal.HousingUnit}");
                }

                // Clear the fields after a successful save or update.
                txtAnimalID.Clear();
                txtAnimalName.Clear();
                txtSpecies.Clear();
                txtAge.Clear();
                txtRecoveryScore.Clear();
                txtAnimalID.Focus();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("The animal file could not be saved. Please try again.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to save the animal file.");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnimalID.Clear();
            txtAnimalName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtRecoveryScore.Clear();

            // Reset the form back to Add Animal mode.
            isUpdateMode = false;
            originalAnimalID = "";
            txtAnimalID.Enabled = true;
            btnAddAnimalSave.Text = "Add Animal";
            lblFormTitle.Text = "Add New Animal";

            txtAnimalID.Focus();
        }

        private void btnUpdateAnimal_Click(object sender, EventArgs e)
        {
            string searchID = Microsoft.VisualBasic.Interaction
       .InputBox("Enter the Animal ID to update:", "Update Animal")
       .Trim();

            if (string.IsNullOrWhiteSpace(searchID))
            {
                return;
            }

            Animal animal = fileService.LoadAnimals()
                .FirstOrDefault(a => a.AnimalID.Equals(
                    searchID, StringComparison.OrdinalIgnoreCase));

            if (animal == null)
            {
                MessageBox.Show("Animal ID not found.");
                return;
            }

            txtAnimalID.Text = animal.AnimalID;
            txtAnimalName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
            txtRecoveryScore.Text = animal.RecoveryScore.ToString();

            txtAnimalID.Enabled = false;
            isUpdateMode = true;
            lblFormTitle.Text = "Update Animal";
            originalAnimalID = animal.AnimalID;

            btnAddAnimalSave.Text = "Save Changes";

            MessageBox.Show("Animal loaded. Edit the details and click Save Changes.");
        }
    }
}
