namespace TabelaBrasileirao
{
    partial class frmTelaConsultar
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
            label1 = new Label();
            label2 = new Label();
            cbSeries = new ComboBox();
            btnConsultar = new Button();
            dgvConsultar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(340, 18);
            label1.Name = "label1";
            label1.Size = new Size(170, 30);
            label1.TabIndex = 0;
            label1.Text = "Consultar Times";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(627, 141);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 2;
            label2.Text = "Serie:";
            // 
            // cbSeries
            // 
            cbSeries.FormattingEnabled = true;
            cbSeries.Items.AddRange(new object[] { "", "A", "B", "C", "D" });
            cbSeries.Location = new Point(627, 164);
            cbSeries.Name = "cbSeries";
            cbSeries.Size = new Size(121, 23);
            cbSeries.TabIndex = 3;
            cbSeries.SelectedIndexChanged += cbSeries_SelectedIndexChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(128, 255, 128);
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.Location = new Point(644, 235);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(93, 27);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvConsultar
            // 
            dgvConsultar.BackgroundColor = Color.White;
            dgvConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultar.Location = new Point(286, 131);
            dgvConsultar.Name = "dgvConsultar";
            dgvConsultar.Size = new Size(292, 169);
            dgvConsultar.TabIndex = 5;
            // 
            // frmTelaConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.imagem_da_tela_de_consulta;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConsultar);
            Controls.Add(btnConsultar);
            Controls.Add(cbSeries);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTelaConsultar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTelaconsulatar";
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbSeries;
        private Button btnConsultar;
        private DataGridView dgvConsultar;
    }
}