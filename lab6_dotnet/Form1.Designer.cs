namespace lab6_dotnet
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.TextBox ownerBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox mileageBox;
        private System.Windows.Forms.TextBox filterYearBox;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSortMileage;
        private System.Windows.Forms.Button btnSortYear;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridCars = new DataGridView();
            brandBox = new TextBox();
            ownerBox = new TextBox();
            yearBox = new TextBox();
            mileageBox = new TextBox();
            filterYearBox = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnSortMileage = new Button();
            btnSortYear = new Button();
            btnFilter = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).BeginInit();
            SuspendLayout();
            // 
            // dataGridCars
            // 
            dataGridCars.Location = new Point(12, 12);
            dataGridCars.Name = "dataGridCars";
            dataGridCars.Size = new Size(600, 300);
            dataGridCars.TabIndex = 0;
            // 
            // brandBox
            // 
            brandBox.Location = new Point(12, 330);
            brandBox.Name = "brandBox";
            brandBox.PlaceholderText = "Марка";
            brandBox.Size = new Size(100, 23);
            brandBox.TabIndex = 1;
            // 
            // ownerBox
            // 
            ownerBox.Location = new Point(130, 330);
            ownerBox.Name = "ownerBox";
            ownerBox.PlaceholderText = "Власник";
            ownerBox.Size = new Size(100, 23);
            ownerBox.TabIndex = 2;
            // 
            // yearBox
            // 
            yearBox.Location = new Point(250, 330);
            yearBox.Name = "yearBox";
            yearBox.PlaceholderText = "Рік";
            yearBox.Size = new Size(100, 23);
            yearBox.TabIndex = 3;
            // 
            // mileageBox
            // 
            mileageBox.Location = new Point(370, 330);
            mileageBox.Name = "mileageBox";
            mileageBox.PlaceholderText = "Пробіг";
            mileageBox.Size = new Size(100, 23);
            mileageBox.TabIndex = 4;
            // 
            // filterYearBox
            // 
            filterYearBox.Location = new Point(12, 410);
            filterYearBox.Name = "filterYearBox";
            filterYearBox.PlaceholderText = "Фільтр: рік";
            filterYearBox.Size = new Size(100, 23);
            filterYearBox.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 360);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Додати";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(100, 360);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Видалити";
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSortMileage
            // 
            btnSortMileage.Location = new Point(12, 450);
            btnSortMileage.Name = "btnSortMileage";
            btnSortMileage.Size = new Size(162, 23);
            btnSortMileage.TabIndex = 8;
            btnSortMileage.Text = "Сортувати по пробігу";
            btnSortMileage.Click += btnSortMileage_Click;
            // 
            // btnSortYear
            // 
            btnSortYear.Location = new Point(180, 450);
            btnSortYear.Name = "btnSortYear";
            btnSortYear.Size = new Size(164, 23);
            btnSortYear.TabIndex = 9;
            btnSortYear.Text = "Сортувати по року";
            btnSortYear.Click += btnSortYear_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(118, 410);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(87, 23);
            btnFilter.TabIndex = 10;
            btnFilter.Text = "Фільтрувати";
            btnFilter.Click += btnFilter_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(456, 450);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Зберегти";
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(537, 450);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Завантажити";
            btnLoad.Click += btnLoad_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(640, 520);
            Controls.Add(dataGridCars);
            Controls.Add(brandBox);
            Controls.Add(ownerBox);
            Controls.Add(yearBox);
            Controls.Add(mileageBox);
            Controls.Add(filterYearBox);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(btnSortMileage);
            Controls.Add(btnSortYear);
            Controls.Add(btnFilter);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Name = "MainForm";
            Text = "Автомобільна відомість";
            ((System.ComponentModel.ISupportInitialize)dataGridCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
