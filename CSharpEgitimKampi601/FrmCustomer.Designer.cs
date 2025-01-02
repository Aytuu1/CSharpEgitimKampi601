namespace CSharpEgitimKampi601
{
  partial class FrmCustomer
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
      this.btnGetCustomerID = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnCustomerUpdate = new System.Windows.Forms.Button();
      this.btnCustomerDelete = new System.Windows.Forms.Button();
      this.btnCustomerCreate = new System.Windows.Forms.Button();
      this.btnCustomerList = new System.Windows.Forms.Button();
      this.txtCustomerCity = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtCustomerSurname = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtCustomerName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtCustomerID = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnGetCustomerID
      // 
      this.btnGetCustomerID.BackColor = System.Drawing.SystemColors.Info;
      this.btnGetCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnGetCustomerID.Location = new System.Drawing.Point(148, 325);
      this.btnGetCustomerID.Name = "btnGetCustomerID";
      this.btnGetCustomerID.Size = new System.Drawing.Size(141, 29);
      this.btnGetCustomerID.TabIndex = 35;
      this.btnGetCustomerID.Text = "Id\'ye Göre Getir";
      this.btnGetCustomerID.UseVisualStyleBackColor = false;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(299, 9);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.Size = new System.Drawing.Size(841, 291);
      this.dataGridView1.TabIndex = 34;
      // 
      // btnCustomerUpdate
      // 
      this.btnCustomerUpdate.BackColor = System.Drawing.SystemColors.Info;
      this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnCustomerUpdate.Location = new System.Drawing.Point(148, 289);
      this.btnCustomerUpdate.Name = "btnCustomerUpdate";
      this.btnCustomerUpdate.Size = new System.Drawing.Size(141, 29);
      this.btnCustomerUpdate.TabIndex = 33;
      this.btnCustomerUpdate.Text = "Güncelle";
      this.btnCustomerUpdate.UseVisualStyleBackColor = false;
      this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
      // 
      // btnCustomerDelete
      // 
      this.btnCustomerDelete.BackColor = System.Drawing.SystemColors.Info;
      this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnCustomerDelete.Location = new System.Drawing.Point(148, 253);
      this.btnCustomerDelete.Name = "btnCustomerDelete";
      this.btnCustomerDelete.Size = new System.Drawing.Size(141, 30);
      this.btnCustomerDelete.TabIndex = 32;
      this.btnCustomerDelete.Text = "Sil";
      this.btnCustomerDelete.UseVisualStyleBackColor = false;
      this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
      // 
      // btnCustomerCreate
      // 
      this.btnCustomerCreate.BackColor = System.Drawing.SystemColors.Info;
      this.btnCustomerCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnCustomerCreate.Location = new System.Drawing.Point(148, 218);
      this.btnCustomerCreate.Name = "btnCustomerCreate";
      this.btnCustomerCreate.Size = new System.Drawing.Size(141, 29);
      this.btnCustomerCreate.TabIndex = 31;
      this.btnCustomerCreate.Text = "Ekle";
      this.btnCustomerCreate.UseVisualStyleBackColor = false;
      this.btnCustomerCreate.Click += new System.EventHandler(this.btnCustomerCreate_Click);
      // 
      // btnCustomerList
      // 
      this.btnCustomerList.BackColor = System.Drawing.SystemColors.Info;
      this.btnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnCustomerList.Location = new System.Drawing.Point(148, 183);
      this.btnCustomerList.Name = "btnCustomerList";
      this.btnCustomerList.Size = new System.Drawing.Size(141, 29);
      this.btnCustomerList.TabIndex = 30;
      this.btnCustomerList.Text = "Listele";
      this.btnCustomerList.UseVisualStyleBackColor = false;
      this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
      // 
      // txtCustomerCity
      // 
      this.txtCustomerCity.Location = new System.Drawing.Point(152, 144);
      this.txtCustomerCity.Name = "txtCustomerCity";
      this.txtCustomerCity.Size = new System.Drawing.Size(141, 20);
      this.txtCustomerCity.TabIndex = 25;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.Location = new System.Drawing.Point(22, 144);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(128, 20);
      this.label4.TabIndex = 24;
      this.label4.Text = "Müşteri Şehir:";
      // 
      // txtCustomerSurname
      // 
      this.txtCustomerSurname.Location = new System.Drawing.Point(152, 106);
      this.txtCustomerSurname.Name = "txtCustomerSurname";
      this.txtCustomerSurname.Size = new System.Drawing.Size(141, 20);
      this.txtCustomerSurname.TabIndex = 23;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.Location = new System.Drawing.Point(9, 106);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(140, 20);
      this.label3.TabIndex = 22;
      this.label3.Text = "Müşteri Soyadı:";
      // 
      // txtCustomerName
      // 
      this.txtCustomerName.Location = new System.Drawing.Point(152, 65);
      this.txtCustomerName.Name = "txtCustomerName";
      this.txtCustomerName.Size = new System.Drawing.Size(141, 20);
      this.txtCustomerName.TabIndex = 21;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(35, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(111, 20);
      this.label2.TabIndex = 20;
      this.label2.Text = "Müşteri Adı:";
      // 
      // txtCustomerID
      // 
      this.txtCustomerID.Location = new System.Drawing.Point(152, 25);
      this.txtCustomerID.Name = "txtCustomerID";
      this.txtCustomerID.Size = new System.Drawing.Size(141, 20);
      this.txtCustomerID.TabIndex = 19;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(43, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 20);
      this.label1.TabIndex = 18;
      this.label1.Text = "Müşteri ID:";
      // 
      // FrmCustomer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1238, 450);
      this.Controls.Add(this.btnGetCustomerID);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnCustomerUpdate);
      this.Controls.Add(this.btnCustomerDelete);
      this.Controls.Add(this.btnCustomerCreate);
      this.Controls.Add(this.btnCustomerList);
      this.Controls.Add(this.txtCustomerCity);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtCustomerSurname);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtCustomerName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtCustomerID);
      this.Controls.Add(this.label1);
      this.Name = "FrmCustomer";
      this.Text = "FrmCustomer";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnGetCustomerID;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnCustomerUpdate;
    private System.Windows.Forms.Button btnCustomerDelete;
    private System.Windows.Forms.Button btnCustomerCreate;
    private System.Windows.Forms.Button btnCustomerList;
    private System.Windows.Forms.TextBox txtCustomerCity;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtCustomerSurname;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtCustomerName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtCustomerID;
    private System.Windows.Forms.Label label1;
  }
}