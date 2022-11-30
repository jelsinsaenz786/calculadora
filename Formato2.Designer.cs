
namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_restar = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_realA = new System.Windows.Forms.TextBox();
            this.txt_imaA = new System.Windows.Forms.TextBox();
            this.txt_realB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_result_real = new System.Windows.Forms.TextBox();
            this.txt_result_ima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_imaB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_restar
            // 
            this.btn_restar.Location = new System.Drawing.Point(579, 174);
            this.btn_restar.Name = "btn_restar";
            this.btn_restar.Size = new System.Drawing.Size(42, 29);
            this.btn_restar.TabIndex = 1;
            this.btn_restar.Text = "-";
            this.btn_restar.UseVisualStyleBackColor = true;
            this.btn_restar.Click += new System.EventHandler(this.btn_restar_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(654, 174);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(42, 29);
            this.btn_multiplicar.TabIndex = 2;
            this.btn_multiplicar.Text = "x";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Real";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Imaginaria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "B:";
            // 
            // txt_realA
            // 
            this.txt_realA.Location = new System.Drawing.Point(184, 162);
            this.txt_realA.Name = "txt_realA";
            this.txt_realA.Size = new System.Drawing.Size(127, 27);
            this.txt_realA.TabIndex = 8;
            // 
            // txt_imaA
            // 
            this.txt_imaA.Location = new System.Drawing.Point(336, 162);
            this.txt_imaA.Name = "txt_imaA";
            this.txt_imaA.Size = new System.Drawing.Size(127, 27);
            this.txt_imaA.TabIndex = 9;
            // 
            // txt_realB
            // 
            this.txt_realB.Location = new System.Drawing.Point(184, 217);
            this.txt_realB.Name = "txt_realB";
            this.txt_realB.Size = new System.Drawing.Size(127, 27);
            this.txt_realB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(417, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "____________________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Resultado:";
            // 
            // txt_result_real
            // 
            this.txt_result_real.Location = new System.Drawing.Point(184, 322);
            this.txt_result_real.Name = "txt_result_real";
            this.txt_result_real.Size = new System.Drawing.Size(127, 27);
            this.txt_result_real.TabIndex = 14;
            // 
            // txt_result_ima
            // 
            this.txt_result_ima.Location = new System.Drawing.Point(336, 322);
            this.txt_result_ima.Name = "txt_result_ima";
            this.txt_result_ima.Size = new System.Drawing.Size(127, 27);
            this.txt_result_ima.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(215, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Calculadora";
            // 
            // txt_imaB
            // 
            this.txt_imaB.Location = new System.Drawing.Point(336, 217);
            this.txt_imaB.Name = "txt_imaB";
            this.txt_imaB.Size = new System.Drawing.Size(126, 27);
            this.txt_imaB.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_imaB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_result_ima);
            this.Controls.Add(this.txt_result_real);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_realB);
            this.Controls.Add(this.txt_imaA);
            this.Controls.Add(this.txt_realA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_restar);
            this.Name = "Form1";
            this.Text = "B:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_realA;
        private System.Windows.Forms.TextBox txt_imaA;
        private System.Windows.Forms.TextBox txt_realB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_result_real;
        private System.Windows.Forms.TextBox txt_result_ima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_imaB;
        private System.Windows.Forms.Button button1;
    }
}

