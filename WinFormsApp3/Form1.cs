namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    richTextBox1.Text = filetext;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            String temp= richTextBox1.Text;
            richTextBox1.Text = "";
            richTextBox1.Text= temp;

            while (index < richTextBox1.Text.LastIndexOf(textBox1.Text))
            {
                richTextBox1.Find(textBox1.Text,index,richTextBox1.TextLength,RichTextBoxFinds.None);
                richTextBox1.SelectionBackColor = Color.Red;
                index = richTextBox1.Text.IndexOf(textBox1.Text, index) + 1;
            }
        }
    }
}
