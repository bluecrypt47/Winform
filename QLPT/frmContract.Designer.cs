namespace QLPT
{
    partial class frmContract
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnDelAccount = new System.Windows.Forms.Button();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxCMND = new System.Windows.Forms.ComboBox();
            this.cbxNumberRoom = new System.Windows.Forms.ComboBox();
            this.cbxStatusDepositMoney = new System.Windows.Forms.ComboBox();
            this.txtDepositMoney = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtSexual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDContract = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 720);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.dgvContract);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(450, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 720);
            this.panel3.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Control;
            this.panel10.Controls.Add(this.btnEditAccount);
            this.panel10.Controls.Add(this.btnAddAccount);
            this.panel10.Controls.Add(this.btnDelAccount);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 552);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(582, 168);
            this.panel10.TabIndex = 1;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.Color.Silver;
            this.btnEditAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditAccount.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.Location = new System.Drawing.Point(0, 0);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(582, 58);
            this.btnEditAccount.TabIndex = 11;
            this.btnEditAccount.Text = "Sửa thông tin hợp đồng";
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Silver;
            this.btnAddAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddAccount.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Location = new System.Drawing.Point(0, 58);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(582, 55);
            this.btnAddAccount.TabIndex = 12;
            this.btnAddAccount.Text = "Thêm hợp đồng";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnDelAccount
            // 
            this.btnDelAccount.BackColor = System.Drawing.Color.Silver;
            this.btnDelAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelAccount.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAccount.Location = new System.Drawing.Point(0, 113);
            this.btnDelAccount.Name = "btnDelAccount";
            this.btnDelAccount.Size = new System.Drawing.Size(582, 55);
            this.btnDelAccount.TabIndex = 13;
            this.btnDelAccount.Text = "Xóa hợp dồng";
            this.btnDelAccount.UseVisualStyleBackColor = false;
            this.btnDelAccount.Click += new System.EventHandler(this.btnDelAccount_Click);
            // 
            // dgvContract
            // 
            this.dgvContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContract.BackgroundColor = System.Drawing.Color.White;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvContract.Location = new System.Drawing.Point(0, 0);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.RowHeadersWidth = 51;
            this.dgvContract.RowTemplate.Height = 24;
            this.dgvContract.Size = new System.Drawing.Size(582, 552);
            this.dgvContract.TabIndex = 14;
            this.dgvContract.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContract_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 720);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Controls.Add(this.cbxCMND);
            this.panel6.Controls.Add(this.cbxNumberRoom);
            this.panel6.Controls.Add(this.cbxStatusDepositMoney);
            this.panel6.Controls.Add(this.txtDepositMoney);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.txtDateTime);
            this.panel6.Controls.Add(this.txtSexual);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtName);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtLastName);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.txtSurName);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtIDContract);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(450, 617);
            this.panel6.TabIndex = 8;
            // 
            // cbxCMND
            // 
            this.cbxCMND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCMND.FormattingEnabled = true;
            this.cbxCMND.Location = new System.Drawing.Point(246, 115);
            this.cbxCMND.Name = "cbxCMND";
            this.cbxCMND.Size = new System.Drawing.Size(198, 24);
            this.cbxCMND.TabIndex = 3;
            // 
            // cbxNumberRoom
            // 
            this.cbxNumberRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumberRoom.FormattingEnabled = true;
            this.cbxNumberRoom.Location = new System.Drawing.Point(246, 72);
            this.cbxNumberRoom.Name = "cbxNumberRoom";
            this.cbxNumberRoom.Size = new System.Drawing.Size(198, 24);
            this.cbxNumberRoom.TabIndex = 2;
            // 
            // cbxStatusDepositMoney
            // 
            this.cbxStatusDepositMoney.FormattingEnabled = true;
            this.cbxStatusDepositMoney.Items.AddRange(new object[] {
            "Đã cọc",
            "Chưa"});
            this.cbxStatusDepositMoney.Location = new System.Drawing.Point(246, 405);
            this.cbxStatusDepositMoney.Name = "cbxStatusDepositMoney";
            this.cbxStatusDepositMoney.Size = new System.Drawing.Size(199, 24);
            this.cbxStatusDepositMoney.TabIndex = 19;
            // 
            // txtDepositMoney
            // 
            this.txtDepositMoney.Location = new System.Drawing.Point(246, 458);
            this.txtDepositMoney.Name = "txtDepositMoney";
            this.txtDepositMoney.Size = new System.Drawing.Size(198, 22);
            this.txtDepositMoney.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(110, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 33);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tiền cọc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 33);
            this.label13.TabIndex = 16;
            this.label13.Text = "Tình trạng cọc";
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(246, 357);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(198, 22);
            this.txtDateTime.TabIndex = 8;
            // 
            // txtSexual
            // 
            this.txtSexual.Location = new System.Drawing.Point(246, 305);
            this.txtSexual.Name = "txtSexual";
            this.txtSexual.Size = new System.Drawing.Size(198, 22);
            this.txtSexual.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày chuyển vào";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(246, 262);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 22);
            this.txtName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giới tính";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(246, 213);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(198, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 33);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 33);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên lót";
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(246, 167);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(198, 22);
            this.txtSurName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "CMND";
            // 
            // txtIDContract
            // 
            this.txtIDContract.Location = new System.Drawing.Point(246, 23);
            this.txtIDContract.Name = "txtIDContract";
            this.txtIDContract.Size = new System.Drawing.Size(198, 22);
            this.txtIDContract.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hợp đồng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 100);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hợp đồng";
            // 
            // frmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 720);
            this.Controls.Add(this.panel1);
            this.Name = "frmContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hợp đồng";
            this.Load += new System.EventHandler(this.frmContract_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnDelAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIDContract;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtDepositMoney;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtSexual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxStatusDepositMoney;
        private System.Windows.Forms.ComboBox cbxCMND;
        private System.Windows.Forms.ComboBox cbxNumberRoom;
    }
}