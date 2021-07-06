
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnAct = new MaterialSkin.Controls.MaterialButton();
            this.lstVetoed = new MaterialSkin.Controls.MaterialListBox();
            this.lstPicked = new MaterialSkin.Controls.MaterialListBox();
            this.lstMaps = new MaterialSkin.Controls.MaterialListBox();
            this.cmbStyle = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtT2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtT1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPools = new MaterialSkin.Controls.MaterialComboBox();
            this.lblRemaining = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnLoadPools = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 9;
            // 
            // btnAct
            // 
            this.btnAct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAct.Depth = 0;
            this.btnAct.HighEmphasis = true;
            this.btnAct.Icon = null;
            this.btnAct.Location = new System.Drawing.Point(434, 362);
            this.btnAct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(67, 36);
            this.btnAct.TabIndex = 11;
            this.btnAct.Text = "Start";
            this.btnAct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAct.UseAccentColor = false;
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click_1);
            // 
            // lstVetoed
            // 
            this.lstVetoed.BackColor = System.Drawing.Color.White;
            this.lstVetoed.BorderColor = System.Drawing.Color.LightGray;
            this.lstVetoed.Depth = 0;
            this.lstVetoed.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstVetoed.Location = new System.Drawing.Point(6, 449);
            this.lstVetoed.MouseState = MaterialSkin.MouseState.HOVER;
            this.lstVetoed.Name = "lstVetoed";
            this.lstVetoed.SelectedIndex = -1;
            this.lstVetoed.SelectedItem = null;
            this.lstVetoed.Size = new System.Drawing.Size(311, 222);
            this.lstVetoed.TabIndex = 12;
            // 
            // lstPicked
            // 
            this.lstPicked.BackColor = System.Drawing.Color.White;
            this.lstPicked.BorderColor = System.Drawing.Color.LightGray;
            this.lstPicked.Depth = 0;
            this.lstPicked.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstPicked.Location = new System.Drawing.Point(350, 449);
            this.lstPicked.MouseState = MaterialSkin.MouseState.HOVER;
            this.lstPicked.Name = "lstPicked";
            this.lstPicked.SelectedIndex = -1;
            this.lstPicked.SelectedItem = null;
            this.lstPicked.Size = new System.Drawing.Size(311, 222);
            this.lstPicked.TabIndex = 12;
            // 
            // lstMaps
            // 
            this.lstMaps.BackColor = System.Drawing.Color.White;
            this.lstMaps.BorderColor = System.Drawing.Color.LightGray;
            this.lstMaps.Depth = 0;
            this.lstMaps.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstMaps.Location = new System.Drawing.Point(12, 150);
            this.lstMaps.MouseState = MaterialSkin.MouseState.HOVER;
            this.lstMaps.Name = "lstMaps";
            this.lstMaps.SelectedIndex = -1;
            this.lstMaps.SelectedItem = null;
            this.lstMaps.Size = new System.Drawing.Size(219, 245);
            this.lstMaps.TabIndex = 12;
            // 
            // cmbStyle
            // 
            this.cmbStyle.AutoResize = false;
            this.cmbStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbStyle.Depth = 0;
            this.cmbStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStyle.DropDownHeight = 174;
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.DropDownWidth = 121;
            this.cmbStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.IntegralHeight = false;
            this.cmbStyle.ItemHeight = 43;
            this.cmbStyle.Items.AddRange(new object[] {
            "Best of 1",
            "Best of 2",
            "Best of 3",
            "Best of 5"});
            this.cmbStyle.Location = new System.Drawing.Point(350, 295);
            this.cmbStyle.MaxDropDownItems = 4;
            this.cmbStyle.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(311, 49);
            this.cmbStyle.StartIndex = 0;
            this.cmbStyle.TabIndex = 13;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(258, 309);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Veto Style";
            // 
            // txtT2
            // 
            this.txtT2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtT2.Depth = 0;
            this.txtT2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtT2.LeadingIcon = null;
            this.txtT2.Location = new System.Drawing.Point(350, 227);
            this.txtT2.MaxLength = 50;
            this.txtT2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtT2.Multiline = false;
            this.txtT2.Name = "txtT2";
            this.txtT2.Size = new System.Drawing.Size(311, 50);
            this.txtT2.TabIndex = 15;
            this.txtT2.Text = "";
            this.txtT2.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(262, 242);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Team 2";
            // 
            // txtT1
            // 
            this.txtT1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtT1.Depth = 0;
            this.txtT1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtT1.LeadingIcon = null;
            this.txtT1.Location = new System.Drawing.Point(350, 156);
            this.txtT1.MaxLength = 50;
            this.txtT1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtT1.Multiline = false;
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(311, 50);
            this.txtT1.TabIndex = 15;
            this.txtT1.Text = "";
            this.txtT1.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(262, 174);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Team 1";
            // 
            // cmbPools
            // 
            this.cmbPools.AutoResize = false;
            this.cmbPools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPools.Depth = 0;
            this.cmbPools.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPools.DropDownHeight = 174;
            this.cmbPools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPools.DropDownWidth = 121;
            this.cmbPools.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPools.FormattingEnabled = true;
            this.cmbPools.IntegralHeight = false;
            this.cmbPools.ItemHeight = 43;
            this.cmbPools.Location = new System.Drawing.Point(149, 80);
            this.cmbPools.MaxDropDownItems = 4;
            this.cmbPools.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPools.Name = "cmbPools";
            this.cmbPools.Size = new System.Drawing.Size(352, 49);
            this.cmbPools.StartIndex = 0;
            this.cmbPools.TabIndex = 13;
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Depth = 0;
            this.lblRemaining.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRemaining.Location = new System.Drawing.Point(56, 398);
            this.lblRemaining.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(129, 19);
            this.lblRemaining.TabIndex = 14;
            this.lblRemaining.Text = "Waiting for Data...";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(135, 427);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(50, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Vetoed";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(483, 427);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(48, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Picked";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(40, 95);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(69, 19);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "Map Pool";
            // 
            // btnLoadPools
            // 
            this.btnLoadPools.AutoSize = false;
            this.btnLoadPools.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadPools.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoadPools.Depth = 0;
            this.btnLoadPools.HighEmphasis = true;
            this.btnLoadPools.Icon = null;
            this.btnLoadPools.Location = new System.Drawing.Point(548, 85);
            this.btnLoadPools.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadPools.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadPools.Name = "btnLoadPools";
            this.btnLoadPools.Size = new System.Drawing.Size(75, 36);
            this.btnLoadPools.TabIndex = 16;
            this.btnLoadPools.Text = "Load";
            this.btnLoadPools.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoadPools.UseAccentColor = true;
            this.btnLoadPools.UseVisualStyleBackColor = true;
            this.btnLoadPools.Click += new System.EventHandler(this.btnLoadPools_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 677);
            this.Controls.Add(this.btnLoadPools);
            this.Controls.Add(this.txtT1);
            this.Controls.Add(this.txtT2);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbPools);
            this.Controls.Add(this.cmbStyle);
            this.Controls.Add(this.lstPicked);
            this.Controls.Add(this.lstMaps);
            this.Controls.Add(this.lstVetoed);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Map Veto by Andrés Caraballo";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialButton btnAct;
        private MaterialSkin.Controls.MaterialListBox lstVetoed;
        private MaterialSkin.Controls.MaterialListBox lstPicked;
        private MaterialSkin.Controls.MaterialListBox lstMaps;
        private MaterialSkin.Controls.MaterialComboBox cmbStyle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtT2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtT1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cmbPools;
        private MaterialSkin.Controls.MaterialLabel lblRemaining;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton btnLoadPools;
    }
}

