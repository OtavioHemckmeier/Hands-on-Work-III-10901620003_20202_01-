namespace tasks
{
    partial class Form1
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
            this.insert_task = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.TextBox();
            this.prioridade = new System.Windows.Forms.ComboBox();
            this.Título = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar_insert = new System.Windows.Forms.Button();
            this.gridTasks = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxInsertTask = new System.Windows.Forms.GroupBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.actions_task = new System.Windows.Forms.GroupBox();
            this.update_task = new System.Windows.Forms.Button();
            this.hide_actions_task = new System.Windows.Forms.Button();
            this.delete_task = new System.Windows.Forms.Button();
            this.groupBoxEditTask = new System.Windows.Forms.GroupBox();
            this.edit_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edit_task = new System.Windows.Forms.Button();
            this.edit_descricao = new System.Windows.Forms.TextBox();
            this.edit_titulo = new System.Windows.Forms.TextBox();
            this.cancela_edit = new System.Windows.Forms.Button();
            this.edit_prioridade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxConfirmApagaTask = new System.Windows.Forms.GroupBox();
            this.delete_id_task = new System.Windows.Forms.TextBox();
            this.confirm_apagar = new System.Windows.Forms.Button();
            this.cancel_apagar = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            this.groupBoxInsertTask.SuspendLayout();
            this.actions_task.SuspendLayout();
            this.groupBoxEditTask.SuspendLayout();
            this.groupBoxConfirmApagaTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // insert_task
            // 
            this.insert_task.Location = new System.Drawing.Point(150, 186);
            this.insert_task.Name = "insert_task";
            this.insert_task.Size = new System.Drawing.Size(75, 23);
            this.insert_task.TabIndex = 0;
            this.insert_task.Text = "Inserir";
            this.insert_task.UseVisualStyleBackColor = true;
            this.insert_task.Click += new System.EventHandler(this.button1_Click);
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(16, 92);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(209, 20);
            this.descricao.TabIndex = 1;
            // 
            // prioridade
            // 
            this.prioridade.FormattingEnabled = true;
            this.prioridade.Items.AddRange(new object[] {
            "baixa",
            "media",
            "alta"});
            this.prioridade.Location = new System.Drawing.Point(16, 143);
            this.prioridade.Name = "prioridade";
            this.prioridade.Size = new System.Drawing.Size(209, 21);
            this.prioridade.TabIndex = 6;
            // 
            // Título
            // 
            this.Título.AutoSize = true;
            this.Título.BackColor = System.Drawing.Color.Transparent;
            this.Título.Location = new System.Drawing.Point(19, 26);
            this.Título.Name = "Título";
            this.Título.Size = new System.Drawing.Size(42, 13);
            this.Título.TabIndex = 7;
            this.Título.Text = "Título *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descrição *";
            // 
            // cancelar_insert
            // 
            this.cancelar_insert.Location = new System.Drawing.Point(16, 186);
            this.cancelar_insert.Name = "cancelar_insert";
            this.cancelar_insert.Size = new System.Drawing.Size(75, 23);
            this.cancelar_insert.TabIndex = 11;
            this.cancelar_insert.Text = "Cancelar";
            this.cancelar_insert.UseVisualStyleBackColor = true;
            this.cancelar_insert.Click += new System.EventHandler(this.cancelar_insert_Click);
            // 
            // gridTasks
            // 
            this.gridTasks.BackgroundColor = System.Drawing.Color.Azure;
            this.gridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTitulo,
            this.ColumnPrioridade,
            this.ColumnDescricao});
            this.gridTasks.Location = new System.Drawing.Point(289, 32);
            this.gridTasks.Name = "gridTasks";
            this.gridTasks.Size = new System.Drawing.Size(769, 421);
            this.gridTasks.TabIndex = 12;
            this.gridTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTasks_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(292, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lista de Tarefas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prioridade *";
            // 
            // groupBoxInsertTask
            // 
            this.groupBoxInsertTask.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInsertTask.Controls.Add(this.Título);
            this.groupBoxInsertTask.Controls.Add(this.label2);
            this.groupBoxInsertTask.Controls.Add(this.insert_task);
            this.groupBoxInsertTask.Controls.Add(this.descricao);
            this.groupBoxInsertTask.Controls.Add(this.titulo);
            this.groupBoxInsertTask.Controls.Add(this.cancelar_insert);
            this.groupBoxInsertTask.Controls.Add(this.prioridade);
            this.groupBoxInsertTask.Controls.Add(this.label1);
            this.groupBoxInsertTask.Location = new System.Drawing.Point(12, 16);
            this.groupBoxInsertTask.Name = "groupBoxInsertTask";
            this.groupBoxInsertTask.Size = new System.Drawing.Size(243, 225);
            this.groupBoxInsertTask.TabIndex = 15;
            this.groupBoxInsertTask.TabStop = false;
            this.groupBoxInsertTask.Text = "Inserir Tarefa";
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(16, 41);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(209, 20);
            this.titulo.TabIndex = 2;
            // 
            // actions_task
            // 
            this.actions_task.BackColor = System.Drawing.Color.Transparent;
            this.actions_task.Controls.Add(this.update_task);
            this.actions_task.Controls.Add(this.hide_actions_task);
            this.actions_task.Controls.Add(this.delete_task);
            this.actions_task.Location = new System.Drawing.Point(12, 19);
            this.actions_task.Name = "actions_task";
            this.actions_task.Size = new System.Drawing.Size(243, 129);
            this.actions_task.TabIndex = 16;
            this.actions_task.TabStop = false;
            this.actions_task.Text = "Ações";
            // 
            // update_task
            // 
            this.update_task.Location = new System.Drawing.Point(6, 19);
            this.update_task.Name = "update_task";
            this.update_task.Size = new System.Drawing.Size(231, 23);
            this.update_task.TabIndex = 2;
            this.update_task.Text = "Editar Tarefa";
            this.update_task.UseVisualStyleBackColor = true;
            this.update_task.Click += new System.EventHandler(this.update_task_Click);
            // 
            // hide_actions_task
            // 
            this.hide_actions_task.Location = new System.Drawing.Point(6, 100);
            this.hide_actions_task.Name = "hide_actions_task";
            this.hide_actions_task.Size = new System.Drawing.Size(231, 23);
            this.hide_actions_task.TabIndex = 1;
            this.hide_actions_task.Text = "Cancelar";
            this.hide_actions_task.UseVisualStyleBackColor = true;
            this.hide_actions_task.Click += new System.EventHandler(this.hide_actions_task_Click);
            // 
            // delete_task
            // 
            this.delete_task.Location = new System.Drawing.Point(6, 47);
            this.delete_task.Name = "delete_task";
            this.delete_task.Size = new System.Drawing.Size(231, 23);
            this.delete_task.TabIndex = 0;
            this.delete_task.Text = "Apagar Tarefa";
            this.delete_task.UseVisualStyleBackColor = true;
            this.delete_task.Click += new System.EventHandler(this.delete_task_Click);
            // 
            // groupBoxEditTask
            // 
            this.groupBoxEditTask.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEditTask.Controls.Add(this.edit_id);
            this.groupBoxEditTask.Controls.Add(this.label5);
            this.groupBoxEditTask.Controls.Add(this.label6);
            this.groupBoxEditTask.Controls.Add(this.edit_task);
            this.groupBoxEditTask.Controls.Add(this.edit_descricao);
            this.groupBoxEditTask.Controls.Add(this.edit_titulo);
            this.groupBoxEditTask.Controls.Add(this.cancela_edit);
            this.groupBoxEditTask.Controls.Add(this.edit_prioridade);
            this.groupBoxEditTask.Controls.Add(this.label8);
            this.groupBoxEditTask.Location = new System.Drawing.Point(12, 17);
            this.groupBoxEditTask.Name = "groupBoxEditTask";
            this.groupBoxEditTask.Size = new System.Drawing.Size(243, 230);
            this.groupBoxEditTask.TabIndex = 16;
            this.groupBoxEditTask.TabStop = false;
            this.groupBoxEditTask.Text = "Editar Tarefa";
            // 
            // edit_id
            // 
            this.edit_id.Location = new System.Drawing.Point(103, 185);
            this.edit_id.Name = "edit_id";
            this.edit_id.Size = new System.Drawing.Size(20, 20);
            this.edit_id.TabIndex = 15;
            this.edit_id.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(19, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Título *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(19, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prioridade *";
            // 
            // edit_task
            // 
            this.edit_task.Location = new System.Drawing.Point(150, 182);
            this.edit_task.Name = "edit_task";
            this.edit_task.Size = new System.Drawing.Size(75, 23);
            this.edit_task.TabIndex = 0;
            this.edit_task.Text = "Editar";
            this.edit_task.UseVisualStyleBackColor = true;
            this.edit_task.Click += new System.EventHandler(this.edit_task_Click);
            // 
            // edit_descricao
            // 
            this.edit_descricao.Location = new System.Drawing.Point(16, 92);
            this.edit_descricao.Name = "edit_descricao";
            this.edit_descricao.Size = new System.Drawing.Size(209, 20);
            this.edit_descricao.TabIndex = 1;
            // 
            // edit_titulo
            // 
            this.edit_titulo.Location = new System.Drawing.Point(16, 41);
            this.edit_titulo.Name = "edit_titulo";
            this.edit_titulo.Size = new System.Drawing.Size(209, 20);
            this.edit_titulo.TabIndex = 2;
            // 
            // cancela_edit
            // 
            this.cancela_edit.Location = new System.Drawing.Point(16, 182);
            this.cancela_edit.Name = "cancela_edit";
            this.cancela_edit.Size = new System.Drawing.Size(75, 23);
            this.cancela_edit.TabIndex = 11;
            this.cancela_edit.Text = "Cancelar";
            this.cancela_edit.UseVisualStyleBackColor = true;
            this.cancela_edit.Click += new System.EventHandler(this.cancela_edit_Click);
            // 
            // edit_prioridade
            // 
            this.edit_prioridade.FormattingEnabled = true;
            this.edit_prioridade.Items.AddRange(new object[] {
            "baixa",
            "media",
            "alta"});
            this.edit_prioridade.Location = new System.Drawing.Point(16, 143);
            this.edit_prioridade.Name = "edit_prioridade";
            this.edit_prioridade.Size = new System.Drawing.Size(209, 21);
            this.edit_prioridade.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(20, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Descrição *";
            // 
            // groupBoxConfirmApagaTask
            // 
            this.groupBoxConfirmApagaTask.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxConfirmApagaTask.Controls.Add(this.delete_id_task);
            this.groupBoxConfirmApagaTask.Controls.Add(this.confirm_apagar);
            this.groupBoxConfirmApagaTask.Controls.Add(this.cancel_apagar);
            this.groupBoxConfirmApagaTask.Location = new System.Drawing.Point(12, 19);
            this.groupBoxConfirmApagaTask.Name = "groupBoxConfirmApagaTask";
            this.groupBoxConfirmApagaTask.Size = new System.Drawing.Size(243, 67);
            this.groupBoxConfirmApagaTask.TabIndex = 17;
            this.groupBoxConfirmApagaTask.TabStop = false;
            this.groupBoxConfirmApagaTask.Text = "Deseja Realmente Apagar";
            // 
            // delete_id_task
            // 
            this.delete_id_task.Location = new System.Drawing.Point(225, 27);
            this.delete_id_task.Name = "delete_id_task";
            this.delete_id_task.Size = new System.Drawing.Size(15, 20);
            this.delete_id_task.TabIndex = 18;
            this.delete_id_task.Visible = false;
            // 
            // confirm_apagar
            // 
            this.confirm_apagar.Location = new System.Drawing.Point(124, 26);
            this.confirm_apagar.Name = "confirm_apagar";
            this.confirm_apagar.Size = new System.Drawing.Size(101, 23);
            this.confirm_apagar.TabIndex = 16;
            this.confirm_apagar.Text = "Sim";
            this.confirm_apagar.UseVisualStyleBackColor = true;
            this.confirm_apagar.Click += new System.EventHandler(this.confirm_apagar_Click);
            // 
            // cancel_apagar
            // 
            this.cancel_apagar.Location = new System.Drawing.Point(16, 26);
            this.cancel_apagar.Name = "cancel_apagar";
            this.cancel_apagar.Size = new System.Drawing.Size(102, 23);
            this.cancel_apagar.TabIndex = 15;
            this.cancel_apagar.Text = "Cancelar";
            this.cancel_apagar.UseVisualStyleBackColor = true;
            this.cancel_apagar.Click += new System.EventHandler(this.cancel_apagar_Click);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 60;
            // 
            // ColumnTitulo
            // 
            this.ColumnTitulo.HeaderText = "Título";
            this.ColumnTitulo.Name = "ColumnTitulo";
            this.ColumnTitulo.Width = 220;
            // 
            // ColumnPrioridade
            // 
            this.ColumnPrioridade.HeaderText = "Prioridade";
            this.ColumnPrioridade.Name = "ColumnPrioridade";
            this.ColumnPrioridade.Width = 90;
            // 
            // ColumnDescricao
            // 
            this.ColumnDescricao.HeaderText = "Descrição";
            this.ColumnDescricao.Name = "ColumnDescricao";
            this.ColumnDescricao.Width = 350;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::tasks.Properties.Resources.fundo_abstrato_azul_formas_geometricas_1017_15490;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 465);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridTasks);
            this.Controls.Add(this.actions_task);
            this.Controls.Add(this.groupBoxConfirmApagaTask);
            this.Controls.Add(this.groupBoxEditTask);
            this.Controls.Add(this.groupBoxInsertTask);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            this.groupBoxInsertTask.ResumeLayout(false);
            this.groupBoxInsertTask.PerformLayout();
            this.actions_task.ResumeLayout(false);
            this.groupBoxEditTask.ResumeLayout(false);
            this.groupBoxEditTask.PerformLayout();
            this.groupBoxConfirmApagaTask.ResumeLayout(false);
            this.groupBoxConfirmApagaTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insert_task;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.ComboBox prioridade;
        private System.Windows.Forms.Label Título;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar_insert;
        private System.Windows.Forms.DataGridView gridTasks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxInsertTask;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.GroupBox actions_task;
        private System.Windows.Forms.Button update_task;
        private System.Windows.Forms.Button hide_actions_task;
        private System.Windows.Forms.Button delete_task;
        private System.Windows.Forms.GroupBox groupBoxEditTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button edit_task;
        private System.Windows.Forms.TextBox edit_descricao;
        private System.Windows.Forms.TextBox edit_titulo;
        private System.Windows.Forms.Button cancela_edit;
        private System.Windows.Forms.ComboBox edit_prioridade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edit_id;
        private System.Windows.Forms.GroupBox groupBoxConfirmApagaTask;
        private System.Windows.Forms.TextBox delete_id_task;
        private System.Windows.Forms.Button confirm_apagar;
        private System.Windows.Forms.Button cancel_apagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescricao;
    }
}

