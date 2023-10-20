namespace LinkedList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InputTextBox = new TextBox();
            PushButton = new Button();
            PopButton = new Button();
            PeekButton = new Button();
            label2 = new Label();
            StackListBox = new ListBox();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InputTextBox.Location = new Point(83, 106);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(125, 34);
            InputTextBox.TabIndex = 0;
            // 
            // PushButton
            // 
            PushButton.Location = new Point(261, 112);
            PushButton.Name = "PushButton";
            PushButton.Size = new Size(186, 29);
            PushButton.TabIndex = 2;
            PushButton.Text = "Push (Apilar/Agregar)";
            PushButton.UseVisualStyleBackColor = true;
            PushButton.Click += PushButton_Click_1;
            // 
            // PopButton
            // 
            PopButton.Location = new Point(261, 171);
            PopButton.Name = "PopButton";
            PopButton.Size = new Size(186, 29);
            PopButton.TabIndex = 3;
            PopButton.Text = "Pop (Eliminar)";
            PopButton.UseVisualStyleBackColor = true;
            PopButton.Click += PopButton_Click_1;
            // 
            // PeekButton
            // 
            PeekButton.Location = new Point(261, 230);
            PeekButton.Name = "PeekButton";
            PeekButton.Size = new Size(186, 29);
            PeekButton.TabIndex = 6;
            PeekButton.Text = "Peek (Solo Mostrar)";
            PeekButton.UseVisualStyleBackColor = true;
            PeekButton.Click += PeekButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 71);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 8;
            label2.Text = "Dato  (Int):";
            // 
            // StackListBox
            // 
            StackListBox.FormattingEnabled = true;
            StackListBox.ItemHeight = 20;
            StackListBox.Location = new Point(517, 71);
            StackListBox.Name = "StackListBox";
            StackListBox.Size = new Size(321, 184);
            StackListBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 364);
            Controls.Add(StackListBox);
            Controls.Add(label2);
            Controls.Add(PeekButton);
            Controls.Add(PopButton);
            Controls.Add(PushButton);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button btnAdd;
        private Button PushButton;
        private Button PopButton;
        private Button PeekButton;
        private Label label2;
        private ListBox StackListBox;
    }
}