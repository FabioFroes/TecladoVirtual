namespace TecladoVirtual.Telas
{
    partial class F_Lua3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Lua3));
            label1 = new Label();
            btnVoltarLua1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(736, 185);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // btnVoltarLua1
            // 
            btnVoltarLua1.Anchor = AnchorStyles.Right;
            btnVoltarLua1.BackColor = Color.Transparent;
            btnVoltarLua1.FlatAppearance.BorderSize = 3;
            btnVoltarLua1.FlatStyle = FlatStyle.Popup;
            btnVoltarLua1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarLua1.ForeColor = SystemColors.Window;
            btnVoltarLua1.Image = (Image)resources.GetObject("btnVoltarLua1.Image");
            btnVoltarLua1.Location = new Point(964, 391);
            btnVoltarLua1.Name = "btnVoltarLua1";
            btnVoltarLua1.Size = new Size(150, 144);
            btnVoltarLua1.TabIndex = 5;
            btnVoltarLua1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(12, 229);
            label2.Name = "label2";
            label2.Size = new Size(828, 407);
            label2.TabIndex = 6;
            label2.Text = resources.GetString("label2.Text");
            // 
            // F_Lua3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1197, 695);
            ControlBox = false;
            Controls.Add(btnVoltarLua1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Lua3";
            Text = "F_Lua3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVoltarLua1;
        private Label label2;
    }
}