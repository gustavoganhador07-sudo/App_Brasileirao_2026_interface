namespace TabelaBrasileirao
{
    partial class Atualizartimes
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
            panel1 = new Panel();
            label11 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            cb_Serie = new ComboBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtPontosClube = new TextBox();
            txtJogosClube = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtSaldosGols = new TextBox();
            label6 = new Label();
            txtVitoriasClube = new TextBox();
            label8 = new Label();
            txtEmpateClube = new TextBox();
            label9 = new Label();
            txtDerrotasClube = new TextBox();
            label10 = new Label();
            txtPosiçaoClube = new TextBox();
            dgvAtualizar = new DataGridView();
            rbNomeTime = new RadioButton();
            rbPosicao = new RadioButton();
            txtBuscar = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtualizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cb_Serie);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 449);
            panel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(16, 116);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 9;
            label11.Text = "Serie:";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(24, 310);
            button3.Name = "button3";
            button3.Size = new Size(97, 36);
            button3.TabIndex = 8;
            button3.Text = "Apagar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(24, 248);
            button2.Name = "button2";
            button2.Size = new Size(97, 39);
            button2.TabIndex = 7;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(24, 187);
            button1.Name = "button1";
            button1.Size = new Size(97, 39);
            button1.TabIndex = 6;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 5;
            label1.Text = "ATUALIZAR TIMES";
            // 
            // cb_Serie
            // 
            cb_Serie.FormattingEnabled = true;
            cb_Serie.Items.AddRange(new object[] { "", "A", "B", "C", "D" });
            cb_Serie.Location = new Point(12, 138);
            cb_Serie.Name = "cb_Serie";
            cb_Serie.Size = new Size(121, 23);
            cb_Serie.TabIndex = 4;
            cb_Serie.SelectedIndexChanged += cb_Serie_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(205, 37);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome Do Clube:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(205, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(165, 23);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(205, 102);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 3;
            label3.Text = "Pontos Clube:";
            // 
            // txtPontosClube
            // 
            txtPontosClube.Location = new Point(205, 120);
            txtPontosClube.Name = "txtPontosClube";
            txtPontosClube.Size = new Size(165, 23);
            txtPontosClube.TabIndex = 4;
            // 
            // txtJogosClube
            // 
            txtJogosClube.Location = new Point(205, 187);
            txtJogosClube.Name = "txtJogosClube";
            txtJogosClube.Size = new Size(165, 23);
            txtJogosClube.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(205, 169);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 6;
            label4.Text = "Jogos  Clube:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(205, 236);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 7;
            label5.Text = "Saldos Gols:";
            // 
            // txtSaldosGols
            // 
            txtSaldosGols.Location = new Point(205, 254);
            txtSaldosGols.Name = "txtSaldosGols";
            txtSaldosGols.Size = new Size(165, 23);
            txtSaldosGols.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(205, 299);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 9;
            label6.Text = "Vitorias Clube:";
            // 
            // txtVitoriasClube
            // 
            txtVitoriasClube.Location = new Point(205, 317);
            txtVitoriasClube.Name = "txtVitoriasClube";
            txtVitoriasClube.Size = new Size(165, 23);
            txtVitoriasClube.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(440, 41);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 13;
            label8.Text = "Empate Clube:";
            // 
            // txtEmpateClube
            // 
            txtEmpateClube.Location = new Point(440, 59);
            txtEmpateClube.Name = "txtEmpateClube";
            txtEmpateClube.Size = new Size(165, 23);
            txtEmpateClube.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(440, 102);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 15;
            label9.Text = "Derrotas Clube:";
            // 
            // txtDerrotasClube
            // 
            txtDerrotasClube.Location = new Point(440, 120);
            txtDerrotasClube.Name = "txtDerrotasClube";
            txtDerrotasClube.Size = new Size(165, 23);
            txtDerrotasClube.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(436, 169);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 17;
            label10.Text = "Posicao Clube:";
            // 
            // txtPosiçaoClube
            // 
            txtPosiçaoClube.Location = new Point(436, 187);
            txtPosiçaoClube.Name = "txtPosiçaoClube";
            txtPosiçaoClube.Size = new Size(165, 23);
            txtPosiçaoClube.TabIndex = 18;
            // 
            // dgvAtualizar
            // 
            dgvAtualizar.BackgroundColor = Color.White;
            dgvAtualizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtualizar.Location = new Point(401, 216);
            dgvAtualizar.Name = "dgvAtualizar";
            dgvAtualizar.Size = new Size(368, 202);
            dgvAtualizar.TabIndex = 19;
            dgvAtualizar.CellClick += dgvAtualizar_CellClick;
            // 
            // rbNomeTime
            // 
            rbNomeTime.AutoSize = true;
            rbNomeTime.BackColor = Color.Transparent;
            rbNomeTime.Location = new Point(414, 428);
            rbNomeTime.Name = "rbNomeTime";
            rbNomeTime.Size = new Size(91, 19);
            rbNomeTime.TabIndex = 20;
            rbNomeTime.TabStop = true;
            rbNomeTime.Text = "Nome Time ";
            rbNomeTime.UseVisualStyleBackColor = false;
            // 
            // rbPosicao
            // 
            rbPosicao.AutoSize = true;
            rbPosicao.BackColor = Color.Transparent;
            rbPosicao.Location = new Point(528, 428);
            rbPosicao.Name = "rbPosicao";
            rbPosicao.Size = new Size(66, 19);
            rbPosicao.TabIndex = 21;
            rbPosicao.TabStop = true;
            rbPosicao.Text = "Posiçao";
            rbPosicao.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(620, 424);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(149, 23);
            txtBuscar.TabIndex = 22;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // Atualizartimes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cbf;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscar);
            Controls.Add(rbPosicao);
            Controls.Add(rbNomeTime);
            Controls.Add(dgvAtualizar);
            Controls.Add(txtPosiçaoClube);
            Controls.Add(label10);
            Controls.Add(txtDerrotasClube);
            Controls.Add(label9);
            Controls.Add(txtEmpateClube);
            Controls.Add(label8);
            Controls.Add(txtVitoriasClube);
            Controls.Add(label6);
            Controls.Add(txtSaldosGols);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtJogosClube);
            Controls.Add(txtPontosClube);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Atualizartimes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizartimes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtualizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cb_Serie;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtPontosClube;
        private TextBox txtJogosClube;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox txtVitoriasClube;
        private Label label8;
        private TextBox txtEmpateClube;
        private Label label9;
        private TextBox txtDerrotasClube;
        private Label label10;
        private TextBox txtPosiçaoClube;
        private DataGridView dgvAtualizar;
        private RadioButton rbNomeTime;
        private RadioButton rbPosicao;
        private Label label11;
        private TextBox txtSaldosGols;
        private TextBox txtBuscar;
    }
}