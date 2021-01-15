namespace QLPT
{
    partial class frmBuilding
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBuilding = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtAddressBuilding = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddBuilding = new System.Windows.Forms.Button();
            this.btnDelBuilding = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtIDBuilding = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditBuilding = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 681);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(450, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 681);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 65);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 46);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh sách dãy nhà";
            // 
            // dgvBuilding
            // 
            this.dgvBuilding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuilding.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuilding.Location = new System.Drawing.Point(0, 0);
            this.dgvBuilding.Name = "dgvBuilding";
            this.dgvBuilding.RowHeadersWidth = 51;
            this.dgvBuilding.RowTemplate.Height = 24;
            this.dgvBuilding.Size = new System.Drawing.Size(558, 616);
            this.dgvBuilding.TabIndex = 0;
            this.dgvBuilding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuilding_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btnAddBuilding);
            this.panel2.Controls.Add(this.btnDelBuilding);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnEditBuilding);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 681);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.AliceBlue;
            this.panel7.Controls.Add(this.txtAddressBuilding);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 200);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(450, 100);
            this.panel7.TabIndex = 2;
            // 
            // txtAddressBuilding
            // 
            this.txtAddressBuilding.Location = new System.Drawing.Point(192, 43);
            this.txtAddressBuilding.Name = "txtAddressBuilding";
            this.txtAddressBuilding.Size = new System.Drawing.Size(230, 22);
            this.txtAddressBuilding.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.BackColor = System.Drawing.Color.Silver;
            this.btnAddBuilding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddBuilding.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBuilding.Location = new System.Drawing.Point(0, 516);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(450, 55);
            this.btnAddBuilding.TabIndex = 4;
            this.btnAddBuilding.Text = "Thêm dãy nhà";
            this.btnAddBuilding.UseVisualStyleBackColor = false;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // btnDelBuilding
            // 
            this.btnDelBuilding.BackColor = System.Drawing.Color.Silver;
            this.btnDelBuilding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelBuilding.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelBuilding.Location = new System.Drawing.Point(0, 571);
            this.btnDelBuilding.Name = "btnDelBuilding";
            this.btnDelBuilding.Size = new System.Drawing.Size(450, 55);
            this.btnDelBuilding.TabIndex = 5;
            this.btnDelBuilding.Text = "Xóa dãy nhà";
            this.btnDelBuilding.UseVisualStyleBackColor = false;
            this.btnDelBuilding.Click += new System.EventHandler(this.btnDelBuilding_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Controls.Add(this.txtIDBuilding);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(450, 100);
            this.panel6.TabIndex = 1;
            // 
            // txtIDBuilding
            // 
            this.txtIDBuilding.Location = new System.Drawing.Point(192, 35);
            this.txtIDBuilding.Name = "txtIDBuilding";
            this.txtIDBuilding.Size = new System.Drawing.Size(230, 22);
            this.txtIDBuilding.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã dãy";
            // 
            // btnEditBuilding
            // 
            this.btnEditBuilding.BackColor = System.Drawing.Color.Silver;
            this.btnEditBuilding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditBuilding.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBuilding.Location = new System.Drawing.Point(0, 626);
            this.btnEditBuilding.Name = "btnEditBuilding";
            this.btnEditBuilding.Size = new System.Drawing.Size(450, 55);
            this.btnEditBuilding.TabIndex = 6;
            this.btnEditBuilding.Text = "Sửa thông tin dãy nhà";
            this.btnEditBuilding.UseVisualStyleBackColor = false;
            this.btnEditBuilding.Click += new System.EventHandler(this.btnEditBuilding_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 100);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "DÃY NHÀ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvBuilding);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 65);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(558, 616);
            this.panel8.TabIndex = 2;
            // 
            // frmBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panel1);
            this.Name = "frmBuilding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dãy nhà";
            this.Load += new System.EventHandler(this.frmBuilding_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtAddressBuilding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddBuilding;
        private System.Windows.Forms.Button btnDelBuilding;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIDBuilding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditBuilding;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBuilding;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
    }
}