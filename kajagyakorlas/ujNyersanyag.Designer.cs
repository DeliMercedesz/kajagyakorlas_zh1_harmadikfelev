namespace kajagyakorlas
{
    partial class ujNyersanyag
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
            Nevtxt = new TextBox();
            Egysegartxt = new TextBox();
            Nyersanyagnevlabel = new Label();
            EgysegarLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Nevtxt
            // 
            Nevtxt.Location = new Point(141, 23);
            Nevtxt.Name = "Nevtxt";
            Nevtxt.Size = new Size(254, 23);
            Nevtxt.TabIndex = 0;
            // 
            // Egysegartxt
            // 
            Egysegartxt.Location = new Point(141, 61);
            Egysegartxt.Name = "Egysegartxt";
            Egysegartxt.Size = new Size(254, 23);
            Egysegartxt.TabIndex = 1;
            // 
            // Nyersanyagnevlabel
            // 
            Nyersanyagnevlabel.AutoSize = true;
            Nyersanyagnevlabel.Location = new Point(24, 31);
            Nyersanyagnevlabel.Name = "Nyersanyagnevlabel";
            Nyersanyagnevlabel.Size = new Size(90, 15);
            Nyersanyagnevlabel.TabIndex = 2;
            Nyersanyagnevlabel.Text = "NyersanyagNev";
            // 
            // EgysegarLabel
            // 
            EgysegarLabel.AutoSize = true;
            EgysegarLabel.Location = new Point(24, 64);
            EgysegarLabel.Name = "EgysegarLabel";
            EgysegarLabel.Size = new Size(54, 15);
            EgysegarLabel.TabIndex = 3;
            EgysegarLabel.Text = "Egysegar";
            // 
            // button1
            // 
            button1.Location = new Point(25, 114);
            button1.Name = "button1";
            button1.Size = new Size(131, 26);
            button1.TabIndex = 4;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ujNyersanyag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 160);
            Controls.Add(button1);
            Controls.Add(EgysegarLabel);
            Controls.Add(Nyersanyagnevlabel);
            Controls.Add(Egysegartxt);
            Controls.Add(Nevtxt);
            Name = "ujNyersanyag";
            Text = "ujNyersanyag";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Nyersanyagnevlabel;
        private Label EgysegarLabel;
        public TextBox Nevtxt;
        public TextBox Egysegartxt;
        private Button button1;
    }
}