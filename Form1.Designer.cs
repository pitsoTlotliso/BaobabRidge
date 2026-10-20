namespace BoababRidge
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlHeader = new Panel();
            picWildlife = new PictureBox();
            lblCentreSubtitle = new Label();
            lblCentreName = new Label();
            pnlNavigation = new Panel();
            btnSummary = new Button();
            btnDeleteAnimal = new Button();
            btnUpdateAnimal = new Button();
            btnViewAnimals = new Button();
            btnAddAnimal = new Button();
            pnlContent = new Panel();
            btnClear = new Button();
            btnAddAnimalSave = new Button();
            txtRecoveryScore = new TextBox();
            txtAge = new TextBox();
            txtSpecies = new TextBox();
            txtAnimalName = new TextBox();
            txtAnimalID = new TextBox();
            lblRecoveryScore = new Label();
            lblAge = new Label();
            lblSpecies = new Label();
            lblAnimalName = new Label();
            lblAnimalID = new Label();
            lblFormTitle = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWildlife).BeginInit();
            pnlNavigation.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkOliveGreen;
            pnlHeader.Controls.Add(picWildlife);
            pnlHeader.Controls.Add(lblCentreSubtitle);
            pnlHeader.Controls.Add(lblCentreName);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1100, 100);
            pnlHeader.TabIndex = 0;
            // 
            // picWildlife
            // 
            picWildlife.BackColor = Color.DarkOliveGreen;
            picWildlife.ErrorImage = (Image)resources.GetObject("picWildlife.ErrorImage");
            picWildlife.Image = (Image)resources.GetObject("picWildlife.Image");
            picWildlife.Location = new Point(-33, 0);
            picWildlife.Name = "picWildlife";
            picWildlife.Size = new Size(162, 100);
            picWildlife.SizeMode = PictureBoxSizeMode.Zoom;
            picWildlife.TabIndex = 2;
            picWildlife.TabStop = false;
            // 
            // lblCentreSubtitle
            // 
            lblCentreSubtitle.AutoSize = true;
            lblCentreSubtitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCentreSubtitle.ForeColor = Color.WhiteSmoke;
            lblCentreSubtitle.Location = new Point(135, 60);
            lblCentreSubtitle.Name = "lblCentreSubtitle";
            lblCentreSubtitle.Size = new Size(284, 23);
            lblCentreSubtitle.TabIndex = 1;
            lblCentreSubtitle.Text = "WILDLIFE REHABILITATION CENTRE";
            // 
            // lblCentreName
            // 
            lblCentreName.AutoSize = true;
            lblCentreName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCentreName.ForeColor = Color.WhiteSmoke;
            lblCentreName.Location = new Point(135, 0);
            lblCentreName.Name = "lblCentreName";
            lblCentreName.Size = new Size(268, 46);
            lblCentreName.TabIndex = 0;
            lblCentreName.Text = "BAOBAB RIDGE";
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = Color.FromArgb(6, 49, 29);
            pnlNavigation.Controls.Add(btnSummary);
            pnlNavigation.Controls.Add(btnDeleteAnimal);
            pnlNavigation.Controls.Add(btnUpdateAnimal);
            pnlNavigation.Controls.Add(btnViewAnimals);
            pnlNavigation.Controls.Add(btnAddAnimal);
            pnlNavigation.Location = new Point(0, 100);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(220, 560);
            pnlNavigation.TabIndex = 1;
            // 
            // btnSummary
            // 
            btnSummary.FlatStyle = FlatStyle.Flat;
            btnSummary.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSummary.ForeColor = Color.WhiteSmoke;
            btnSummary.Location = new Point(10, 240);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(200, 45);
            btnSummary.TabIndex = 4;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAnimal
            // 
            btnDeleteAnimal.FlatStyle = FlatStyle.Flat;
            btnDeleteAnimal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteAnimal.ForeColor = Color.WhiteSmoke;
            btnDeleteAnimal.Location = new Point(10, 185);
            btnDeleteAnimal.Name = "btnDeleteAnimal";
            btnDeleteAnimal.Size = new Size(200, 45);
            btnDeleteAnimal.TabIndex = 3;
            btnDeleteAnimal.Text = "Delete Animal";
            btnDeleteAnimal.UseVisualStyleBackColor = true;
            btnDeleteAnimal.Click += btnDeleteAnimal_Click;
            // 
            // btnUpdateAnimal
            // 
            btnUpdateAnimal.FlatStyle = FlatStyle.Flat;
            btnUpdateAnimal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAnimal.ForeColor = Color.WhiteSmoke;
            btnUpdateAnimal.Location = new Point(10, 130);
            btnUpdateAnimal.Name = "btnUpdateAnimal";
            btnUpdateAnimal.Size = new Size(200, 45);
            btnUpdateAnimal.TabIndex = 2;
            btnUpdateAnimal.Text = "Update Animal";
            btnUpdateAnimal.UseVisualStyleBackColor = true;
            btnUpdateAnimal.Click += btnUpdateAnimal_Click;
            // 
            // btnViewAnimals
            // 
            btnViewAnimals.FlatStyle = FlatStyle.Flat;
            btnViewAnimals.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewAnimals.ForeColor = Color.WhiteSmoke;
            btnViewAnimals.Location = new Point(10, 75);
            btnViewAnimals.Name = "btnViewAnimals";
            btnViewAnimals.Size = new Size(200, 45);
            btnViewAnimals.TabIndex = 1;
            btnViewAnimals.Text = "View Animals";
            btnViewAnimals.UseVisualStyleBackColor = true;
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.BackColor = Color.FromArgb(6, 49, 29);
            btnAddAnimal.FlatStyle = FlatStyle.Flat;
            btnAddAnimal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAnimal.ForeColor = Color.WhiteSmoke;
            btnAddAnimal.Location = new Point(10, 20);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(200, 45);
            btnAddAnimal.TabIndex = 0;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = false;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(225, 236, 197);
            pnlContent.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.Controls.Add(btnClear);
            pnlContent.Controls.Add(btnAddAnimalSave);
            pnlContent.Controls.Add(txtRecoveryScore);
            pnlContent.Controls.Add(txtAge);
            pnlContent.Controls.Add(txtSpecies);
            pnlContent.Controls.Add(txtAnimalName);
            pnlContent.Controls.Add(txtAnimalID);
            pnlContent.Controls.Add(lblRecoveryScore);
            pnlContent.Controls.Add(lblAge);
            pnlContent.Controls.Add(lblSpecies);
            pnlContent.Controls.Add(lblAnimalName);
            pnlContent.Controls.Add(lblAnimalID);
            pnlContent.Controls.Add(lblFormTitle);
            pnlContent.Location = new Point(216, 100);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(866, 560);
            pnlContent.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(350, 405);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddAnimalSave
            // 
            btnAddAnimalSave.BackColor = Color.FromArgb(6, 49, 29);
            btnAddAnimalSave.FlatStyle = FlatStyle.Flat;
            btnAddAnimalSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAnimalSave.ForeColor = Color.WhiteSmoke;
            btnAddAnimalSave.Location = new Point(220, 405);
            btnAddAnimalSave.Name = "btnAddAnimalSave";
            btnAddAnimalSave.Size = new Size(115, 40);
            btnAddAnimalSave.TabIndex = 11;
            btnAddAnimalSave.Text = "Add Animal";
            btnAddAnimalSave.UseVisualStyleBackColor = false;
            btnAddAnimalSave.Click += btnAddAnimalSave_Click;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.BorderStyle = BorderStyle.FixedSingle;
            txtRecoveryScore.Location = new Point(220, 335);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(300, 27);
            txtRecoveryScore.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(220, 270);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(300, 27);
            txtAge.TabIndex = 9;
            // 
            // txtSpecies
            // 
            txtSpecies.BorderStyle = BorderStyle.FixedSingle;
            txtSpecies.Location = new Point(220, 205);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(300, 27);
            txtSpecies.TabIndex = 8;
            // 
            // txtAnimalName
            // 
            txtAnimalName.BorderStyle = BorderStyle.FixedSingle;
            txtAnimalName.Location = new Point(220, 140);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.Size = new Size(300, 27);
            txtAnimalName.TabIndex = 7;
            // 
            // txtAnimalID
            // 
            txtAnimalID.BorderStyle = BorderStyle.FixedSingle;
            txtAnimalID.Location = new Point(220, 75);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(300, 27);
            txtAnimalID.TabIndex = 6;
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(25, 340);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(162, 20);
            lblRecoveryScore.TabIndex = 5;
            lblRecoveryScore.Text = "Recovery Score (0-100)";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(25, 275);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(25, 210);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(59, 20);
            lblSpecies.TabIndex = 3;
            lblSpecies.Text = "Species";
            // 
            // lblAnimalName
            // 
            lblAnimalName.AutoSize = true;
            lblAnimalName.Location = new Point(25, 145);
            lblAnimalName.Name = "lblAnimalName";
            lblAnimalName.Size = new Size(100, 20);
            lblAnimalName.TabIndex = 2;
            lblAnimalName.Text = "Animal Name";
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(25, 80);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(75, 20);
            lblAnimalID.TabIndex = 1;
            lblAnimalID.Text = "Animal ID";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(6, 49, 29);
            lblFormTitle.Location = new Point(25, 20);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(240, 38);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Add New Animal";
            lblFormTitle.Click += label1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 666);
            Controls.Add(pnlContent);
            Controls.Add(pnlNavigation);
            Controls.Add(pnlHeader);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baobab Ridge Wildlife Rehabilitation Centre";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picWildlife).EndInit();
            pnlNavigation.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblCentreSubtitle;
        private Label lblCentreName;
        private PictureBox picWildlife;
        private Panel pnlNavigation;
        private Button btnAddAnimal;
        private Button btnUpdateAnimal;
        private Button btnViewAnimals;
        private Button btnSummary;
        private Button btnDeleteAnimal;
        private Panel pnlContent;
        private Label lblFormTitle;
        private Label lblRecoveryScore;
        private Label lblAge;
        private Label lblSpecies;
        private Label lblAnimalName;
        private Label lblAnimalID;
        private TextBox txtRecoveryScore;
        private TextBox txtAge;
        private TextBox txtSpecies;
        private TextBox txtAnimalName;
        private TextBox txtAnimalID;
        private Button btnClear;
        private Button btnAddAnimalSave;
    }
}
