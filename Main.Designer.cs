namespace Komis
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSignOut_Exit = new System.Windows.Forms.Button();
            this.BtnChangeAcc = new System.Windows.Forms.Button();
            this.BtnAdd_Car = new System.Windows.Forms.Button();
            this.BtnCar_Online = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnSignOut_Exit);
            this.panel1.Controls.Add(this.BtnChangeAcc);
            this.panel1.Controls.Add(this.BtnAdd_Car);
            this.panel1.Controls.Add(this.BtnCar_Online);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 350);
            this.panel1.TabIndex = 0;
            // 
            // BtnSignOut_Exit
            // 
            this.BtnSignOut_Exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSignOut_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSignOut_Exit.Location = new System.Drawing.Point(3, 227);
            this.BtnSignOut_Exit.Name = "BtnSignOut_Exit";
            this.BtnSignOut_Exit.Size = new System.Drawing.Size(300, 52);
            this.BtnSignOut_Exit.TabIndex = 6;
            this.BtnSignOut_Exit.Text = "SIGN-OUT AND EXIT";
            this.BtnSignOut_Exit.UseVisualStyleBackColor = false;
            // 
            // BtnChangeAcc
            // 
            this.BtnChangeAcc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnChangeAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnChangeAcc.Location = new System.Drawing.Point(8, 169);
            this.BtnChangeAcc.Name = "BtnChangeAcc";
            this.BtnChangeAcc.Size = new System.Drawing.Size(300, 52);
            this.BtnChangeAcc.TabIndex = 5;
            this.BtnChangeAcc.Text = "CHANGE ACCOUNT";
            this.BtnChangeAcc.UseVisualStyleBackColor = false;
            // 
            // BtnAdd_Car
            // 
            this.BtnAdd_Car.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdd_Car.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdd_Car.Location = new System.Drawing.Point(8, 111);
            this.BtnAdd_Car.Name = "BtnAdd_Car";
            this.BtnAdd_Car.Size = new System.Drawing.Size(300, 52);
            this.BtnAdd_Car.TabIndex = 2;
            this.BtnAdd_Car.Text = "ADD A CAR FOR SALE";
            this.BtnAdd_Car.UseVisualStyleBackColor = false;
            // 
            // BtnCar_Online
            // 
            this.BtnCar_Online.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCar_Online.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnCar_Online.Location = new System.Drawing.Point(8, 53);
            this.BtnCar_Online.Name = "BtnCar_Online";
            this.BtnCar_Online.Size = new System.Drawing.Size(300, 52);
            this.BtnCar_Online.TabIndex = 1;
            this.BtnCar_Online.Text = "CARS FOR SALE/EDIT CAR ";
            this.BtnCar_Online.UseVisualStyleBackColor = false;
            this.BtnCar_Online.Click += new System.EventHandler(this.BtnCar_Online_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "FASTCARS - HOME MENU";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(340, 375);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSignOut_Exit;
        private System.Windows.Forms.Button BtnChangeAcc;
        private System.Windows.Forms.Button BtnAdd_Car;
        private System.Windows.Forms.Button BtnCar_Online;
    }
}