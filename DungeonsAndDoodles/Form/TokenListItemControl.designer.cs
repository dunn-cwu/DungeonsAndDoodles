namespace DungeonsAndDoodles
{
    partial class TokenListItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TokenName = new System.Windows.Forms.Label();
            this.TokenStrength = new System.Windows.Forms.Label();
            this.TokenDexterity = new System.Windows.Forms.Label();
            this.TokenConstitution = new System.Windows.Forms.Label();
            this.TokenIntelligence = new System.Windows.Forms.Label();
            this.TokenWisdom = new System.Windows.Forms.Label();
            this.TokenCharisma = new System.Windows.Forms.Label();
            this.HealthBox = new System.Windows.Forms.TextBox();
            this.HPPlus = new System.Windows.Forms.Button();
            this.HPMinus = new System.Windows.Forms.Button();
            this.TokenImageBox = new System.Windows.Forms.PictureBox();
            this.acLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TokenImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TokenName
            // 
            this.TokenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TokenName.Location = new System.Drawing.Point(3, 0);
            this.TokenName.Name = "TokenName";
            this.TokenName.Size = new System.Drawing.Size(242, 20);
            this.TokenName.TabIndex = 0;
            this.TokenName.Text = "label1";
            this.TokenName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TokenStrength
            // 
            this.TokenStrength.AutoSize = true;
            this.TokenStrength.Location = new System.Drawing.Point(116, 55);
            this.TokenStrength.Name = "TokenStrength";
            this.TokenStrength.Size = new System.Drawing.Size(35, 13);
            this.TokenStrength.TabIndex = 2;
            this.TokenStrength.Text = "label1";
            // 
            // TokenDexterity
            // 
            this.TokenDexterity.AutoSize = true;
            this.TokenDexterity.Location = new System.Drawing.Point(176, 55);
            this.TokenDexterity.Name = "TokenDexterity";
            this.TokenDexterity.Size = new System.Drawing.Size(35, 13);
            this.TokenDexterity.TabIndex = 3;
            this.TokenDexterity.Text = "label2";
            // 
            // TokenConstitution
            // 
            this.TokenConstitution.AutoSize = true;
            this.TokenConstitution.Location = new System.Drawing.Point(237, 55);
            this.TokenConstitution.Name = "TokenConstitution";
            this.TokenConstitution.Size = new System.Drawing.Size(35, 13);
            this.TokenConstitution.TabIndex = 4;
            this.TokenConstitution.Text = "label3";
            // 
            // TokenIntelligence
            // 
            this.TokenIntelligence.AutoSize = true;
            this.TokenIntelligence.Location = new System.Drawing.Point(116, 80);
            this.TokenIntelligence.Name = "TokenIntelligence";
            this.TokenIntelligence.Size = new System.Drawing.Size(35, 13);
            this.TokenIntelligence.TabIndex = 5;
            this.TokenIntelligence.Text = "label4";
            // 
            // TokenWisdom
            // 
            this.TokenWisdom.AutoSize = true;
            this.TokenWisdom.Location = new System.Drawing.Point(176, 80);
            this.TokenWisdom.Name = "TokenWisdom";
            this.TokenWisdom.Size = new System.Drawing.Size(35, 13);
            this.TokenWisdom.TabIndex = 6;
            this.TokenWisdom.Text = "label5";
            this.TokenWisdom.Click += new System.EventHandler(this.label5_Click);
            // 
            // TokenCharisma
            // 
            this.TokenCharisma.AutoSize = true;
            this.TokenCharisma.Location = new System.Drawing.Point(237, 80);
            this.TokenCharisma.Name = "TokenCharisma";
            this.TokenCharisma.Size = new System.Drawing.Size(35, 13);
            this.TokenCharisma.TabIndex = 7;
            this.TokenCharisma.Text = "label6";
            // 
            // HealthBox
            // 
            this.HealthBox.Location = new System.Drawing.Point(125, 23);
            this.HealthBox.Name = "HealthBox";
            this.HealthBox.Size = new System.Drawing.Size(135, 20);
            this.HealthBox.TabIndex = 8;
            this.HealthBox.Click += new System.EventHandler(this.HealthBox_Click);
            this.HealthBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HealthBox_KeyDown);
            // 
            // HPPlus
            // 
            this.HPPlus.Location = new System.Drawing.Point(262, 22);
            this.HPPlus.Name = "HPPlus";
            this.HPPlus.Size = new System.Drawing.Size(22, 22);
            this.HPPlus.TabIndex = 9;
            this.HPPlus.Text = "+";
            this.HPPlus.UseVisualStyleBackColor = true;
            this.HPPlus.Click += new System.EventHandler(this.HPPlus_Click);
            // 
            // HPMinus
            // 
            this.HPMinus.Location = new System.Drawing.Point(101, 22);
            this.HPMinus.Name = "HPMinus";
            this.HPMinus.Size = new System.Drawing.Size(22, 22);
            this.HPMinus.TabIndex = 10;
            this.HPMinus.Text = "-";
            this.HPMinus.UseVisualStyleBackColor = true;
            this.HPMinus.Click += new System.EventHandler(this.HPMinus_Click);
            // 
            // TokenImageBox
            // 
            this.TokenImageBox.Location = new System.Drawing.Point(7, 23);
            this.TokenImageBox.Name = "TokenImageBox";
            this.TokenImageBox.Size = new System.Drawing.Size(75, 75);
            this.TokenImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TokenImageBox.TabIndex = 11;
            this.TokenImageBox.TabStop = false;
            // 
            // acLabel
            // 
            this.acLabel.AutoSize = true;
            this.acLabel.Location = new System.Drawing.Point(261, 6);
            this.acLabel.Name = "acLabel";
            this.acLabel.Size = new System.Drawing.Size(35, 13);
            this.acLabel.TabIndex = 12;
            this.acLabel.Text = "label1";
            // 
            // TokenListItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.acLabel);
            this.Controls.Add(this.TokenImageBox);
            this.Controls.Add(this.HPMinus);
            this.Controls.Add(this.HPPlus);
            this.Controls.Add(this.HealthBox);
            this.Controls.Add(this.TokenCharisma);
            this.Controls.Add(this.TokenWisdom);
            this.Controls.Add(this.TokenIntelligence);
            this.Controls.Add(this.TokenConstitution);
            this.Controls.Add(this.TokenDexterity);
            this.Controls.Add(this.TokenStrength);
            this.Controls.Add(this.TokenName);
            this.Name = "TokenListItemControl";
            this.Size = new System.Drawing.Size(306, 105);
            this.Load += new System.EventHandler(this.TokenListItemControl_Load);
            this.Click += new System.EventHandler(this.TokenListItemControl_Click);
            this.MouseLeave += new System.EventHandler(this.TokenListItemControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.TokenImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label TokenName;
        private System.Windows.Forms.Label TokenStrength;
        private System.Windows.Forms.Label TokenDexterity;
        private System.Windows.Forms.Label TokenConstitution;
        private System.Windows.Forms.Label TokenIntelligence;
        private System.Windows.Forms.Label TokenWisdom;
        private System.Windows.Forms.Label TokenCharisma;
        private System.Windows.Forms.TextBox HealthBox;
        private System.Windows.Forms.Button HPPlus;
        private System.Windows.Forms.Button HPMinus;
        private System.Windows.Forms.PictureBox TokenImageBox;
        private System.Windows.Forms.Label acLabel;
    }
}
