using IRCalculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoRendaForms
{
    public partial class IRForms : Form
    {
        DataTable _dataTable;

        public IRForms()
        {
            InitializeComponent();

            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            _dataTable = new DataTable();
            _dataTable.Columns.Add("Nome", typeof(string));
            _dataTable.Columns.Add("CPF", typeof(string));
            _dataTable.Columns.Add("Renda Bruta", typeof(double));
            _dataTable.Columns.Add("Qtd Dependentes", typeof(int));
            _dataTable.Columns.Add("Valor a pagar", typeof(double));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateIncomeTax incomeTax = new CalculateIncomeTax(Convert.ToDouble(txtMinimumWage.Text));

            foreach (DataRow row in _dataTable.Rows)
            {
                row["Valor a pagar"] = incomeTax.AmountToPay(Convert.ToDouble(row["Renda Bruta"]), Convert.ToInt32(row["Qtd Dependentes"]));
            }

            OrderByValueIRAndName();
        }

        private void OrderByValueIRAndName()
        {            
            _dataTable.DefaultView.Sort = "Valor a pagar asc, Nome asc";
            _dataTable = _dataTable.DefaultView.ToTable();
            dgvListContributors.DataSource = _dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = _dataTable.NewRow();
            row["Nome"] = txtFullName.Text;
            row["CPF"] = txtCPF.Text;
            row["Renda Bruta"] = txtGrossIncome.Text;
            row["Qtd Dependentes"] = nudDependents.Value;

            InsertTaxpayer(row);

            ClearFields();
            EnabledBtnClear();
            EnabledBtnRemove();
        }

        private void InsertTaxpayer(DataRow dataRow)
        {
            _dataTable.Rows.Add(dataRow);
            dgvListContributors.DataSource = _dataTable;
        }

        private void ClearFields()
        {
            txtCPF.Clear();
            txtFullName.Clear();
            txtGrossIncome.Clear();
            nudDependents.Value = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _dataTable.Rows.Clear();
            dgvListContributors.DataSource = _dataTable;
            EnabledBtnClear();
            EnabledbtnCalculate();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvListContributors.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvListContributors.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvListContributors.Rows[selectedrowindex];

                string cpf = selectedRow.Cells["CPF"].Value.ToString();

                dgvListContributors.Rows.RemoveAt(selectedrowindex);
                foreach (DataRow row in _dataTable.Rows)
                {
                    if (row["CPF"].ToString().Equals(cpf))
                        row.Delete();
                }

                EnabledBtnClear();
                EnabledbtnCalculate();
            }
        }      

        private void EnabledBtnRemove()
        {
            btnRemove.Enabled = dgvListContributors.SelectedRows.Count > 0;
        }

        private void EnabledBtnClear()
        {
            btnClear.Enabled = dgvListContributors.Rows.Count > 0;
        }

        private void EnabledbtnCalculate()
        {
            btnCalculate.Enabled = (!string.IsNullOrEmpty(txtMinimumWage.Text.Trim()) && dgvListContributors.Rows.Count > 0);
        }
        private void dgvListContributors_SelectionChanged(object sender, EventArgs e)
        {
            EnabledBtnRemove();
            EnabledbtnCalculate();
        }

        private void txtFields_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !string.IsNullOrEmpty(txtFullName.Text.Trim()) && !string.IsNullOrEmpty(txtCPF.Text.Trim()) && !string.IsNullOrEmpty(txtGrossIncome.Text.Trim());
        }

        private void nudDependents_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void txtMinimumWage_TextChanged(object sender, EventArgs e)
        {
            EnabledbtnCalculate();
        }
    }
}
