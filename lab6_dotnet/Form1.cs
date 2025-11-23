using System;
using System.Linq;
using System.Windows.Forms;
using lab6_dotnet;

namespace lab6_dotnet
{
    public partial class MainForm : Form
    {
        private CarList carList = new CarList();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Приклад даних
            carList.Add(new Car("Toyota", "Ivanov", 2015, 50000));
            carList.Add(new Car("Ford", "Petrenko", 2018, 30000));
            carList.Add(new Car("BMW", "Shevchenko", 2020, 40000));

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridViewResults.DataSource = carList.Cars.Select(c => new
            {
                c.Brand,
                c.OwnerSurname,
                c.Year,
                c.Mileage
            }).ToList();
        }

        private void btnShowBrands_Click(object sender, EventArgs e)
        {
            var brands = carList.GetAllBrands();
            dataGridViewResults.DataSource = brands.Select(b => new { Brand = b }).ToList();
        }

        private void btnGroupByYear_Click(object sender, EventArgs e)
        {
            var groupedData = carList.GroupByYear()
                .Select(g => new
                {
                    Year = g.Key,
                    Cars = string.Join(", ", g.Select(c => c.Brand + " (" + c.OwnerSurname + ")"))
                })
                .ToList();

            dataGridViewResults.DataSource = groupedData;
        }


        private void btnAvgMileage_Click(object sender, EventArgs e)
        {
            double avg = carList.AverageMileage();
            MessageBox.Show($"Середній пробіг: {avg}", "Результат");
        }

        private void btnCountByYear_Click(object sender, EventArgs e)
        {
            var counts = carList.CountByYear()
                                .Select(kv => new { Year = kv.Key, Count = kv.Value })
                                .ToList();
            dataGridViewResults.DataSource = counts;
        }

        private void btnMaxMileageForBrand_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text.Trim();
            if (string.IsNullOrEmpty(brand))
            {
                MessageBox.Show("Введіть марку авто", "Помилка");
                return;
            }

            int maxMileage = carList.MaxMileageForBrand(brand);
            MessageBox.Show($"Максимальний пробіг для {brand}: {maxMileage}", "Результат");
        }

        private void btnSortByMileage_Click(object sender, EventArgs e)
        {
            carList.SortByMileage();
            RefreshGrid();
        }

        private void btnFilterByYear_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFilterYear.Text, out int year))
            {
                var filtered = carList.FilterByYear(year);
                dataGridViewResults.DataSource = filtered.Select(c => new
                {
                    c.Brand,
                    c.OwnerSurname,
                    c.Year,
                    c.Mileage
                }).ToList();
            }
            else
            {
                MessageBox.Show("Некоректний рік", "Помилка");
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        carList.LoadFromFile(ofd.FileName);
                        RefreshGrid();
                        MessageBox.Show("Файл завантажено успішно", "Інформація");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка завантаження: " + ex.Message, "Помилка");
                    }
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        carList.SaveToFile(sfd.FileName);
                        MessageBox.Show("Файл збережено успішно", "Інформація");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка збереження: " + ex.Message, "Помилка");
                    }
                }
            }
        }
    }
}
