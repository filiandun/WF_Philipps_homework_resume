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
            string[] text = // 88 ��������
            {
                "���: ���������� ������ ����������",
                "���� ��������: 24.06.2004",
                "���: �������",
                "�����������: �����"
            };

            uint i; // ���-�� MessageBox
            uint length = 0; // ����� ������ ������

            DialogResult result = DialogResult.Retry;

            while (result == DialogResult.Retry)
            {
                for (i = 0; i < text.Length; i++)
                {
                    MessageBox.Show(text[i], $"������, �������� {i + 1}", MessageBoxButtons.OK);
                    length += (uint) text[i].Length;
                }

                result = MessageBox.Show($"������� ����� �������� �� ��������: {length / i}\n\n���������?", "����������", MessageBoxButtons.RetryCancel);
            }
        }
    }
}