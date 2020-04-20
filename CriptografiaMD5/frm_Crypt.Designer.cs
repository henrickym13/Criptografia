namespace CriptografiaMD5
{
    partial class frm_Crypt
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
            this.bt_decript = new System.Windows.Forms.Button();
            this.bt_encrypt = new System.Windows.Forms.Button();
            this.txt_ResultDecript = new System.Windows.Forms.TextBox();
            this.txt_toDecript = new System.Windows.Forms.TextBox();
            this.txt_ResultEncript = new System.Windows.Forms.TextBox();
            this.txt_toEncript = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_decript
            // 
            this.bt_decript.Location = new System.Drawing.Point(324, 153);
            this.bt_decript.Name = "bt_decript";
            this.bt_decript.Size = new System.Drawing.Size(296, 23);
            this.bt_decript.TabIndex = 0;
            this.bt_decript.Text = "Decriptar";
            this.bt_decript.UseVisualStyleBackColor = true;
            this.bt_decript.Click += new System.EventHandler(this.bt_decript_Click);
            // 
            // bt_encrypt
            // 
            this.bt_encrypt.Location = new System.Drawing.Point(14, 153);
            this.bt_encrypt.Name = "bt_encrypt";
            this.bt_encrypt.Size = new System.Drawing.Size(279, 23);
            this.bt_encrypt.TabIndex = 1;
            this.bt_encrypt.Text = "Criptografar";
            this.bt_encrypt.UseVisualStyleBackColor = true;
            this.bt_encrypt.Click += new System.EventHandler(this.bt_encrypt_Click);
            // 
            // txt_ResultDecript
            // 
            this.txt_ResultDecript.Location = new System.Drawing.Point(324, 107);
            this.txt_ResultDecript.Name = "txt_ResultDecript";
            this.txt_ResultDecript.Size = new System.Drawing.Size(296, 20);
            this.txt_ResultDecript.TabIndex = 2;
            // 
            // txt_toDecript
            // 
            this.txt_toDecript.Location = new System.Drawing.Point(324, 62);
            this.txt_toDecript.Name = "txt_toDecript";
            this.txt_toDecript.Size = new System.Drawing.Size(296, 20);
            this.txt_toDecript.TabIndex = 3;
            // 
            // txt_ResultEncript
            // 
            this.txt_ResultEncript.Location = new System.Drawing.Point(14, 107);
            this.txt_ResultEncript.Name = "txt_ResultEncript";
            this.txt_ResultEncript.Size = new System.Drawing.Size(278, 20);
            this.txt_ResultEncript.TabIndex = 4;
            // 
            // txt_toEncript
            // 
            this.txt_toEncript.AccessibleDescription = "";
            this.txt_toEncript.AccessibleName = "";
            this.txt_toEncript.Location = new System.Drawing.Point(14, 62);
            this.txt_toEncript.Multiline = true;
            this.txt_toEncript.Name = "txt_toEncript";
            this.txt_toEncript.Size = new System.Drawing.Size(278, 20);
            this.txt_toEncript.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(321, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "String Criptografada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "String para Encriptar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultado";
            // 
            // frm_Crypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 198);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_toEncript);
            this.Controls.Add(this.txt_ResultEncript);
            this.Controls.Add(this.txt_toDecript);
            this.Controls.Add(this.txt_ResultDecript);
            this.Controls.Add(this.bt_encrypt);
            this.Controls.Add(this.bt_decript);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Crypt";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_decript;
        private System.Windows.Forms.Button bt_encrypt;
        private System.Windows.Forms.TextBox txt_ResultDecript;
        private System.Windows.Forms.TextBox txt_toDecript;
        private System.Windows.Forms.TextBox txt_ResultEncript;
        private System.Windows.Forms.TextBox txt_toEncript;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

