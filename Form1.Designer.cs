namespace APIs
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
            pokedex = new PictureBox();
            pokemon = new PictureBox();
            left = new Button();
            right = new Button();
            name = new Label();
            idLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pokedex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pokemon).BeginInit();
            SuspendLayout();
            // 
            // pokedex
            // 
            pokedex.Image = Properties.Resources.plantilla;
            pokedex.Location = new Point(-1, 0);
            pokedex.Name = "pokedex";
            pokedex.Size = new Size(786, 421);
            pokedex.TabIndex = 0;
            pokedex.TabStop = false;
            pokedex.MouseDown += pokedex_MouseDown;
            pokedex.MouseMove += pokedex_mouseMove;
            // 
            // pokemon
            // 
            pokemon.BackColor = Color.White;
            pokemon.Location = new Point(82, 81);
            pokemon.Name = "pokemon";
            pokemon.Size = new Size(227, 120);
            pokemon.SizeMode = PictureBoxSizeMode.Zoom;
            pokemon.TabIndex = 1;
            pokemon.TabStop = false;
            // 
            // left
            // 
            left.FlatStyle = FlatStyle.Flat;
            left.ForeColor = Color.FromArgb(35, 35, 35);
            left.Image = Properties.Resources.btn_izq;
            left.Location = new Point(264, 344);
            left.Name = "left";
            left.Size = new Size(28, 30);
            left.TabIndex = 2;
            left.UseVisualStyleBackColor = true;
            left.Click += left_Click;
            // 
            // right
            // 
            right.BackColor = Color.Transparent;
            right.FlatStyle = FlatStyle.Flat;
            right.ForeColor = Color.FromArgb(35, 35, 35);
            right.Image = Properties.Resources.btn_der;
            right.Location = new Point(324, 344);
            right.Name = "right";
            right.Size = new Size(28, 28);
            right.TabIndex = 3;
            right.UseVisualStyleBackColor = false;
            right.Click += right_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(510, 90);
            name.Name = "name";
            name.Size = new Size(233, 37);
            name.TabIndex = 4;
            name.Text = "Nombre Pokemon";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = Color.White;
            idLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.Location = new Point(150, 366);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(53, 32);
            idLabel.TabIndex = 5;
            idLabel.Text = "000";
            // 
            // Form1
            // 
            ClientSize = new Size(786, 420);
            Controls.Add(idLabel);
            Controls.Add(name);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(pokemon);
            Controls.Add(pokedex);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Load += Form1_load;
            ((System.ComponentModel.ISupportInitialize)pokedex).EndInit();
            ((System.ComponentModel.ISupportInitialize)pokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pokedex;
        private PictureBox pokemon;
        private Button left;
        private Button right;
        private Label name;
        private Label idLabel;
    }
}