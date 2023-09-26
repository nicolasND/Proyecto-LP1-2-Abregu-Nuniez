namespace Proyecto_LP1_2_Abregu_Nuniez
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rb1 = new RadioButton();
            clb1 = new CheckedListBox();
            rb2 = new RadioButton();
            cb1 = new ComboBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            b1 = new Button();
            tb1 = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(6, 23);
            rb1.Name = "rb1";
            rb1.Size = new Size(80, 19);
            rb1.TabIndex = 0;
            rb1.TabStop = true;
            rb1.Text = "Masculino";
            rb1.UseVisualStyleBackColor = true;
            // 
            // clb1
            // 
            clb1.BackColor = SystemColors.ScrollBar;
            clb1.FormattingEnabled = true;
            clb1.Items.AddRange(new object[] { "FPS (First Person Shooter)", "RPG (Rol Play Game)", "Estrategia", "Sandbox", "Hack ´n Slash", "Metroidvania", "Otro/s" });
            clb1.Location = new Point(17, 151);
            clb1.Name = "clb1";
            clb1.Size = new Size(266, 94);
            clb1.TabIndex = 2;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(6, 48);
            rb2.Name = "rb2";
            rb2.Size = new Size(78, 19);
            rb2.TabIndex = 3;
            rb2.TabStop = true;
            rb2.Text = "Femenino";
            rb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            cb1.AutoCompleteCustomSource.AddRange(new string[] { "Seleccione una opcion:", "Consola (PlayStation/Xbox/Nintendo/Otros)", "PC", "Móvil" });
            cb1.BackColor = SystemColors.ScrollBar;
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "Consola", "PC", "Movil" });
            cb1.Location = new Point(17, 282);
            cb1.Name = "cb1";
            cb1.Size = new Size(151, 23);
            cb1.TabIndex = 4;
            cb1.Text = "Seleccione una opcion:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(rb2);
            groupBox1.Controls.Add(rb1);
            groupBox1.Location = new Point(17, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 89);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione su sexo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 133);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 6;
            label1.Text = "¿Qué genero/s juega?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 264);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 7;
            label2.Text = "¿En qué consola juega?";
            // 
            // b1
            // 
            b1.BackColor = SystemColors.ScrollBar;
            b1.Location = new Point(17, 326);
            b1.Name = "b1";
            b1.Size = new Size(75, 23);
            b1.TabIndex = 8;
            b1.Text = "Guardar";
            b1.UseVisualStyleBackColor = false;
            b1.Click += B1_Click;
            // 
            // tb1
            // 
            tb1.BackColor = SystemColors.ScrollBar;
            tb1.Enabled = false;
            tb1.Location = new Point(374, 27);
            tb1.Multiline = true;
            tb1.Name = "tb1";
            tb1.ReadOnly = true;
            tb1.ScrollBars = ScrollBars.Vertical;
            tb1.Size = new Size(280, 326);
            tb1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 9);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 10;
            label3.Text = "Resultados:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(695, 397);
            Controls.Add(label3);
            Controls.Add(tb1);
            Controls.Add(b1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(cb1);
            Controls.Add(clb1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Encuesta sobre gaming";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rb1;
        private CheckedListBox clb1;
        private RadioButton rb2;
        private ComboBox cb1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button b1;
        private TextBox tb1;
        private Label label3;
    }
}