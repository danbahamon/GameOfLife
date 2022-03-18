
namespace GameOfLife
{
    partial class EdgeStyle
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
            this.wrapBtn = new System.Windows.Forms.RadioButton();
            this.finiteBtn = new System.Windows.Forms.RadioButton();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wrapBtn
            // 
            this.wrapBtn.AutoSize = true;
            this.wrapBtn.Location = new System.Drawing.Point(12, 15);
            this.wrapBtn.Name = "wrapBtn";
            this.wrapBtn.Size = new System.Drawing.Size(113, 21);
            this.wrapBtn.TabIndex = 0;
            this.wrapBtn.TabStop = true;
            this.wrapBtn.Text = "Wrap Around";
            this.wrapBtn.UseVisualStyleBackColor = true;
            // 
            // finiteBtn
            // 
            this.finiteBtn.AutoSize = true;
            this.finiteBtn.Location = new System.Drawing.Point(12, 43);
            this.finiteBtn.Name = "finiteBtn";
            this.finiteBtn.Size = new System.Drawing.Size(63, 21);
            this.finiteBtn.TabIndex = 1;
            this.finiteBtn.TabStop = true;
            this.finiteBtn.Text = "Finite";
            this.finiteBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(12, 84);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 2;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(93, 84);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // EdgeStyle
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(185, 119);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.finiteBtn);
            this.Controls.Add(this.wrapBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdgeStyle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdgeStyle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        public System.Windows.Forms.RadioButton wrapBtn;
        public System.Windows.Forms.RadioButton finiteBtn;
    }
}