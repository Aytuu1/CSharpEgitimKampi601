﻿namespace CSharpEgitimKampi601
{
  partial class FrmEmployee
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
      this.btnGetById = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnList = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtEmployeeName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtEmployeeId = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.cmbEmployeeDepartment = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnGetById
      // 
      this.btnGetById.BackColor = System.Drawing.SystemColors.Info;
      this.btnGetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnGetById.Location = new System.Drawing.Point(170, 371);
      this.btnGetById.Name = "btnGetById";
      this.btnGetById.Size = new System.Drawing.Size(141, 29);
      this.btnGetById.TabIndex = 49;
      this.btnGetById.Text = "Id\'ye Göre Getir";
      this.btnGetById.UseVisualStyleBackColor = false;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(317, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.Size = new System.Drawing.Size(841, 291);
      this.dataGridView1.TabIndex = 48;
      // 
      // btnUpdate
      // 
      this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnUpdate.Location = new System.Drawing.Point(170, 335);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(141, 29);
      this.btnUpdate.TabIndex = 47;
      this.btnUpdate.Text = "Güncelle";
      this.btnUpdate.UseVisualStyleBackColor = false;
      // 
      // btnDelete
      // 
      this.btnDelete.BackColor = System.Drawing.SystemColors.Info;
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnDelete.Location = new System.Drawing.Point(170, 299);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(141, 30);
      this.btnDelete.TabIndex = 46;
      this.btnDelete.Text = "Sil";
      this.btnDelete.UseVisualStyleBackColor = false;
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnAdd.Location = new System.Drawing.Point(170, 264);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(141, 29);
      this.btnAdd.TabIndex = 45;
      this.btnAdd.Text = "Ekle";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnList
      // 
      this.btnList.BackColor = System.Drawing.SystemColors.Info;
      this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnList.Location = new System.Drawing.Point(170, 229);
      this.btnList.Name = "btnList";
      this.btnList.Size = new System.Drawing.Size(141, 29);
      this.btnList.TabIndex = 44;
      this.btnList.Text = "Listele";
      this.btnList.UseVisualStyleBackColor = false;
      this.btnList.Click += new System.EventHandler(this.btnList_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.Location = new System.Drawing.Point(20, 177);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(107, 20);
      this.label4.TabIndex = 42;
      this.label4.Text = "Departman:";
      // 
      // txtEmployeeSalary
      // 
      this.txtEmployeeSalary.Location = new System.Drawing.Point(170, 141);
      this.txtEmployeeSalary.Name = "txtEmployeeSalary";
      this.txtEmployeeSalary.Size = new System.Drawing.Size(141, 20);
      this.txtEmployeeSalary.TabIndex = 41;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.Location = new System.Drawing.Point(20, 139);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(140, 20);
      this.label3.TabIndex = 40;
      this.label3.Text = "Personel Maaş:";
      // 
      // txtEmployeeName
      // 
      this.txtEmployeeName.Location = new System.Drawing.Point(170, 68);
      this.txtEmployeeName.Name = "txtEmployeeName";
      this.txtEmployeeName.Size = new System.Drawing.Size(141, 20);
      this.txtEmployeeName.TabIndex = 39;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(20, 68);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(122, 20);
      this.label2.TabIndex = 38;
      this.label2.Text = "Personel Adı:";
      // 
      // txtEmployeeId
      // 
      this.txtEmployeeId.Location = new System.Drawing.Point(170, 30);
      this.txtEmployeeId.Name = "txtEmployeeId";
      this.txtEmployeeId.Size = new System.Drawing.Size(141, 20);
      this.txtEmployeeId.TabIndex = 37;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(20, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(114, 20);
      this.label1.TabIndex = 36;
      this.label1.Text = "Personel ID:";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // txtEmployeeSurname
      // 
      this.txtEmployeeSurname.Location = new System.Drawing.Point(170, 105);
      this.txtEmployeeSurname.Name = "txtEmployeeSurname";
      this.txtEmployeeSurname.Size = new System.Drawing.Size(141, 20);
      this.txtEmployeeSurname.TabIndex = 51;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label5.Location = new System.Drawing.Point(20, 103);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(151, 20);
      this.label5.TabIndex = 50;
      this.label5.Text = "Personel Soyadı:";
      // 
      // cmbEmployeeDepartment
      // 
      this.cmbEmployeeDepartment.FormattingEnabled = true;
      this.cmbEmployeeDepartment.Location = new System.Drawing.Point(170, 179);
      this.cmbEmployeeDepartment.Name = "cmbEmployeeDepartment";
      this.cmbEmployeeDepartment.Size = new System.Drawing.Size(141, 21);
      this.cmbEmployeeDepartment.TabIndex = 52;
      // 
      // FrmEmployee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1160, 450);
      this.Controls.Add(this.cmbEmployeeDepartment);
      this.Controls.Add(this.txtEmployeeSurname);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnGetById);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.btnList);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtEmployeeSalary);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtEmployeeName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtEmployeeId);
      this.Controls.Add(this.label1);
      this.Name = "FrmEmployee";
      this.Text = "FrmEmployee";
      this.Load += new System.EventHandler(this.FrmEmployee_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnGetById;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnList;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtEmployeeSalary;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtEmployeeName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtEmployeeId;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtEmployeeSurname;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cmbEmployeeDepartment;
  }
}