namespace DungeonsAndDoodles
{
    partial class TestTokenListItemForm
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
            this.testFlowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.addCtrlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testFlowContainer
            // 
            this.testFlowContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testFlowContainer.AutoScroll = true;
            this.testFlowContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testFlowContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.testFlowContainer.Location = new System.Drawing.Point(12, 12);
            this.testFlowContainer.Name = "testFlowContainer";
            this.testFlowContainer.Size = new System.Drawing.Size(350, 335);
            this.testFlowContainer.TabIndex = 0;
            this.testFlowContainer.WrapContents = false;
            // 
            // addCtrlBtn
            // 
            this.addCtrlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCtrlBtn.Location = new System.Drawing.Point(12, 353);
            this.addCtrlBtn.Name = "addCtrlBtn";
            this.addCtrlBtn.Size = new System.Drawing.Size(92, 23);
            this.addCtrlBtn.TabIndex = 1;
            this.addCtrlBtn.Text = "Add Test Ctrl";
            this.addCtrlBtn.UseVisualStyleBackColor = true;
            this.addCtrlBtn.Click += new System.EventHandler(this.addCtrlBtn_Click);
            // 
            // TestTokenListItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 379);
            this.Controls.Add(this.addCtrlBtn);
            this.Controls.Add(this.testFlowContainer);
            this.Name = "TestTokenListItemForm";
            this.Text = "TestTokenListItemForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel testFlowContainer;
        private System.Windows.Forms.Button addCtrlBtn;
    }
}