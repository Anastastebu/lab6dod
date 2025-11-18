namespace WindowsFormsApp1
{
    partial class Form1
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
            this.A_matrix_dgv = new System.Windows.Forms.DataGridView();
            this.C_matrix_dgv = new System.Windows.Forms.DataGridView();
            this.B_vector_dgv = new System.Windows.Forms.DataGridView();
            this.X_vector_dgv = new System.Windows.Forms.DataGridView();
            this.BCreateGrid = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.NUD_rozmir = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Method = new System.Windows.Forms.Label();
            this.method_Selector_cmbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_matrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).BeginInit();
            this.SuspendLayout();
            // 
            // A_matrix_dgv
            // 
            this.A_matrix_dgv.AllowUserToAddRows = false;
            this.A_matrix_dgv.AllowUserToDeleteRows = false;
            this.A_matrix_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.A_matrix_dgv.ColumnHeadersVisible = false;
            this.A_matrix_dgv.Location = new System.Drawing.Point(12, 114);
            this.A_matrix_dgv.Name = "A_matrix_dgv";
            this.A_matrix_dgv.RowHeadersVisible = false;
            this.A_matrix_dgv.Size = new System.Drawing.Size(268, 140);
            this.A_matrix_dgv.TabIndex = 0;
            this.A_matrix_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.A_matrix_dgv_CellClick);
            // 
            // C_matrix_dgv
            // 
            this.C_matrix_dgv.AllowUserToAddRows = false;
            this.C_matrix_dgv.AllowUserToDeleteRows = false;
            this.C_matrix_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.C_matrix_dgv.ColumnHeadersVisible = false;
            this.C_matrix_dgv.Location = new System.Drawing.Point(12, 293);
            this.C_matrix_dgv.Name = "C_matrix_dgv";
            this.C_matrix_dgv.RowHeadersVisible = false;
            this.C_matrix_dgv.Size = new System.Drawing.Size(268, 140);
            this.C_matrix_dgv.TabIndex = 1;
            // 
            // B_vector_dgv
            // 
            this.B_vector_dgv.AllowUserToAddRows = false;
            this.B_vector_dgv.AllowUserToDeleteRows = false;
            this.B_vector_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.B_vector_dgv.ColumnHeadersVisible = false;
            this.B_vector_dgv.Location = new System.Drawing.Point(298, 114);
            this.B_vector_dgv.Name = "B_vector_dgv";
            this.B_vector_dgv.ReadOnly = false;
            this.B_vector_dgv.RowHeadersVisible = false;
            this.B_vector_dgv.Size = new System.Drawing.Size(80, 140);
            this.B_vector_dgv.TabIndex = 2;
            this.B_vector_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.B_vector_dgv_CellClick);
            // 
            // X_vector_dgv
            // 
            this.X_vector_dgv.AllowUserToAddRows = false;
            this.X_vector_dgv.AllowUserToDeleteRows = false;
            this.X_vector_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.X_vector_dgv.ColumnHeadersVisible = false;
            this.X_vector_dgv.Location = new System.Drawing.Point(395, 114);
            this.X_vector_dgv.Name = "X_vector_dgv";
            this.X_vector_dgv.ReadOnly = true;
            this.X_vector_dgv.RowHeadersVisible = false;
            this.X_vector_dgv.Size = new System.Drawing.Size(80, 140);
            this.X_vector_dgv.TabIndex = 3;
            // 
            // BCreateGrid
            // 
            this.BCreateGrid.Location = new System.Drawing.Point(298, 293);
            this.BCreateGrid.Name = "BCreateGrid";
            this.BCreateGrid.Size = new System.Drawing.Size(177, 30);
            this.BCreateGrid.TabIndex = 4;
            this.BCreateGrid.Text = "Розв\'язати";
            this.BCreateGrid.UseVisualStyleBackColor = true;
            this.BCreateGrid.Click += new System.EventHandler(this.BCreateGrid_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(298, 341);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(177, 30);
            this.BClear.TabIndex = 5;
            this.BClear.Text = "Очистити";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(298, 403);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(177, 30);
            this.BClose.TabIndex = 6;
            this.BClose.Text = "Вихід";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // NUD_rozmir
            // 
            this.NUD_rozmir.Location = new System.Drawing.Point(160, 20);
            this.NUD_rozmir.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_rozmir.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_rozmir.Name = "NUD_rozmir";
            this.NUD_rozmir.Size = new System.Drawing.Size(120, 20);
            this.NUD_rozmir.TabIndex = 7;
            this.NUD_rozmir.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_rozmir.ValueChanged += new System.EventHandler(this.NUD_rozmir_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оберіть розмір матриці А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Матриця А коефіцієнтів СЛАР";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вектор В";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вектор Х";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Матриця С коефіцієнтів L/U розкладу";
            // 
            // label_Method
            // 
            this.label_Method.AutoSize = true;
            this.label_Method.Location = new System.Drawing.Point(12, 57);
            this.label_Method.Name = "label_Method";
            this.label_Method.Size = new System.Drawing.Size(82, 13);
            this.label_Method.TabIndex = 13;
            this.label_Method.Text = "Оберіть метод:";
            // 
            // method_Selector_cmbx
            // 
            this.method_Selector_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.method_Selector_cmbx.FormattingEnabled = true;
            this.method_Selector_cmbx.Location = new System.Drawing.Point(160, 54);
            this.method_Selector_cmbx.Name = "method_Selector_cmbx";
            this.method_Selector_cmbx.Size = new System.Drawing.Size(218, 21);
            this.method_Selector_cmbx.TabIndex = 14;
            this.method_Selector_cmbx.SelectedIndexChanged += new System.EventHandler(this.method_Selector_cmbx_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 451);
            this.Controls.Add(this.method_Selector_cmbx);
            this.Controls.Add(this.label_Method);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_rozmir);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BCreateGrid);
            this.Controls.Add(this.X_vector_dgv);
            this.Controls.Add(this.B_vector_dgv);
            this.Controls.Add(this.C_matrix_dgv);
            this.Controls.Add(this.A_matrix_dgv);
            this.Name = "Form1";
            this.Text = "ХІО Розв\'язання СЛАР";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_matrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Оголошення полів для компонентів
        private System.Windows.Forms.DataGridView A_matrix_dgv;
        private System.Windows.Forms.DataGridView C_matrix_dgv;
        private System.Windows.Forms.DataGridView B_vector_dgv;
        private System.Windows.Forms.DataGridView X_vector_dgv;
        private System.Windows.Forms.Button BCreateGrid;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.NumericUpDown NUD_rozmir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        // Нові елементи:
        private System.Windows.Forms.Label label_Method;
        private System.Windows.Forms.ComboBox method_Selector_cmbx;
    }
}

