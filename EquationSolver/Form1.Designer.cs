namespace EquationSolver
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nsTheme1 = new NSTheme();
            this.nsContextMenu1 = new NSContextMenu();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nsGroupBox3 = new NSGroupBox();
            this.infobutton = new NSButton();
            this.github = new NSButton();
            this.version = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.x2 = new NSTextBox();
            this.x1 = new NSTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.y2 = new NSTextBox();
            this.y1 = new NSTextBox();
            this.a2 = new NSTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Valider = new NSButton();
            this.a1 = new NSTextBox();
            this.nsGroupBox2 = new NSGroupBox();
            this.nsButton1 = new NSButton();
            this.answer = new System.Windows.Forms.TextBox();
            this.flatMini1 = new theme.FlatMini();
            this.flatClose1 = new theme.FlatClose();
            this.documentation = new NSButton();
            this.nsTheme1.SuspendLayout();
            this.nsContextMenu1.SuspendLayout();
            this.nsGroupBox3.SuspendLayout();
            this.nsGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.ContextMenuStrip = this.nsContextMenu1;
            this.nsTheme1.Controls.Add(this.nsGroupBox3);
            this.nsTheme1.Controls.Add(this.nsGroupBox2);
            this.nsTheme1.Controls.Add(this.flatMini1);
            this.nsTheme1.Controls.Add(this.flatClose1);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(530, 414);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "EquationSolver - Yann Berlemont";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            this.nsTheme1.Click += new System.EventHandler(this.nsTheme1_Click);
            // 
            // nsContextMenu1
            // 
            this.nsContextMenu1.ForeColor = System.Drawing.Color.White;
            this.nsContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youTubeToolStripMenuItem,
            this.faceBookToolStripMenuItem,
            this.discordToolStripMenuItem});
            this.nsContextMenu1.Name = "nsContextMenu1";
            this.nsContextMenu1.Size = new System.Drawing.Size(68, 70);
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // faceBookToolStripMenuItem
            // 
            this.faceBookToolStripMenuItem.Name = "faceBookToolStripMenuItem";
            this.faceBookToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // discordToolStripMenuItem
            // 
            this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            this.discordToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // nsGroupBox3
            // 
            this.nsGroupBox3.Controls.Add(this.documentation);
            this.nsGroupBox3.Controls.Add(this.infobutton);
            this.nsGroupBox3.Controls.Add(this.github);
            this.nsGroupBox3.Controls.Add(this.version);
            this.nsGroupBox3.Controls.Add(this.label12);
            this.nsGroupBox3.Controls.Add(this.label11);
            this.nsGroupBox3.Controls.Add(this.label10);
            this.nsGroupBox3.Controls.Add(this.x2);
            this.nsGroupBox3.Controls.Add(this.x1);
            this.nsGroupBox3.Controls.Add(this.label9);
            this.nsGroupBox3.Controls.Add(this.label6);
            this.nsGroupBox3.Controls.Add(this.y2);
            this.nsGroupBox3.Controls.Add(this.y1);
            this.nsGroupBox3.Controls.Add(this.a2);
            this.nsGroupBox3.Controls.Add(this.label7);
            this.nsGroupBox3.Controls.Add(this.Valider);
            this.nsGroupBox3.Controls.Add(this.a1);
            this.nsGroupBox3.DrawSeperator = false;
            this.nsGroupBox3.Location = new System.Drawing.Point(3, 33);
            this.nsGroupBox3.Name = "nsGroupBox3";
            this.nsGroupBox3.Size = new System.Drawing.Size(524, 117);
            this.nsGroupBox3.SubTitle = "";
            this.nsGroupBox3.TabIndex = 25;
            this.nsGroupBox3.Text = "nsGroupBox3";
            this.nsGroupBox3.Title = "Équation";
            this.nsGroupBox3.Click += new System.EventHandler(this.nsGroupBox3_Click);
            // 
            // infobutton
            // 
            this.infobutton.Location = new System.Drawing.Point(419, 73);
            this.infobutton.Name = "infobutton";
            this.infobutton.SelectedIndex = 0;
            this.infobutton.Size = new System.Drawing.Size(94, 19);
            this.infobutton.TabIndex = 31;
            this.infobutton.Text = "Infos";
            this.infobutton.Click += new System.EventHandler(this.infobutton_Click);
            // 
            // github
            // 
            this.github.Location = new System.Drawing.Point(445, 20);
            this.github.Name = "github";
            this.github.SelectedIndex = 0;
            this.github.Size = new System.Drawing.Size(68, 18);
            this.github.TabIndex = 30;
            this.github.Text = "Github";
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.ForeColor = System.Drawing.Color.Lime;
            this.version.Location = new System.Drawing.Point(442, 3);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(78, 13);
            this.version.TabIndex = 21;
            this.version.Text = "Version 0.3a";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(177, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(78, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "X  +";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(78, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "X  +";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // x2
            // 
            this.x2.AutoScroll = false;
            this.x2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.x2.Location = new System.Drawing.Point(19, 71);
            this.x2.MaxLength = 32767;
            this.x2.Multiline = false;
            this.x2.Name = "x2";
            this.x2.NumberBounds = new System.Drawing.Point(0, 0);
            this.x2.NumbersOnly = false;
            this.x2.ReadOnly = false;
            this.x2.Size = new System.Drawing.Size(54, 23);
            this.x2.TabIndex = 4;
            this.x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x2.UseSystemPasswordChar = false;
            this.x2.TextChanged += new System.EventHandler(this.x2_TextChanged);
            // 
            // x1
            // 
            this.x1.AutoScroll = false;
            this.x1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.x1.Location = new System.Drawing.Point(19, 42);
            this.x1.MaxLength = 32767;
            this.x1.Multiline = false;
            this.x1.Name = "x1";
            this.x1.NumberBounds = new System.Drawing.Point(0, 0);
            this.x1.NumbersOnly = false;
            this.x1.ReadOnly = false;
            this.x1.Size = new System.Drawing.Size(54, 23);
            this.x1.TabIndex = 1;
            this.x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x1.UseSystemPasswordChar = false;
            this.x1.TextChanged += new System.EventHandler(this.x1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(193, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(193, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "=";
            // 
            // y2
            // 
            this.y2.AutoScroll = false;
            this.y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.y2.Location = new System.Drawing.Point(117, 71);
            this.y2.MaxLength = 32767;
            this.y2.Multiline = false;
            this.y2.Name = "y2";
            this.y2.NumberBounds = new System.Drawing.Point(0, 0);
            this.y2.NumbersOnly = false;
            this.y2.ReadOnly = false;
            this.y2.Size = new System.Drawing.Size(54, 23);
            this.y2.TabIndex = 5;
            this.y2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y2.UseSystemPasswordChar = false;
            this.y2.TextChanged += new System.EventHandler(this.y2_TextChanged);
            // 
            // y1
            // 
            this.y1.AutoScroll = false;
            this.y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.y1.Location = new System.Drawing.Point(117, 42);
            this.y1.MaxLength = 32767;
            this.y1.Multiline = false;
            this.y1.Name = "y1";
            this.y1.NumberBounds = new System.Drawing.Point(0, 0);
            this.y1.NumbersOnly = false;
            this.y1.ReadOnly = false;
            this.y1.Size = new System.Drawing.Size(54, 23);
            this.y1.TabIndex = 2;
            this.y1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y1.UseSystemPasswordChar = false;
            this.y1.TextChanged += new System.EventHandler(this.y1_TextChanged);
            // 
            // a2
            // 
            this.a2.AutoScroll = false;
            this.a2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.a2.Location = new System.Drawing.Point(218, 71);
            this.a2.MaxLength = 32767;
            this.a2.Multiline = false;
            this.a2.Name = "a2";
            this.a2.NumberBounds = new System.Drawing.Point(0, 0);
            this.a2.NumbersOnly = false;
            this.a2.ReadOnly = false;
            this.a2.Size = new System.Drawing.Size(54, 23);
            this.a2.TabIndex = 6;
            this.a2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a2.UseSystemPasswordChar = false;
            this.a2.TextChanged += new System.EventHandler(this.a2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(177, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Y";
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(278, 53);
            this.Valider.Name = "Valider";
            this.Valider.SelectedIndex = 0;
            this.Valider.Size = new System.Drawing.Size(87, 33);
            this.Valider.TabIndex = 7;
            this.Valider.Text = "Calculer";
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // a1
            // 
            this.a1.AutoScroll = false;
            this.a1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.a1.Location = new System.Drawing.Point(218, 42);
            this.a1.MaxLength = 32767;
            this.a1.Multiline = false;
            this.a1.Name = "a1";
            this.a1.NumberBounds = new System.Drawing.Point(0, 0);
            this.a1.NumbersOnly = false;
            this.a1.ReadOnly = false;
            this.a1.Size = new System.Drawing.Size(54, 23);
            this.a1.TabIndex = 3;
            this.a1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a1.UseSystemPasswordChar = false;
            this.a1.TextChanged += new System.EventHandler(this.a1_TextChanged);
            // 
            // nsGroupBox2
            // 
            this.nsGroupBox2.Controls.Add(this.nsButton1);
            this.nsGroupBox2.Controls.Add(this.answer);
            this.nsGroupBox2.DrawSeperator = false;
            this.nsGroupBox2.Location = new System.Drawing.Point(3, 156);
            this.nsGroupBox2.Name = "nsGroupBox2";
            this.nsGroupBox2.Size = new System.Drawing.Size(521, 252);
            this.nsGroupBox2.SubTitle = "";
            this.nsGroupBox2.TabIndex = 24;
            this.nsGroupBox2.Text = "nsGroupBox2";
            this.nsGroupBox2.Title = "Historique des réponses";
            this.nsGroupBox2.Click += new System.EventHandler(this.nsGroupBox2_Click);
            // 
            // nsButton1
            // 
            this.nsButton1.Location = new System.Drawing.Point(401, 3);
            this.nsButton1.Name = "nsButton1";
            this.nsButton1.SelectedIndex = 0;
            this.nsButton1.Size = new System.Drawing.Size(117, 23);
            this.nsButton1.TabIndex = 30;
            this.nsButton1.Text = "Effacer l\'historique";
            this.nsButton1.Click += new System.EventHandler(this.nsButton1_Click);
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answer.Font = new System.Drawing.Font("Verdana", 15F);
            this.answer.ForeColor = System.Drawing.Color.White;
            this.answer.Location = new System.Drawing.Point(4, 29);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(514, 217);
            this.answer.TabIndex = 0;
            this.answer.TextChanged += new System.EventHandler(this.answer_TextChanged);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(485, 3);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 1;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(509, 3);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // documentation
            // 
            this.documentation.Location = new System.Drawing.Point(419, 93);
            this.documentation.Name = "documentation";
            this.documentation.SelectedIndex = 0;
            this.documentation.Size = new System.Drawing.Size(94, 21);
            this.documentation.TabIndex = 32;
            this.documentation.Text = "Documentation";
            this.documentation.Click += new System.EventHandler(this.nsButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 414);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.nsTheme1.ResumeLayout(false);
            this.nsContextMenu1.ResumeLayout(false);
            this.nsGroupBox3.ResumeLayout(false);
            this.nsGroupBox3.PerformLayout();
            this.nsGroupBox2.ResumeLayout(false);
            this.nsGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme1;
        private theme.FlatMini flatMini1;
        private theme.FlatClose flatClose1;
        private NSTextBox a2;
        private NSTextBox a1;
        private System.Windows.Forms.Label label7;
        private NSButton Valider;
        private NSGroupBox nsGroupBox2;
        private System.Windows.Forms.TextBox answer;
        private NSGroupBox nsGroupBox3;
        private NSContextMenu nsContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordToolStripMenuItem;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label label6;
        private NSTextBox y2;
        private NSTextBox y1;
        private System.Windows.Forms.Label label10;
        private NSTextBox x2;
        private NSTextBox x1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private NSButton github;
        private NSButton nsButton1;
        private NSButton infobutton;
        private NSButton documentation;
    }
}

