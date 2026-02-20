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
            lbRgb = new Label();
            label2 = new Label();
            label1 = new Label();
            lbCmy = new Label();
            label4 = new Label();
            lbHsi = new Label();
            tbBrilho = new TrackBar();
            lbBrilho = new Label();
            btImagemOriginal = new Button();
            btDiminuiI = new Button();
            btAumentaI = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrigem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBrilho).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxOrigem
            // 
            pictureBoxOrigem.Location = new Point(12, 12);
            pictureBoxOrigem.Name = "pictureBoxOrigem";
            pictureBoxOrigem.Size = new Size(571, 521);
            pictureBoxOrigem.TabIndex = 0;
            pictureBoxOrigem.TabStop = false;
            pictureBoxOrigem.MouseMove += pictureBoxOrigem_MouseMove;
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
            btnLuminancia.Size = new Size(115, 25);
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
            // lbRgb
            // 
            lbRgb.AutoSize = true;
            lbRgb.Location = new Point(397, 539);
            lbRgb.Name = "lbRgb";
            lbRgb.Size = new Size(39, 15);
            lbRgb.TabIndex = 10;
            lbRgb.Text = "(0,0,0)";
            lbRgb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(359, 539);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 11;
            label2.Text = "RGB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(359, 554);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 13;
            label1.Text = "CMY";
            // 
            // lbCmy
            // 
            lbCmy.AutoSize = true;
            lbCmy.Location = new Point(397, 554);
            lbCmy.Name = "lbCmy";
            lbCmy.Size = new Size(39, 15);
            lbCmy.TabIndex = 12;
            lbCmy.Text = "(0,0,0)";
            lbCmy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(359, 569);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 15;
            label4.Text = "HSI";
            // 
            // lbHsi
            // 
            lbHsi.AutoSize = true;
            lbHsi.Location = new Point(397, 569);
            lbHsi.Name = "lbHsi";
            lbHsi.Size = new Size(39, 15);
            lbHsi.TabIndex = 14;
            lbHsi.Text = "(0,0,0)";
            lbHsi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbBrilho
            // 
            tbBrilho.Anchor = AnchorStyles.None;
            tbBrilho.Location = new Point(586, 554);
            tbBrilho.Maximum = 100;
            tbBrilho.Name = "tbBrilho";
            tbBrilho.Size = new Size(104, 45);
            tbBrilho.TabIndex = 16;
            tbBrilho.Value = 10;
            tbBrilho.Scroll += tbBrilho_Scroll;
            // 
            // lbBrilho
            // 
            lbBrilho.AutoSize = true;
            lbBrilho.Location = new Point(696, 562);
            lbBrilho.Name = "lbBrilho";
            lbBrilho.Size = new Size(19, 15);
            lbBrilho.TabIndex = 17;
            lbBrilho.Text = "10";
            lbBrilho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btImagemOriginal
            // 
            btImagemOriginal.Location = new Point(12, 570);
            btImagemOriginal.Name = "btImagemOriginal";
            btImagemOriginal.Size = new Size(106, 23);
            btImagemOriginal.TabIndex = 18;
            btImagemOriginal.Text = "Imagem Original";
            btImagemOriginal.UseVisualStyleBackColor = true;
            btImagemOriginal.Click += btImagemOriginal_Click;
            // 
            // btDiminuiI
            // 
            btDiminuiI.Location = new Point(504, 563);
            btDiminuiI.Name = "btDiminuiI";
            btDiminuiI.Size = new Size(50, 23);
            btDiminuiI.TabIndex = 20;
            btDiminuiI.Text = "I-";
            btDiminuiI.UseVisualStyleBackColor = true;
            btDiminuiI.Click += btDiminuiI_Click;
            // 
            // btAumentaI
            // 
            btAumentaI.AutoSize = true;
            btAumentaI.Location = new Point(504, 534);
            btAumentaI.Name = "btAumentaI";
            btAumentaI.Size = new Size(50, 25);
            btAumentaI.TabIndex = 19;
            btAumentaI.Text = "I+";
            btAumentaI.UseVisualStyleBackColor = true;
            btAumentaI.Click += btAumentaI_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(566, 536);
            label3.Name = "label3";
            label3.Size = new Size(155, 15);
            label3.TabIndex = 21;
            label3.Text = "Porcentagem para alteracao";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 629);
            Controls.Add(label3);
            Controls.Add(btDiminuiI);
            Controls.Add(btAumentaI);
            Controls.Add(btImagemOriginal);
            Controls.Add(lbBrilho);
            Controls.Add(tbBrilho);
            Controls.Add(label4);
            Controls.Add(lbHsi);
            Controls.Add(label1);
            Controls.Add(lbCmy);
            Controls.Add(label2);
            Controls.Add(lbRgb);
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
            ((System.ComponentModel.ISupportInitialize)tbBrilho).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lbRgb;
        private Label label2;
        private Label label1;
        private Label lbCmy;
        private Label label4;
        private Label lbHsi;
        private TrackBar tbBrilho;
        private Label lbBrilho;
        private Button btImagemOriginal;
        private Button btDiminuiI;
        private Button btAumentaI;
        private Label label3;
    }
}
