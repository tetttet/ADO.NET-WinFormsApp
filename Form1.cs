global using System;
global using System.Data;
global using System.Data.SqlClient;


namespace formsNS {
  public partial class Form : System.Windows.Forms.Form {

    private SqlConnection _connection = null;
    private SqlDataAdapter _adapter = null;
    private DataSet _dataSet = null;
    private SqlCommandBuilder _commandBuilder = null;

    string _tableName = "Book";
    string query = "SELECT * FROM Authors";


    public Form() {
      InitializeComponent();
    }

    //string query = "SELECT * FROM Authors";

    private void _ViewButton_Click(object sender, EventArgs e) {
      string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Library; Integrated Security=SSPI;";
      _connection = new SqlConnection(connectionString);
      _connection.Open();
      _adapter = new SqlDataAdapter(query, _connection);
      _commandBuilder = new SqlCommandBuilder(_adapter);
      _dataSet = new DataSet();
      _adapter.Fill(_dataSet, _tableName);
      _dgvDataView.DataSource = _dataSet.Tables[_tableName];
      _connection.Close();
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
      query = textBox1.Text;
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {
      if (_dataSet != null) {
        _adapter.Update(_dataSet, _tableName);
      }
    }

    private void _dgvDataView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void textBox2_TextChanged(object sender, EventArgs e) {

    }
    private void textBox3_TextChanged(object sender, EventArgs e) {

    }
    private void textBox4_TextChanged(object sender, EventArgs e) {

    }
    private void textBox5_TextChanged(object sender, EventArgs e) {

    }

    private void insert_Click(object sender, EventArgs e) {

      if (_dataSet != null) {
        DataRow _dataRow = _dataSet.Tables[0].NewRow();
        _dataRow[1] = textBox2.Text;
        _dataRow[2] = textBox3.Text;
        int _age = -1;
        bool successfullyParsed = int.TryParse(textBox4.Text, out _age);
        if (!successfullyParsed) {
          _dataRow[3] = _age; // incorrect age 
        }
        else {
          _dataRow[3] = _age;
        }

        _dataSet.Tables[0].Rows.Add(_dataRow);
      }

    }
  }
}