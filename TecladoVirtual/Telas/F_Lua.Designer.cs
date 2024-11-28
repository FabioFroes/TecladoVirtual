namespace TecladoVirtual.Telas
{
    partial class F_Lua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Lua));
            lblTextoLua = new Label();
            btnVoltarLua = new Button();
            btnAvancarLua2 = new Button();
            lblInfo2Lua1 = new Label();
            SuspendLayout();
            // 
            // lblTextoLua
            // 
            lblTextoLua.AutoSize = true;
            lblTextoLua.BackColor = Color.Transparent;
            lblTextoLua.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoLua.ForeColor = SystemColors.Window;
            lblTextoLua.Location = new Point(28, 22);
            lblTextoLua.Name = "lblTextoLua";
            lblTextoLua.Size = new Size(1163, 156);
            lblTextoLua.TabIndex = 0;
            lblTextoLua.Text = resources.GetString("lblTextoLua.Text");
            lblTextoLua.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnVoltarLua
            // 
            btnVoltarLua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltarLua.BackColor = Color.Transparent;
            btnVoltarLua.FlatAppearance.BorderSize = 3;
            btnVoltarLua.FlatStyle = FlatStyle.Popup;
            btnVoltarLua.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarLua.ForeColor = SystemColors.Window;
            btnVoltarLua.Image = (Image)resources.GetObject("btnVoltarLua.Image");
            btnVoltarLua.Location = new Point(81, 571);
            btnVoltarLua.Name = "btnVoltarLua";
            btnVoltarLua.Size = new Size(150, 129);
            btnVoltarLua.TabIndex = 3;
            btnVoltarLua.UseVisualStyleBackColor = false;
            btnVoltarLua.Click += btnVoltarLua_Click;
            // 
            // btnAvancarLua2
            // 
            btnAvancarLua2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAvancarLua2.BackColor = Color.Transparent;
            btnAvancarLua2.FlatAppearance.BorderSize = 3;
            btnAvancarLua2.FlatStyle = FlatStyle.Popup;
            btnAvancarLua2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarLua2.ForeColor = SystemColors.Window;
            btnAvancarLua2.Image = (Image)resources.GetObject("btnAvancarLua2.Image");
            btnAvancarLua2.Location = new Point(993, 571);
            btnAvancarLua2.Name = "btnAvancarLua2";
            btnAvancarLua2.Size = new Size(150, 129);
            btnAvancarLua2.TabIndex = 6;
            btnAvancarLua2.UseVisualStyleBackColor = false;
            btnAvancarLua2.Click += btnAvancarLua2_Click;
            // 
            // lblInfo2Lua1
            // 
            lblInfo2Lua1.Anchor = AnchorStyles.None;
            lblInfo2Lua1.AutoSize = true;
            lblInfo2Lua1.BackColor = Color.Transparent;
            lblInfo2Lua1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo2Lua1.ForeColor = SystemColors.Window;
            lblInfo2Lua1.Location = new Point(28, 217);
            lblInfo2Lua1.Name = "lblInfo2Lua1";
            lblInfo2Lua1.Size = new Size(1037, 351);
            lblInfo2Lua1.TabIndex = 7;
            lblInfo2Lua1.Text = resources.GetString("lblInfo2Lua1.Text");
            lblInfo2Lua1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // F_Lua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1231, 715);
            ControlBox = false;
            Controls.Add(btnAvancarLua2);
            Controls.Add(btnVoltarLua);
            Controls.Add(lblTextoLua);
            Controls.Add(lblInfo2Lua1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Lua";
            Text = "F_Lua";
            Load += F_Lua_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoLua;
        private Button btnVoltarLua;
        private Button btnAvancarLua2;
        private Label lblInfo2Lua1;
    }
}