namespace TecladoVirtual.Telas
{
    partial class F_QInstrucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_QInstrucao));
            lblTextoInstrucao = new Label();
            btnVoltarInstrucao = new Button();
            btnAvancarInstrucao = new Button();
            lblBOASORTE = new Label();
            SuspendLayout();
            // 
            // lblTextoInstrucao
            // 
            lblTextoInstrucao.Anchor = AnchorStyles.None;
            lblTextoInstrucao.AutoSize = true;
            lblTextoInstrucao.BackColor = Color.Transparent;
            lblTextoInstrucao.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoInstrucao.ForeColor = Color.Transparent;
            lblTextoInstrucao.Location = new Point(23, 103);
            lblTextoInstrucao.Name = "lblTextoInstrucao";
            lblTextoInstrucao.Size = new Size(1039, 294);
            lblTextoInstrucao.TabIndex = 0;
            lblTextoInstrucao.Text = resources.GetString("lblTextoInstrucao.Text");
            lblTextoInstrucao.TextAlign = ContentAlignment.MiddleCenter;
            lblTextoInstrucao.Click += lblTextoInstrucao_Click;
            // 
            // btnVoltarInstrucao
            // 
            btnVoltarInstrucao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltarInstrucao.BackColor = Color.Transparent;
            btnVoltarInstrucao.FlatAppearance.BorderSize = 3;
            btnVoltarInstrucao.FlatStyle = FlatStyle.Popup;
            btnVoltarInstrucao.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarInstrucao.ForeColor = SystemColors.Window;
            btnVoltarInstrucao.Image = (Image)resources.GetObject("btnVoltarInstrucao.Image");
            btnVoltarInstrucao.Location = new Point(61, 518);
            btnVoltarInstrucao.Name = "btnVoltarInstrucao";
            btnVoltarInstrucao.Size = new Size(150, 133);
            btnVoltarInstrucao.TabIndex = 1;
            btnVoltarInstrucao.UseVisualStyleBackColor = false;
            btnVoltarInstrucao.Click += btnVoltarInstrucao_Click;
            // 
            // btnAvancarInstrucao
            // 
            btnAvancarInstrucao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAvancarInstrucao.BackColor = Color.Transparent;
            btnAvancarInstrucao.FlatAppearance.BorderSize = 3;
            btnAvancarInstrucao.FlatStyle = FlatStyle.Popup;
            btnAvancarInstrucao.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarInstrucao.ForeColor = SystemColors.Window;
            btnAvancarInstrucao.Image = (Image)resources.GetObject("btnAvancarInstrucao.Image");
            btnAvancarInstrucao.Location = new Point(884, 508);
            btnAvancarInstrucao.Name = "btnAvancarInstrucao";
            btnAvancarInstrucao.Size = new Size(150, 148);
            btnAvancarInstrucao.TabIndex = 2;
            btnAvancarInstrucao.UseVisualStyleBackColor = false;
            btnAvancarInstrucao.Click += btnAvancarInstrucao_Click;
            // 
            // lblBOASORTE
            // 
            lblBOASORTE.Anchor = AnchorStyles.None;
            lblBOASORTE.AutoSize = true;
            lblBOASORTE.BackColor = Color.Transparent;
            lblBOASORTE.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBOASORTE.ForeColor = SystemColors.Window;
            lblBOASORTE.Location = new Point(351, 465);
            lblBOASORTE.Name = "lblBOASORTE";
            lblBOASORTE.Size = new Size(424, 73);
            lblBOASORTE.TabIndex = 3;
            lblBOASORTE.Text = "BOA SORTE!";
            lblBOASORTE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F_QInstrucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1091, 668);
            ControlBox = false;
            Controls.Add(lblBOASORTE);
            Controls.Add(btnAvancarInstrucao);
            Controls.Add(btnVoltarInstrucao);
            Controls.Add(lblTextoInstrucao);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_QInstrucao";
            Text = "F_QInstrucao";
            Load += F_QInstrucao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoInstrucao;
        private Button btnVoltarInstrucao;
        private Button btnAvancarInstrucao;
        private Label lblBOASORTE;
    }
}