namespace Banco
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSet = new Banco.bancoDataSet();
            this.contaTableAdapter = new Banco.bancoDataSetTableAdapters.contaTableAdapter();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "VALOR:";
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(183, 115);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(151, 20);
            this.valor.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "SACAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(271, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "DEPOSITAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "OU";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpfDataGridViewTextBoxColumn,
            this.nome,
            this.valorDataGridViewTextBoxColumn,
            this.conta});
            this.dataGridView1.DataSource = this.contaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // conta
            // 
            this.conta.DataPropertyName = "conta";
            this.conta.HeaderText = "conta";
            this.conta.Name = "conta";
            // 
            // contaBindingSource
            // 
            this.contaBindingSource.DataMember = "conta";
            this.contaBindingSource.DataSource = this.bancoDataSet;
            // 
            // bancoDataSet
            // 
            this.bancoDataSet.DataSetName = "bancoDataSet";
            this.bancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contaTableAdapter
            // 
            this.contaTableAdapter.ClearBeforeFill = true;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(183, 27);
            this.cpf.Mask = "00000000000";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(151, 20);
            this.cpf.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 315);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bancoDataSet bancoDataSet;
        private System.Windows.Forms.BindingSource contaBindingSource;
        private bancoDataSetTableAdapters.contaTableAdapter contaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.MaskedTextBox cpf;
    }
}