namespace ImpostoRendaForms
{
    partial class IRForms
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IRForms));
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrossIncome = new System.Windows.Forms.TextBox();
            this.dgvListContributors = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMinimumWage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDependents = new System.Windows.Forms.Label();
            this.nudDependents = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContributors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDependents)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(46, 33);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(122, 20);
            this.txtCPF.TabIndex = 0;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtFields_TextChanged);
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(10, 36);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(101, 6);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(231, 20);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFields_TextChanged);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(10, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(85, 13);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Nome Completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Renda Bruta Mensal:";
            // 
            // txtGrossIncome
            // 
            this.txtGrossIncome.Location = new System.Drawing.Point(287, 33);
            this.txtGrossIncome.Name = "txtGrossIncome";
            this.txtGrossIncome.Size = new System.Drawing.Size(97, 20);
            this.txtGrossIncome.TabIndex = 5;
            this.txtGrossIncome.TextChanged += new System.EventHandler(this.txtFields_TextChanged);
            // 
            // dgvListContributors
            // 
            this.dgvListContributors.AllowUserToAddRows = false;
            this.dgvListContributors.AllowUserToDeleteRows = false;
            this.dgvListContributors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListContributors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListContributors.Location = new System.Drawing.Point(12, 68);
            this.dgvListContributors.MultiSelect = false;
            this.dgvListContributors.Name = "dgvListContributors";
            this.dgvListContributors.ReadOnly = true;
            this.dgvListContributors.RowHeadersVisible = false;
            this.dgvListContributors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListContributors.Size = new System.Drawing.Size(451, 300);
            this.dgvListContributors.TabIndex = 6;
            this.dgvListContributors.SelectionChanged += new System.EventHandler(this.dgvListContributors_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(390, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(390, 374);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(73, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(12, 374);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpar Lista";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMinimumWage
            // 
            this.txtMinimumWage.Location = new System.Drawing.Point(181, 417);
            this.txtMinimumWage.Name = "txtMinimumWage";
            this.txtMinimumWage.Size = new System.Drawing.Size(100, 20);
            this.txtMinimumWage.TabIndex = 10;
            this.txtMinimumWage.TextChanged += new System.EventHandler(this.txtMinimumWage_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor salário mínimo:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(287, 415);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calcular IR";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDependents
            // 
            this.lblDependents.AutoSize = true;
            this.lblDependents.Location = new System.Drawing.Point(338, 9);
            this.lblDependents.Name = "lblDependents";
            this.lblDependents.Size = new System.Drawing.Size(74, 13);
            this.lblDependents.TabIndex = 13;
            this.lblDependents.Text = "Dependentes:";
            // 
            // nudDependents
            // 
            this.nudDependents.Location = new System.Drawing.Point(418, 7);
            this.nudDependents.Name = "nudDependents";
            this.nudDependents.Size = new System.Drawing.Size(45, 20);
            this.nudDependents.TabIndex = 14;
            this.nudDependents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudDependents_KeyPress);
            // 
            // IRForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.nudDependents);
            this.Controls.Add(this.lblDependents);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinimumWage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvListContributors);
            this.Controls.Add(this.txtGrossIncome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IRForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste prático IR - BR Conselhos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContributors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDependents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrossIncome;
        private System.Windows.Forms.DataGridView dgvListContributors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMinimumWage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDependents;
        private System.Windows.Forms.NumericUpDown nudDependents;
    }
}

