using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoababRidge
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btnAddAnimalSave_Click(object sender, EventArgs e)
        {
            if (dgrDelete.SelectedRows.Count > 0)
            {
                string animalID =
                    dgrDelete.SelectedRows[0].Cells["AnimalID"].Value.ToString();

                string animalName =
                    dgrDelete.SelectedRows[0].Cells["Name"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete " +
                    animalName + " (" + animalID + ")?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    AnimalFileService service = new AnimalFileService();

                    service.Delete(animalID);

                    dgrDelete.DataSource = null;

                    dgrDelete.DataSource = service.LoadAnimals();
                }
            }
            else
            {
                MessageBox.Show("Please select an animal first.");
            }
        }


        

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        
        private void Delete_Load(object sender, EventArgs e)
        {
            AnimalFileService service = new AnimalFileService();

            dgrDelete.DataSource = service.LoadAnimals();

        }
    }
}
