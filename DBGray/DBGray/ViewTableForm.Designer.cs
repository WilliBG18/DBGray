namespace DBGray
{
    partial class ViewTableForm
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
            this.tuplePanel = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.tuplePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tuplePanel
            // 
            this.tuplePanel.AutoScroll = true;
            this.tuplePanel.Controls.Add(this.hScrollBar1);
            this.tuplePanel.Location = new System.Drawing.Point(13, 13);
            this.tuplePanel.Name = "tuplePanel";
            this.tuplePanel.Size = new System.Drawing.Size(524, 261);
            this.tuplePanel.TabIndex = 0;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(226, 240);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 21);
            this.hScrollBar1.TabIndex = 0;
            // 
            // ViewTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 434);
            this.Controls.Add(this.tuplePanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewTableForm";
            this.Text = "Form4";
            this.tuplePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tuplePanel;
        private System.Windows.Forms.HScrollBar hScrollBar1;


    }
}