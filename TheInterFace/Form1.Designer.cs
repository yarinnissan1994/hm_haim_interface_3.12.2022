namespace TheInterFace
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.colaBtn = new System.Windows.Forms.Button();
            this.kinleyBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(35, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Full Name";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(35, 113);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(43, 25);
            this.dayLabel.TabIndex = 1;
            this.dayLabel.Text = "Day";
            this.dayLabel.UseWaitCursor = true;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(35, 196);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(44, 25);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(35, 280);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 34);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save Info";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(153, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 31);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.Text = "Enter Name";
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(153, 110);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(150, 31);
            this.dayTextBox.TabIndex = 5;
            this.dayTextBox.Text = "Enter Day";
            this.dayTextBox.Click += new System.EventHandler(this.dayTextBox_Click);
            this.dayTextBox.Leave += new System.EventHandler(this.dayTextBox_Leave);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(153, 193);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(150, 31);
            this.ageTextBox.TabIndex = 6;
            this.ageTextBox.Text = "Enter Age";
            this.ageTextBox.Click += new System.EventHandler(this.ageTextBox_Click);
            this.ageTextBox.Leave += new System.EventHandler(this.ageTextBox_Leave);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(218, 280);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(112, 34);
            this.loadBtn.TabIndex = 7;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // colaBtn
            // 
            this.colaBtn.Location = new System.Drawing.Point(35, 366);
            this.colaBtn.Name = "colaBtn";
            this.colaBtn.Size = new System.Drawing.Size(112, 34);
            this.colaBtn.TabIndex = 8;
            this.colaBtn.Text = "Cola";
            this.colaBtn.UseVisualStyleBackColor = true;
            this.colaBtn.Click += new System.EventHandler(this.colaBtn_Click);
            // 
            // kinleyBtn
            // 
            this.kinleyBtn.Location = new System.Drawing.Point(218, 366);
            this.kinleyBtn.Name = "kinleyBtn";
            this.kinleyBtn.Size = new System.Drawing.Size(112, 34);
            this.kinleyBtn.TabIndex = 9;
            this.kinleyBtn.Text = "Kinley";
            this.kinleyBtn.UseVisualStyleBackColor = true;
            this.kinleyBtn.Click += new System.EventHandler(this.kinleyBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(404, 366);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(168, 34);
            this.printBtn.TabIndex = 10;
            this.printBtn.Text = "Print Drink List";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.kinleyBtn);
            this.Controls.Add(this.colaBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label dayLabel;
        private Label ageLabel;
        private Button saveBtn;
        private TextBox nameTextBox;
        private TextBox dayTextBox;
        private TextBox ageTextBox;
        private Button loadBtn;
        private Button colaBtn;
        private Button kinleyBtn;
        private Button printBtn;
    }
}