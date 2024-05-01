namespace Лаба_Левкулич_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Устанавливаем название вкладки при нажатии кнопки
            tabControl1.TabPages[0].Text = "Универ";
            //Переключаемся на TabPage1 внутри табконтроля
            tabControl1.SelectedTab = tabPage1;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].Text = "Школа";
            tabControl1.SelectedTab = tabPage2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Создаем Датабазу
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //Параметры диалога
            saveFileDialog.Filter = "Textfiles (*.txt)| *.txt| All files(*.*)|*.*";
            saveFileDialog.DefaultExt = "txt"; //Расширение файла по умолчанию ставим  txt

            //Выгружаем диалог 
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Получаем выбранный путь
                string selectedFilePath = saveFileDialog.FileName;
                //Используем StreamWriter для сохранения данных
                using (StreamWriter writer = new StreamWriter(selectedFilePath))
                {
                    foreach (var item in listView1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
            }

        }

        private void ButtonDobav_Click(object sender, EventArgs e)
        {
            //Проерка является ли строка пустой, чтобы не добавлять null
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                //Создаем новый элемент со значением из первого текстового поля
                ListViewItem item = new ListViewItem(textBox1.Text);
                //Добавляем подэлементы 
                item.SubItems.Add(textBox2.Text);
                item.SubItems.Add(textBox3.Text);

                //Добавляем весь элемент в ListView
                listView1.Items.Add(item);

                //Чистим предыдущее для нового ввода
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Введите значение в тектсоовое поле перед добавлением");
            }
        }

        private void ButtonUbrat_Click(object sender, EventArgs e)
        {
            //Проверка на наличие элементов
            if (listView1.SelectedItems.Count > 0)
            {
                //Чистим элементы
                foreach (ListViewItem itemToRemove in listView1.SelectedItems)
                {
                    listView1.Items.Remove(itemToRemove);
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDobav2_Click(object sender, EventArgs e)
        {
            //Проерка является ли строка пустой, чтобы не добавлять null
            if (!string.IsNullOrWhiteSpace(textBox6.Text))
            {
                //Создаем новый элемент со значением из первого текстового поля
                ListViewItem item = new ListViewItem(textBox6.Text);
                //Добавляем подэлементы 
                item.SubItems.Add(textBox5.Text);
                item.SubItems.Add(textBox4.Text);

                //Добавляем весь элемент в ListView
                listView2.Items.Add(item);

                //Чистим предыдущее для нового ввода
                textBox6.Clear();
                textBox5.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Введите значение в тектсоовое поле перед добавлением");
            }
        }

        private void ButtonUbrat2_Click(object sender, EventArgs e)
        {
            //Проверка на наличие элементов
            if (listView2.SelectedItems.Count > 0)
            {
                //Чистим элементы
                foreach (ListViewItem itemToRemove in listView2.SelectedItems)
                {
                    listView2.Items.Remove(itemToRemove);
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}