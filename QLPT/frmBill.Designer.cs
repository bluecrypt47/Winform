namespace QLPT
{
    partial class frmBill
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDelCustomer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxCMND = new System.Windows.Forms.ComboBox();
            this.cbxIDRoom = new System.Windows.Forms.ComboBox();
            this.txtPriceRoom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNewNumberWater = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOldNumberWater = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewNumberElectirc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOldNumberElectirc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 720);
            this.panel1.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAddCustomer);
            this.panel7.Controls.Add(this.btnEditCustomer);
            this.panel7.Controls.Add(this.btnDelCustomer);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(466, 552);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(693, 168);
            this.panel7.TabIndex = 2;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Silver;
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddCustomer.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(0, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(693, 55);
            this.btnAddCustomer.TabIndex = 12;
            this.btnAddCustomer.Text = "Thêm hóa đơn";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.Silver;
            this.btnEditCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditCustomer.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.Location = new System.Drawing.Point(0, 58);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(693, 55);
            this.btnEditCustomer.TabIndex = 13;
            this.btnEditCustomer.Text = "Sửa thông tin hóa đơn ";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDelCustomer
            // 
            this.btnDelCustomer.BackColor = System.Drawing.Color.Silver;
            this.btnDelCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelCustomer.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCustomer.Location = new System.Drawing.Point(0, 113);
            this.btnDelCustomer.Name = "btnDelCustomer";
            this.btnDelCustomer.Size = new System.Drawing.Size(693, 55);
            this.btnDelCustomer.TabIndex = 14;
            this.btnDelCustomer.Text = "Xóa hóa đơn";
            this.btnDelCustomer.UseVisualStyleBackColor = false;
            this.btnDelCustomer.Click += new System.EventHandler(this.btnDelCustomer_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(466, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 720);
            this.panel3.TabIndex = 1;
            // 
            // dgvBill
            // 
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBill.Location = new System.Drawing.Point(0, 0);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(693, 549);
            this.dgvBill.TabIndex = 15;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 720);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.AliceBlue;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.txtTotalBill);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 524);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 196);
            this.panel5.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(164, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 33);
            this.label14.TabIndex = 23;
            this.label14.Text = "Tổng tiền";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(240, 109);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(207, 22);
            this.txtTotalBill.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Controls.Add(this.cbxCMND);
            this.panel6.Controls.Add(this.cbxIDRoom);
            this.panel6.Controls.Add(this.txtPriceRoom);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.txtNewNumberWater);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.txtOldNumberWater);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txtNewNumberElectirc);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtOldNumberElectirc);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtDateTime);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtIDBill);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(466, 446);
            this.panel6.TabIndex = 8;
            // 
            // cbxCMND
            // 
            this.cbxCMND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCMND.FormattingEnabled = true;
            this.cbxCMND.Location = new System.Drawing.Point(240, 103);
            this.cbxCMND.Name = "cbxCMND";
            this.cbxCMND.Size = new System.Drawing.Size(207, 24);
            this.cbxCMND.Sorted = true;
            this.cbxCMND.TabIndex = 3;
            // 
            // cbxIDRoom
            // 
            this.cbxIDRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDRoom.FormattingEnabled = true;
            this.cbxIDRoom.Location = new System.Drawing.Point(240, 58);
            this.cbxIDRoom.Name = "cbxIDRoom";
            this.cbxIDRoom.Size = new System.Drawing.Size(207, 24);
            this.cbxIDRoom.Sorted = true;
            this.cbxIDRoom.TabIndex = 2;
            // 
            // txtPriceRoom
            // 
            this.txtPriceRoom.Location = new System.Drawing.Point(240, 359);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.Size = new System.Drawing.Size(207, 22);
            this.txtPriceRoom.TabIndex = 9;
            this.txtPriceRoom.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(80, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 33);
            this.label13.TabIndex = 22;
            this.label13.Text = "Giá phòng";
            // 
            // txtNewNumberWater
            // 
            this.txtNewNumberWater.Location = new System.Drawing.Point(240, 320);
            this.txtNewNumberWater.Name = "txtNewNumberWater";
            this.txtNewNumberWater.Size = new System.Drawing.Size(207, 22);
            this.txtNewNumberWater.TabIndex = 8;
            this.txtNewNumberWater.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-9, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 33);
            this.label9.TabIndex = 14;
            this.label9.Text = "Chỉ số nước mới";
            // 
            // txtOldNumberWater
            // 
            this.txtOldNumberWater.Location = new System.Drawing.Point(240, 276);
            this.txtOldNumberWater.Name = "txtOldNumberWater";
            this.txtOldNumberWater.Size = new System.Drawing.Size(207, 22);
            this.txtOldNumberWater.TabIndex = 7;
            this.txtOldNumberWater.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 33);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chỉ số nước cũ";
            // 
            // txtNewNumberElectirc
            // 
            this.txtNewNumberElectirc.Location = new System.Drawing.Point(240, 233);
            this.txtNewNumberElectirc.Name = "txtNewNumberElectirc";
            this.txtNewNumberElectirc.Size = new System.Drawing.Size(207, 22);
            this.txtNewNumberElectirc.TabIndex = 6;
            this.txtNewNumberElectirc.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 33);
            this.label7.TabIndex = 10;
            this.label7.Text = "Chỉ số điện mới";
            // 
            // txtOldNumberElectirc
            // 
            this.txtOldNumberElectirc.Location = new System.Drawing.Point(240, 190);
            this.txtOldNumberElectirc.Name = "txtOldNumberElectirc";
            this.txtOldNumberElectirc.Size = new System.Drawing.Size(207, 22);
            this.txtOldNumberElectirc.TabIndex = 5;
            this.txtOldNumberElectirc.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 33);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chỉ số điện cũ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "CMND";
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(240, 147);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(207, 22);
            this.txtDateTime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập";
            // 
            // txtIDBill
            // 
            this.txtIDBill.Location = new System.Drawing.Point(240, 12);
            this.txtIDBill.Name = "txtIDBill";
            this.txtIDBill.Size = new System.Drawing.Size(207, 22);
            this.txtIDBill.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 78);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(86, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 101);
            this.button1.TabIndex = 24;
            this.button1.Text = "In hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 720);
            this.Controls.Add(this.panel1);
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIDBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewNumberWater;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOldNumberWater;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewNumberElectirc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOldNumberElectirc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.TextBox txtPriceRoom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxCMND;
        private System.Windows.Forms.ComboBox cbxIDRoom;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDelCustomer;
        private System.Windows.Forms.Button button1;
    }
}