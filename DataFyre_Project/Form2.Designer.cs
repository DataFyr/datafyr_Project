namespace datascience_project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.subcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_link_text = new System.Windows.Forms.TextBox();
            this.textbox_sub_link_text = new System.Windows.Forms.TextBox();
            this.textbox_link_content = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Content = new System.Windows.Forms.DataGridViewButtonColumn();
            this.user_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.linkBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.linkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.linkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ddl_category = new System.Windows.Forms.ComboBox();
            this.tblcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddl_sub_category_name = new System.Windows.Forms.ComboBox();
            this.ddll_link_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_link_published_date = new System.Windows.Forms.TextBox();
            this.textbox_link_author = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblcategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // subcategoryBindingSource
            // 
            this.subcategoryBindingSource.DataMember = "subcategory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(183, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(183, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Source Sub Link Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(183, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Link Content";
            // 
            // textbox_link_text
            // 
            this.textbox_link_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_link_text.Location = new System.Drawing.Point(344, 87);
            this.textbox_link_text.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_link_text.Name = "textbox_link_text";
            this.textbox_link_text.Size = new System.Drawing.Size(648, 26);
            this.textbox_link_text.TabIndex = 12;
            // 
            // textbox_sub_link_text
            // 
            this.textbox_sub_link_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textbox_sub_link_text.Location = new System.Drawing.Point(344, 123);
            this.textbox_sub_link_text.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_sub_link_text.Name = "textbox_sub_link_text";
            this.textbox_sub_link_text.Size = new System.Drawing.Size(648, 26);
            this.textbox_sub_link_text.TabIndex = 13;
            // 
            // textbox_link_content
            // 
            this.textbox_link_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textbox_link_content.Location = new System.Drawing.Point(344, 157);
            this.textbox_link_content.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_link_content.Name = "textbox_link_content";
            this.textbox_link_content.Size = new System.Drawing.Size(648, 26);
            this.textbox_link_content.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(873, 371);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 40);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(744, 445);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 40);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(873, 445);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 40);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Content,
            this.user_fullname,
            this.date});
            this.dataGridView1.Location = new System.Drawing.Point(188, 489);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(810, 278);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Format = "Show Content";
            dataGridViewCellStyle2.NullValue = "Show Content";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.Content.DefaultCellStyle = dataGridViewCellStyle2;
            this.Content.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Content.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Content.Text = "Content";
            // 
            // user_fullname
            // 
            this.user_fullname.DataPropertyName = "user_fullname";
            this.user_fullname.HeaderText = "user_fullname";
            this.user_fullname.Name = "user_fullname";
            this.user_fullname.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // linkBindingSource3
            // 
            this.linkBindingSource3.DataMember = "link";
            // 
            // linkBindingSource2
            // 
            this.linkBindingSource2.DataMember = "link";
            // 
            // linkBindingSource1
            // 
            this.linkBindingSource1.DataMember = "link";
            // 
            // linkBindingSource
            // 
            this.linkBindingSource.DataMember = "link";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "Export to Excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.btnMinimize);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1021, 26);
            this.panel5.TabIndex = 41;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data Source Management";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(972, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "⎯";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(999, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panel6.Controls.Add(this.btnImport);
            this.panel6.Controls.Add(this.dashboardbtn);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 752);
            this.panel6.TabIndex = 42;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(0, 294);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(164, 47);
            this.btnImport.TabIndex = 38;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dashboardbtn.FlatAppearance.BorderSize = 0;
            this.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dashboardbtn.ForeColor = System.Drawing.Color.White;
            this.dashboardbtn.Location = new System.Drawing.Point(0, -1);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(164, 47);
            this.dashboardbtn.TabIndex = 37;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = false;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 705);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(167, 47);
            this.button7.TabIndex = 36;
            this.button7.Text = "Log Out";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 191);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 47);
            this.button5.TabIndex = 34;
            this.button5.Text = "View";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 47);
            this.button4.TabIndex = 33;
            this.button4.Text = "Users";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 47);
            this.button3.TabIndex = 32;
            this.button3.Text = "Sources";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 47);
            this.button2.TabIndex = 31;
            this.button2.Text = "Indicators";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.subCategoryToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 47);
            this.button6.TabIndex = 30;
            this.button6.Text = "Projects";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // ddl_category
            // 
            this.ddl_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ddl_category.FormattingEnabled = true;
            this.ddl_category.Location = new System.Drawing.Point(344, 192);
            this.ddl_category.Margin = new System.Windows.Forms.Padding(2);
            this.ddl_category.Name = "ddl_category";
            this.ddl_category.Size = new System.Drawing.Size(648, 28);
            this.ddl_category.TabIndex = 46;
            this.ddl_category.SelectedIndexChanged += new System.EventHandler(this.ddl_category_SelectedIndexChanged);
            // 
            // tblcategoryBindingSource
            // 
            this.tblcategoryBindingSource.DataMember = "tbl_category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(183, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(183, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Indicators";
            // 
            // ddl_sub_category_name
            // 
            this.ddl_sub_category_name.DataSource = this.subcategoryBindingSource;
            this.ddl_sub_category_name.DisplayMember = "subcategory_name";
            this.ddl_sub_category_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_sub_category_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ddl_sub_category_name.FormattingEnabled = true;
            this.ddl_sub_category_name.Location = new System.Drawing.Point(344, 225);
            this.ddl_sub_category_name.Margin = new System.Windows.Forms.Padding(2);
            this.ddl_sub_category_name.Name = "ddl_sub_category_name";
            this.ddl_sub_category_name.Size = new System.Drawing.Size(648, 28);
            this.ddl_sub_category_name.TabIndex = 49;
            this.ddl_sub_category_name.ValueMember = "subcategory_id";
            // 
            // ddll_link_type
            // 
            this.ddll_link_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddll_link_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ddll_link_type.FormattingEnabled = true;
            this.ddll_link_type.Items.AddRange(new object[] {
            "Youtube",
            "LinkedIn",
            "Google",
            "Website"});
            this.ddll_link_type.Location = new System.Drawing.Point(344, 258);
            this.ddll_link_type.Margin = new System.Windows.Forms.Padding(2);
            this.ddll_link_type.Name = "ddll_link_type";
            this.ddll_link_type.Size = new System.Drawing.Size(648, 28);
            this.ddll_link_type.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(183, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Data Source";
            // 
            // textbox_link_published_date
            // 
            this.textbox_link_published_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textbox_link_published_date.Location = new System.Drawing.Point(344, 330);
            this.textbox_link_published_date.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_link_published_date.Name = "textbox_link_published_date";
            this.textbox_link_published_date.Size = new System.Drawing.Size(646, 26);
            this.textbox_link_published_date.TabIndex = 54;
            // 
            // textbox_link_author
            // 
            this.textbox_link_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textbox_link_author.Location = new System.Drawing.Point(344, 295);
            this.textbox_link_author.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_link_author.Name = "textbox_link_author";
            this.textbox_link_author.Size = new System.Drawing.Size(646, 26);
            this.textbox_link_author.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(183, 336);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Published Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(181, 295);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Source Author";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 778);
            this.Controls.Add(this.textbox_link_published_date);
            this.Controls.Add(this.textbox_link_author);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddl_sub_category_name);
            this.Controls.Add(this.ddll_link_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddl_category);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textbox_link_content);
            this.Controls.Add(this.textbox_sub_link_text);
            this.Controls.Add(this.textbox_link_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblcategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_link_text;
        private System.Windows.Forms.TextBox textbox_sub_link_text;
        private System.Windows.Forms.TextBox textbox_link_content;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource linkBindingSource;
        private System.Windows.Forms.BindingSource subcategoryBindingSource;
        private System.Windows.Forms.BindingSource linkBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource linkBindingSource2;
        private System.Windows.Forms.BindingSource linkBindingSource3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddl_category;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddl_sub_category_name;
        private System.Windows.Forms.ComboBox ddll_link_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource tblcategoryBindingSource;
        private System.Windows.Forms.TextBox textbox_link_published_date;
        private System.Windows.Forms.TextBox textbox_link_author;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewButtonColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}