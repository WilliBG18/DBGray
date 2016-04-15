namespace DBGray
{
    partial class InsertTupleForm
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
            this.InsertTuplePnl = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.insertButton = new System.Windows.Forms.Button();
            this.InsertTuplePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertTuplePnl
            // 
            this.InsertTuplePnl.AutoScroll = true;
            this.InsertTuplePnl.Controls.Add(this.hScrollBar1);
            this.InsertTuplePnl.Location = new System.Drawing.Point(13, 13);
            this.InsertTuplePnl.Name = "InsertTuplePnl";
            this.InsertTuplePnl.Size = new System.Drawing.Size(549, 441);
            this.InsertTuplePnl.TabIndex = 0;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(229, 420);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 21);
            this.hScrollBar1.TabIndex = 0;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(247, 488);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // InsertTupleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 523);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.InsertTuplePnl);
            this.Name = "InsertTupleForm";
            this.Text = "Form5";
            this.InsertTuplePnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InsertTuplePnl;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button insertButton;
    }
}