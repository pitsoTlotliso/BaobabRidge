
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BoababRidge
{
    public partial class frmViewAnimals : Form
    {
        private AnimalFileService service = new AnimalFileService();

        public frmViewAnimals()
        {
            InitializeComponent();
            LoadAnimalRecords();
        }

        private void LoadAnimalRecords()
        {
            List<Animal> animals = service.LoadAnimals();

            dgv_ViewAnimals.DataSource = animals;
        }

    }
}
