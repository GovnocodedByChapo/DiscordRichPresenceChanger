
namespace DRPC_METRO
{
    partial class Form2
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
            this.notf_title = new System.Windows.Forms.Label();
            this.notf_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notf_title
            // 
            this.notf_title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notf_title.ForeColor = System.Drawing.Color.White;
            this.notf_title.Location = new System.Drawing.Point(0, 0);
            this.notf_title.Name = "notf_title";
            this.notf_title.Size = new System.Drawing.Size(240, 29);
            this.notf_title.TabIndex = 0;
            this.notf_title.Text = "DRPC";
            this.notf_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notf_text
            // 
            this.notf_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.notf_text.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notf_text.ForeColor = System.Drawing.Color.White;
            this.notf_text.Location = new System.Drawing.Point(3, 38);
            this.notf_text.Name = "notf_text";
            this.notf_text.Size = new System.Drawing.Size(238, 40);
            this.notf_text.TabIndex = 1;
            this.notf_text.Text = "Client id changed. Restarting...\r\n";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(1, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 53);
            this.label1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(242, 79);
            this.Controls.Add(this.notf_text);
            this.Controls.Add(this.notf_title);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label notf_title;
        private System.Windows.Forms.Label notf_text;
        private System.Windows.Forms.Label label1;
    }
}