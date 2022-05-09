namespace calculator
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calciDataSet6 = new calculator.calciDataSet6();
            this.signBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signTableAdapter = new calculator.calciDataSet6TableAdapters.signTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERTYPE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UPDATE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calciDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.usertypeDataGridViewTextBoxColumn,
            this.USERTYPE,
            this.DELETE,
            this.UPDATE});
            this.dataGridView1.DataSource = this.signBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(942, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // calciDataSet6
            // 
            this.calciDataSet6.DataSetName = "calciDataSet6";
            this.calciDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // signBindingSource
            // 
            this.signBindingSource.DataMember = "sign";
            this.signBindingSource.DataSource = this.calciDataSet6;
            // 
            // signTableAdapter
            // 
            this.signTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // usertypeDataGridViewTextBoxColumn
            // 
            this.usertypeDataGridViewTextBoxColumn.DataPropertyName = "usertype";
            this.usertypeDataGridViewTextBoxColumn.HeaderText = "usertype";
            this.usertypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usertypeDataGridViewTextBoxColumn.Name = "usertypeDataGridViewTextBoxColumn";
            this.usertypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // USERTYPE
            // 
            this.USERTYPE.HeaderText = "USERTYPE";
            this.USERTYPE.Items.AddRange(new object[] {
            "admin",
            "user\t"});
            this.USERTYPE.MinimumWidth = 8;
            this.USERTYPE.Name = "USERTYPE";
            this.USERTYPE.Width = 150;
            // 
            // DELETE
            // 
            this.DELETE.DataPropertyName = "name";
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.MinimumWidth = 8;
            this.DELETE.Name = "DELETE";
            this.DELETE.Text = "DELETE";
            this.DELETE.UseColumnTextForButtonValue = true;
            this.DELETE.Width = 150;
            // 
            // UPDATE
            // 
            this.UPDATE.DataPropertyName = "name";
            this.UPDATE.HeaderText = "UPDATE";
            this.UPDATE.MinimumWidth = 8;
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseColumnTextForButtonValue = true;
            this.UPDATE.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go To App";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Log out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calciDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private calciDataSet6 calciDataSet6;
        private System.Windows.Forms.BindingSource signBindingSource;
        private calciDataSet6TableAdapters.signTableAdapter signTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn USERTYPE;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
        private System.Windows.Forms.DataGridViewButtonColumn UPDATE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}