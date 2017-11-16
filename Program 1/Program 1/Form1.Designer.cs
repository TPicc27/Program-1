namespace Program_1
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
            this.squareFeetentry = new System.Windows.Forms.TextBox();
            this.coatsEntry = new System.Windows.Forms.TextBox();
            this.gallonCostentry = new System.Windows.Forms.TextBox();
            this.entryLabel = new System.Windows.Forms.Label();
            this.squareFeetlabel = new System.Windows.Forms.Label();
            this.coatsLabel = new System.Windows.Forms.Label();
            this.gallonCostlabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.totalSquarefeetAnswer = new System.Windows.Forms.Label();
            this.totalGallonsanswer = new System.Windows.Forms.Label();
            this.totalHoursanswer = new System.Windows.Forms.Label();
            this.totalCostforPaintanswer = new System.Windows.Forms.Label();
            this.totalCostofLaboranswer = new System.Windows.Forms.Label();
            this.fullTotalanswer = new System.Windows.Forms.Label();
            this.output1 = new System.Windows.Forms.Label();
            this.output2 = new System.Windows.Forms.Label();
            this.output3 = new System.Windows.Forms.Label();
            this.output4 = new System.Windows.Forms.Label();
            this.output5 = new System.Windows.Forms.Label();
            this.output6 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // squareFeetentry
            // 
            this.squareFeetentry.Location = new System.Drawing.Point(149, 93);
            this.squareFeetentry.Name = "squareFeetentry";
            this.squareFeetentry.Size = new System.Drawing.Size(100, 20);
            this.squareFeetentry.TabIndex = 0;
            // 
            // coatsEntry
            // 
            this.coatsEntry.Location = new System.Drawing.Point(149, 145);
            this.coatsEntry.Name = "coatsEntry";
            this.coatsEntry.Size = new System.Drawing.Size(100, 20);
            this.coatsEntry.TabIndex = 1;
            // 
            // gallonCostentry
            // 
            this.gallonCostentry.Location = new System.Drawing.Point(149, 198);
            this.gallonCostentry.Name = "gallonCostentry";
            this.gallonCostentry.Size = new System.Drawing.Size(100, 20);
            this.gallonCostentry.TabIndex = 2;
            // 
            // entryLabel
            // 
            this.entryLabel.Location = new System.Drawing.Point(56, 37);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(193, 40);
            this.entryLabel.TabIndex = 3;
            this.entryLabel.Text = "Enter the number of square feet, number of coats, and cost per gallon:";
            this.entryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // squareFeetlabel
            // 
            this.squareFeetlabel.AutoSize = true;
            this.squareFeetlabel.Location = new System.Drawing.Point(28, 96);
            this.squareFeetlabel.Name = "squareFeetlabel";
            this.squareFeetlabel.Size = new System.Drawing.Size(115, 13);
            this.squareFeetlabel.TabIndex = 4;
            this.squareFeetlabel.Text = "Number of square feet:";
            // 
            // coatsLabel
            // 
            this.coatsLabel.AutoSize = true;
            this.coatsLabel.Location = new System.Drawing.Point(55, 148);
            this.coatsLabel.Name = "coatsLabel";
            this.coatsLabel.Size = new System.Drawing.Size(88, 13);
            this.coatsLabel.TabIndex = 5;
            this.coatsLabel.Text = "Number of coats:";
            // 
            // gallonCostlabel
            // 
            this.gallonCostlabel.AutoSize = true;
            this.gallonCostlabel.Location = new System.Drawing.Point(63, 201);
            this.gallonCostlabel.Name = "gallonCostlabel";
            this.gallonCostlabel.Size = new System.Drawing.Size(80, 13);
            this.gallonCostlabel.TabIndex = 6;
            this.gallonCostlabel.Text = "Cost per gallon:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(393, 51);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(77, 13);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = "Total numbers:";
            // 
            // totalSquarefeetAnswer
            // 
            this.totalSquarefeetAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSquarefeetAnswer.Location = new System.Drawing.Point(420, 77);
            this.totalSquarefeetAnswer.Name = "totalSquarefeetAnswer";
            this.totalSquarefeetAnswer.Size = new System.Drawing.Size(100, 21);
            this.totalSquarefeetAnswer.TabIndex = 8;
            this.totalSquarefeetAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalGallonsanswer
            // 
            this.totalGallonsanswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalGallonsanswer.Location = new System.Drawing.Point(420, 110);
            this.totalGallonsanswer.Name = "totalGallonsanswer";
            this.totalGallonsanswer.Size = new System.Drawing.Size(100, 23);
            this.totalGallonsanswer.TabIndex = 9;
            this.totalGallonsanswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalHoursanswer
            // 
            this.totalHoursanswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalHoursanswer.Location = new System.Drawing.Point(420, 148);
            this.totalHoursanswer.Name = "totalHoursanswer";
            this.totalHoursanswer.Size = new System.Drawing.Size(100, 23);
            this.totalHoursanswer.TabIndex = 10;
            this.totalHoursanswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostforPaintanswer
            // 
            this.totalCostforPaintanswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostforPaintanswer.Location = new System.Drawing.Point(420, 181);
            this.totalCostforPaintanswer.Name = "totalCostforPaintanswer";
            this.totalCostforPaintanswer.Size = new System.Drawing.Size(100, 23);
            this.totalCostforPaintanswer.TabIndex = 11;
            this.totalCostforPaintanswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostofLaboranswer
            // 
            this.totalCostofLaboranswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostofLaboranswer.Location = new System.Drawing.Point(420, 212);
            this.totalCostofLaboranswer.Name = "totalCostofLaboranswer";
            this.totalCostofLaboranswer.Size = new System.Drawing.Size(100, 23);
            this.totalCostofLaboranswer.TabIndex = 12;
            this.totalCostofLaboranswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullTotalanswer
            // 
            this.fullTotalanswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullTotalanswer.Location = new System.Drawing.Point(420, 255);
            this.fullTotalanswer.Name = "fullTotalanswer";
            this.fullTotalanswer.Size = new System.Drawing.Size(100, 23);
            this.fullTotalanswer.TabIndex = 13;
            this.fullTotalanswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output1
            // 
            this.output1.AutoSize = true;
            this.output1.Location = new System.Drawing.Point(324, 81);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(90, 13);
            this.output1.TabIndex = 14;
            this.output1.Text = "Total square feet:";
            // 
            // output2
            // 
            this.output2.AutoSize = true;
            this.output2.Location = new System.Drawing.Point(344, 115);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(70, 13);
            this.output2.TabIndex = 15;
            this.output2.Text = "Total gallons:";
            // 
            // output3
            // 
            this.output3.AutoSize = true;
            this.output3.Location = new System.Drawing.Point(351, 153);
            this.output3.Name = "output3";
            this.output3.Size = new System.Drawing.Size(63, 13);
            this.output3.TabIndex = 16;
            this.output3.Text = "Total hours:";
            // 
            // output4
            // 
            this.output4.AutoSize = true;
            this.output4.Location = new System.Drawing.Point(319, 186);
            this.output4.Name = "output4";
            this.output4.Size = new System.Drawing.Size(95, 13);
            this.output4.TabIndex = 17;
            this.output4.Text = "Total cost of paint:";
            // 
            // output5
            // 
            this.output5.AutoSize = true;
            this.output5.Location = new System.Drawing.Point(319, 217);
            this.output5.Name = "output5";
            this.output5.Size = new System.Drawing.Size(95, 13);
            this.output5.TabIndex = 18;
            this.output5.Text = "Total cost of labor:";
            // 
            // output6
            // 
            this.output6.AutoSize = true;
            this.output6.Location = new System.Drawing.Point(365, 260);
            this.output6.Name = "output6";
            this.output6.Size = new System.Drawing.Size(49, 13);
            this.output6.TabIndex = 19;
            this.output6.Text = "Full total:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 255);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 20;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(118, 255);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(224, 255);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 23);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 319);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.output6);
            this.Controls.Add(this.output5);
            this.Controls.Add(this.output4);
            this.Controls.Add(this.output3);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.fullTotalanswer);
            this.Controls.Add(this.totalCostofLaboranswer);
            this.Controls.Add(this.totalCostforPaintanswer);
            this.Controls.Add(this.totalHoursanswer);
            this.Controls.Add(this.totalGallonsanswer);
            this.Controls.Add(this.totalSquarefeetAnswer);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.gallonCostlabel);
            this.Controls.Add(this.coatsLabel);
            this.Controls.Add(this.squareFeetlabel);
            this.Controls.Add(this.entryLabel);
            this.Controls.Add(this.gallonCostentry);
            this.Controls.Add(this.coatsEntry);
            this.Controls.Add(this.squareFeetentry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox squareFeetentry;
        private System.Windows.Forms.TextBox coatsEntry;
        private System.Windows.Forms.TextBox gallonCostentry;
        private System.Windows.Forms.Label entryLabel;
        private System.Windows.Forms.Label squareFeetlabel;
        private System.Windows.Forms.Label coatsLabel;
        private System.Windows.Forms.Label gallonCostlabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label totalSquarefeetAnswer;
        private System.Windows.Forms.Label totalGallonsanswer;
        private System.Windows.Forms.Label totalHoursanswer;
        private System.Windows.Forms.Label totalCostforPaintanswer;
        private System.Windows.Forms.Label totalCostofLaboranswer;
        private System.Windows.Forms.Label fullTotalanswer;
        private System.Windows.Forms.Label output1;
        private System.Windows.Forms.Label output2;
        private System.Windows.Forms.Label output3;
        private System.Windows.Forms.Label output4;
        private System.Windows.Forms.Label output5;
        private System.Windows.Forms.Label output6;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;

    }
}

