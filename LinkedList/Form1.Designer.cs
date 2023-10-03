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
            txtDato = new TextBox();
            btnCrear = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            lblCima = new Label();
            SuspendLayout();
            // 
            // txtDato
            // 
            txtDato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDato.Location = new Point(83, 106);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(125, 34);
            txtDato.TabIndex = 0;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(261, 112);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(186, 29);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Push (Apilar/Agregar)";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // button1
            // 
            button1.Location = new Point(261, 171);
            button1.Name = "button1";
            button1.Size = new Size(186, 29);
            button1.TabIndex = 3;
            button1.Text = "Pop (Eliminar)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(261, 230);
            button2.Name = "button2";
            button2.Size = new Size(186, 29);
            button2.TabIndex = 6;
            button2.Text = "Peek (Solo Mostrar)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(508, 107);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 7;
            label1.Text = "label1";
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
            // lblCima
            // 
            lblCima.AutoSize = true;
            lblCima.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCima.Location = new Point(508, 225);
            lblCima.Name = "lblCima";
            lblCima.Size = new Size(78, 32);
            lblCima.TabIndex = 9;
            lblCima.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 364);
            Controls.Add(lblCima);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCrear);
            Controls.Add(txtDato);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDato;
        private Button btnAdd;
        private Button btnCrear;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label lblCima;
    }
}