namespace kajagyakorlas
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
            fogaslb = new ListBox();
            fogasokBindingSource = new BindingSource(components);
            fogastxt = new TextBox();
            Nyersanyagtxt = new TextBox();
            Nyersanyaglb = new ListBox();
            nyersanyagokBindingSource = new BindingSource(components);
            labelmennyegys = new Label();
            dataGridView1 = new DataGridView();
            receptIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fogasIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nyersanyagNevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyiseg4foDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egysegNevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            árDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hozzávalóBindingSource = new BindingSource(components);
            Add = new Button();
            mennyisegtxt = new TextBox();
            remove = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)fogasokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nyersanyagokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hozzávalóBindingSource).BeginInit();
            SuspendLayout();
            // 
            // fogaslb
            // 
            fogaslb.DataSource = fogasokBindingSource;
            fogaslb.DisplayMember = "FogasNev";
            fogaslb.FormattingEnabled = true;
            fogaslb.ItemHeight = 15;
            fogaslb.Location = new Point(11, 89);
            fogaslb.Name = "fogaslb";
            fogaslb.Size = new Size(169, 349);
            fogaslb.TabIndex = 0;
            fogaslb.ValueMember = "FogasID";
            fogaslb.SelectedIndexChanged += fogaslb_SelectedIndexChanged;
            // 
            // fogasokBindingSource
            // 
            fogasokBindingSource.DataSource = typeof(Models.Fogasok);
            // 
            // fogastxt
            // 
            fogastxt.Location = new Point(11, 60);
            fogastxt.Name = "fogastxt";
            fogastxt.Size = new Size(169, 23);
            fogastxt.TabIndex = 1;
            fogastxt.TextChanged += fogastxt_TextChanged;
            // 
            // Nyersanyagtxt
            // 
            Nyersanyagtxt.Location = new Point(618, 60);
            Nyersanyagtxt.Name = "Nyersanyagtxt";
            Nyersanyagtxt.Size = new Size(170, 23);
            Nyersanyagtxt.TabIndex = 2;
            Nyersanyagtxt.TextChanged += Nyersanyagtxt_TextChanged;
            // 
            // Nyersanyaglb
            // 
            Nyersanyaglb.DataSource = nyersanyagokBindingSource;
            Nyersanyaglb.DisplayMember = "NyersanyagNev";
            Nyersanyaglb.FormattingEnabled = true;
            Nyersanyaglb.ItemHeight = 15;
            Nyersanyaglb.Location = new Point(618, 89);
            Nyersanyaglb.Name = "Nyersanyaglb";
            Nyersanyaglb.Size = new Size(170, 319);
            Nyersanyaglb.TabIndex = 3;
            Nyersanyaglb.ValueMember = "NyersanyagID";
            Nyersanyaglb.SelectedIndexChanged += Nyersanyaglb_SelectedIndexChanged;
            // 
            // nyersanyagokBindingSource
            // 
            nyersanyagokBindingSource.DataSource = typeof(Models.Nyersanyagok);
            // 
            // labelmennyegys
            // 
            labelmennyegys.AutoSize = true;
            labelmennyegys.Location = new Point(750, 423);
            labelmennyegys.Name = "labelmennyegys";
            labelmennyegys.Size = new Size(38, 15);
            labelmennyegys.TabIndex = 4;
            labelmennyegys.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { receptIDDataGridViewTextBoxColumn, fogasIDDataGridViewTextBoxColumn, nyersanyagNevDataGridViewTextBoxColumn, mennyiseg4foDataGridViewTextBoxColumn, egysegNevDataGridViewTextBoxColumn, árDataGridViewTextBoxColumn });
            dataGridView1.DataSource = hozzávalóBindingSource;
            dataGridView1.Location = new Point(195, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(339, 349);
            dataGridView1.TabIndex = 5;
            // 
            // receptIDDataGridViewTextBoxColumn
            // 
            receptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceptID";
            receptIDDataGridViewTextBoxColumn.HeaderText = "ReceptID";
            receptIDDataGridViewTextBoxColumn.Name = "receptIDDataGridViewTextBoxColumn";
            // 
            // fogasIDDataGridViewTextBoxColumn
            // 
            fogasIDDataGridViewTextBoxColumn.DataPropertyName = "FogasID";
            fogasIDDataGridViewTextBoxColumn.HeaderText = "FogasID";
            fogasIDDataGridViewTextBoxColumn.Name = "fogasIDDataGridViewTextBoxColumn";
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg_4fo";
            mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg_4fo";
            mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            // 
            // egysegNevDataGridViewTextBoxColumn
            // 
            egysegNevDataGridViewTextBoxColumn.DataPropertyName = "EgysegNev";
            egysegNevDataGridViewTextBoxColumn.HeaderText = "EgysegNev";
            egysegNevDataGridViewTextBoxColumn.Name = "egysegNevDataGridViewTextBoxColumn";
            // 
            // árDataGridViewTextBoxColumn
            // 
            árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            árDataGridViewTextBoxColumn.HeaderText = "Ár";
            árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            // 
            // hozzávalóBindingSource
            // 
            hozzávalóBindingSource.DataSource = typeof(Hozzávaló);
            // 
            // Add
            // 
            Add.Location = new Point(549, 181);
            Add.Name = "Add";
            Add.Size = new Size(54, 30);
            Add.TabIndex = 6;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // mennyisegtxt
            // 
            mennyisegtxt.Location = new Point(618, 420);
            mennyisegtxt.Name = "mennyisegtxt";
            mennyisegtxt.Size = new Size(97, 23);
            mennyisegtxt.TabIndex = 7;
            // 
            // remove
            // 
            remove.Location = new Point(549, 226);
            remove.Name = "remove";
            remove.Size = new Size(53, 33);
            remove.TabIndex = 8;
            remove.Text = "-";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // button1
            // 
            button1.Location = new Point(514, 28);
            button1.Name = "button1";
            button1.Size = new Size(69, 26);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(remove);
            Controls.Add(mennyisegtxt);
            Controls.Add(Add);
            Controls.Add(dataGridView1);
            Controls.Add(labelmennyegys);
            Controls.Add(Nyersanyaglb);
            Controls.Add(Nyersanyagtxt);
            Controls.Add(fogastxt);
            Controls.Add(fogaslb);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fogasokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nyersanyagokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hozzávalóBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox fogaslb;
        private TextBox fogastxt;
        private BindingSource fogasokBindingSource;
        private TextBox Nyersanyagtxt;
        private ListBox Nyersanyaglb;
        private BindingSource nyersanyagokBindingSource;
        private Label labelmennyegys;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn receptIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private BindingSource hozzávalóBindingSource;
        private Button Add;
        private TextBox mennyisegtxt;
        private Button remove;
        private Button button1;
    }
}
