namespace FigurasBiyTri
{
    partial class frmBidimensional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtlado = new TextBox();
            txtradio = new TextBox();
            lstrespuesta = new ListView();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 78);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Triangulo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(10, 119);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cuadrado";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(10, 167);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Circulo";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 14);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 54);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 5;
            label3.Text = "Ingrese uno de sus lados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 54);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 6;
            label4.Text = "ingrese el radio";
            // 
            // txtlado
            // 
            txtlado.Location = new Point(177, 72);
            txtlado.Name = "txtlado";
            txtlado.Size = new Size(100, 23);
            txtlado.TabIndex = 7;
            // 
            // txtradio
            // 
            txtradio.Location = new Point(351, 72);
            txtradio.Name = "txtradio";
            txtradio.Size = new Size(100, 23);
            txtradio.TabIndex = 8;
            // 
            // lstrespuesta
            // 
            lstrespuesta.Location = new Point(142, 101);
            lstrespuesta.Name = "lstrespuesta";
            lstrespuesta.Size = new Size(225, 97);
            lstrespuesta.TabIndex = 9;
            lstrespuesta.UseCompatibleStateImageBehavior = false;
            lstrespuesta.View = View.Details;
            // 
            // button4
            // 
            button4.Location = new Point(385, 167);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // frmBidimensional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 237);
            Controls.Add(button4);
            Controls.Add(lstrespuesta);
            Controls.Add(txtradio);
            Controls.Add(txtlado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmBidimensional";
            Text = "frmBidimensional";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtlado;
        private TextBox txtradio;
        private ListView lstrespuesta;
        private Button button4;
    }
}