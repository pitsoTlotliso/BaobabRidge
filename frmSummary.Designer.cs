namespace BoababRidge
{
    partial class frmSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummary));
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pnlContent = new Panel();
            lblStatus = new Label();
            lblAge = new Label();
            lblSpecies = new Label();
            lblName = new Label();
            btnGenerate = new Button();
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
            rtSumm = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlContent.SuspendLayout();
            panel2.SuspendLayout();
            pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWildlife).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(10, 185);
            button2.Name = "button2";
            button2.Size = new Size(200, 45);
            button2.TabIndex = 3;
            button2.Text = "Delete Animal";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 49, 29);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(0, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 560);
            panel1.TabIndex = 11;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(10, 240);
            button1.Name = "button1";
            button1.Size = new Size(200, 45);
            button1.TabIndex = 4;
            button1.Text = "Summary";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(10, 130);
            button3.Name = "button3";
            button3.Size = new Size(200, 45);
            button3.TabIndex = 2;
            button3.Text = "Update Animal";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(10, 75);
            button4.Name = "button4";
            button4.Size = new Size(200, 45);
            button4.TabIndex = 1;
            button4.Text = "View Animals";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(6, 49, 29);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(10, 20);
            button5.Name = "button5";
            button5.Size = new Size(200, 45);
            button5.TabIndex = 0;
            button5.Text = "Add Animal";
            button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkOliveGreen;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-33, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(135, 60);
            label1.Name = "label1";
            label1.Size = new Size(284, 23);
            label1.TabIndex = 1;
            label1.Text = "WILDLIFE REHABILITATION CENTRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(135, 0);
            label2.Name = "label2";
            label2.Size = new Size(268, 46);
            label2.TabIndex = 0;
            label2.Text = "BAOBAB RIDGE";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(225, 236, 197);
            pnlContent.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.Controls.Add(rtSumm);
            pnlContent.Controls.Add(lblStatus);
            pnlContent.Controls.Add(lblAge);
            pnlContent.Controls.Add(lblSpecies);
            pnlContent.Controls.Add(lblName);
            pnlContent.Controls.Add(btnGenerate);
            pnlContent.Controls.Add(lblFormTitle);
            pnlContent.Location = new Point(216, 107);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(951, 526);
            pnlContent.TabIndex = 12;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(465, 367);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 21;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(465, 307);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(0, 20);
            lblAge.TabIndex = 19;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(465, 252);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(0, 20);
            lblSpecies.TabIndex = 17;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(455, 197);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 20);
            lblName.TabIndex = 16;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(6, 49, 29);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.WhiteSmoke;
            btnGenerate.Location = new Point(803, 15);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(115, 40);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate Summary";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(6, 49, 29);
            lblFormTitle.Location = new Point(349, 14);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(162, 38);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "SUMMARY";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1135, 100);
            panel2.TabIndex = 10;
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
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = Color.FromArgb(6, 49, 29);
            pnlNavigation.Controls.Add(btnSummary);
            pnlNavigation.Controls.Add(btnDeleteAnimal);
            pnlNavigation.Controls.Add(btnUpdateAnimal);
            pnlNavigation.Controls.Add(btnViewAnimals);
            pnlNavigation.Controls.Add(btnAddAnimal);
            pnlNavigation.Location = new Point(-46, 32);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(44, 465);
            pnlNavigation.TabIndex = 9;
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
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkOliveGreen;
            pnlHeader.Controls.Add(picWildlife);
            pnlHeader.Controls.Add(lblCentreSubtitle);
            pnlHeader.Controls.Add(lblCentreName);
            pnlHeader.Location = new Point(-46, -68);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(924, 10);
            pnlHeader.TabIndex = 8;
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
            // rtSumm
            // 
            rtSumm.Location = new Point(156, 89);
            rtSumm.Name = "rtSumm";
            rtSumm.ReadOnly = true;
            rtSumm.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtSumm.Size = new Size(615, 424);
            rtSumm.TabIndex = 22;
            rtSumm.Text = "";
            // 
            // frmSummary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 633);
            Controls.Add(panel1);
            Controls.Add(pnlContent);
            Controls.Add(panel2);
            Controls.Add(pnlNavigation);
            Controls.Add(pnlHeader);
            Name = "frmSummary";
            Text = "frmSummary";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picWildlife).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
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
        private Button btnGenerate;
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
        private RichTextBox rtSumm;
    }
}