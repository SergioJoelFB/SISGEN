namespace LoginPage
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.UsuarioTx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ContraTx = new MetroFramework.Controls.MetroTextBox();
            this.NuevoUsuario = new MetroFramework.Controls.MetroButton();
            this.IniciarBt = new MetroFramework.Controls.MetroButton();
            this.OlvContra = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(763, 97);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(349, 36);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(50, 20, 50, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "SISGEN";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // UsuarioTx
            // 
            this.UsuarioTx.BackColor = System.Drawing.Color.Peru;
            // 
            // 
            // 
            this.UsuarioTx.CustomButton.Image = null;
            this.UsuarioTx.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.UsuarioTx.CustomButton.Name = "";
            this.UsuarioTx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsuarioTx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsuarioTx.CustomButton.TabIndex = 1;
            this.UsuarioTx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsuarioTx.CustomButton.UseSelectable = true;
            this.UsuarioTx.CustomButton.Visible = false;
            this.UsuarioTx.Lines = new string[0];
            this.UsuarioTx.Location = new System.Drawing.Point(298, 201);
            this.UsuarioTx.MaxLength = 32767;
            this.UsuarioTx.Name = "UsuarioTx";
            this.UsuarioTx.PasswordChar = '\0';
            this.UsuarioTx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsuarioTx.SelectedText = "";
            this.UsuarioTx.SelectionLength = 0;
            this.UsuarioTx.SelectionStart = 0;
            this.UsuarioTx.ShortcutsEnabled = true;
            this.UsuarioTx.Size = new System.Drawing.Size(175, 23);
            this.UsuarioTx.TabIndex = 1;
            this.UsuarioTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsuarioTx.UseSelectable = true;
            this.UsuarioTx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsuarioTx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Orange;
            this.metroLabel2.Location = new System.Drawing.Point(350, 160);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Usuario";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.Orange;
            this.metroLabel3.Location = new System.Drawing.Point(331, 253);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 25);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Contraseña";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // ContraTx
            // 
            // 
            // 
            // 
            this.ContraTx.CustomButton.Image = null;
            this.ContraTx.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.ContraTx.CustomButton.Name = "";
            this.ContraTx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ContraTx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ContraTx.CustomButton.TabIndex = 1;
            this.ContraTx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ContraTx.CustomButton.UseSelectable = true;
            this.ContraTx.CustomButton.Visible = false;
            this.ContraTx.Lines = new string[0];
            this.ContraTx.Location = new System.Drawing.Point(298, 293);
            this.ContraTx.MaxLength = 32767;
            this.ContraTx.Name = "ContraTx";
            this.ContraTx.PasswordChar = '*';
            this.ContraTx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ContraTx.SelectedText = "";
            this.ContraTx.SelectionLength = 0;
            this.ContraTx.SelectionStart = 0;
            this.ContraTx.ShortcutsEnabled = true;
            this.ContraTx.Size = new System.Drawing.Size(175, 23);
            this.ContraTx.TabIndex = 3;
            this.ContraTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContraTx.UseSelectable = true;
            this.ContraTx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ContraTx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NuevoUsuario
            // 
            this.NuevoUsuario.BackColor = System.Drawing.Color.Orange;
            this.NuevoUsuario.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.NuevoUsuario.Location = new System.Drawing.Point(283, 462);
            this.NuevoUsuario.Name = "NuevoUsuario";
            this.NuevoUsuario.Size = new System.Drawing.Size(203, 33);
            this.NuevoUsuario.TabIndex = 5;
            this.NuevoUsuario.Text = "Registrar Nuevo Usuario";
            this.NuevoUsuario.UseCustomBackColor = true;
            this.NuevoUsuario.UseCustomForeColor = true;
            this.NuevoUsuario.UseSelectable = true;
            this.NuevoUsuario.UseStyleColors = true;
            this.NuevoUsuario.Click += new System.EventHandler(this.NuevoUsBt_Click);
            // 
            // IniciarBt
            // 
            this.IniciarBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IniciarBt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.IniciarBt.Location = new System.Drawing.Point(283, 349);
            this.IniciarBt.Name = "IniciarBt";
            this.IniciarBt.Size = new System.Drawing.Size(203, 60);
            this.IniciarBt.TabIndex = 6;
            this.IniciarBt.Text = "Iniciar";
            this.IniciarBt.UseCustomBackColor = true;
            this.IniciarBt.UseCustomForeColor = true;
            this.IniciarBt.UseSelectable = true;
            this.IniciarBt.UseStyleColors = true;
            this.IniciarBt.Click += new System.EventHandler(this.IniciarBt_Click);
            this.IniciarBt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IniciarBt_MouseClick);
            // 
            // OlvContra
            // 
            this.OlvContra.AutoSize = true;
            this.OlvContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OlvContra.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.OlvContra.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.OlvContra.ForeColor = System.Drawing.Color.Orange;
            this.OlvContra.Location = new System.Drawing.Point(274, 534);
            this.OlvContra.Name = "OlvContra";
            this.OlvContra.Size = new System.Drawing.Size(222, 25);
            this.OlvContra.TabIndex = 7;
            this.OlvContra.Text = "Olvidaste tu contraseña?";
            this.OlvContra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OlvContra.UseCustomBackColor = true;
            this.OlvContra.UseCustomForeColor = true;
            this.OlvContra.UseStyleColors = true;
            this.OlvContra.Click += new System.EventHandler(this.OlvidarContra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(7, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sergio Joel Ferreras Derechos Reservados 2017";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OlvContra);
            this.Controls.Add(this.IniciarBt);
            this.Controls.Add(this.NuevoUsuario);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ContraTx);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.UsuarioTx);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(764, 616);
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox UsuarioTx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox ContraTx;
        private MetroFramework.Controls.MetroButton NuevoUsuario;
        private MetroFramework.Controls.MetroButton IniciarBt;
        private MetroFramework.Controls.MetroLabel OlvContra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

