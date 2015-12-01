namespace ProjectPZ
{
    partial class FormDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            this.forwardDeleteBtn = new System.Windows.Forms.Button();
            this.backDeleteBtn = new System.Windows.Forms.Button();
            this.sortByIdDeleteBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sortByNameDeleteBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.endPageBtn = new System.Windows.Forms.Button();
            this.startPageBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(477, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Electronics Shop";
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.Location = new System.Drawing.Point(237, 255);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.Size = new System.Drawing.Size(596, 349);
            this.dataGridViewDelete.TabIndex = 1;
            this.dataGridViewDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDelete_CellClick);
            // 
            // forwardDeleteBtn
            // 
            this.forwardDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forwardDeleteBtn.Location = new System.Drawing.Point(553, 610);
            this.forwardDeleteBtn.Name = "forwardDeleteBtn";
            this.forwardDeleteBtn.Size = new System.Drawing.Size(137, 34);
            this.forwardDeleteBtn.TabIndex = 2;
            this.forwardDeleteBtn.Text = "Forward";
            this.forwardDeleteBtn.UseVisualStyleBackColor = true;
            this.forwardDeleteBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // backDeleteBtn
            // 
            this.backDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backDeleteBtn.Location = new System.Drawing.Point(388, 610);
            this.backDeleteBtn.Name = "backDeleteBtn";
            this.backDeleteBtn.Size = new System.Drawing.Size(137, 34);
            this.backDeleteBtn.TabIndex = 3;
            this.backDeleteBtn.Text = "Back";
            this.backDeleteBtn.UseVisualStyleBackColor = true;
            this.backDeleteBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // sortByIdDeleteBtn
            // 
            this.sortByIdDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByIdDeleteBtn.Location = new System.Drawing.Point(70, 255);
            this.sortByIdDeleteBtn.Name = "sortByIdDeleteBtn";
            this.sortByIdDeleteBtn.Size = new System.Drawing.Size(137, 61);
            this.sortByIdDeleteBtn.TabIndex = 4;
            this.sortByIdDeleteBtn.Text = "Sort by ID";
            this.sortByIdDeleteBtn.UseVisualStyleBackColor = true;
            this.sortByIdDeleteBtn.Click += new System.EventHandler(this.sortByIdBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(470, 228);
            this.searchTxt.Multiline = true;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(363, 21);
            this.searchTxt.TabIndex = 6;
            this.searchTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.comboBox1.Location = new System.Drawing.Point(237, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // sortByNameDeleteBtn
            // 
            this.sortByNameDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByNameDeleteBtn.Location = new System.Drawing.Point(70, 369);
            this.sortByNameDeleteBtn.Name = "sortByNameDeleteBtn";
            this.sortByNameDeleteBtn.Size = new System.Drawing.Size(137, 61);
            this.sortByNameDeleteBtn.TabIndex = 8;
            this.sortByNameDeleteBtn.Text = "Sort by Name";
            this.sortByNameDeleteBtn.UseVisualStyleBackColor = true;
            this.sortByNameDeleteBtn.Click += new System.EventHandler(this.sortByNameBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(1035, 369);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(214, 30);
            this.nameTxt.TabIndex = 10;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(1020, 454);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(246, 42);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // endPageBtn
            // 
            this.endPageBtn.Location = new System.Drawing.Point(758, 610);
            this.endPageBtn.Name = "endPageBtn";
            this.endPageBtn.Size = new System.Drawing.Size(75, 23);
            this.endPageBtn.TabIndex = 12;
            this.endPageBtn.Text = "End page";
            this.endPageBtn.UseVisualStyleBackColor = true;
            this.endPageBtn.Click += new System.EventHandler(this.endPageBtn_Click);
            // 
            // startPageBtn
            // 
            this.startPageBtn.Location = new System.Drawing.Point(237, 610);
            this.startPageBtn.Name = "startPageBtn";
            this.startPageBtn.Size = new System.Drawing.Size(75, 23);
            this.startPageBtn.TabIndex = 13;
            this.startPageBtn.Text = "Start page";
            this.startPageBtn.UseVisualStyleBackColor = true;
            this.startPageBtn.Click += new System.EventHandler(this.startPageBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1032, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Input Name for deleting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(467, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Input data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(238, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Search by (ID, Name)";
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::ProjectPZ.Properties.Resources.digo_ws_green_wallpapers_0046;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startPageBtn);
            this.Controls.Add(this.endPageBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.sortByNameDeleteBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.sortByIdDeleteBtn);
            this.Controls.Add(this.backDeleteBtn);
            this.Controls.Add(this.forwardDeleteBtn);
            this.Controls.Add(this.dataGridViewDelete);
            this.Controls.Add(this.label1);
            this.Name = "FormDelete";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDelete;
        private System.Windows.Forms.Button forwardDeleteBtn;
        private System.Windows.Forms.Button backDeleteBtn;
        private System.Windows.Forms.Button sortByIdDeleteBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button sortByNameDeleteBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button endPageBtn;
        private System.Windows.Forms.Button startPageBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}