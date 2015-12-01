namespace ProjectPZ
{
    partial class FormEdit
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
            this.dataGridViewEdit = new System.Windows.Forms.DataGridView();
            this.forwardEditBtn = new System.Windows.Forms.Button();
            this.backEditBtn = new System.Windows.Forms.Button();
            this.sortByIdEditBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sortByNameEditBtn = new System.Windows.Forms.Button();
            this.nameEditTxt = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.endPageEditBtn = new System.Windows.Forms.Button();
            this.startPageEditBtn = new System.Windows.Forms.Button();
            this.idEditTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).BeginInit();
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
            // dataGridViewEdit
            // 
            this.dataGridViewEdit.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.dataGridViewEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEdit.Location = new System.Drawing.Point(237, 255);
            this.dataGridViewEdit.Name = "dataGridViewEdit";
            this.dataGridViewEdit.Size = new System.Drawing.Size(596, 349);
            this.dataGridViewEdit.TabIndex = 1;
            this.dataGridViewEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEdit_CellClick);
            // 
            // forwardEditBtn
            // 
            this.forwardEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forwardEditBtn.Location = new System.Drawing.Point(553, 610);
            this.forwardEditBtn.Name = "forwardEditBtn";
            this.forwardEditBtn.Size = new System.Drawing.Size(137, 34);
            this.forwardEditBtn.TabIndex = 2;
            this.forwardEditBtn.Text = "Forward";
            this.forwardEditBtn.UseVisualStyleBackColor = true;
            this.forwardEditBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // backEditBtn
            // 
            this.backEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backEditBtn.Location = new System.Drawing.Point(388, 610);
            this.backEditBtn.Name = "backEditBtn";
            this.backEditBtn.Size = new System.Drawing.Size(137, 34);
            this.backEditBtn.TabIndex = 3;
            this.backEditBtn.Text = "Back";
            this.backEditBtn.UseVisualStyleBackColor = true;
            this.backEditBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // sortByIdEditBtn
            // 
            this.sortByIdEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByIdEditBtn.Location = new System.Drawing.Point(70, 255);
            this.sortByIdEditBtn.Name = "sortByIdEditBtn";
            this.sortByIdEditBtn.Size = new System.Drawing.Size(137, 61);
            this.sortByIdEditBtn.TabIndex = 4;
            this.sortByIdEditBtn.Text = "Sort by ID";
            this.sortByIdEditBtn.UseVisualStyleBackColor = true;
            this.sortByIdEditBtn.Click += new System.EventHandler(this.sortByIdBtn_Click);
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
            // sortByNameEditBtn
            // 
            this.sortByNameEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByNameEditBtn.Location = new System.Drawing.Point(70, 369);
            this.sortByNameEditBtn.Name = "sortByNameEditBtn";
            this.sortByNameEditBtn.Size = new System.Drawing.Size(137, 61);
            this.sortByNameEditBtn.TabIndex = 8;
            this.sortByNameEditBtn.Text = "Sort by Name";
            this.sortByNameEditBtn.UseVisualStyleBackColor = true;
            this.sortByNameEditBtn.Click += new System.EventHandler(this.sortByNameBtn_Click);
            // 
            // nameEditTxt
            // 
            this.nameEditTxt.Location = new System.Drawing.Point(1035, 369);
            this.nameEditTxt.Multiline = true;
            this.nameEditTxt.Name = "nameEditTxt";
            this.nameEditTxt.Size = new System.Drawing.Size(214, 30);
            this.nameEditTxt.TabIndex = 10;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.Location = new System.Drawing.Point(1020, 454);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(246, 42);
            this.editBtn.TabIndex = 11;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // endPageEditBtn
            // 
            this.endPageEditBtn.Location = new System.Drawing.Point(758, 610);
            this.endPageEditBtn.Name = "endPageEditBtn";
            this.endPageEditBtn.Size = new System.Drawing.Size(75, 23);
            this.endPageEditBtn.TabIndex = 12;
            this.endPageEditBtn.Text = "End page";
            this.endPageEditBtn.UseVisualStyleBackColor = true;
            this.endPageEditBtn.Click += new System.EventHandler(this.endPageBtn_Click);
            // 
            // startPageEditBtn
            // 
            this.startPageEditBtn.Location = new System.Drawing.Point(237, 610);
            this.startPageEditBtn.Name = "startPageEditBtn";
            this.startPageEditBtn.Size = new System.Drawing.Size(75, 23);
            this.startPageEditBtn.TabIndex = 13;
            this.startPageEditBtn.Text = "Start page";
            this.startPageEditBtn.UseVisualStyleBackColor = true;
            this.startPageEditBtn.Click += new System.EventHandler(this.startPageBtn_Click);
            // 
            // idEditTxt
            // 
            this.idEditTxt.Location = new System.Drawing.Point(1035, 276);
            this.idEditTxt.Multiline = true;
            this.idEditTxt.Name = "idEditTxt";
            this.idEditTxt.Size = new System.Drawing.Size(214, 30);
            this.idEditTxt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(234, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Search by (ID, Name)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(463, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Input data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1032, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1032, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Input Name for editing";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::ProjectPZ.Properties.Resources.digo_ws_green_wallpapers_0046;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idEditTxt);
            this.Controls.Add(this.startPageEditBtn);
            this.Controls.Add(this.endPageEditBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.nameEditTxt);
            this.Controls.Add(this.sortByNameEditBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.sortByIdEditBtn);
            this.Controls.Add(this.backEditBtn);
            this.Controls.Add(this.forwardEditBtn);
            this.Controls.Add(this.dataGridViewEdit);
            this.Controls.Add(this.label1);
            this.Name = "FormEdit";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEdit;
        private System.Windows.Forms.Button forwardEditBtn;
        private System.Windows.Forms.Button backEditBtn;
        private System.Windows.Forms.Button sortByIdEditBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button sortByNameEditBtn;
        private System.Windows.Forms.TextBox nameEditTxt;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button endPageEditBtn;
        private System.Windows.Forms.Button startPageEditBtn;
        private System.Windows.Forms.TextBox idEditTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}