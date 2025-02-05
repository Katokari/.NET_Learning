namespace PizzaProject
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rpBig = new System.Windows.Forms.RadioButton();
            this.rpSmall = new System.Windows.Forms.RadioButton();
            this.rpMid = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkOlive = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rpThin = new System.Windows.Forms.RadioButton();
            this.rpThick = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rpTakeOut = new System.Windows.Forms.RadioButton();
            this.rpEatIn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labCrust = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rpBig);
            this.gbSize.Controls.Add(this.rpSmall);
            this.gbSize.Controls.Add(this.rpMid);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Location = new System.Drawing.Point(54, 70);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(128, 130);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rpBig
            // 
            this.rpBig.AutoSize = true;
            this.rpBig.Location = new System.Drawing.Point(26, 99);
            this.rpBig.Name = "rpBig";
            this.rpBig.Size = new System.Drawing.Size(39, 17);
            this.rpBig.TabIndex = 2;
            this.rpBig.Tag = "40";
            this.rpBig.Text = "Big";
            this.rpBig.UseVisualStyleBackColor = true;
            this.rpBig.CheckedChanged += new System.EventHandler(this.rpBig_CheckedChanged);
            // 
            // rpSmall
            // 
            this.rpSmall.AutoSize = true;
            this.rpSmall.Checked = true;
            this.rpSmall.Location = new System.Drawing.Point(26, 29);
            this.rpSmall.Name = "rpSmall";
            this.rpSmall.Size = new System.Drawing.Size(49, 17);
            this.rpSmall.TabIndex = 0;
            this.rpSmall.TabStop = true;
            this.rpSmall.Tag = "20";
            this.rpSmall.Text = "Small";
            this.rpSmall.UseVisualStyleBackColor = true;
            this.rpSmall.CheckedChanged += new System.EventHandler(this.rpSmall_CheckedChanged);
            // 
            // rpMid
            // 
            this.rpMid.AutoSize = true;
            this.rpMid.Location = new System.Drawing.Point(26, 64);
            this.rpMid.Name = "rpMid";
            this.rpMid.Size = new System.Drawing.Size(61, 17);
            this.rpMid.TabIndex = 1;
            this.rpMid.Tag = "30";
            this.rpMid.Text = "Medium";
            this.rpMid.UseVisualStyleBackColor = true;
            this.rpMid.CheckedChanged += new System.EventHandler(this.rpMid_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPepper);
            this.gbToppings.Controls.Add(this.chkOlive);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomato);
            this.gbToppings.Controls.Add(this.chkMushroom);
            this.gbToppings.Controls.Add(this.chkCheese);
            this.gbToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbToppings.Location = new System.Drawing.Point(262, 70);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(205, 130);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Tag = "";
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Location = new System.Drawing.Point(107, 98);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(92, 17);
            this.chkGreenPepper.TabIndex = 5;
            this.chkGreenPepper.Tag = "5";
            this.chkGreenPepper.Text = "Green Pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            this.chkGreenPepper.CheckedChanged += new System.EventHandler(this.chkGreenPepper_CheckedChanged);
            // 
            // chkOlive
            // 
            this.chkOlive.AutoSize = true;
            this.chkOlive.Location = new System.Drawing.Point(107, 64);
            this.chkOlive.Name = "chkOlive";
            this.chkOlive.Size = new System.Drawing.Size(55, 17);
            this.chkOlive.TabIndex = 4;
            this.chkOlive.Tag = "5";
            this.chkOlive.Text = "Olives";
            this.chkOlive.UseVisualStyleBackColor = true;
            this.chkOlive.CheckedChanged += new System.EventHandler(this.chkOlive_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(107, 30);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.Location = new System.Drawing.Point(6, 98);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(67, 17);
            this.chkTomato.TabIndex = 2;
            this.chkTomato.Tag = "5";
            this.chkTomato.Text = "Tomatos";
            this.chkTomato.UseVisualStyleBackColor = true;
            this.chkTomato.CheckedChanged += new System.EventHandler(this.chkTomato_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(6, 64);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(80, 17);
            this.chkMushroom.TabIndex = 1;
            this.chkMushroom.Tag = "5";
            this.chkMushroom.Text = "Mushrooms";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(6, 30);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(91, 17);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Tag = "5";
            this.chkCheese.Text = "Extra Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rpThin);
            this.gbCrust.Controls.Add(this.rpThick);
            this.gbCrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCrust.Location = new System.Drawing.Point(54, 236);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(128, 93);
            this.gbCrust.TabIndex = 3;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rpThin
            // 
            this.rpThin.AutoSize = true;
            this.rpThin.Checked = true;
            this.rpThin.Location = new System.Drawing.Point(26, 29);
            this.rpThin.Name = "rpThin";
            this.rpThin.Size = new System.Drawing.Size(74, 17);
            this.rpThin.TabIndex = 0;
            this.rpThin.TabStop = true;
            this.rpThin.Tag = "5";
            this.rpThin.Text = "Thin Crust";
            this.rpThin.UseVisualStyleBackColor = true;
            this.rpThin.CheckedChanged += new System.EventHandler(this.rpThin_CheckedChanged);
            // 
            // rpThick
            // 
            this.rpThick.AutoSize = true;
            this.rpThick.Location = new System.Drawing.Point(26, 63);
            this.rpThick.Name = "rpThick";
            this.rpThick.Size = new System.Drawing.Size(78, 17);
            this.rpThick.TabIndex = 1;
            this.rpThick.Tag = "10";
            this.rpThick.Text = "Thick Crust";
            this.rpThick.UseVisualStyleBackColor = true;
            this.rpThick.CheckedChanged += new System.EventHandler(this.rpThick_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rpTakeOut);
            this.gbWhereToEat.Controls.Add(this.rpEatIn);
            this.gbWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWhereToEat.Location = new System.Drawing.Point(262, 236);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(205, 68);
            this.gbWhereToEat.TabIndex = 6;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where to Eat";
            // 
            // rpTakeOut
            // 
            this.rpTakeOut.AutoSize = true;
            this.rpTakeOut.Location = new System.Drawing.Point(108, 29);
            this.rpTakeOut.Name = "rpTakeOut";
            this.rpTakeOut.Size = new System.Drawing.Size(69, 17);
            this.rpTakeOut.TabIndex = 1;
            this.rpTakeOut.Text = "Take Out";
            this.rpTakeOut.UseVisualStyleBackColor = true;
            this.rpTakeOut.CheckedChanged += new System.EventHandler(this.rpTakeOut_CheckedChanged);
            // 
            // rpEatIn
            // 
            this.rpEatIn.AutoSize = true;
            this.rpEatIn.Checked = true;
            this.rpEatIn.Location = new System.Drawing.Point(6, 29);
            this.rpEatIn.Name = "rpEatIn";
            this.rpEatIn.Size = new System.Drawing.Size(54, 17);
            this.rpEatIn.TabIndex = 0;
            this.rpEatIn.TabStop = true;
            this.rpEatIn.Text = "Eat In";
            this.rpEatIn.UseVisualStyleBackColor = true;
            this.rpEatIn.CheckedChanged += new System.EventHandler(this.rpEatIn_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Order Pizza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.labPrice);
            this.gbSummary.Controls.Add(this.label9);
            this.gbSummary.Controls.Add(this.labWhereToEat);
            this.gbSummary.Controls.Add(this.label8);
            this.gbSummary.Controls.Add(this.labCrust);
            this.gbSummary.Controls.Add(this.label6);
            this.gbSummary.Controls.Add(this.labToppings);
            this.gbSummary.Controls.Add(this.label4);
            this.gbSummary.Controls.Add(this.labSize);
            this.gbSummary.Controls.Add(this.label1);
            this.gbSummary.Location = new System.Drawing.Point(547, 70);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(216, 295);
            this.gbSummary.TabIndex = 9;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Order Summary";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrice.ForeColor = System.Drawing.Color.Crimson;
            this.labPrice.Location = new System.Drawing.Point(104, 243);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(0, 23);
            this.labPrice.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Price:";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.Location = new System.Drawing.Point(104, 195);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(0, 16);
            this.labWhereToEat.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Where to Eat:";
            // 
            // labCrust
            // 
            this.labCrust.AutoSize = true;
            this.labCrust.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrust.Location = new System.Drawing.Point(104, 125);
            this.labCrust.Name = "labCrust";
            this.labCrust.Size = new System.Drawing.Size(0, 16);
            this.labCrust.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Crust Type:";
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppings.Location = new System.Drawing.Point(70, 88);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(0, 16);
            this.labToppings.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Toppings: ";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.Location = new System.Drawing.Point(60, 29);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(0, 16);
            this.labSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Make Your Pizza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rpBig;
        private System.Windows.Forms.RadioButton rpMid;
        private System.Windows.Forms.RadioButton rpSmall;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkOlive;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rpThin;
        private System.Windows.Forms.RadioButton rpThick;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rpTakeOut;
        private System.Windows.Forms.RadioButton rpEatIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCrust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}

