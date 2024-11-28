namespace TecladoVirtual.Telas
{
    partial class F_FeedbackGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_FeedbackGeral));
            btnRetornar = new Button();
            lblTextoFeedbackGeral = new Label();
            lblVisitantes = new Label();
            lblAcertos = new Label();
            lblNumeroVisitante = new Label();
            lblNumeroAcertos = new Label();
            lblNome = new Label();
            lblIdade = new Label();
            lblMedia = new Label();
            lblMediaDasPerguntas = new Label();
            SuspendLayout();
            // 
            // btnRetornar
            // 
            btnRetornar.Anchor = AnchorStyles.Right;
            btnRetornar.BackColor = Color.Transparent;
            btnRetornar.FlatAppearance.BorderSize = 3;
            btnRetornar.FlatStyle = FlatStyle.Popup;
            btnRetornar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetornar.ForeColor = SystemColors.Window;
            btnRetornar.Image = (Image)resources.GetObject("btnRetornar.Image");
            btnRetornar.Location = new Point(835, 404);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(150, 144);
            btnRetornar.TabIndex = 11;
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // lblTextoFeedbackGeral
            // 
            lblTextoFeedbackGeral.Anchor = AnchorStyles.None;
            lblTextoFeedbackGeral.AutoSize = true;
            lblTextoFeedbackGeral.BackColor = Color.Transparent;
            lblTextoFeedbackGeral.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoFeedbackGeral.ForeColor = SystemColors.Window;
            lblTextoFeedbackGeral.Location = new Point(131, 96);
            lblTextoFeedbackGeral.Name = "lblTextoFeedbackGeral";
            lblTextoFeedbackGeral.Size = new Size(919, 73);
            lblTextoFeedbackGeral.TabIndex = 12;
            lblTextoFeedbackGeral.Text = "RELATÓRIO DE RESPOSTAS";
            lblTextoFeedbackGeral.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVisitantes
            // 
            lblVisitantes.Anchor = AnchorStyles.None;
            lblVisitantes.AutoSize = true;
            lblVisitantes.BackColor = Color.Transparent;
            lblVisitantes.Font = new Font("Microsoft Sans Serif", 27.75F);
            lblVisitantes.ForeColor = SystemColors.Window;
            lblVisitantes.Location = new Point(254, 280);
            lblVisitantes.Name = "lblVisitantes";
            lblVisitantes.Size = new Size(180, 42);
            lblVisitantes.TabIndex = 13;
            lblVisitantes.Text = "Visitantes";
            lblVisitantes.TextAlign = ContentAlignment.MiddleCenter;
            lblVisitantes.Click += label1_Click;
            // 
            // lblAcertos
            // 
            lblAcertos.Anchor = AnchorStyles.None;
            lblAcertos.AutoSize = true;
            lblAcertos.BackColor = Color.Transparent;
            lblAcertos.Font = new Font("Microsoft Sans Serif", 27.75F);
            lblAcertos.ForeColor = SystemColors.Window;
            lblAcertos.Location = new Point(614, 280);
            lblAcertos.Name = "lblAcertos";
            lblAcertos.Size = new Size(177, 42);
            lblAcertos.TabIndex = 14;
            lblAcertos.Text = "Média(%)";
            lblAcertos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumeroVisitante
            // 
            lblNumeroVisitante.Anchor = AnchorStyles.None;
            lblNumeroVisitante.AutoSize = true;
            lblNumeroVisitante.BackColor = Color.Transparent;
            lblNumeroVisitante.Font = new Font("Microsoft Sans Serif", 27.75F);
            lblNumeroVisitante.ForeColor = SystemColors.Window;
            lblNumeroVisitante.Location = new Point(307, 323);
            lblNumeroVisitante.Name = "lblNumeroVisitante";
            lblNumeroVisitante.Size = new Size(39, 42);
            lblNumeroVisitante.TabIndex = 15;
            lblNumeroVisitante.Text = "0";
            lblNumeroVisitante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumeroAcertos
            // 
            lblNumeroAcertos.Anchor = AnchorStyles.None;
            lblNumeroAcertos.AutoSize = true;
            lblNumeroAcertos.BackColor = Color.Transparent;
            lblNumeroAcertos.Font = new Font("Microsoft Sans Serif", 27.75F);
            lblNumeroAcertos.ForeColor = SystemColors.Window;
            lblNumeroAcertos.Location = new Point(657, 323);
            lblNumeroAcertos.Name = "lblNumeroAcertos";
            lblNumeroAcertos.Size = new Size(39, 42);
            lblNumeroAcertos.TabIndex = 16;
            lblNumeroAcertos.Text = "0";
            lblNumeroAcertos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.None;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Microsoft Sans Serif", 27.75F);
            lblNome.ForeColor = SystemColors.Window;
            lblNome.Location = new Point(157, 203);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(117, 42);
            lblNome.TabIndex = 17;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIdade
            // 
            lblIdade.Anchor = AnchorStyles.None;
            lblIdade.AutoSize = true;
            lblIdade.BackColor = Color.Transparent;
            lblIdade.Font = new Font("Microsoft Sans Serif", 27.75F);
            lblIdade.ForeColor = SystemColors.Window;
            lblIdade.Location = new Point(468, 203);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(111, 42);
            lblIdade.TabIndex = 18;
            lblIdade.Text = "Idade";
            lblIdade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMedia
            // 
            lblMedia.Anchor = AnchorStyles.None;
            lblMedia.AutoSize = true;
            lblMedia.BackColor = Color.Transparent;
            lblMedia.Font = new Font("Microsoft Sans Serif", 27.75F);
            lblMedia.ForeColor = SystemColors.Window;
            lblMedia.Location = new Point(722, 203);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(202, 42);
            lblMedia.TabIndex = 19;
            lblMedia.Text = "Acertos(%)";
            lblMedia.TextAlign = ContentAlignment.MiddleCenter;
            lblMedia.Click += label3_Click;
            // 
            // lblMediaDasPerguntas
            // 
            lblMediaDasPerguntas.Anchor = AnchorStyles.None;
            lblMediaDasPerguntas.AutoSize = true;
            lblMediaDasPerguntas.BackColor = Color.Transparent;
            lblMediaDasPerguntas.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMediaDasPerguntas.ForeColor = SystemColors.Window;
            lblMediaDasPerguntas.Location = new Point(254, 458);
            lblMediaDasPerguntas.Name = "lblMediaDasPerguntas";
            lblMediaDasPerguntas.Size = new Size(266, 31);
            lblMediaDasPerguntas.TabIndex = 21;
            lblMediaDasPerguntas.Text = "Media das perguntas";
            // 
            // F_FeedbackGeral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1069, 621);
            ControlBox = false;
            Controls.Add(lblMediaDasPerguntas);
            Controls.Add(lblMedia);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Controls.Add(lblNumeroAcertos);
            Controls.Add(lblNumeroVisitante);
            Controls.Add(lblAcertos);
            Controls.Add(lblVisitantes);
            Controls.Add(lblTextoFeedbackGeral);
            Controls.Add(btnRetornar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_FeedbackGeral";
            Text = "F_FeedbackGeral";
            Load += F_FeedbackGeral_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetornar;
        private Label lblTextoFeedbackGeral;
        private Label lblVisitantes;
        private Label lblAcertos;
        private Label lblNumeroVisitante;
        private Label lblNumeroAcertos;
        public Label lblNome;
        public Label lblIdade;
        public Label lblMedia;
        private Label lblMediaDasPerguntas;
    }
}