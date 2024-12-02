namespace WindowsFormsApp1
{
    partial class MainMenu
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
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.rdMeduim = new System.Windows.Forms.RadioButton();
            this.rdLarg = new System.Windows.Forms.RadioButton();
            this.checkBoxExtraChees = new System.Windows.Forms.CheckBox();
            this.checkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.checkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.checkBoxOnion = new System.Windows.Forms.CheckBox();
            this.checkBoxOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxGreenPappers = new System.Windows.Forms.CheckBox();
            this.RadThinCrust = new System.Windows.Forms.RadioButton();
            this.RadThinkCrust = new System.Windows.Forms.RadioButton();
            this.RadEatIn = new System.Windows.Forms.RadioButton();
            this.RadTakeOut = new System.Windows.Forms.RadioButton();
            this.ButtonOrederPizza = new System.Windows.Forms.Button();
            this.buttonResetForm = new System.Windows.Forms.Button();
            this.panelSize = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelToppings = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCrustType = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelWhereToEat = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabToppingsSummay = new System.Windows.Forms.Label();
            this.LabWhereToEatSummary = new System.Windows.Forms.Label();
            this.LabCrustSummary = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabSizeSummary = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelSize.SuspendLayout();
            this.panelToppings.SuspendLayout();
            this.panelCrustType.SuspendLayout();
            this.panelWhereToEat.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Checked = true;
            this.rdSmall.Location = new System.Drawing.Point(24, 24);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(62, 20);
            this.rdSmall.TabIndex = 2;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "20";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // rdMeduim
            // 
            this.rdMeduim.AutoSize = true;
            this.rdMeduim.Location = new System.Drawing.Point(24, 61);
            this.rdMeduim.Name = "rdMeduim";
            this.rdMeduim.Size = new System.Drawing.Size(76, 20);
            this.rdMeduim.TabIndex = 3;
            this.rdMeduim.Tag = "30";
            this.rdMeduim.Text = "Meduim";
            this.rdMeduim.UseVisualStyleBackColor = true;
            this.rdMeduim.CheckedChanged += new System.EventHandler(this.rdMeduim_CheckedChanged);
            // 
            // rdLarg
            // 
            this.rdLarg.AutoSize = true;
            this.rdLarg.Location = new System.Drawing.Point(24, 100);
            this.rdLarg.Name = "rdLarg";
            this.rdLarg.Size = new System.Drawing.Size(55, 20);
            this.rdLarg.TabIndex = 4;
            this.rdLarg.Tag = "40";
            this.rdLarg.Text = "Larg";
            this.rdLarg.UseVisualStyleBackColor = true;
            this.rdLarg.CheckedChanged += new System.EventHandler(this.rdLarg_CheckedChanged);
            // 
            // checkBoxExtraChees
            // 
            this.checkBoxExtraChees.AutoSize = true;
            this.checkBoxExtraChees.Location = new System.Drawing.Point(18, 20);
            this.checkBoxExtraChees.Name = "checkBoxExtraChees";
            this.checkBoxExtraChees.Size = new System.Drawing.Size(101, 20);
            this.checkBoxExtraChees.TabIndex = 6;
            this.checkBoxExtraChees.Tag = "5";
            this.checkBoxExtraChees.Text = "Extra Chees";
            this.checkBoxExtraChees.UseVisualStyleBackColor = true;
            this.checkBoxExtraChees.CheckedChanged += new System.EventHandler(this.checkBoxExtraChees_CheckedChanged);
            // 
            // checkBoxMushrooms
            // 
            this.checkBoxMushrooms.AutoSize = true;
            this.checkBoxMushrooms.Location = new System.Drawing.Point(18, 57);
            this.checkBoxMushrooms.Name = "checkBoxMushrooms";
            this.checkBoxMushrooms.Size = new System.Drawing.Size(99, 20);
            this.checkBoxMushrooms.TabIndex = 7;
            this.checkBoxMushrooms.Tag = "5";
            this.checkBoxMushrooms.Text = "Mushrooms";
            this.checkBoxMushrooms.UseVisualStyleBackColor = true;
            this.checkBoxMushrooms.CheckedChanged += new System.EventHandler(this.checkBoxMushrooms_CheckedChanged);
            // 
            // checkBoxTomatoes
            // 
            this.checkBoxTomatoes.AutoSize = true;
            this.checkBoxTomatoes.Location = new System.Drawing.Point(18, 96);
            this.checkBoxTomatoes.Name = "checkBoxTomatoes";
            this.checkBoxTomatoes.Size = new System.Drawing.Size(91, 20);
            this.checkBoxTomatoes.TabIndex = 8;
            this.checkBoxTomatoes.Tag = "5";
            this.checkBoxTomatoes.Text = "Tomatoes";
            this.checkBoxTomatoes.UseVisualStyleBackColor = true;
            this.checkBoxTomatoes.CheckedChanged += new System.EventHandler(this.checkBoxTomatoes_CheckedChanged);
            // 
            // checkBoxOnion
            // 
            this.checkBoxOnion.AutoSize = true;
            this.checkBoxOnion.Location = new System.Drawing.Point(143, 20);
            this.checkBoxOnion.Name = "checkBoxOnion";
            this.checkBoxOnion.Size = new System.Drawing.Size(64, 20);
            this.checkBoxOnion.TabIndex = 9;
            this.checkBoxOnion.Tag = "5";
            this.checkBoxOnion.Text = "Onion";
            this.checkBoxOnion.UseVisualStyleBackColor = true;
            this.checkBoxOnion.CheckedChanged += new System.EventHandler(this.checkBoxOnion_CheckedChanged);
            // 
            // checkBoxOlives
            // 
            this.checkBoxOlives.AutoSize = true;
            this.checkBoxOlives.Location = new System.Drawing.Point(143, 61);
            this.checkBoxOlives.Name = "checkBoxOlives";
            this.checkBoxOlives.Size = new System.Drawing.Size(67, 20);
            this.checkBoxOlives.TabIndex = 10;
            this.checkBoxOlives.Tag = "5";
            this.checkBoxOlives.Text = "Olives";
            this.checkBoxOlives.UseVisualStyleBackColor = true;
            this.checkBoxOlives.CheckedChanged += new System.EventHandler(this.checkBoxOlives_CheckedChanged);
            // 
            // checkBoxGreenPappers
            // 
            this.checkBoxGreenPappers.AutoSize = true;
            this.checkBoxGreenPappers.Location = new System.Drawing.Point(143, 96);
            this.checkBoxGreenPappers.Name = "checkBoxGreenPappers";
            this.checkBoxGreenPappers.Size = new System.Drawing.Size(121, 20);
            this.checkBoxGreenPappers.TabIndex = 11;
            this.checkBoxGreenPappers.Tag = "5";
            this.checkBoxGreenPappers.Text = "Green Pappers";
            this.checkBoxGreenPappers.UseVisualStyleBackColor = true;
            this.checkBoxGreenPappers.CheckedChanged += new System.EventHandler(this.checkBoxGreenPappers_CheckedChanged);
            // 
            // RadThinCrust
            // 
            this.RadThinCrust.AutoSize = true;
            this.RadThinCrust.Checked = true;
            this.RadThinCrust.Location = new System.Drawing.Point(24, 30);
            this.RadThinCrust.Name = "RadThinCrust";
            this.RadThinCrust.Size = new System.Drawing.Size(87, 20);
            this.RadThinCrust.TabIndex = 13;
            this.RadThinCrust.TabStop = true;
            this.RadThinCrust.Tag = "0";
            this.RadThinCrust.Text = "Thin Crust";
            this.RadThinCrust.UseVisualStyleBackColor = true;
            this.RadThinCrust.CheckedChanged += new System.EventHandler(this.RadThinCrust_CheckedChanged);
            // 
            // RadThinkCrust
            // 
            this.RadThinkCrust.AutoSize = true;
            this.RadThinkCrust.Location = new System.Drawing.Point(24, 75);
            this.RadThinkCrust.Name = "RadThinkCrust";
            this.RadThinkCrust.Size = new System.Drawing.Size(94, 20);
            this.RadThinkCrust.TabIndex = 14;
            this.RadThinkCrust.Tag = "10";
            this.RadThinkCrust.Text = "Think Crust";
            this.RadThinkCrust.UseVisualStyleBackColor = true;
            this.RadThinkCrust.CheckedChanged += new System.EventHandler(this.RadThinkCrust_CheckedChanged);
            // 
            // RadEatIn
            // 
            this.RadEatIn.AutoSize = true;
            this.RadEatIn.Checked = true;
            this.RadEatIn.Location = new System.Drawing.Point(16, 30);
            this.RadEatIn.Name = "RadEatIn";
            this.RadEatIn.Size = new System.Drawing.Size(61, 20);
            this.RadEatIn.TabIndex = 17;
            this.RadEatIn.TabStop = true;
            this.RadEatIn.Text = "Eat In";
            this.RadEatIn.UseVisualStyleBackColor = true;
            this.RadEatIn.CheckedChanged += new System.EventHandler(this.RadEatIn_CheckedChanged);
            // 
            // RadTakeOut
            // 
            this.RadTakeOut.AutoSize = true;
            this.RadTakeOut.Location = new System.Drawing.Point(101, 30);
            this.RadTakeOut.Name = "RadTakeOut";
            this.RadTakeOut.Size = new System.Drawing.Size(83, 20);
            this.RadTakeOut.TabIndex = 16;
            this.RadTakeOut.Text = "Take Out";
            this.RadTakeOut.UseVisualStyleBackColor = true;
            this.RadTakeOut.CheckedChanged += new System.EventHandler(this.RadTakeOut_CheckedChanged);
            // 
            // ButtonOrederPizza
            // 
            this.ButtonOrederPizza.Location = new System.Drawing.Point(307, 420);
            this.ButtonOrederPizza.Name = "ButtonOrederPizza";
            this.ButtonOrederPizza.Size = new System.Drawing.Size(96, 29);
            this.ButtonOrederPizza.TabIndex = 18;
            this.ButtonOrederPizza.Text = "Order Pizza";
            this.ButtonOrederPizza.UseVisualStyleBackColor = true;
            this.ButtonOrederPizza.Click += new System.EventHandler(this.buttonOrederPizza_Click);
            // 
            // buttonResetForm
            // 
            this.buttonResetForm.Location = new System.Drawing.Point(437, 420);
            this.buttonResetForm.Name = "buttonResetForm";
            this.buttonResetForm.Size = new System.Drawing.Size(96, 29);
            this.buttonResetForm.TabIndex = 19;
            this.buttonResetForm.Text = "Reset Form";
            this.buttonResetForm.UseVisualStyleBackColor = true;
            this.buttonResetForm.Click += new System.EventHandler(this.buttonResetForm_Click);
            // 
            // panelSize
            // 
            this.panelSize.BackColor = System.Drawing.Color.Transparent;
            this.panelSize.Controls.Add(this.rdLarg);
            this.panelSize.Controls.Add(this.rdSmall);
            this.panelSize.Controls.Add(this.rdMeduim);
            this.panelSize.Location = new System.Drawing.Point(47, 141);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(111, 124);
            this.panelSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Size";
            // 
            // panelToppings
            // 
            this.panelToppings.Controls.Add(this.checkBoxOnion);
            this.panelToppings.Controls.Add(this.checkBoxGreenPappers);
            this.panelToppings.Controls.Add(this.checkBoxTomatoes);
            this.panelToppings.Controls.Add(this.checkBoxExtraChees);
            this.panelToppings.Controls.Add(this.checkBoxOlives);
            this.panelToppings.Controls.Add(this.checkBoxMushrooms);
            this.panelToppings.Location = new System.Drawing.Point(207, 146);
            this.panelToppings.Name = "panelToppings";
            this.panelToppings.Size = new System.Drawing.Size(274, 119);
            this.panelToppings.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Toppings";
            // 
            // panelCrustType
            // 
            this.panelCrustType.Controls.Add(this.RadThinCrust);
            this.panelCrustType.Controls.Add(this.RadThinkCrust);
            this.panelCrustType.Location = new System.Drawing.Point(47, 327);
            this.panelCrustType.Name = "panelCrustType";
            this.panelCrustType.Size = new System.Drawing.Size(149, 122);
            this.panelCrustType.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Crust Type";
            // 
            // panelWhereToEat
            // 
            this.panelWhereToEat.Controls.Add(this.RadTakeOut);
            this.panelWhereToEat.Controls.Add(this.RadEatIn);
            this.panelWhereToEat.Location = new System.Drawing.Point(249, 327);
            this.panelWhereToEat.Name = "panelWhereToEat";
            this.panelWhereToEat.Size = new System.Drawing.Size(213, 64);
            this.panelWhereToEat.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Where To Eat";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labTotalPrice);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.LabToppingsSummay);
            this.panel5.Controls.Add(this.LabWhereToEatSummary);
            this.panel5.Controls.Add(this.LabCrustSummary);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.LabSizeSummary);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(558, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 302);
            this.panel5.TabIndex = 20;
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.Font = new System.Drawing.Font("Unispace", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.labTotalPrice.Location = new System.Drawing.Point(113, 240);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(104, 47);
            this.labTotalPrice.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Toppings:";
            // 
            // LabToppingsSummay
            // 
            this.LabToppingsSummay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabToppingsSummay.Location = new System.Drawing.Point(35, 86);
            this.LabToppingsSummay.Name = "LabToppingsSummay";
            this.LabToppingsSummay.Size = new System.Drawing.Size(210, 50);
            this.LabToppingsSummay.TabIndex = 22;
            // 
            // LabWhereToEatSummary
            // 
            this.LabWhereToEatSummary.AutoSize = true;
            this.LabWhereToEatSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWhereToEatSummary.Location = new System.Drawing.Point(152, 181);
            this.LabWhereToEatSummary.Name = "LabWhereToEatSummary";
            this.LabWhereToEatSummary.Size = new System.Drawing.Size(0, 20);
            this.LabWhereToEatSummary.TabIndex = 23;
            // 
            // LabCrustSummary
            // 
            this.LabCrustSummary.AutoSize = true;
            this.LabCrustSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCrustSummary.Location = new System.Drawing.Point(117, 158);
            this.LabCrustSummary.Name = "LabCrustSummary";
            this.LabCrustSummary.Size = new System.Drawing.Size(0, 20);
            this.LabCrustSummary.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Where To Eat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Crust Type:";
            // 
            // LabSizeSummary
            // 
            this.LabSizeSummary.AutoSize = true;
            this.LabSizeSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSizeSummary.Location = new System.Drawing.Point(77, 21);
            this.LabSizeSummary.Name = "LabSizeSummary";
            this.LabSizeSummary.Size = new System.Drawing.Size(0, 25);
            this.LabSizeSummary.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Order Summary";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(936, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelWhereToEat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelCrustType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelToppings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonResetForm);
            this.Controls.Add(this.panelSize);
            this.Controls.Add(this.ButtonOrederPizza);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelSize.ResumeLayout(false);
            this.panelSize.PerformLayout();
            this.panelToppings.ResumeLayout(false);
            this.panelToppings.PerformLayout();
            this.panelCrustType.ResumeLayout(false);
            this.panelCrustType.PerformLayout();
            this.panelWhereToEat.ResumeLayout(false);
            this.panelWhereToEat.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdLarg;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.RadioButton rdMeduim;
        private System.Windows.Forms.CheckBox checkBoxGreenPappers;
        private System.Windows.Forms.CheckBox checkBoxOlives;
        private System.Windows.Forms.CheckBox checkBoxOnion;
        private System.Windows.Forms.CheckBox checkBoxTomatoes;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.CheckBox checkBoxExtraChees;
        private System.Windows.Forms.RadioButton RadThinkCrust;
        private System.Windows.Forms.RadioButton RadThinCrust;
        private System.Windows.Forms.RadioButton RadTakeOut;
        private System.Windows.Forms.RadioButton RadEatIn;
        private System.Windows.Forms.Button ButtonOrederPizza;
        private System.Windows.Forms.Button buttonResetForm;
        private System.Windows.Forms.Panel panelSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelToppings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelCrustType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelWhereToEat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LabSizeSummary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabCrustSummary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabWhereToEatSummary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabToppingsSummay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label label11;
    }
}