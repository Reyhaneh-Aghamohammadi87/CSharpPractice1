namespace WindowsFormsApplication1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultVisit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.btnCheckVisit = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaseCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResultBmi = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnCheckBmi = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDirtyResult = new System.Windows.Forms.Label();
            this.txtThyroidTest = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSugarTest = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDirtyCheck = new System.Windows.Forms.Button();
            this.txtBloodTest = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultVisit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkInsurance);
            this.groupBox1.Controls.Add(this.btnCheckVisit);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBaseCost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 539);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visit";
            // 
            // lblResultVisit
            // 
            this.lblResultVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultVisit.ForeColor = System.Drawing.Color.Black;
            this.lblResultVisit.Location = new System.Drawing.Point(86, 440);
            this.lblResultVisit.Name = "lblResultVisit";
            this.lblResultVisit.Size = new System.Drawing.Size(188, 23);
            this.lblResultVisit.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Result:";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInsurance.Location = new System.Drawing.Point(17, 219);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(257, 29);
            this.chkInsurance.TabIndex = 7;
            this.chkInsurance.Text = "Supplementary Insurance";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCheckVisit
            // 
            this.btnCheckVisit.BackColor = System.Drawing.Color.Navy;
            this.btnCheckVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckVisit.ForeColor = System.Drawing.Color.White;
            this.btnCheckVisit.Location = new System.Drawing.Point(113, 304);
            this.btnCheckVisit.Name = "btnCheckVisit";
            this.btnCheckVisit.Size = new System.Drawing.Size(175, 46);
            this.btnCheckVisit.TabIndex = 1;
            this.btnCheckVisit.Text = "Check";
            this.btnCheckVisit.UseVisualStyleBackColor = false;
            this.btnCheckVisit.Click += new System.EventHandler(this.btnCheckVisit_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(134, 147);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(256, 36);
            this.txtDiscount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discount:";
            // 
            // txtBaseCost
            // 
            this.txtBaseCost.Location = new System.Drawing.Point(134, 75);
            this.txtBaseCost.Multiline = true;
            this.txtBaseCost.Name = "txtBaseCost";
            this.txtBaseCost.Size = new System.Drawing.Size(256, 36);
            this.txtBaseCost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base Cost:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblResultBmi);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.btnCheckBmi);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtWeight);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(418, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 541);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BMI";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(86, 454);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(188, 36);
            this.lblStatus.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // lblResultBmi
            // 
            this.lblResultBmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultBmi.ForeColor = System.Drawing.Color.Black;
            this.lblResultBmi.Location = new System.Drawing.Point(86, 415);
            this.lblResultBmi.Name = "lblResultBmi";
            this.lblResultBmi.Size = new System.Drawing.Size(188, 23);
            this.lblResultBmi.TabIndex = 9;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(12, 413);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(82, 23);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "BMI:";
            // 
            // btnCheckBmi
            // 
            this.btnCheckBmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCheckBmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBmi.ForeColor = System.Drawing.Color.White;
            this.btnCheckBmi.Location = new System.Drawing.Point(124, 304);
            this.btnCheckBmi.Name = "btnCheckBmi";
            this.btnCheckBmi.Size = new System.Drawing.Size(175, 46);
            this.btnCheckBmi.TabIndex = 1;
            this.btnCheckBmi.Text = "Check";
            this.btnCheckBmi.UseVisualStyleBackColor = false;
            this.btnCheckBmi.Click += new System.EventHandler(this.btnCheckBmi_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(124, 148);
            this.txtHeight.Multiline = true;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(256, 36);
            this.txtHeight.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Height:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(124, 75);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(256, 36);
            this.txtWeight.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Weight:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDirtyResult);
            this.groupBox3.Controls.Add(this.txtThyroidTest);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtSugarTest);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnDirtyCheck);
            this.groupBox3.Controls.Add(this.txtBloodTest);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtPatient);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(838, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 541);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dirty Code";
            // 
            // lblDirtyResult
            // 
            this.lblDirtyResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirtyResult.ForeColor = System.Drawing.Color.Maroon;
            this.lblDirtyResult.Location = new System.Drawing.Point(17, 457);
            this.lblDirtyResult.Name = "lblDirtyResult";
            this.lblDirtyResult.Size = new System.Drawing.Size(410, 69);
            this.lblDirtyResult.TabIndex = 17;
            // 
            // txtThyroidTest
            // 
            this.txtThyroidTest.Location = new System.Drawing.Point(154, 268);
            this.txtThyroidTest.Multiline = true;
            this.txtThyroidTest.Name = "txtThyroidTest";
            this.txtThyroidTest.Size = new System.Drawing.Size(256, 36);
            this.txtThyroidTest.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 30);
            this.label14.TabIndex = 14;
            this.label14.Text = "Thyroid Test:";
            // 
            // txtSugarTest
            // 
            this.txtSugarTest.Location = new System.Drawing.Point(154, 205);
            this.txtSugarTest.Multiline = true;
            this.txtSugarTest.Name = "txtSugarTest";
            this.txtSugarTest.Size = new System.Drawing.Size(256, 36);
            this.txtSugarTest.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 30);
            this.label13.TabIndex = 12;
            this.label13.Text = "Sugar Test:";
            // 
            // btnDirtyCheck
            // 
            this.btnDirtyCheck.BackColor = System.Drawing.Color.DarkRed;
            this.btnDirtyCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirtyCheck.ForeColor = System.Drawing.Color.White;
            this.btnDirtyCheck.Location = new System.Drawing.Point(137, 350);
            this.btnDirtyCheck.Name = "btnDirtyCheck";
            this.btnDirtyCheck.Size = new System.Drawing.Size(175, 46);
            this.btnDirtyCheck.TabIndex = 1;
            this.btnDirtyCheck.Text = "Check";
            this.btnDirtyCheck.UseVisualStyleBackColor = false;
            this.btnDirtyCheck.Click += new System.EventHandler(this.btnDirtyCheck_Click);
            // 
            // txtBloodTest
            // 
            this.txtBloodTest.Location = new System.Drawing.Point(154, 141);
            this.txtBloodTest.Multiline = true;
            this.txtBloodTest.Name = "txtBloodTest";
            this.txtBloodTest.Size = new System.Drawing.Size(256, 36);
            this.txtBloodTest.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 30);
            this.label11.TabIndex = 6;
            this.label11.Text = "Blood Test:";
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(154, 76);
            this.txtPatient.Multiline = true;
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(256, 36);
            this.txtPatient.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 30);
            this.label12.TabIndex = 2;
            this.label12.Text = "Patient Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckVisit;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaseCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.Label lblResultVisit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultBmi;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnCheckBmi;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDirtyResult;
        private System.Windows.Forms.TextBox txtThyroidTest;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSugarTest;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDirtyCheck;
        private System.Windows.Forms.TextBox txtBloodTest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Label label12;
    }
}

