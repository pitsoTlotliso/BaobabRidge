namespace BoababRidge
{
    partial class frmViewAnimals : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pnlContent = new Panel();
            dgv_ViewAnimals = new DataGridView();
            lblStatus = new Label();
            lblAge = new Label();
            lblSpecies = new Label();
            lblName = new Label();
            lblFormTitle = new Label();
            panel2 = new Panel();
            btnSummary = new Button();
            btnDeleteAnimal = new Button();
            btnUpdateAnimal = new Button();
            btnViewAnimals = new Button();
            btnAddAnimal = new Button();
            pnlNavigation = new Panel();
            picWildlife = new PictureBox();
            lblCentreSubtitle = new Label();
            pnlHeader = new Panel();
            lblCentreName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ViewAnimals).BeginInit();
            panel2.SuspendLayout();
            pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWildlife).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 49, 29);
            panel1.Location = new Point(0, 129);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 700);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkOliveGreen;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(-41, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(169, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(351, 30);
            label1.TabIndex = 1;
            label1.Text = "WILDLIFE REHABILITATION CENTRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(169, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(315, 54);
            label2.TabIndex = 0;
            label2.Text = "BAOBAB RIDGE";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(225, 236, 197);
            pnlContent.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.Controls.Add(dgv_ViewAnimals);
            pnlContent.Controls.Add(lblStatus);
            pnlContent.Controls.Add(lblAge);
            pnlContent.Controls.Add(lblSpecies);
            pnlContent.Controls.Add(lblName);
            pnlContent.Controls.Add(lblFormTitle);
            pnlContent.Location = new Point(270, 134);
            pnlContent.Margin = new Padding(4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1188, 657);
            pnlContent.TabIndex = 12;
            // 
            // dgv_ViewAnimals
            // 
            dgv_ViewAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ViewAnimals.Location = new Point(21, 67);
            dgv_ViewAnimals.Name = "dgv_ViewAnimals";
            dgv_ViewAnimals.RowHeadersWidth = 62;
            dgv_ViewAnimals.Size = new Size(1127, 577);
            dgv_ViewAnimals.TabIndex = 25;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(581, 459);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 21;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(581, 384);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(0, 25);
            lblAge.TabIndex = 19;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(581, 315);
            lblSpecies.Margin = new Padding(4, 0, 4, 0);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(0, 25);
            lblSpecies.TabIndex = 17;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(569, 246);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 25);
            lblName.TabIndex = 16;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(6, 49, 29);
            lblFormTitle.Location = new Point(365, 19);
            lblFormTitle.Margin = new Padding(4, 0, 4, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(228, 45);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "View Animals";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 1);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1419, 125);
            panel2.TabIndex = 10;
            // 
            // btnSummary
            // 
            btnSummary.FlatStyle = FlatStyle.Flat;
            btnSummary.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSummary.ForeColor = Color.WhiteSmoke;
            btnSummary.Location = new Point(12, 300);
            btnSummary.Margin = new Padding(4);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(250, 56);
            btnSummary.TabIndex = 4;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAnimal
            // 
            btnDeleteAnimal.FlatStyle = FlatStyle.Flat;
            btnDeleteAnimal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteAnimal.ForeColor = Color.WhiteSmoke;
            btnDeleteAnimal.Location = new Point(12, 231);
            btnDeleteAnimal.Margin = new Padding(4);
            btnDeleteAnimal.Name = "btnDeleteAnimal";
            btnDeleteAnimal.Size = new Size(250, 56);
            btnDeleteAnimal.TabIndex = 3;
            btnDeleteAnimal.Text = "Delete Animal";
            btnDeleteAnimal.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAnimal
            // 
            btnUpdateAnimal.FlatStyle = FlatStyle.Flat;
            btnUpdateAnimal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAnimal.ForeColor = Color.WhiteSmoke;
            btnUpdateAnimal.Location = new Point(12, 162);
            btnUpdateAnimal.Margin = new Padding(4);
            btnUpdateAnimal.Name = "btnUpdateAnimal";
            btnUpdateAnimal.Size = new Size(250, 56);
            btnUpdateAnimal.TabIndex = 2;
            btnUpdateAnimal.Text = "Update Animal";
            btnUpdateAnimal.UseVisualStyleBackColor = true;
            // 
            // btnViewAnimals
            // 
            btnViewAnimals.FlatStyle = FlatStyle.Flat;
            btnViewAnimals.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewAnimals.ForeColor = Color.WhiteSmoke;
            btnViewAnimals.Location = new Point(12, 94);
            btnViewAnimals.Margin = new Padding(4);
            btnViewAnimals.Name = "btnViewAnimals";
            btnViewAnimals.Size = new Size(250, 56);
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
            btnAddAnimal.Location = new Point(12, 25);
            btnAddAnimal.Margin = new Padding(4);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(250, 56);
            btnAddAnimal.TabIndex = 0;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = false;
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = Color.FromArgb(6, 49, 29);
            pnlNavigation.Controls.Add(btnSummary);
            pnlNavigation.Controls.Add(btnDeleteAnimal);
            pnlNavigation.Controls.Add(btnUpdateAnimal);
            pnlNavigation.Controls.Add(btnViewAnimals);
            pnlNavigation.Controls.Add(btnAddAnimal);
            pnlNavigation.Location = new Point(-58, 40);
            pnlNavigation.Margin = new Padding(4);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(55, 581);
            pnlNavigation.TabIndex = 9;
            // 
            // picWildlife
            // 
            picWildlife.BackColor = Color.DarkOliveGreen;
            picWildlife.ErrorImage = null;
            picWildlife.Location = new Point(-41, 0);
            picWildlife.Margin = new Padding(4);
            picWildlife.Name = "picWildlife";
            picWildlife.Size = new Size(202, 125);
            picWildlife.SizeMode = PictureBoxSizeMode.Zoom;
            picWildlife.TabIndex = 2;
            picWildlife.TabStop = false;
            // 
            // lblCentreSubtitle
            // 
            lblCentreSubtitle.AutoSize = true;
            lblCentreSubtitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCentreSubtitle.ForeColor = Color.WhiteSmoke;
            lblCentreSubtitle.Location = new Point(169, 75);
            lblCentreSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblCentreSubtitle.Name = "lblCentreSubtitle";
            lblCentreSubtitle.Size = new Size(351, 30);
            lblCentreSubtitle.TabIndex = 1;
            lblCentreSubtitle.Text = "WILDLIFE REHABILITATION CENTRE";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkOliveGreen;
            pnlHeader.Controls.Add(picWildlife);
            pnlHeader.Controls.Add(lblCentreSubtitle);
            pnlHeader.Controls.Add(lblCentreName);
            pnlHeader.Location = new Point(-58, -85);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1155, 12);
            pnlHeader.TabIndex = 8;
            // 
            // lblCentreName
            // 
            lblCentreName.AutoSize = true;
            lblCentreName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCentreName.ForeColor = Color.WhiteSmoke;
            lblCentreName.Location = new Point(169, 0);
            lblCentreName.Margin = new Padding(4, 0, 4, 0);
            lblCentreName.Name = "lblCentreName";
            lblCentreName.Size = new Size(315, 54);
            lblCentreName.TabIndex = 0;
            lblCentreName.Text = "BAOBAB RIDGE";
            // 
            // frmViewAnimals
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 791);
            Controls.Add(panel1);
            Controls.Add(pnlContent);
            Controls.Add(panel2);
            Controls.Add(pnlNavigation);
            Controls.Add(pnlHeader);
            Margin = new Padding(4);
            Name = "frmViewAnimals";
            Text = "frmViewAnimals";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ViewAnimals).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picWildlife).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel pnlContent;
        private Label lblStatus;
        private Label label9;
        private Label lblAge;
        private Label label7;
        private Label lblSpecies;
        private Label lblName;
        private Label label4;
        private Label label3;
        private Button btnClear;
        private Label lblAnimalID;
        private Label lblFormTitle;
        private Panel panel2;
        private Button btnSummary;
        private Button btnDeleteAnimal;
        private Button btnUpdateAnimal;
        private Button btnViewAnimals;
        private Button btnAddAnimal;
        private Panel pnlNavigation;
        private PictureBox picWildlife;
        private Label lblCentreSubtitle;
        private Panel pnlHeader;
        private Label lblCentreName;
        private DataGridView dgv_ViewAnimals;
    }
}