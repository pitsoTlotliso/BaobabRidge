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
    public partial class frmSummary : Form
    {
        public frmSummary()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            AnimalFileService service = new AnimalFileService();

            List<Animal> animals = service.LoadAnimals();

            int totalAnimals = animals.Count;

            double averageAge = animals.Average(a => a.Age);

            double averageRecoveryScore =
                animals.Average(a => a.RecoveryScore);

            int critical = animals.Count(a => a.Status == "Critical");
            int serious = animals.Count(a => a.Status == "Serious");
            int stable = animals.Count(a => a.Status == "Stable");
            int recovering = animals.Count(a => a.Status == "Recovering");
            int releaseReady = animals.Count(a => a.Status == "Release-Ready");

            string report =
                "=====================================\n" +
                "     BAOBAB RIDGE SUMMARY REPORT\n" +
                "=====================================\n\n" +
                "Total Animals: " + totalAnimals + "\n\n" +
                "Average Age: " + averageAge.ToString("F2") + "\n" +
                "Average Recovery Score: " + averageRecoveryScore.ToString("F2") + "\n\n" +
                "ANIMALS BY STATUS\n" +
                "---------------------\n" +
                "Critical: " + critical + "\n" +
                "Serious: " + serious + "\n" +
                "Stable: " + stable + "\n" +
                "Recovering: " + recovering + "\n" +
                "Release Ready: " + releaseReady;
            File.WriteAllText("summary.txt", report);
            rtSumm.Text = report;
        }
    }
}
