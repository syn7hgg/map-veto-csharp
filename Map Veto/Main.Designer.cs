
namespace Map_Veto
{
    partial class Main
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
            this.cmbPools = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadPools = new System.Windows.Forms.Button();
            this.lstMaps = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.lstVetoed = new System.Windows.Forms.ListBox();
            this.lstPicked = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPools
            // 
            this.cmbPools.FormattingEnabled = true;
            this.cmbPools.Location = new System.Drawing.Point(103, 8);
            this.cmbPools.Name = "cmbPools";
            this.cmbPools.Size = new System.Drawing.Size(349, 23);
            this.cmbPools.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map Pool";
            // 
            // btnLoadPools
            // 
            this.btnLoadPools.Location = new System.Drawing.Point(473, 6);
            this.btnLoadPools.Name = "btnLoadPools";
            this.btnLoadPools.Size = new System.Drawing.Size(99, 25);
            this.btnLoadPools.TabIndex = 2;
            this.btnLoadPools.Text = "Load";
            this.btnLoadPools.UseVisualStyleBackColor = true;
            this.btnLoadPools.Click += new System.EventHandler(this.btnLoadPools_Click);
            // 
            // lstMaps
            // 
            this.lstMaps.FormattingEnabled = true;
            this.lstMaps.ItemHeight = 15;
            this.lstMaps.Location = new System.Drawing.Point(12, 58);
            this.lstMaps.Name = "lstMaps";
            this.lstMaps.Size = new System.Drawing.Size(202, 229);
            this.lstMaps.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team 1 Name";
            // 
            // txtT1
            // 
            this.txtT1.Location = new System.Drawing.Point(342, 55);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(230, 23);
            this.txtT1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Team 2 Name";
            // 
            // txtT2
            // 
            this.txtT2.Location = new System.Drawing.Point(342, 100);
            this.txtT2.Name = "txtT2";
            this.txtT2.Size = new System.Drawing.Size(230, 23);
            this.txtT2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Veto Style";
            // 
            // cmbStyle
            // 
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Items.AddRange(new object[] {
            "Best of 1",
            "Best of 3",
            "Best of 5"});
            this.cmbStyle.Location = new System.Drawing.Point(342, 147);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(230, 23);
            this.cmbStyle.TabIndex = 2;
            // 
            // btnAct
            // 
            this.btnAct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAct.Location = new System.Drawing.Point(244, 194);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(328, 93);
            this.btnAct.TabIndex = 7;
            this.btnAct.Text = "Start";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // lstVetoed
            // 
            this.lstVetoed.FormattingEnabled = true;
            this.lstVetoed.ItemHeight = 15;
            this.lstVetoed.Location = new System.Drawing.Point(12, 347);
            this.lstVetoed.Name = "lstVetoed";
            this.lstVetoed.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstVetoed.Size = new System.Drawing.Size(267, 94);
            this.lstVetoed.TabIndex = 8;
            // 
            // lstPicked
            // 
            this.lstPicked.FormattingEnabled = true;
            this.lstPicked.ItemHeight = 15;
            this.lstPicked.Location = new System.Drawing.Point(302, 347);
            this.lstPicked.Name = "lstPicked";
            this.lstPicked.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstPicked.Size = new System.Drawing.Size(270, 94);
            this.lstPicked.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vetoed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Picked";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(62, 290);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(102, 15);
            this.lblRemaining.TabIndex = 10;
            this.lblRemaining.Text = "Waiting for Data...";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstPicked);
            this.Controls.Add(this.lstVetoed);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.cmbStyle);
            this.Controls.Add(this.txtT2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtT1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstMaps);
            this.Controls.Add(this.btnLoadPools);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPools);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Map Veto by Andrés Caraballo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadPools;
        private System.Windows.Forms.ListBox lstMaps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtT2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.ListBox lstVetoed;
        private System.Windows.Forms.ListBox lstPicked;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRemaining;
    }
}

