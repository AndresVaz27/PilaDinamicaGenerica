namespace LinkedList
{
    public partial class Form1 : Form
    {
        LinkedList List1;

        public Form1()
        {
            InitializeComponent();
            List1 = new LinkedList();

        }

        private void Crearnodo_Click(object sender, EventArgs e)
        {


        }

        private void StringToListBox(string[] dataArray, Label list1)
        {
            list1.Text = string.Empty;
            for (int i = 0; i < dataArray.Length; i++)
            {
                if (dataArray[i] == null)
                {
                    MessageBox.Show("Item array is null");
                    continue;
                }
                list1.Text = dataArray[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblCima.Text == "")
                lblCima.Text = "Cima = " + List1.Peek();
            else
                lblCima.Text = "";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            List1.Push(int.Parse(txtDato.Text));
            label1.Text = List1.ToString();
            txtDato.Clear();
            txtDato.Focus();
            lblCima.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List1.Pop();
            label1.Text = List1.ToString();
            lblCima.Text = "";
        }
    }
}