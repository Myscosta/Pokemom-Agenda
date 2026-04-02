namespace Pokemom_Agenda
{
    partial class FormDetalhesPokemon
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbNivel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(37, 48);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "label1";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(37, 74);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(35, 13);
            this.lbTipo.TabIndex = 1;
            this.lbTipo.Text = "label2";
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Location = new System.Drawing.Point(40, 101);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(35, 13);
            this.lbNivel.TabIndex = 2;
            this.lbNivel.Text = "label3";
            // 
            // FormDetalhesPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 404);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbNome);
            this.Name = "FormDetalhesPokemon";
            this.Text = "FormDetalhesPokemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbNivel;
    }
}