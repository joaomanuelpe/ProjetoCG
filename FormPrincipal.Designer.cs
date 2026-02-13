namespace ProjCG
{
    partial class FormPrincipal
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
            pictureBoxOrigem = new PictureBox();
            pictureBoxDestino = new PictureBox();
            btnAbirImg = new Button();
            btnLuminancia = new Button();
            btnR = new Button();
            btnG = new Button();
            btnB = new Button();
            btnRmenos = new Button();
            btnGmenos = new Button();
            btnBmenos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrigem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestino).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxOrigem
            // 
            pictureBoxOrigem.Location = new Point(12, 12);
            pictureBoxOrigem.Name = "pictureBoxOrigem";
            pictureBoxOrigem.Size = new Size(571, 521);
            pictureBoxOrigem.TabIndex = 0;
            pictureBoxOrigem.TabStop = false;
            // 
            // pictureBoxDestino
            // 
            pictureBoxDestino.Location = new Point(601, 12);
            pictureBoxDestino.Name = "pictureBoxDestino";
            pictureBoxDestino.Size = new Size(548, 521);
            pictureBoxDestino.TabIndex = 1;
            pictureBoxDestino.TabStop = false;
            // 
            // btnAbirImg
            // 
            btnAbirImg.Location = new Point(12, 539);
            btnAbirImg.Name = "btnAbirImg";
            btnAbirImg.Size = new Size(106, 23);
            btnAbirImg.TabIndex = 2;
            btnAbirImg.Text = "Abrir Imagem";
            btnAbirImg.UseVisualStyleBackColor = true;
            btnAbirImg.Click += btnAbirImg_Click;
            // 
            // btnLuminancia
            // 
            btnLuminancia.Location = new Point(124, 539);
            btnLuminancia.Name = "btnLuminancia";
            btnLuminancia.Size = new Size(115, 23);
            btnLuminancia.TabIndex = 3;
            btnLuminancia.Text = "Luminância";
            btnLuminancia.UseVisualStyleBackColor = true;
            btnLuminancia.Click += btnLuminancia_Click;
            // 
            // btnR
            // 
            btnR.Location = new Point(245, 539);
            btnR.Name = "btnR";
            btnR.Size = new Size(35, 23);
            btnR.TabIndex = 4;
            btnR.Text = "R+";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // btnG
            // 
            btnG.Location = new Point(278, 539);
            btnG.Name = "btnG";
            btnG.Size = new Size(34, 23);
            btnG.TabIndex = 5;
            btnG.Text = "G+";
            btnG.UseVisualStyleBackColor = true;
            btnG.Click += btnG_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(310, 539);
            btnB.Name = "btnB";
            btnB.Size = new Size(38, 23);
            btnB.TabIndex = 6;
            btnB.Text = "B+";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnRmenos
            // 
            btnRmenos.Location = new Point(245, 568);
            btnRmenos.Name = "btnRmenos";
            btnRmenos.Size = new Size(35, 23);
            btnRmenos.TabIndex = 7;
            btnRmenos.Text = "R-";
            btnRmenos.UseVisualStyleBackColor = true;
            btnRmenos.Click += btnRmenos_Click;
            // 
            // btnGmenos
            // 
            btnGmenos.Location = new Point(278, 568);
            btnGmenos.Name = "btnGmenos";
            btnGmenos.Size = new Size(34, 23);
            btnGmenos.TabIndex = 8;
            btnGmenos.Text = "G-";
            btnGmenos.UseVisualStyleBackColor = true;
            btnGmenos.Click += btnGmenos_Click;
            // 
            // btnBmenos
            // 
            btnBmenos.Location = new Point(310, 568);
            btnBmenos.Name = "btnBmenos";
            btnBmenos.Size = new Size(38, 23);
            btnBmenos.TabIndex = 9;
            btnBmenos.Text = "B-";
            btnBmenos.UseVisualStyleBackColor = true;
            btnBmenos.Click += btnBmenos_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 629);
            Controls.Add(btnBmenos);
            Controls.Add(btnGmenos);
            Controls.Add(btnRmenos);
            Controls.Add(btnB);
            Controls.Add(btnG);
            Controls.Add(btnR);
            Controls.Add(btnLuminancia);
            Controls.Add(btnAbirImg);
            Controls.Add(pictureBoxDestino);
            Controls.Add(pictureBoxOrigem);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrigem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestino).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private PictureBox pictureBoxOrigem;
        private PictureBox pictureBoxDestino;
        private Button btnAbirImg;
        private Button btnLuminancia;
        private Button btnR;
        private Button btnG;
        private Button btnB;
        private Button btnRmenos;
        private Button btnGmenos;
        private Button btnBmenos;
    }
}
