namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            AddToPublic = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            colorDialog1 = new ColorDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            axAcropdf2 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axAcropdf2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 64);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 95);
            button1.Name = "button1";
            button1.Size = new Size(80, 28);
            button1.TabIndex = 1;
            button1.Text = "LoadImage";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddToPublic
            // 
            AddToPublic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddToPublic.Location = new Point(91, 54);
            AddToPublic.Name = "AddToPublic";
            AddToPublic.Size = new Size(154, 23);
            AddToPublic.TabIndex = 2;
            AddToPublic.Text = "AddToPublic";
            AddToPublic.UseVisualStyleBackColor = true;
            AddToPublic.Click += AddToPublic_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(101, 18);
            button2.Name = "button2";
            button2.Size = new Size(154, 30);
            button2.TabIndex = 3;
            button2.Text = "ModifyImage";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(126, 95);
            button3.Name = "button3";
            button3.Size = new Size(146, 28);
            button3.TabIndex = 5;
            button3.Text = "Open Pdf File";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(91, 202);
            button4.Name = "button4";
            button4.Size = new Size(146, 28);
            button4.TabIndex = 7;
            button4.Text = "next";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // axAcropdf2
            // 
            axAcropdf2.Enabled = true;
            axAcropdf2.Location = new Point(545, 38);
            axAcropdf2.Name = "axAcropdf2";
            axAcropdf2.OcxState = (AxHost.State)resources.GetObject("axAcropdf2.OcxState");
            axAcropdf2.Size = new Size(192, 192);
            axAcropdf2.TabIndex = 8;
            axAcropdf2.Enter += axAcropdf2_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 450);
            Controls.Add(axAcropdf2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(AddToPublic);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)axAcropdf2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button AddToPublic;
        private Button button2;
        private Button button3;
        private Button button4;
        private ContextMenuStrip contextMenuStrip1;
        private ColorDialog colorDialog1;
        private AxAcroPDFLib.AxAcroPDF axAcropdf1;
        private System.Windows.Forms.Timer timer1;
        private AxAcroPDFLib.AxAcroPDF axAcropdf2;
    }
}
