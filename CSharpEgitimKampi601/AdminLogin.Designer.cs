namespace CSharpEgitimKampi601
{
  partial class AdminLogin
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
      this.label3 = new System.Windows.Forms.Label();
      this.txtuserName = new System.Windows.Forms.TextBox();
      this.txtuserPassword = new System.Windows.Forms.TextBox();
      this.btnAdmlnLogin = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
      this.label1.Location = new System.Drawing.Point(99, 73);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(120, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Kullanıcı Adı:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
      this.label3.Location = new System.Drawing.Point(166, 123);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 24);
      this.label3.TabIndex = 2;
      this.label3.Text = "Şifre:";
      // 
      // txtuserName
      // 
      this.txtuserName.Location = new System.Drawing.Point(236, 73);
      this.txtuserName.Name = "txtuserName";
      this.txtuserName.Size = new System.Drawing.Size(250, 22);
      this.txtuserName.TabIndex = 3;
      this.txtuserName.TextChanged += new System.EventHandler(this.txtuserName_TextChanged);
      // 
      // txtuserPassword
      // 
      this.txtuserPassword.Location = new System.Drawing.Point(236, 123);
      this.txtuserPassword.Name = "txtuserPassword";
      this.txtuserPassword.Size = new System.Drawing.Size(250, 22);
      this.txtuserPassword.TabIndex = 4;
      this.txtuserPassword.UseSystemPasswordChar = true;
      this.txtuserPassword.TextChanged += new System.EventHandler(this.txtuserPassword_TextChanged);
      // 
      // btnAdmlnLogin
      // 
      this.btnAdmlnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
      this.btnAdmlnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAdmlnLogin.ForeColor = System.Drawing.Color.Transparent;
      this.btnAdmlnLogin.Location = new System.Drawing.Point(286, 169);
      this.btnAdmlnLogin.Name = "btnAdmlnLogin";
      this.btnAdmlnLogin.Size = new System.Drawing.Size(100, 30);
      this.btnAdmlnLogin.TabIndex = 5;
      this.btnAdmlnLogin.Text = "Giriş Yap";
      this.btnAdmlnLogin.UseVisualStyleBackColor = false;
      this.btnAdmlnLogin.Click += new System.EventHandler(this.btnAdmlnLogin_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
      this.label2.Location = new System.Drawing.Point(203, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(283, 38);
      this.label2.TabIndex = 6;
      this.label2.Text = "Financial CRM GİRİŞ";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.checkBox1.Location = new System.Drawing.Point(520, 127);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(132, 27);
      this.checkBox1.TabIndex = 7;
      this.checkBox1.Text = "Şifreyi Göster";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // AdminLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.ClientSize = new System.Drawing.Size(700, 326);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnAdmlnLogin);
      this.Controls.Add(this.txtuserPassword);
      this.Controls.Add(this.txtuserName);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Name = "AdminLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Admin Giriş Ekranı";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtuserName;
    private System.Windows.Forms.TextBox txtuserPassword;
    private System.Windows.Forms.Button btnAdmlnLogin;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox checkBox1;
  }
}