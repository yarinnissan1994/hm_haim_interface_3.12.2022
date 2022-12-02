namespace ShapesForm
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
            this.RectangleCB = new System.Windows.Forms.CheckBox();
            this.CircleCB = new System.Windows.Forms.CheckBox();
            this.ElipseCB = new System.Windows.Forms.CheckBox();
            this.TringleCB = new System.Windows.Forms.CheckBox();
            this.MoonCB = new System.Windows.Forms.CheckBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ResaultBtn = new System.Windows.Forms.Button();
            this.ResaultLabel = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RectangleCB
            // 
            this.RectangleCB.AutoSize = true;
            this.RectangleCB.Location = new System.Drawing.Point(47, 55);
            this.RectangleCB.Name = "RectangleCB";
            this.RectangleCB.Size = new System.Drawing.Size(114, 29);
            this.RectangleCB.TabIndex = 2;
            this.RectangleCB.Text = "Rectangle";
            this.RectangleCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RectangleCB.UseVisualStyleBackColor = true;
            // 
            // CircleCB
            // 
            this.CircleCB.AutoSize = true;
            this.CircleCB.Location = new System.Drawing.Point(47, 112);
            this.CircleCB.Name = "CircleCB";
            this.CircleCB.Size = new System.Drawing.Size(81, 29);
            this.CircleCB.TabIndex = 3;
            this.CircleCB.Text = "CIrcle";
            this.CircleCB.UseVisualStyleBackColor = true;
            // 
            // ElipseCB
            // 
            this.ElipseCB.AutoSize = true;
            this.ElipseCB.Location = new System.Drawing.Point(47, 172);
            this.ElipseCB.Name = "ElipseCB";
            this.ElipseCB.Size = new System.Drawing.Size(83, 29);
            this.ElipseCB.TabIndex = 4;
            this.ElipseCB.Text = "Elipse";
            this.ElipseCB.UseVisualStyleBackColor = true;
            // 
            // TringleCB
            // 
            this.TringleCB.AutoSize = true;
            this.TringleCB.Location = new System.Drawing.Point(47, 233);
            this.TringleCB.Name = "TringleCB";
            this.TringleCB.Size = new System.Drawing.Size(89, 29);
            this.TringleCB.TabIndex = 5;
            this.TringleCB.Text = "Tringle";
            this.TringleCB.UseVisualStyleBackColor = true;
            // 
            // MoonCB
            // 
            this.MoonCB.AutoSize = true;
            this.MoonCB.Location = new System.Drawing.Point(47, 292);
            this.MoonCB.Name = "MoonCB";
            this.MoonCB.Size = new System.Drawing.Size(86, 29);
            this.MoonCB.TabIndex = 6;
            this.MoonCB.Text = "Moon";
            this.MoonCB.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(47, 352);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(198, 34);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add Shape";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ResaultBtn
            // 
            this.ResaultBtn.Location = new System.Drawing.Point(262, 352);
            this.ResaultBtn.Name = "ResaultBtn";
            this.ResaultBtn.Size = new System.Drawing.Size(191, 34);
            this.ResaultBtn.TabIndex = 8;
            this.ResaultBtn.Text = "Show Resault";
            this.ResaultBtn.UseVisualStyleBackColor = true;
            this.ResaultBtn.Click += new System.EventHandler(this.ResaultBtn_Click);
            // 
            // ResaultLabel
            // 
            this.ResaultLabel.AutoSize = true;
            this.ResaultLabel.Location = new System.Drawing.Point(494, 357);
            this.ResaultLabel.Name = "ResaultLabel";
            this.ResaultLabel.Size = new System.Drawing.Size(22, 25);
            this.ResaultLabel.TabIndex = 9;
            this.ResaultLabel.Text = "0";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(552, 352);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(216, 34);
            this.ResetBtn.TabIndex = 10;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ResaultLabel);
            this.Controls.Add(this.ResaultBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MoonCB);
            this.Controls.Add(this.TringleCB);
            this.Controls.Add(this.ElipseCB);
            this.Controls.Add(this.CircleCB);
            this.Controls.Add(this.RectangleCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox RectangleCB;
        private CheckBox CircleCB;
        private CheckBox ElipseCB;
        private CheckBox TringleCB;
        private CheckBox MoonCB;
        private Button AddBtn;
        private Button ResaultBtn;
        private Label ResaultLabel;
        private Button ResetBtn;
    }
}