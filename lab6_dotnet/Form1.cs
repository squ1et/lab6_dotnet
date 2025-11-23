using lab6_dotnet;
using System;
using System.Linq;
using System.Windows.Forms;

namespace lab6_dotnet
{
    public partial class MainForm : Form
    {
        private CarList carList = new();

        public MainForm()
        {
            InitializeComponent();
            dataGridCars.DataSource = carList.Cars;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car(
                    brandBox.Text,
                    ownerBox.Text,
                    int.Parse(yearBox.Text),
                    int.Parse(mileageBox.Text));

                carList.Add(car);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridCars.SelectedRows.Count > 0)
            {
                int index = dataGridCars.SelectedRows[0].Index;
                carList.Cars.RemoveAt(index);
                RefreshGrid();
            }
        }

        private void btnSortMileage_Click(object sender, EventArgs e)
        {
            carList.SortByMileage();
            RefreshGrid();
        }

        private void btnSortYear_Click(object sender, EventArgs e)
        {
            carList.SortByYear();
            RefreshGrid();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(filterYearBox.Text);
                var filtered = carList.FilterByYear(year);

                dataGridCars.DataSource = filtered;
            }
            catch
            {
                MessageBox.Show("Некоректний рік");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                carList.SaveToFile(sfd.FileName);
                MessageBox.Show("Збережено");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                carList.LoadFromFile(ofd.FileName);
                RefreshGrid();
                MessageBox.Show("Завантажено");
            }
        }

        private void RefreshGrid()
        {
            dataGridCars.DataSource = null;
            dataGridCars.DataSource = carList.Cars;
        }
    }
}
