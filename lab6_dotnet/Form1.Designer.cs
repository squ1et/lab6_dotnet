namespace lab6_dotnet
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button btnShowBrands;
        private System.Windows.Forms.Button btnGroupByYear;
        private System.Windows.Forms.Button btnAvgMileage;
        private System.Windows.Forms.Button btnCountByYear;
        private System.Windows.Forms.Button btnMaxMileageForBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Button btnSortByMileage;
        private System.Windows.Forms.TextBox txtFilterYear;
        private System.Windows.Forms.Button btnFilterByYear;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnSaveFile;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewResults = new DataGridView();
            btnShowBrands = new Button();
            btnGroupByYear = new Button();
            btnAvgMileage = new Button();
            btnCountByYear = new Button();
            btnMaxMileageForBrand = new Button();
            txtBrand = new TextBox();
            btnSortByMileage = new Button();
            txtFilterYear = new TextBox();
            btnFilterByYear = new Button();
            btnLoadFile = new Button();
            btnSaveFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(12, 12);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.Size = new Size(500, 300);
            dataGridViewResults.TabIndex = 0;
            // 
            // btnShowBrands
            // 
            btnShowBrands.Location = new Point(530, 12);
            btnShowBrands.Name = "btnShowBrands";
            btnShowBrands.Size = new Size(150, 30);
            btnShowBrands.TabIndex = 3;
            btnShowBrands.Text = "Показати марки";
            btnShowBrands.Click += btnShowBrands_Click;
            // 
            // btnGroupByYear
            // 
            btnGroupByYear.Location = new Point(530, 50);
            btnGroupByYear.Name = "btnGroupByYear";
            btnGroupByYear.Size = new Size(150, 30);
            btnGroupByYear.TabIndex = 4;
            btnGroupByYear.Text = "Групування за роком";
            btnGroupByYear.Click += btnGroupByYear_Click;
            // 
            // btnAvgMileage
            // 
            btnAvgMileage.Location = new Point(530, 88);
            btnAvgMileage.Name = "btnAvgMileage";
            btnAvgMileage.Size = new Size(150, 30);
            btnAvgMileage.TabIndex = 5;
            btnAvgMileage.Text = "Середній пробіг";
            btnAvgMileage.Click += btnAvgMileage_Click;
            // 
            // btnCountByYear
            // 
            btnCountByYear.Location = new Point(530, 126);
            btnCountByYear.Name = "btnCountByYear";
            btnCountByYear.Size = new Size(150, 30);
            btnCountByYear.TabIndex = 6;
            btnCountByYear.Text = "Кількість авто по роках";
            btnCountByYear.Click += btnCountByYear_Click;
            // 
            // btnMaxMileageForBrand
            // 
            btnMaxMileageForBrand.Location = new Point(168, 369);
            btnMaxMileageForBrand.Name = "btnMaxMileageForBrand";
            btnMaxMileageForBrand.Size = new Size(150, 30);
            btnMaxMileageForBrand.TabIndex = 8;
            btnMaxMileageForBrand.Text = "Макс пробіг марки";
            btnMaxMileageForBrand.Click += btnMaxMileageForBrand_Click;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(12, 374);
            txtBrand.Name = "txtBrand";
            txtBrand.PlaceholderText = "Введіть марку";
            txtBrand.Size = new Size(150, 23);
            txtBrand.TabIndex = 7;
            // 
            // btnSortByMileage
            // 
            btnSortByMileage.Location = new Point(530, 162);
            btnSortByMileage.Name = "btnSortByMileage";
            btnSortByMileage.Size = new Size(150, 30);
            btnSortByMileage.TabIndex = 11;
            btnSortByMileage.Text = "Сортувати за пробігом";
            btnSortByMileage.Click += btnSortByMileage_Click;
            // 
            // txtFilterYear
            // 
            txtFilterYear.Location = new Point(12, 331);
            txtFilterYear.Name = "txtFilterYear";
            txtFilterYear.PlaceholderText = "Рік для фільтру";
            txtFilterYear.Size = new Size(150, 23);
            txtFilterYear.TabIndex = 9;
            // 
            // btnFilterByYear
            // 
            btnFilterByYear.Location = new Point(168, 326);
            btnFilterByYear.Name = "btnFilterByYear";
            btnFilterByYear.Size = new Size(150, 30);
            btnFilterByYear.TabIndex = 10;
            btnFilterByYear.Text = "Фільтрувати за роком";
            btnFilterByYear.Click += btnFilterByYear_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(472, 369);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(100, 30);
            btnLoadFile.TabIndex = 1;
            btnLoadFile.Text = "Завантажити";
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(578, 367);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(100, 30);
            btnSaveFile.TabIndex = 2;
            btnSaveFile.Text = "Зберегти";
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(690, 406);
            Controls.Add(dataGridViewResults);
            Controls.Add(btnLoadFile);
            Controls.Add(btnSaveFile);
            Controls.Add(btnShowBrands);
            Controls.Add(btnGroupByYear);
            Controls.Add(btnAvgMileage);
            Controls.Add(btnCountByYear);
            Controls.Add(txtBrand);
            Controls.Add(btnMaxMileageForBrand);
            Controls.Add(txtFilterYear);
            Controls.Add(btnFilterByYear);
            Controls.Add(btnSortByMileage);
            Name = "MainForm";
            Text = "CarApp LINQ Demo";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
