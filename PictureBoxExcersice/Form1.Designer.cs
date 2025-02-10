namespace PictureBoxExcersice
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rpBoy = new System.Windows.Forms.RadioButton();
            this.rpGirl = new System.Windows.Forms.RadioButton();
            this.rpBook = new System.Windows.Forms.RadioButton();
            this.rpPen = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PictureBoxExcersice.Properties.Resources.Boy;
            this.pictureBox1.InitialImage = global::PictureBoxExcersice.Properties.Resources.Boy;
            this.pictureBox1.Location = new System.Drawing.Point(256, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // rpBoy
            // 
            this.rpBoy.AutoSize = true;
            this.rpBoy.Checked = true;
            this.rpBoy.Location = new System.Drawing.Point(256, 316);
            this.rpBoy.Name = "rpBoy";
            this.rpBoy.Size = new System.Drawing.Size(43, 17);
            this.rpBoy.TabIndex = 2;
            this.rpBoy.TabStop = true;
            this.rpBoy.Text = "Boy";
            this.rpBoy.UseVisualStyleBackColor = true;
            this.rpBoy.CheckedChanged += new System.EventHandler(this.rpBoy_CheckedChanged);
            // 
            // rpGirl
            // 
            this.rpGirl.AutoSize = true;
            this.rpGirl.Location = new System.Drawing.Point(331, 316);
            this.rpGirl.Name = "rpGirl";
            this.rpGirl.Size = new System.Drawing.Size(40, 17);
            this.rpGirl.TabIndex = 3;
            this.rpGirl.Text = "Girl";
            this.rpGirl.UseVisualStyleBackColor = true;
            this.rpGirl.CheckedChanged += new System.EventHandler(this.rpGirl_CheckedChanged);
            // 
            // rpBook
            // 
            this.rpBook.AutoSize = true;
            this.rpBook.Location = new System.Drawing.Point(403, 316);
            this.rpBook.Name = "rpBook";
            this.rpBook.Size = new System.Drawing.Size(48, 17);
            this.rpBook.TabIndex = 4;
            this.rpBook.Text = "Book";
            this.rpBook.UseVisualStyleBackColor = true;
            this.rpBook.CheckedChanged += new System.EventHandler(this.rpBook_CheckedChanged);
            // 
            // rpPen
            // 
            this.rpPen.AutoSize = true;
            this.rpPen.Location = new System.Drawing.Point(483, 316);
            this.rpPen.Name = "rpPen";
            this.rpPen.Size = new System.Drawing.Size(43, 17);
            this.rpPen.TabIndex = 5;
            this.rpPen.Text = "Pen";
            this.rpPen.UseVisualStyleBackColor = true;
            this.rpPen.CheckedChanged += new System.EventHandler(this.rpPen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpPen);
            this.Controls.Add(this.rpBook);
            this.Controls.Add(this.rpGirl);
            this.Controls.Add(this.rpBoy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rpBoy;
        private System.Windows.Forms.RadioButton rpGirl;
        private System.Windows.Forms.RadioButton rpBook;
        private System.Windows.Forms.RadioButton rpPen;
    }
}

