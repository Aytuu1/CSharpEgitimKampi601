﻿namespace CSharpEgitimKampi601
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtCustomerID = new System.Windows.Forms.TextBox();
      this.txtCustomerName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtCustomerSurname = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtCustomerCity = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtCustomerBalance = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtCustomerShoppingCount = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.btnCustomerList = new System.Windows.Forms.Button();
      this.btnCustomerCreate = new System.Windows.Forms.Button();
      this.btnCustomerDelete = new System.Windows.Forms.Button();
      this.btnCustomerUpdate = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnGetCustomerID = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(49, 28);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Müşteri ID:";
      // 
      // txtCustomerID
      // 
      this.txtCustomerID.Location = new System.Drawing.Point(172, 28);
      this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtCustomerID.Name = "txtCustomerID";
      this.txtCustomerID.Size = new System.Drawing.Size(187, 22);
      this.txtCustomerID.TabIndex = 1;
      this.txtCustomerID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // txtCustomerName
      // 
      this.txtCustomerName.Location = new System.Drawing.Point(172, 78);
      this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtCustomerName.Name = "txtCustomerName";
      this.txtCustomerName.Size = new System.Drawing.Size(187, 22);
      this.txtCustomerName.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(39, 78);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(111, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Müşteri Adı:";
      // 
      // txtCustomerSurname
      // 
      this.txtCustomerSurname.Location = new System.Drawing.Point(172, 128);
      this.txtCustomerSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtCustomerSurname.Name = "txtCustomerSurname";
      this.txtCustomerSurname.Size = new System.Drawing.Size(187, 22);
      this.txtCustomerSurname.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.Location = new System.Drawing.Point(4, 128);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(140, 20);
      this.label3.TabIndex = 4;
      this.label3.Text = "Müşteri Soyadı:";
      // 
      // txtCustomerCity
      // 
      this.txtCustomerCity.Location = new System.Drawing.Point(172, 175);
      this.txtCustomerCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtCustomerCity.Name = "txtCustomerCity";
      this.txtCustomerCity.Size = new System.Drawing.Size(187, 22);
      this.txtCustomerCity.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.Location = new System.Drawing.Point(21, 175);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(128, 20);
      this.label4.TabIndex = 6;
      this.label4.Text = "Müşteri Şehir:";
      // 
      // txtCustomerBalance
      // 
      this.txtCustomerBalance.Location = new System.Drawing.Point(172, 225);
      this.txtCustomerBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtCustomerBalance.Name = "txtCustomerBalance";
      this.txtCustomerBalance.Size = new System.Drawing.Size(187, 22);
      this.txtCustomerBalance.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label5.Location = new System.Drawing.Point(77, 225);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(71, 20);
      this.label5.TabIndex = 8;
      this.label5.Text = "Bakiye:";
      // 
      // txtCustomerShoppingCount
      // 
      this.txtCustomerShoppingCount.Location = new System.Drawing.Point(172, 279);
      this.txtCustomerShoppingCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtCustomerShoppingCount.Name = "txtCustomerShoppingCount";
      this.txtCustomerShoppingCount.Size = new System.Drawing.Size(187, 22);
      this.txtCustomerShoppingCount.TabIndex = 11;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label6.Location = new System.Drawing.Point(3, 279);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(143, 20);
      this.label6.TabIndex = 10;
      this.label6.Text = "Alışveriş Tutarı:";
      // 
      // btnCustomerList
      // 
      this.btnCustomerList.BackColor = System.Drawing.SystemColors.Info;
      this.btnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnCustomerList.Location = new System.Drawing.Point(172, 331);
      this.btnCustomerList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnCustomerList.Name = "btnCustomerList";
      this.btnCustomerList.Size = new System.Drawing.Size(188, 36);
      this.btnCustomerList.TabIndex = 12;
      this.btnCustomerList.Text = "Listele";
      this.btnCustomerList.UseVisualStyleBackColor = false;
      this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
      // 
      // btnCustomerCreate
      // 
      this.btnCustomerCreate.BackColor = System.Drawing.SystemColors.Info;
      this.btnCustomerCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnCustomerCreate.Location = new System.Drawing.Point(172, 374);
      this.btnCustomerCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnCustomerCreate.Name = "btnCustomerCreate";
      this.btnCustomerCreate.Size = new System.Drawing.Size(188, 36);
      this.btnCustomerCreate.TabIndex = 13;
      this.btnCustomerCreate.Text = "Ekle";
      this.btnCustomerCreate.UseVisualStyleBackColor = false;
      this.btnCustomerCreate.Click += new System.EventHandler(this.btnCustomerCreate_Click);
      // 
      // btnCustomerDelete
      // 
      this.btnCustomerDelete.BackColor = System.Drawing.SystemColors.Info;
      this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnCustomerDelete.Location = new System.Drawing.Point(172, 417);
      this.btnCustomerDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnCustomerDelete.Name = "btnCustomerDelete";
      this.btnCustomerDelete.Size = new System.Drawing.Size(188, 37);
      this.btnCustomerDelete.TabIndex = 14;
      this.btnCustomerDelete.Text = "Sil";
      this.btnCustomerDelete.UseVisualStyleBackColor = false;
      this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
      // 
      // btnCustomerUpdate
      // 
      this.btnCustomerUpdate.BackColor = System.Drawing.SystemColors.Info;
      this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnCustomerUpdate.Location = new System.Drawing.Point(172, 462);
      this.btnCustomerUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnCustomerUpdate.Name = "btnCustomerUpdate";
      this.btnCustomerUpdate.Size = new System.Drawing.Size(188, 36);
      this.btnCustomerUpdate.TabIndex = 15;
      this.btnCustomerUpdate.Text = "Güncelle";
      this.btnCustomerUpdate.UseVisualStyleBackColor = false;
      this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(368, 9);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.Size = new System.Drawing.Size(1121, 358);
      this.dataGridView1.TabIndex = 16;
      // 
      // btnGetCustomerID
      // 
      this.btnGetCustomerID.BackColor = System.Drawing.SystemColors.Info;
      this.btnGetCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnGetCustomerID.Location = new System.Drawing.Point(172, 506);
      this.btnGetCustomerID.Margin = new System.Windows.Forms.Padding(4);
      this.btnGetCustomerID.Name = "btnGetCustomerID";
      this.btnGetCustomerID.Size = new System.Drawing.Size(188, 36);
      this.btnGetCustomerID.TabIndex = 17;
      this.btnGetCustomerID.Text = "Id\'ye Göre Getir";
      this.btnGetCustomerID.UseVisualStyleBackColor = false;
      this.btnGetCustomerID.Click += new System.EventHandler(this.btnGetCustomerID_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1505, 554);
      this.Controls.Add(this.btnGetCustomerID);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnCustomerUpdate);
      this.Controls.Add(this.btnCustomerDelete);
      this.Controls.Add(this.btnCustomerCreate);
      this.Controls.Add(this.btnCustomerList);
      this.Controls.Add(this.txtCustomerShoppingCount);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtCustomerBalance);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtCustomerCity);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtCustomerSurname);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtCustomerName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtCustomerID);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCustomerID;
    private System.Windows.Forms.TextBox txtCustomerName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtCustomerSurname;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtCustomerCity;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtCustomerBalance;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtCustomerShoppingCount;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnCustomerList;
    private System.Windows.Forms.Button btnCustomerCreate;
    private System.Windows.Forms.Button btnCustomerDelete;
    private System.Windows.Forms.Button btnCustomerUpdate;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnGetCustomerID;
  }
}
