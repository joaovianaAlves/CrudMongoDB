namespace Crud
{
    partial class frmDetalhe
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
            components = new System.ComponentModel.Container();
            bsDetalhe = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            btnCancelar = new Button();
            btnOk = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)bsDetalhe).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bsDetalhe
            // 
            bsDetalhe.DataSource = typeof(DAL.Agenda);
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bsDetalhe, "Nome", true));
            textBox1.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(40, 16);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Endereco";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bsDetalhe, "Endereco", true));
            textBox2.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 27);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 183);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefone";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bsDetalhe, "Telefone", true));
            textBox3.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(12, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 27);
            textBox3.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(92, 70, 156);
            btnCancelar.Dock = DockStyle.Right;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(29, 38, 125);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(222, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(65, 48);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(92, 70, 156);
            btnOk.Dock = DockStyle.Right;
            btnOk.FlatAppearance.BorderColor = Color.FromArgb(29, 38, 125);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Location = new Point(287, 0);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(65, 48);
            btnOk.TabIndex = 7;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 19, 79);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 52);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(212, 173, 252);
            label4.Location = new Point(76, 9);
            label4.Name = "label4";
            label4.Size = new Size(208, 31);
            label4.TabIndex = 9;
            label4.Text = "Add a New User";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(12, 19, 79);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnOk);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 255);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 48);
            panel2.TabIndex = 9;
            // 
            // frmDetalhe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(212, 173, 252);
            ClientSize = new Size(352, 303);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDetalhe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhe";
            Load += frmDetalhe_Load;
            ((System.ComponentModel.ISupportInitialize)bsDetalhe).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsDetalhe;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button btnCancelar;
        private Button btnOk;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
    }
}