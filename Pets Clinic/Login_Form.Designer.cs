namespace Pets_Clinic
{
    partial class Login_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Power = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.IDtxt = new ZBobb.AlphaBlendTextBox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 550;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Power
            // 
            this.Power.BackColor = System.Drawing.Color.Transparent;
            this.Power.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Power.BackgroundImage")));
            this.Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Power.FlatAppearance.BorderSize = 0;
            this.Power.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Power.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Power.Location = new System.Drawing.Point(236, 12);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(22, 23);
            this.Power.TabIndex = 6;
            this.Power.UseVisualStyleBackColor = false;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.Transparent;
            this.hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide.BackgroundImage")));
            this.hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide.FlatAppearance.BorderSize = 0;
            this.hide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Location = new System.Drawing.Point(405, 352);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(21, 38);
            this.hide.TabIndex = 12;
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.IDlabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.ForeColor = System.Drawing.Color.Red;
            this.IDlabel.Location = new System.Drawing.Point(85, 393);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(142, 18);
            this.IDlabel.TabIndex = 11;
            this.IDlabel.Text = "The ID is incorrect.";
            this.IDlabel.Visible = false;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(196, 414);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(98, 45);
            this.Login.TabIndex = 10;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // IDtxt
            // 
            this.IDtxt.BackAlpha = 10;
            this.IDtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IDtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDtxt.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtxt.ForeColor = System.Drawing.Color.Beige;
            this.IDtxt.Location = new System.Drawing.Point(89, 352);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(310, 38);
            this.IDtxt.TabIndex = 9;
            this.IDtxt.Text = "ID";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 492);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.Power);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Button Login;
        private ZBobb.AlphaBlendTextBox IDtxt;
        private System.Windows.Forms.Button Power;
    }
}

