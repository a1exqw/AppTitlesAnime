namespace AppTitlesAnime
{
    partial class FormListGenres
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
            btnDeleteGenre = new Button();
            btnUpdateGenre = new Button();
            btnAddGenre = new Button();
            flowLayoutPanelTop = new FlowLayoutPanel();
            panelFill = new Panel();
            dataGridViewGenres = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.AutoSize = true;
            btnDeleteGenre.BackColor = Color.White;
            btnDeleteGenre.Font = new Font("Segoe UI", 14.25F);
            btnDeleteGenre.ForeColor = Color.Black;
            btnDeleteGenre.Location = new Point(298, 22);
            btnDeleteGenre.Margin = new Padding(5, 5, 5, 5);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(92, 35);
            btnDeleteGenre.TabIndex = 2;
            btnDeleteGenre.Text = "Удалить";
            btnDeleteGenre.UseVisualStyleBackColor = false;
            btnDeleteGenre.Click += BtnDeleteGenre_Click;
            // 
            // btnUpdateGenre
            // 
            btnUpdateGenre.AutoSize = true;
            btnUpdateGenre.BackColor = Color.White;
            btnUpdateGenre.Font = new Font("Segoe UI", 14.25F);
            btnUpdateGenre.ForeColor = Color.Black;
            btnUpdateGenre.Location = new Point(137, 22);
            btnUpdateGenre.Margin = new Padding(5, 5, 5, 5);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.Size = new Size(151, 35);
            btnUpdateGenre.TabIndex = 1;
            btnUpdateGenre.Text = "Редактировать";
            btnUpdateGenre.UseVisualStyleBackColor = false;
            btnUpdateGenre.Click += BtnUpdateGenre_Click;
            // 
            // btnAddGenre
            // 
            btnAddGenre.AutoSize = true;
            btnAddGenre.BackColor = Color.White;
            btnAddGenre.Font = new Font("Segoe UI", 14.25F);
            btnAddGenre.ForeColor = Color.Black;
            btnAddGenre.Location = new Point(21, 22);
            btnAddGenre.Margin = new Padding(5, 5, 5, 5);
            btnAddGenre.Name = "btnAddGenre";
            btnAddGenre.Size = new Size(106, 35);
            btnAddGenre.TabIndex = 0;
            btnAddGenre.Text = "Добавить";
            btnAddGenre.UseVisualStyleBackColor = false;
            btnAddGenre.Click += BtnAddGenre_Click;
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(btnAddGenre);
            flowLayoutPanelTop.Controls.Add(btnUpdateGenre);
            flowLayoutPanelTop.Controls.Add(btnDeleteGenre);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.ForeColor = SystemColors.Control;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(5, 5, 5, 5);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(16, 17, 16, 17);
            flowLayoutPanelTop.Size = new Size(934, 79);
            flowLayoutPanelTop.TabIndex = 3;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewGenres);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 79);
            panelFill.Margin = new Padding(5, 5, 5, 5);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(16, 17, 16, 17);
            panelFill.Size = new Size(934, 432);
            panelFill.TabIndex = 5;
            // 
            // dataGridViewGenres
            // 
            dataGridViewGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGenres.BackgroundColor = Color.White;
            dataGridViewGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenres.Dock = DockStyle.Fill;
            dataGridViewGenres.Location = new Point(16, 17);
            dataGridViewGenres.Margin = new Padding(5, 5, 5, 5);
            dataGridViewGenres.MultiSelect = false;
            dataGridViewGenres.Name = "dataGridViewGenres";
            dataGridViewGenres.ReadOnly = true;
            dataGridViewGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenres.Size = new Size(902, 398);
            dataGridViewGenres.TabIndex = 3;
            // 
            // FormListGenres
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 511);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormListGenres";
            Text = "Список жанры аниме";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteGenre;
        private Button btnUpdateGenre;
        private Button btnAddGenre;
        private FlowLayoutPanel flowLayoutPanelTop;
        private Panel panelFill;
        private DataGridView dataGridViewGenres;
    }
}