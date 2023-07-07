namespace EmployeeManagementSystem
{
    partial class Department
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDepUpdate = new System.Windows.Forms.Button();
            this.btnDepAdd = new System.Windows.Forms.Button();
            this.dgvDepList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Emplbl = new System.Windows.Forms.Label();
            this.Deplbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Salarylbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Logoutlbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 684);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 20);
            this.panel2.TabIndex = 46;
            // 
            // btnDepUpdate
            // 
            this.btnDepUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDepUpdate.FlatAppearance.BorderSize = 0;
            this.btnDepUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDepUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnDepUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepUpdate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDepUpdate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDepUpdate.Location = new System.Drawing.Point(104, 510);
            this.btnDepUpdate.Name = "btnDepUpdate";
            this.btnDepUpdate.Size = new System.Drawing.Size(106, 42);
            this.btnDepUpdate.TabIndex = 45;
            this.btnDepUpdate.Text = "Update";
            this.btnDepUpdate.UseVisualStyleBackColor = false;
            this.btnDepUpdate.Click += new System.EventHandler(this.btnDepUpdate_Click);
            // 
            // btnDepAdd
            // 
            this.btnDepAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDepAdd.FlatAppearance.BorderSize = 0;
            this.btnDepAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDepAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnDepAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDepAdd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDepAdd.Location = new System.Drawing.Point(104, 417);
            this.btnDepAdd.Name = "btnDepAdd";
            this.btnDepAdd.Size = new System.Drawing.Size(106, 42);
            this.btnDepAdd.TabIndex = 44;
            this.btnDepAdd.Text = "Add";
            this.btnDepAdd.UseVisualStyleBackColor = false;
            this.btnDepAdd.Click += new System.EventHandler(this.btnDepAdd_Click);
            // 
            // dgvDepList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDepList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepList.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepList.EnableHeadersVisualStyles = false;
            this.dgvDepList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepList.Location = new System.Drawing.Point(354, 194);
            this.dgvDepList.Name = "dgvDepList";
            this.dgvDepList.RowHeadersVisible = false;
            this.dgvDepList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepList.Size = new System.Drawing.Size(787, 457);
            this.dgvDepList.TabIndex = 41;
            this.dgvDepList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDepList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDepList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDepList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDepList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDepList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDepList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDepList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgvDepList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDepList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDepList.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvDepList.ThemeStyle.ReadOnly = false;
            this.dgvDepList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgvDepList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDepList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDepList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDepList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepList_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(43, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = " Departments  Name";
            // 
            // txtDepName
            // 
            this.txtDepName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepName.Location = new System.Drawing.Point(47, 346);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(258, 29);
            this.txtDepName.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(462, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = " Manage  Departments ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(400, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 65);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(674, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = " Departments  List";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(89, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // Emplbl
            // 
            this.Emplbl.AutoSize = true;
            this.Emplbl.BackColor = System.Drawing.Color.LightGray;
            this.Emplbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Emplbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emplbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.Emplbl.Location = new System.Drawing.Point(136, 83);
            this.Emplbl.Name = "Emplbl";
            this.Emplbl.Size = new System.Drawing.Size(88, 23);
            this.Emplbl.TabIndex = 49;
            this.Emplbl.Text = "Employee";
            this.Emplbl.Click += new System.EventHandler(this.Emplbl_Click);
            // 
            // Deplbl
            // 
            this.Deplbl.AutoSize = true;
            this.Deplbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deplbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.Deplbl.Location = new System.Drawing.Point(375, 83);
            this.Deplbl.Name = "Deplbl";
            this.Deplbl.Size = new System.Drawing.Size(121, 21);
            this.Deplbl.TabIndex = 50;
            this.Deplbl.Text = " Departments  ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(328, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // Salarylbl
            // 
            this.Salarylbl.AutoSize = true;
            this.Salarylbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salarylbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.Salarylbl.Location = new System.Drawing.Point(661, 83);
            this.Salarylbl.Name = "Salarylbl";
            this.Salarylbl.Size = new System.Drawing.Size(58, 21);
            this.Salarylbl.TabIndex = 50;
            this.Salarylbl.Text = "Salary";
            this.Salarylbl.Click += new System.EventHandler(this.Sallbl_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(614, 83);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // Logoutlbl
            // 
            this.Logoutlbl.AutoSize = true;
            this.Logoutlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutlbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.Logoutlbl.Location = new System.Drawing.Point(948, 83);
            this.Logoutlbl.Name = "Logoutlbl";
            this.Logoutlbl.Size = new System.Drawing.Size(64, 21);
            this.Logoutlbl.TabIndex = 50;
            this.Logoutlbl.Text = "Logout";
            this.Logoutlbl.Click += new System.EventHandler(this.Logoutlbl_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(901, 83);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDelete.Location = new System.Drawing.Point(104, 604);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 42);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(89, 194);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(156, 73);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 53;
            this.pictureBox6.TabStop = false;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 704);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Logoutlbl);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Salarylbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Deplbl);
            this.Controls.Add(this.Emplbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDepUpdate);
            this.Controls.Add(this.btnDepAdd);
            this.Controls.Add(this.dgvDepList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDepUpdate;
        private System.Windows.Forms.Button btnDepAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDepList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Emplbl;
        private System.Windows.Forms.Label Deplbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Salarylbl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Logoutlbl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}