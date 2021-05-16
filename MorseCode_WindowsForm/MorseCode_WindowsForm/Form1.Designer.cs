namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Enkodo = new System.Windows.Forms.Button();
            this.txtEncodedText1 = new System.Windows.Forms.TextBox();
            this.Dekodo = new System.Windows.Forms.Button();
            this.txtEncodedText2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDecodedText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.beepBtn = new System.Windows.Forms.Button();
            this.beepBtn1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.frequency = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shkruaj tekstin";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlainText.Location = new System.Drawing.Point(16, 42);
            this.txtPlainText.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(1141, 70);
            this.txtPlainText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teksti i enkoduar ";
            // 
            // Enkodo
            // 
            this.Enkodo.Location = new System.Drawing.Point(1009, 121);
            this.Enkodo.Margin = new System.Windows.Forms.Padding(4);
            this.Enkodo.Name = "Enkodo";
            this.Enkodo.Size = new System.Drawing.Size(149, 41);
            this.Enkodo.TabIndex = 3;
            this.Enkodo.Text = "Enkodo";
            this.Enkodo.UseVisualStyleBackColor = true;
            this.Enkodo.Click += new System.EventHandler(this.Enkodo_Click);
            // 
            // txtEncodedText1
            // 
            this.txtEncodedText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEncodedText1.Location = new System.Drawing.Point(16, 178);
            this.txtEncodedText1.Margin = new System.Windows.Forms.Padding(4);
            this.txtEncodedText1.Multiline = true;
            this.txtEncodedText1.Name = "txtEncodedText1";
            this.txtEncodedText1.Size = new System.Drawing.Size(1141, 70);
            this.txtEncodedText1.TabIndex = 4;
            // 
            // Dekodo
            // 
            this.Dekodo.Location = new System.Drawing.Point(1009, 406);
            this.Dekodo.Margin = new System.Windows.Forms.Padding(4);
            this.Dekodo.Name = "Dekodo";
            this.Dekodo.Size = new System.Drawing.Size(149, 41);
            this.Dekodo.TabIndex = 5;
            this.Dekodo.Text = "Dekodo";
            this.Dekodo.UseVisualStyleBackColor = true;
            this.Dekodo.Click += new System.EventHandler(this.Dekodo_Click);
            // 
            // txtEncodedText2
            // 
            this.txtEncodedText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEncodedText2.Location = new System.Drawing.Point(16, 327);
            this.txtEncodedText2.Margin = new System.Windows.Forms.Padding(4);
            this.txtEncodedText2.Multiline = true;
            this.txtEncodedText2.Name = "txtEncodedText2";
            this.txtEncodedText2.Size = new System.Drawing.Size(1141, 70);
            this.txtEncodedText2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.Location = new System.Drawing.Point(16, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shkruaj Morse kodin";
            // 
            // txtDecodedText
            // 
            this.txtDecodedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDecodedText.Location = new System.Drawing.Point(16, 454);
            this.txtDecodedText.Margin = new System.Windows.Forms.Padding(4);
            this.txtDecodedText.Multiline = true;
            this.txtDecodedText.Name = "txtDecodedText";
            this.txtDecodedText.Size = new System.Drawing.Size(1141, 70);
            this.txtDecodedText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.Location = new System.Drawing.Point(16, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teksti i dekoduar";
            // 
            // beepBtn
            // 
            this.beepBtn.Location = new System.Drawing.Point(839, 122);
            this.beepBtn.Margin = new System.Windows.Forms.Padding(4);
            this.beepBtn.Name = "beepBtn";
            this.beepBtn.Size = new System.Drawing.Size(139, 39);
            this.beepBtn.TabIndex = 10;
            this.beepBtn.Text = "Luaj me ze";
            this.beepBtn.UseVisualStyleBackColor = true;
            this.beepBtn.Click += new System.EventHandler(this.beepBtn_Click);
            // 
            // beepBtn1
            // 
            this.beepBtn1.Location = new System.Drawing.Point(839, 407);
            this.beepBtn1.Margin = new System.Windows.Forms.Padding(4);
            this.beepBtn1.Name = "beepBtn1";
            this.beepBtn1.Size = new System.Drawing.Size(139, 39);
            this.beepBtn1.TabIndex = 11;
            this.beepBtn1.Text = "Luaj me ze";
            this.beepBtn1.UseVisualStyleBackColor = true;
            this.beepBtn1.Click += new System.EventHandler(this.beepBtn1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(730, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Frekuenca:";
            // 
            // frequency
            // 
            this.frequency.Location = new System.Drawing.Point(732, 139);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(100, 22);
            this.frequency.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 599);
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.beepBtn1);
            this.Controls.Add(this.beepBtn);
            this.Controls.Add(this.txtDecodedText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEncodedText2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dekodo);
            this.Controls.Add(this.txtEncodedText1);
            this.Controls.Add(this.Enkodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Enkodo;
        private System.Windows.Forms.TextBox txtEncodedText1;
        private System.Windows.Forms.Button Dekodo;
        private System.Windows.Forms.TextBox txtEncodedText2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecodedText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button beepBtn;
        private System.Windows.Forms.Button beepBtn1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox frequency;
    }
}

