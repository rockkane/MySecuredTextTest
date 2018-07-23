namespace MySecuredTextTest
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
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecript = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColorText = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(68, 79);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(591, 37);
            this.txtPlain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plain Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(70, 207);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(254, 37);
            this.txtKey.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(387, 207);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(106, 37);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecript
            // 
            this.btnDecript.Location = new System.Drawing.Point(553, 207);
            this.btnDecript.Name = "btnDecript";
            this.btnDecript.Size = new System.Drawing.Size(106, 37);
            this.btnDecript.TabIndex = 5;
            this.btnDecript.Text = "Decrypt";
            this.btnDecript.UseVisualStyleBackColor = true;
            this.btnDecript.Click += new System.EventHandler(this.btnDecript_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cypher Text";
            // 
            // txtColorText
            // 
            this.txtColorText.Location = new System.Drawing.Point(68, 338);
            this.txtColorText.Multiline = true;
            this.txtColorText.Name = "txtColorText";
            this.txtColorText.Size = new System.Drawing.Size(591, 37);
            this.txtColorText.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(553, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 508);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColorText);
            this.Controls.Add(this.btnDecript);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecript;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColorText;
        private System.Windows.Forms.Button btnExit;
    }
}

