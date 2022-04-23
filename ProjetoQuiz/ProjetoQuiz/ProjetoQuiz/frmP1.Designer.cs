namespace ProjetoQuiz
{
    partial class frmP1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbtnCerta = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonProximo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(51, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual o buraco mais profundo no ocenao?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.rbtnCerta);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(51, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton4.Location = new System.Drawing.Point(20, 180);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(118, 28);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Lago Ness";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton3.Location = new System.Drawing.Point(20, 123);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(159, 28);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Foça do rio nilo";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbtnCerta
            // 
            this.rbtnCerta.AutoSize = true;
            this.rbtnCerta.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtnCerta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnCerta.Location = new System.Drawing.Point(20, 76);
            this.rbtnCerta.Name = "rbtnCerta";
            this.rbtnCerta.Size = new System.Drawing.Size(187, 28);
            this.rbtnCerta.TabIndex = 1;
            this.rbtnCerta.TabStop = true;
            this.rbtnCerta.Text = "Foça das Marianas";
            this.rbtnCerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnCerta.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(20, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(151, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Casa do nemo";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonProximo
            // 
            this.buttonProximo.BackColor = System.Drawing.Color.IndianRed;
            this.buttonProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProximo.Location = new System.Drawing.Point(537, 391);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(131, 38);
            this.buttonProximo.TabIndex = 0;
            this.buttonProximo.Text = "Próximo";
            this.buttonProximo.UseVisualStyleBackColor = false;
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            // 
            // frmP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoQuiz.Properties.Resources.fossa_das_marianas_profundo_752x440;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.buttonProximo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmP1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonProximo;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbtnCerta;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}