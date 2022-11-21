namespace formsNS {
  partial class Form {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this._dgvDataView = new System.Windows.Forms.DataGridView();
      this._ViewButton = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.update = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.insert = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this._dgvDataView)).BeginInit();
      this.SuspendLayout();
      // 
      // _dgvDataView
      // 
      this._dgvDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this._dgvDataView.Location = new System.Drawing.Point(12, 42);
      this._dgvDataView.Name = "_dgvDataView";
      this._dgvDataView.RowTemplate.Height = 25;
      this._dgvDataView.Size = new System.Drawing.Size(776, 361);
      this._dgvDataView.TabIndex = 0;
      this._dgvDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvDataView_CellContentClick);
      // 
      // _ViewButton
      // 
      this._ViewButton.Location = new System.Drawing.Point(661, 12);
      this._ViewButton.Name = "_ViewButton";
      this._ViewButton.Size = new System.Drawing.Size(55, 22);
      this._ViewButton.TabIndex = 1;
      this._ViewButton.Text = "fill";
      this._ViewButton.UseVisualStyleBackColor = true;
      this._ViewButton.Click += new System.EventHandler(this._ViewButton_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 13);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(632, 23);
      this.textBox1.TabIndex = 2;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // update
      // 
      this.update.Location = new System.Drawing.Point(722, 12);
      this.update.Name = "update";
      this.update.Size = new System.Drawing.Size(66, 22);
      this.update.TabIndex = 3;
      this.update.Text = "update";
      this.update.UseVisualStyleBackColor = true;
      this.update.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(12, 422);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(171, 23);
      this.textBox2.TabIndex = 4;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(209, 423);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(162, 23);
      this.textBox3.TabIndex = 5;
      this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(389, 423);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(139, 23);
      this.textBox4.TabIndex = 6;
      this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(548, 423);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(125, 23);
      this.textBox5.TabIndex = 7;
      this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
      // 
      // insert
      // 
      this.insert.Location = new System.Drawing.Point(690, 422);
      this.insert.Name = "insert";
      this.insert.Size = new System.Drawing.Size(98, 23);
      this.insert.TabIndex = 8;
      this.insert.Text = "insert";
      this.insert.UseVisualStyleBackColor = true;
      this.insert.Click += new System.EventHandler(this.insert_Click);
      // 
      // Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.insert);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.update);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this._ViewButton);
      this.Controls.Add(this._dgvDataView);
      this.Name = "Form";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this._dgvDataView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DataGridView _dgvDataView;
    private Button _ViewButton;
    private TextBox textBox1;
    private Button update;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;
    private Button insert;
  }
}