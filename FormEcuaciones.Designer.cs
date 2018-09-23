namespace SistemasEcuaciones
{
    partial class FormEcuaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudNIncógnitas = new System.Windows.Forms.NumericUpDown();
            this.lblNIncógnitas = new System.Windows.Forms.Label();
            this.panelTextbox = new System.Windows.Forms.Panel();
            this.btnResolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNIncógnitas)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNIncógnitas
            // 
            this.nudNIncógnitas.Location = new System.Drawing.Point(125, 6);
            this.nudNIncógnitas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNIncógnitas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNIncógnitas.Name = "nudNIncógnitas";
            this.nudNIncógnitas.Size = new System.Drawing.Size(43, 20);
            this.nudNIncógnitas.TabIndex = 0;
            this.nudNIncógnitas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNIncógnitas.ValueChanged += new System.EventHandler(this.nudNIncógnitas_ValueChanged);
            // 
            // lblNIncógnitas
            // 
            this.lblNIncógnitas.AutoSize = true;
            this.lblNIncógnitas.Location = new System.Drawing.Point(9, 8);
            this.lblNIncógnitas.Name = "lblNIncógnitas";
            this.lblNIncógnitas.Size = new System.Drawing.Size(110, 13);
            this.lblNIncógnitas.TabIndex = 1;
            this.lblNIncógnitas.Text = "Número de incógnitas";
            // 
            // panelTextbox
            // 
            this.panelTextbox.AutoSize = true;
            this.panelTextbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTextbox.Location = new System.Drawing.Point(12, 37);
            this.panelTextbox.Name = "panelTextbox";
            this.panelTextbox.Size = new System.Drawing.Size(0, 0);
            this.panelTextbox.TabIndex = 2;
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(174, 5);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(77, 22);
            this.btnResolver.TabIndex = 3;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // FormEcuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(307, 134);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.panelTextbox);
            this.Controls.Add(this.lblNIncógnitas);
            this.Controls.Add(this.nudNIncógnitas);
            this.Name = "FormEcuaciones";
            this.Text = "Resolver Sistemas de Ecuaciones";
            ((System.ComponentModel.ISupportInitialize)(this.nudNIncógnitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNIncógnitas;
        private System.Windows.Forms.Label lblNIncógnitas;
        private System.Windows.Forms.Panel panelTextbox;
        private System.Windows.Forms.Button btnResolver;
    }
}

