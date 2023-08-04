
namespace MVP4triangleArea
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSide1 = new System.Windows.Forms.TextBox();
            this.tbSide2 = new System.Windows.Forms.TextBox();
            this.tbSide3 = new System.Windows.Forms.TextBox();
            this.lArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сторона 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сторона 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сторона 3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вычислить площадь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Площадь треугольника, мм2:";
            // 
            // tbSide1
            // 
            this.tbSide1.Location = new System.Drawing.Point(76, 12);
            this.tbSide1.Name = "tbSide1";
            this.tbSide1.Size = new System.Drawing.Size(100, 20);
            this.tbSide1.TabIndex = 5;
            // 
            // tbSide2
            // 
            this.tbSide2.Location = new System.Drawing.Point(76, 38);
            this.tbSide2.Name = "tbSide2";
            this.tbSide2.Size = new System.Drawing.Size(100, 20);
            this.tbSide2.TabIndex = 6;
            // 
            // tbSide3
            // 
            this.tbSide3.Location = new System.Drawing.Point(76, 64);
            this.tbSide3.Name = "tbSide3";
            this.tbSide3.Size = new System.Drawing.Size(100, 20);
            this.tbSide3.TabIndex = 7;
            // 
            // lArea
            // 
            this.lArea.AutoSize = true;
            this.lArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lArea.Location = new System.Drawing.Point(175, 124);
            this.lArea.Name = "lArea";
            this.lArea.Size = new System.Drawing.Size(0, 20);
            this.lArea.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 153);
            this.Controls.Add(this.lArea);
            this.Controls.Add(this.tbSide3);
            this.Controls.Add(this.tbSide2);
            this.Controls.Add(this.tbSide1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Расчет площади треугольника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSide1;
        private System.Windows.Forms.TextBox tbSide2;
        private System.Windows.Forms.TextBox tbSide3;
        private System.Windows.Forms.Label lArea;
    }
}

