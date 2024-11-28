namespace TecladoVirtual
{
    partial class F_TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TelaPrincipal));
            lblTextoPrincipal = new Label();
            btnAvancar1 = new Button();
            SuspendLayout();
            // 
            // lblTextoPrincipal
            // 
            lblTextoPrincipal.Anchor = AnchorStyles.None;
            lblTextoPrincipal.AutoSize = true;
            lblTextoPrincipal.BackColor = Color.Transparent;
            lblTextoPrincipal.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoPrincipal.ForeColor = SystemColors.Window;
            lblTextoPrincipal.Location = new Point(12, 9);
            lblTextoPrincipal.Name = "lblTextoPrincipal";
            lblTextoPrincipal.Size = new Size(781, 330);
            lblTextoPrincipal.TabIndex = 0;
            lblTextoPrincipal.Text = "Seja bem vindo(a) ao nosso Museu\r\nMultitemático!\r\n\r\nApresentaremos para você\r\n o planeta vermelho:\r\nMARTE\r\n";
            lblTextoPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            lblTextoPrincipal.Click += lblTextoPrincipal_Click;
            // 
            // btnAvancar1
            // 
            btnAvancar1.Anchor = AnchorStyles.Bottom;
            btnAvancar1.BackColor = Color.Transparent;
            btnAvancar1.BackgroundImageLayout = ImageLayout.Center;
            btnAvancar1.Cursor = Cursors.Hand;
            btnAvancar1.FlatAppearance.BorderColor = SystemColors.Window;
            btnAvancar1.FlatAppearance.BorderSize = 3;
            btnAvancar1.FlatStyle = FlatStyle.Popup;
            btnAvancar1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancar1.ForeColor = SystemColors.Window;
            btnAvancar1.Image = (Image)resources.GetObject("btnAvancar1.Image");
            btnAvancar1.Location = new Point(332, 341);
            btnAvancar1.Margin = new Padding(3, 2, 3, 2);
            btnAvancar1.Name = "btnAvancar1";
            btnAvancar1.Size = new Size(137, 139);
            btnAvancar1.TabIndex = 1;
            btnAvancar1.UseVisualStyleBackColor = false;
            btnAvancar1.Click += btn1_Click;
            // 
            // F_TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 480);
            Controls.Add(btnAvancar1);
            Controls.Add(lblTextoPrincipal);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_TelaPrincipal";
            RightToLeft = RightToLeft.No;
            Text = "Totem Museu";
            Load += F_TelaPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTextoPrincipal;
        private Button btnAvancar1;
    }
}
