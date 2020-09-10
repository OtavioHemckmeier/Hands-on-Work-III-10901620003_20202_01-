using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tasks
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            atualizaGrid();
            actions_task.Hide();
            groupBoxEditTask.Hide();
            groupBoxConfirmApagaTask.Hide();
        }

        private void atualizaGrid() {
            MySqlConnection realizaConexao = execConectionBD();

            try {
                realizaConexao.Open();

                MySqlCommand comandoMySql = realizaConexao.CreateCommand();
                comandoMySql.CommandText = "SELECT * from tasks WHERE removed = 0";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                gridTasks.Rows.Clear();

                while (reader.Read()) {
                    DataGridViewRow row = (DataGridViewRow)gridTasks.Rows[0].Clone();

                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(3);
                    row.Cells[3].Value = reader.GetString(2);
                    gridTasks.Rows.Add(row);
                }

                realizaConexao.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if(!validaCamposObrigatorioForm(titulo.Text, descricao.Text, prioridade.Text)) {
                MessageBox.Show("Alguns campos obrigatórios não foram preenchidos!");
            } else {
                if (!validaDadosForm(prioridade.Text)) {
                    MessageBox.Show("Valor não permitido inserido no formulário!");
                } else {
                    MySqlConnection realizaConexao = execConectionBD();
                    try {
                        realizaConexao.Open();

                        MySqlCommand cmd = realizaConexao.CreateCommand();
                        cmd.CommandText = "INSERT INTO tasks (titulo,descricao,prioridade, removed) " +
                            "VALUES('" + titulo.Text + "', '" + descricao.Text + "', '" + prioridade.Text + "', 0)";
                        cmd.ExecuteNonQuery();

                        realizaConexao.Close();

                        resetFormInsert();
                        atualizaGrid();
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void cancelar_insert_Click(object sender, EventArgs e) {
            resetFormInsert();
        }

        private void resetFormInsert() {
            titulo.Text = "";
            descricao.Text = "";
            prioridade.Text = "";
        }
        
        private void resetFormUpdate() {
            edit_id.Text = "";
            edit_titulo.Text = "";
            edit_descricao.Text = "";
            edit_prioridade.Text = "";
        }
        
        private void resetFormDelete() {
            delete_id_task.Text = "";
        }

        private bool validaCamposObrigatorioForm(string titulo, string descricao, string prioridade) {
            return !!(titulo != "" && descricao != "" && prioridade != "");
        }

        private bool validaDadosForm(string prioridade) {
            return !!(prioridade != "" && (prioridade == "alta" || prioridade == "media" || prioridade == "baixa"));
        }
        
        private MySqlConnection execConectionBD() {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "tasks";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";

            MySqlConnection realizaConexao = new MySqlConnection(conexaoBD.ToString());
            return realizaConexao;
        }

        private void gridTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridTasks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) {
                gridTasks.CurrentRow.Selected = true;
               
                groupBoxInsertTask.Hide();
                actions_task.Hide();
                groupBoxEditTask.Hide();
                groupBoxConfirmApagaTask.Hide();
                actions_task.Show();

                var id = gridTasks.Rows[e.RowIndex].Cells["ColumnId"].FormattedValue.ToString();
                var titulo= gridTasks.Rows[e.RowIndex].Cells["ColumnTitulo"].FormattedValue.ToString();
                var prioridade = gridTasks.Rows[e.RowIndex].Cells["ColumnPrioridade"].FormattedValue.ToString();
                var descricao= gridTasks.Rows[e.RowIndex].Cells["ColumnDescricao"].FormattedValue.ToString();

                delete_id_task.Text = id;
                edit_id.Text = id;
                edit_titulo.Text = titulo;
                edit_prioridade.Text = prioridade;
                edit_descricao.Text = descricao;
            }
        }

        private void hide_actions_task_Click(object sender, EventArgs e)
        {
            groupBoxInsertTask.Show();
            actions_task.Hide();
        }

        private void cancela_edit_Click(object sender, EventArgs e)
        {
            groupBoxInsertTask.Show();
            actions_task.Hide();
            groupBoxEditTask.Hide();
        }

        private void update_task_Click(object sender, EventArgs e)
        {
            actions_task.Hide();
            groupBoxEditTask.Show();
        }

        private void cancel_apagar_Click(object sender, EventArgs e)
        {
            groupBoxInsertTask.Show();
            actions_task.Hide();
            groupBoxEditTask.Hide();
            groupBoxConfirmApagaTask.Hide();
        }

        private void delete_task_Click(object sender, EventArgs e)
        {
            actions_task.Hide();
            groupBoxConfirmApagaTask.Show();
        }

        private void edit_task_Click(object sender, EventArgs e)
        {
            if (edit_id.Text != "" && !validaCamposObrigatorioForm(edit_titulo.Text, edit_descricao.Text, edit_prioridade.Text))
            {
                MessageBox.Show("Alguns campos obrigatórios não foram preenchidos!");
            }
            else
            {
                if (!validaDadosForm(edit_prioridade.Text))
                {
                    MessageBox.Show("Valor não permitido inserido no formulário!");
                }
                else
                {
                    MySqlConnection realizaConexao = execConectionBD();
                    try
                    {
                        realizaConexao.Open();
                        MySqlCommand cmd = realizaConexao.CreateCommand();
                        cmd.CommandText = "UPDATE tasks SET titulo = '" + edit_titulo.Text + "', descricao = '" + edit_descricao.Text + "', prioridade = '" + edit_prioridade.Text + "' WHERE idTask = '" + edit_id.Text + "'";
                        cmd.ExecuteNonQuery();

                        realizaConexao.Close();

                        resetFormInsert();
                        resetFormUpdate();
                        resetFormDelete();
                        atualizaGrid();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void confirm_apagar_Click(object sender, EventArgs e)
        {
            if (delete_id_task.Text != "")
            {
                MySqlConnection realizaConexao = execConectionBD();
                try
                {
                    realizaConexao.Open();
                    MySqlCommand cmd = realizaConexao.CreateCommand();
                    cmd.CommandText = "UPDATE tasks SET removed = 1 WHERE idTask = '" + delete_id_task.Text + "'";
                    cmd.ExecuteNonQuery();

                    realizaConexao.Close();

                    resetFormInsert();
                    resetFormUpdate();
                    resetFormDelete();
                    atualizaGrid();

                    groupBoxConfirmApagaTask.Hide();
                    groupBoxInsertTask.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Tarefa não encontrada");
            }
        }
    }
}
