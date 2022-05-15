namespace sistemaclube
{
    partial class frzelador
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
            this.bt_reserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_reserva
            // 
            this.bt_reserva.Location = new System.Drawing.Point(840, 13);
            this.bt_reserva.Name = "bt_reserva";
            this.bt_reserva.Size = new System.Drawing.Size(122, 23);
            this.bt_reserva.TabIndex = 0;
            this.bt_reserva.Text = "reserva de quadras";
            this.bt_reserva.UseVisualStyleBackColor = true;
            this.bt_reserva.Click += new System.EventHandler(this.bt_reserva_Click);
            // 
            // frzelador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sistemaclube.Properties.Resources.clube_4;
            this.ClientSize = new System.Drawing.Size(1300, 633);
            this.Controls.Add(this.bt_reserva);
            this.Name = "frzelador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Clube de tênis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_reserva;
    }
}