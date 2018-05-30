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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.TokenImageBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TokenName
            // 
            this.TokenName.AutoEllipsis = true;
            this.TokenName.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.TokenName.Location = new System.Drawing.Point(3, 0);
            this.TokenName.Name = "TokenName";
            this.TokenName.Size = new System.Drawing.Size(222, 20);
            this.TokenName.TabIndex = 0;
            this.TokenName.Text = "label1";
            // 
            // TokenStrength
            // 
            this.TokenStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TokenStrength.Location = new System.Drawing.Point(3, 0);
            this.TokenStrength.Name = "TokenStrength";
            this.TokenStrength.Size = new System.Drawing.Size(55, 22);
            this.TokenStrength.TabIndex = 2;
            this.TokenStrength.Text = "label1";
            // 
            // TokenDexterity
            // 
            this.TokenDexterity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TokenDexterity.Location = new System.Drawing.Point(64, 0);
            this.TokenDexterity.Name = "TokenDexterity";
            this.TokenDexterity.Size = new System.Drawing.Size(56, 22);
            this.TokenDexterity.TabIndex = 3;
            this.TokenDexterity.Text = "label2";
            // 
            // TokenConstitution
            // 
            this.TokenConstitution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TokenConstitution.Location = new System.Drawing.Point(126, 0);
            this.TokenConstitution.Name = "TokenConstitution";
            this.TokenConstitution.Size = new System.Drawing.Size(57, 22);
            this.TokenConstitution.TabIndex = 4;
            this.TokenConstitution.Text = "label3";
            this.TokenConstitution.Click += new System.EventHandler(this.TokenConstitution_Click);
            // 
            // TokenIntelligence
            // 
            this.TokenIntelligence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TokenIntelligence.Location = new System.Drawing.Point(3, 22);
            this.TokenIntelligence.Name = "TokenIntelligence";
            this.TokenIntelligence.Size = new System.Drawing.Size(55, 23);
            this.TokenIntelligence.TabIndex = 5;
            this.TokenIntelligence.Text = "label4";
            // 
            // TokenWisdom
            // 
            this.TokenWisdom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TokenWisdom.Location = new System.Drawing.Point(64, 22);
            this.TokenWisdom.Name = "TokenWisdom";
            this.TokenWisdom.Size = new System.Drawing.Size(56, 23);
            this.TokenWisdom.TabIndex = 6;
            this.TokenWisdom.Text = "label5";
            this.TokenWisdom.Click += new System.EventHandler(this.label5_Click);
            // 
            // TokenCharisma
            // 
            this.TokenCharisma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TokenCharisma.Location = new System.Drawing.Point(126, 22);
            this.TokenCharisma.Name = "TokenCharisma";
            this.TokenCharisma.Size = new System.Drawing.Size(57, 23);
            this.TokenCharisma.TabIndex = 7;
            this.TokenCharisma.Text = "label6";
            // 
            // HealthBox
            // 
            this.HealthBox.Location = new System.Drawing.Point(108, 23);
            this.HealthBox.Name = "HealthBox";
            this.HealthBox.Size = new System.Drawing.Size(130, 20);
            this.HealthBox.TabIndex = 8;
            this.HealthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HealthBox.Click += new System.EventHandler(this.HealthBox_Click);
            this.HealthBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HealthBox_KeyDown);
            // 
            // HPPlus
            // 
            this.HPPlus.Location = new System.Drawing.Point(244, 22);
            this.HPPlus.Name = "HPPlus";
            this.HPPlus.Size = new System.Drawing.Size(22, 22);
            this.HPPlus.TabIndex = 9;
            this.HPPlus.Text = "+";
            this.HPPlus.UseVisualStyleBackColor = true;
            this.HPPlus.Click += new System.EventHandler(this.HPPlus_Click);
            // 
            // HPMinus
            // 
            this.HPMinus.Location = new System.Drawing.Point(80, 22);
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
            this.TokenImageBox.Size = new System.Drawing.Size(60, 60);
            this.TokenImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TokenImageBox.TabIndex = 11;
            this.TokenImageBox.TabStop = false;
            this.TokenImageBox.Click += new System.EventHandler(this.TokenImageBox_Click);
            this.TokenImageBox.DoubleClick += new System.EventHandler(this.TokenImageBox_DoubleClick);
            // 
            // acLabel
            // 
            this.acLabel.Location = new System.Drawing.Point(231, 4);
            this.acLabel.Name = "acLabel";
            this.acLabel.Size = new System.Drawing.Size(35, 13);
            this.acLabel.TabIndex = 12;
            this.acLabel.Text = "label1";
            this.acLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.TokenStrength, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TokenDexterity, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TokenConstitution, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TokenIntelligence, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TokenWisdom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TokenCharisma, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 45);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // TokenListItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.acLabel);
            this.Controls.Add(this.TokenImageBox);
            this.Controls.Add(this.HPMinus);
            this.Controls.Add(this.HPPlus);
            this.Controls.Add(this.HealthBox);
            this.Controls.Add(this.TokenName);
            this.Name = "TokenListItemControl";
            this.Size = new System.Drawing.Size(275, 95);
            this.Load += new System.EventHandler(this.TokenListItemControl_Load);
            this.Click += new System.EventHandler(this.TokenListItemControl_Click);
            this.MouseLeave += new System.EventHandler(this.TokenListItemControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.TokenImageBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
