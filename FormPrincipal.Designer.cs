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
            btnAumentarI40 = new Button();
            btnAumentarHue30 = new Button();
            btnSegHUE = new Button();
            numericUpDownHue = new NumericUpDown();
            numericUpDownHue2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrigem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBrilho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHue2).BeginInit();
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
            btImagemOriginal.Location = new Point(245, 541);
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
            // btnAumentarI40
            // 
            btnAumentarI40.Location = new Point(750, 534);
            btnAumentarI40.Name = "btnAumentarI40";
            btnAumentarI40.Size = new Size(130, 25);
            btnAumentarI40.TabIndex = 22;
            btnAumentarI40.Text = "Aumentar I 40%";
            btnAumentarI40.UseVisualStyleBackColor = true;
            btnAumentarI40.Click += btnAumentarI40_Click;
            // 
            // btnAumentarHue30
            // 
            btnAumentarHue30.Location = new Point(750, 563);
            btnAumentarHue30.Name = "btnAumentarHue30";
            btnAumentarHue30.Size = new Size(130, 25);
            btnAumentarHue30.TabIndex = 23;
            btnAumentarHue30.Text = "Aumentar Hue 30°";
            btnAumentarHue30.UseVisualStyleBackColor = true;
            btnAumentarHue30.Click += btnAumentarHue30_Click;
            // 
            // btnSegHUE
            // 
            btnSegHUE.Location = new Point(899, 565);
            btnSegHUE.Name = "btnSegHUE";
            btnSegHUE.Size = new Size(120, 23);
            btnSegHUE.TabIndex = 24;
            btnSegHUE.Text = "Segmentar HUE";
            btnSegHUE.UseVisualStyleBackColor = true;
            btnSegHUE.Click += btnSegHUE_Click;
            // 
            // numericUpDownHue
            // 
            numericUpDownHue.Location = new Point(899, 537);
            numericUpDownHue.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDownHue.Name = "numericUpDownHue";
            numericUpDownHue.Size = new Size(52, 23);
            numericUpDownHue.TabIndex = 25;
            // 
            // numericUpDownHue2
            // 
            numericUpDownHue2.Location = new Point(964, 536);
            numericUpDownHue2.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDownHue2.Name = "numericUpDownHue2";
            numericUpDownHue2.Size = new Size(52, 23);
            numericUpDownHue2.TabIndex = 26;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 629);
            Controls.Add(numericUpDownHue2);
            Controls.Add(numericUpDownHue);
            Controls.Add(btnSegHUE);
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
            Controls.Add(btnLuminancia);
            Controls.Add(btnAbirImg);
            Controls.Add(pictureBoxDestino);
            Controls.Add(pictureBoxOrigem);
            Controls.Add(btnAumentarI40);
            Controls.Add(btnAumentarHue30);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrigem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestino).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBrilho).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHue2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private PictureBox pictureBoxOrigem;
        private PictureBox pictureBoxDestino;
        private Button btnAbirImg;
        private Button btnLuminancia;
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
        private Button btnAumentarI40;
        private Button btnAumentarHue30;
        private Button btnSegHUE;
        private NumericUpDown numericUpDownHue;
        private NumericUpDown numericUpDownHue2;
    }
}
