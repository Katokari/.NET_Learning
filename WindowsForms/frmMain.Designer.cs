namespace WindowsForms
{
    partial class frmMain
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
            this.btnShowForm1 = new System.Windows.Forms.Button();
            this.btnForm1Dialog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBoxes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowForm1
            // 
            this.btnShowForm1.Location = new System.Drawing.Point(225, 175);
            this.btnShowForm1.Name = "btnShowForm1";
            this.btnShowForm1.Size = new System.Drawing.Size(117, 45);
            this.btnShowForm1.TabIndex = 0;
            this.btnShowForm1.Text = "To Form1";
            this.btnShowForm1.UseVisualStyleBackColor = true;
            this.btnShowForm1.Click += new System.EventHandler(this.btnShowForm1_Click);
            // 
            // btnForm1Dialog
            // 
            this.btnForm1Dialog.Location = new System.Drawing.Point(362, 175);
            this.btnForm1Dialog.Name = "btnForm1Dialog";
            this.btnForm1Dialog.Size = new System.Drawing.Size(117, 45);
            this.btnForm1Dialog.TabIndex = 1;
            this.btnForm1Dialog.Text = "To Form1 as Dialog";
            this.btnForm1Dialog.UseVisualStyleBackColor = true;
            this.btnForm1Dialog.Click += new System.EventHandler(this.btnForm1Dialog_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(699, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBoxes
            // 
            this.btnBoxes.Location = new System.Drawing.Point(497, 175);
            this.btnBoxes.Name = "btnBoxes";
            this.btnBoxes.Size = new System.Drawing.Size(117, 45);
            this.btnBoxes.TabIndex = 3;
            this.btnBoxes.Text = "To Boxes Form";
            this.btnBoxes.UseVisualStyleBackColor = true;
            this.btnBoxes.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBoxes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnForm1Dialog);
            this.Controls.Add(this.btnShowForm1);
            this.Name = "frmMain";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowForm1;
        private System.Windows.Forms.Button btnForm1Dialog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBoxes;
    }
}