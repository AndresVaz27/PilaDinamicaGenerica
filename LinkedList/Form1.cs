namespace LinkedList
{
    public partial class Form1 : Form
    {
        private MyStack<string> stringStack;

        public Form1()
        {
            InitializeComponent();
            stringStack = new MyStack<string>();
        }

        private void UpdateStackListBox()
        {
            StackListBox.Items.Clear();
            for (int i = stringStack.Count - 1; i >= 0; i--)
            {
                string item = stringStack[i];
                StackListBox.Items.Add(item);
            }
        }

        private void PushButton_Click_1(object sender, EventArgs e)
        {
            string item = InputTextBox.Text;
            stringStack.Push(item);
            UpdateStackListBox();
            InputTextBox.Clear();
        }

        private void PopButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string poppedItem = stringStack.Pop();
                MessageBox.Show("Elemento desapilado: " + poppedItem);
                UpdateStackListBox();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("La pila está vacía. No se pueden desapilar elementos.");
            }
        }

        private void PeekButton_Click(object sender, EventArgs e)
        {
            try
            {
                string topItem = stringStack.Peek();
                MessageBox.Show("Elemento en la cima de la pila: " + topItem);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("La pila está vacía. No hay elementos para ver.");
            }
        }
    }
}