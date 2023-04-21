using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (tbId.Text == "" && tbTitle.Text == "")
            {
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            booksTableAdapter.Fill(this.libraryDataSet.Books);
        }

        private void ClearForm()
        {
            tbId.Text = "";
            tbTitle.Text = "";
            tbDescription.Text = "";
            dpDate.Text = DateTime.Today.ToString();

            spPages.Value = 1;

            btnDelete.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book newBook = GetDataOfForm();

            if (Repository.RepositorySQLServer.CrearContacto(newBook))
            {
                UpdateForm();

                ClearForm();

                MessageBox.Show("Libro añadido con éxito.");

            }
            else
            {
                MessageBox.Show("No ha sido posible añadir el libro.");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Book newBook = GetDataOfForm();

            if (Repository.RepositorySQLServer.ModificarContacto(newBook))
            {
                UpdateForm();

                MessageBox.Show("Libro modificado con éxito.");
                ClearForm();
            }
            else
            {
                MessageBox.Show("No ha sido posible modificar el libro.");
            }
        }

        private void UpdateForm()
        {

            booksTableAdapter.Fill(this.libraryDataSet.Books);

        }

        private Book GetDataOfForm()
        {
            Book newBook = new Book();

            if (!tbId.Text.Equals(""))
            {
                newBook.Id = int.Parse(tbId.Text);

            } else
            {
                newBook.Id = -1;
            }

            newBook.Title = tbTitle.Text;
            newBook.PublicationDate = dpDate.Value.ToShortDateString();
            newBook.Description = tbDescription.Text;
            newBook.NumOfPages = int.Parse(spPages.Value.ToString());

            return newBook;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Book newBook = GetDataOfForm();

            DialogResult buttonConfirm = MessageBox.Show("¿Estás seguro de que desea eliminarlo?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (buttonConfirm == DialogResult.OK)
            {
                if (Repository.RepositorySQLServer.EliminarContacto(newBook))
                {
                    UpdateForm();
                    ClearForm();

                    MessageBox.Show("Libro eliminado con éxito.");

                }
                else
                {
                    MessageBox.Show("No ha sido posible eliminar el libro..");
                }
            }

        }

        private void dgBooks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numberOfRow = e.RowIndex;


            if (numberOfRow != -1)
            {

                tbId.Text = dgBooks.Rows[numberOfRow].Cells[0].Value.ToString();
                tbTitle.Text = dgBooks.Rows[numberOfRow].Cells[1].Value.ToString();
                tbDescription.Text = dgBooks.Rows[numberOfRow].Cells[3].Value.ToString();
                dpDate.Text = dgBooks.Rows[numberOfRow].Cells[2].Value.ToString();

                spPages.Value = decimal.Parse(dgBooks.Rows[numberOfRow].Cells[4].Value.ToString());

                btnSave.Enabled = false;
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
            btnSave.Enabled = true;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dgBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
