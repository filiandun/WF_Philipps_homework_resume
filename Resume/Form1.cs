namespace Resume
{
    public partial class Resume : Form
    {
        public Resume()
        {
            InitializeComponent();
        }

        private void Resume_Load(object sender, EventArgs e)
        {
            string[] text = // 88 символов
            {
                "ФИО: Тупольский Филипп Эдуардович",
                "Дата рождения: 24.06.2004",
                "Пол: мужской",
                "Образование: СтГАУ"
            };

            uint i; // кол-во MessageBox
            uint length = 0; // длина текста резюме

            DialogResult result = DialogResult.Retry;

            while (result == DialogResult.Retry)
            {
                for (i = 0; i < text.Length; i++)
                {
                    MessageBox.Show(text[i], $"РЕЗЮМЕ, страница {i + 1}", MessageBoxButtons.OK);
                    length += (uint) text[i].Length;
                }

                result = MessageBox.Show($"Среднее число символов на странице: {length / i}\n\nПовторить?", "ЗАКЛЮЧЕНИЕ", MessageBoxButtons.RetryCancel);
            }
        }
    }
}