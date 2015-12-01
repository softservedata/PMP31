namespace ProjectPZ
{
    partial class FormAdd
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
            this.dataGridViewAdd = new System.Windows.Forms.DataGridView();
            this.forwardAddBtn = new System.Windows.Forms.Button();
            this.backAddBtn = new System.Windows.Forms.Button();
            this.sortByIdAddBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sortByNameAddBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.startPageBtn = new System.Windows.Forms.Button();
            this.endPageBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).BeginInit();
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
            // dataGridViewAdd
            // 
            this.dataGridViewAdd.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.dataGridViewAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdd.Location = new System.Drawing.Point(237, 255);
            this.dataGridViewAdd.Name = "dataGridViewAdd";
            this.dataGridViewAdd.Size = new System.Drawing.Size(596, 349);
            this.dataGridViewAdd.TabIndex = 1;
            // 
            // forwardAddBtn
            // 
            this.forwardAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forwardAddBtn.Location = new System.Drawing.Point(551, 610);
            this.forwardAddBtn.Name = "forwardAddBtn";
            this.forwardAddBtn.Size = new System.Drawing.Size(137, 34);
            this.forwardAddBtn.TabIndex = 2;
            this.forwardAddBtn.Text = "Forward";
            this.forwardAddBtn.UseVisualStyleBackColor = true;
            this.forwardAddBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // backAddBtn
            // 
            this.backAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backAddBtn.Location = new System.Drawing.Point(389, 610);
            this.backAddBtn.Name = "backAddBtn";
            this.backAddBtn.Size = new System.Drawing.Size(137, 34);
            this.backAddBtn.TabIndex = 3;
            this.backAddBtn.Text = "Back";
            this.backAddBtn.UseVisualStyleBackColor = true;
            this.backAddBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // sortByIdAddBtn
            // 
            this.sortByIdAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByIdAddBtn.Location = new System.Drawing.Point(70, 255);
            this.sortByIdAddBtn.Name = "sortByIdAddBtn";
            this.sortByIdAddBtn.Size = new System.Drawing.Size(137, 61);
            this.sortByIdAddBtn.TabIndex = 4;
            this.sortByIdAddBtn.Text = "Sort by ID";
            this.sortByIdAddBtn.UseVisualStyleBackColor = true;
            this.sortByIdAddBtn.Click += new System.EventHandler(this.sortByIdBtn_Click);
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
            // sortByNameAddBtn
            // 
            this.sortByNameAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByNameAddBtn.Location = new System.Drawing.Point(70, 369);
            this.sortByNameAddBtn.Name = "sortByNameAddBtn";
            this.sortByNameAddBtn.Size = new System.Drawing.Size(137, 61);
            this.sortByNameAddBtn.TabIndex = 8;
            this.sortByNameAddBtn.Text = "Sort by Name";
            this.sortByNameAddBtn.UseVisualStyleBackColor = true;
            this.sortByNameAddBtn.Click += new System.EventHandler(this.sortByNameBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(1035, 369);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(214, 30);
            this.nameTxt.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(1020, 454);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(246, 42);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // startPageBtn
            // 
            this.startPageBtn.Location = new System.Drawing.Point(237, 610);
            this.startPageBtn.Name = "startPageBtn";
            this.startPageBtn.Size = new System.Drawing.Size(75, 23);
            this.startPageBtn.TabIndex = 14;
            this.startPageBtn.Text = "Start page";
            this.startPageBtn.UseVisualStyleBackColor = true;
            this.startPageBtn.Click += new System.EventHandler(this.startPageBtn_Click);
            // 
            // endPageBtn
            // 
            this.endPageBtn.Location = new System.Drawing.Point(758, 610);
            this.endPageBtn.Name = "endPageBtn";
            this.endPageBtn.Size = new System.Drawing.Size(75, 23);
            this.endPageBtn.TabIndex = 15;
            this.endPageBtn.Text = "End page";
            this.endPageBtn.UseVisualStyleBackColor = true;
            this.endPageBtn.Click += new System.EventHandler(this.endPageBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(240, 192);
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
            this.label3.Location = new System.Drawing.Point(469, 192);
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
            this.label2.Location = new System.Drawing.Point(1032, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Input Name for adding";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::ProjectPZ.Properties.Resources.digo_ws_green_wallpapers_0046;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endPageBtn);
            this.Controls.Add(this.startPageBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.sortByNameAddBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.sortByIdAddBtn);
            this.Controls.Add(this.backAddBtn);
            this.Controls.Add(this.forwardAddBtn);
            this.Controls.Add(this.dataGridViewAdd);
            this.Controls.Add(this.label1);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAdd;
        private System.Windows.Forms.Button forwardAddBtn;
        private System.Windows.Forms.Button backAddBtn;
        private System.Windows.Forms.Button sortByIdAddBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button sortByNameAddBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button startPageBtn;
        private System.Windows.Forms.Button endPageBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}