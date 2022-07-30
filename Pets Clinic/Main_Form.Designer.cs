namespace Pets_Clinic
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cab3 = new Circular_Animation_Button.CAB();
            this.cab2 = new Circular_Animation_Button.CAB();
            this.cab1 = new Circular_Animation_Button.CAB();
            this.medicines1 = new Pets_Clinic.Users_Control.Medicines();
            this.data_Of_Patient1 = new Pets_Clinic.Users_Control.Data_Of_Patient();
            this.staff1 = new Pets_Clinic.Users_Control.Staff();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lintsec", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pets Clinic";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 59);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(523, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Patient";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(614, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Staff";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(680, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Medicines";
            // 
            // cab3
            // 
            this.cab3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cab3.BackColor = System.Drawing.Color.DodgerBlue;
            this.cab3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cab3.BackgroundImage")));
            this.cab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cab3.FlatAppearance.BorderSize = 0;
            this.cab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cab3.ImageHover = ((System.Drawing.Image)(resources.GetObject("cab3.ImageHover")));
            this.cab3.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cab3.ImageNormal")));
            this.cab3.Location = new System.Drawing.Point(684, 65);
            this.cab3.Name = "cab3";
            this.cab3.Size = new System.Drawing.Size(76, 76);
            this.cab3.TabIndex = 4;
            this.cab3.UseVisualStyleBackColor = false;
            this.cab3.Click += new System.EventHandler(this.cab3_Click);
            // 
            // cab2
            // 
            this.cab2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cab2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.cab2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cab2.BackgroundImage")));
            this.cab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cab2.FlatAppearance.BorderSize = 0;
            this.cab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cab2.ImageHover = ((System.Drawing.Image)(resources.GetObject("cab2.ImageHover")));
            this.cab2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cab2.ImageNormal")));
            this.cab2.Location = new System.Drawing.Point(602, 65);
            this.cab2.Name = "cab2";
            this.cab2.Size = new System.Drawing.Size(76, 76);
            this.cab2.TabIndex = 3;
            this.cab2.UseVisualStyleBackColor = false;
            this.cab2.Click += new System.EventHandler(this.cab2_Click);
            // 
            // cab1
            // 
            this.cab1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cab1.BackColor = System.Drawing.Color.Crimson;
            this.cab1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cab1.BackgroundImage")));
            this.cab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cab1.FlatAppearance.BorderSize = 0;
            this.cab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cab1.ImageHover = ((System.Drawing.Image)(resources.GetObject("cab1.ImageHover")));
            this.cab1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cab1.ImageNormal")));
            this.cab1.Location = new System.Drawing.Point(520, 65);
            this.cab1.Name = "cab1";
            this.cab1.Size = new System.Drawing.Size(76, 76);
            this.cab1.TabIndex = 2;
            this.cab1.UseVisualStyleBackColor = false;
            this.cab1.Click += new System.EventHandler(this.cab1_Click);
            // 
            // medicines1
            // 
            this.medicines1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicines1.Location = new System.Drawing.Point(47, 167);
            this.medicines1.Name = "medicines1";
            this.medicines1.Size = new System.Drawing.Size(1167, 489);
            this.medicines1.TabIndex = 15;
            this.medicines1.Visible = false;
            // 
            // data_Of_Patient1
            // 
            this.data_Of_Patient1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Of_Patient1.Location = new System.Drawing.Point(47, 167);
            this.data_Of_Patient1.Name = "data_Of_Patient1";
            this.data_Of_Patient1.Size = new System.Drawing.Size(1167, 489);
            this.data_Of_Patient1.TabIndex = 13;
            this.data_Of_Patient1.Visible = false;
            this.data_Of_Patient1.Load += new System.EventHandler(this.data_Of_Patient1_Load);
            // 
            // staff1
            // 
            this.staff1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staff1.Location = new System.Drawing.Point(47, 167);
            this.staff1.Name = "staff1";
            this.staff1.Size = new System.Drawing.Size(1167, 489);
            this.staff1.TabIndex = 14;
            this.staff1.Visible = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1282, 668);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cab3);
            this.Controls.Add(this.cab2);
            this.Controls.Add(this.cab1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.medicines1);
            this.Controls.Add(this.data_Of_Patient1);
            this.Controls.Add(this.staff1);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Circular_Animation_Button.CAB cab1;
        private Circular_Animation_Button.CAB cab2;
        private Circular_Animation_Button.CAB cab3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Users_Control.Data_Of_Patient data_Of_Patient1;
        private Users_Control.Staff staff1;
        private Users_Control.Medicines medicines1;
    }
}