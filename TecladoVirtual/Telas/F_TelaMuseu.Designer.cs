﻿namespace TecladoVirtual.Telas
{
    partial class F_TelaMuseu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TelaMuseu));
            lblTextoMuseu1 = new Label();
            btnVoltarMuseu = new Button();
            lblTextoMuseu2 = new Label();
            SuspendLayout();
            // 
            // lblTextoMuseu1
            // 
            lblTextoMuseu1.Anchor = AnchorStyles.Top;
            lblTextoMuseu1.AutoSize = true;
            lblTextoMuseu1.BackColor = Color.Transparent;
            lblTextoMuseu1.Font = new Font("Microsoft Sans Serif", 24F);
            lblTextoMuseu1.ForeColor = SystemColors.Window;
            lblTextoMuseu1.Location = new Point(105, -7);
            lblTextoMuseu1.Name = "lblTextoMuseu1";
            lblTextoMuseu1.Size = new Size(981, 148);
            lblTextoMuseu1.TabIndex = 0;
            lblTextoMuseu1.Text = resources.GetString("lblTextoMuseu1.Text");
            lblTextoMuseu1.TextAlign = ContentAlignment.MiddleLeft;
            lblTextoMuseu1.Click += lblTextoMuseu1_Click;
            // 
            // btnVoltarMuseu
            // 
            btnVoltarMuseu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltarMuseu.BackColor = Color.Transparent;
            btnVoltarMuseu.Cursor = Cursors.Hand;
            btnVoltarMuseu.FlatAppearance.BorderSize = 3;
            btnVoltarMuseu.FlatStyle = FlatStyle.Popup;
            btnVoltarMuseu.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarMuseu.ForeColor = SystemColors.Window;
            btnVoltarMuseu.Image = (Image)resources.GetObject("btnVoltarMuseu.Image");
            btnVoltarMuseu.Location = new Point(1057, 593);
            btnVoltarMuseu.Name = "btnVoltarMuseu";
            btnVoltarMuseu.Size = new Size(150, 132);
            btnVoltarMuseu.TabIndex = 2;
            btnVoltarMuseu.UseVisualStyleBackColor = false;
            btnVoltarMuseu.Click += btnVoltarMuseu_Click;
            // 
            // lblTextoMuseu2
            // 
            lblTextoMuseu2.Anchor = AnchorStyles.None;
            lblTextoMuseu2.AutoSize = true;
            lblTextoMuseu2.BackColor = Color.Transparent;
            lblTextoMuseu2.Font = new Font("Microsoft Sans Serif", 24F);
            lblTextoMuseu2.ForeColor = SystemColors.Window;
            lblTextoMuseu2.Location = new Point(22, 181);
            lblTextoMuseu2.Name = "lblTextoMuseu2";
            lblTextoMuseu2.Size = new Size(1132, 444);
            lblTextoMuseu2.TabIndex = 3;
            lblTextoMuseu2.Text = resources.GetString("lblTextoMuseu2.Text");
            lblTextoMuseu2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F_TelaMuseu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1248, 726);
            ControlBox = false;
            Controls.Add(btnVoltarMuseu);
            Controls.Add(lblTextoMuseu2);
            Controls.Add(lblTextoMuseu1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_TelaMuseu";
            Text = "F_TelaMuseu";
            Load += F_TelaMuseu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoMuseu1;
        private Button btnVoltarMuseu;
        private Label lblTextoMuseu2;
    }
}