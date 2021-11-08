
namespace WorldWord_App.Forms
{
    partial class AllWords
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGViewAllW = new System.Windows.Forms.DataGridView();
            this.IDWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btn_AddNewWord = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_AddIlearned = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewAllW)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGViewAllW);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(239, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // DGViewAllW
            // 
            this.DGViewAllW.AllowUserToAddRows = false;
            this.DGViewAllW.AllowUserToDeleteRows = false;
            this.DGViewAllW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGViewAllW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewAllW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDWord,
            this.Word,
            this.Translation});
            this.DGViewAllW.Location = new System.Drawing.Point(6, 60);
            this.DGViewAllW.Name = "DGViewAllW";
            this.DGViewAllW.ReadOnly = true;
            this.DGViewAllW.RowHeadersWidth = 51;
            this.DGViewAllW.RowTemplate.Height = 24;
            this.DGViewAllW.Size = new System.Drawing.Size(585, 425);
            this.DGViewAllW.TabIndex = 2;
            // 
            // IDWord
            // 
            this.IDWord.DataPropertyName = "IDWord";
            this.IDWord.HeaderText = "IDWord";
            this.IDWord.MinimumWidth = 6;
            this.IDWord.Name = "IDWord";
            this.IDWord.ReadOnly = true;
            this.IDWord.Visible = false;
            // 
            // Word
            // 
            this.Word.DataPropertyName = "Word";
            this.Word.HeaderText = "Word";
            this.Word.MinimumWidth = 6;
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            // 
            // Translation
            // 
            this.Translation.DataPropertyName = "Translation";
            this.Translation.HeaderText = "Translation";
            this.Translation.MinimumWidth = 6;
            this.Translation.Name = "Translation";
            this.Translation.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search :  ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(118, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(473, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btn_AddNewWord
            // 
            this.btn_AddNewWord.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewWord.Location = new System.Drawing.Point(31, 72);
            this.btn_AddNewWord.Name = "btn_AddNewWord";
            this.btn_AddNewWord.Size = new System.Drawing.Size(170, 56);
            this.btn_AddNewWord.TabIndex = 1;
            this.btn_AddNewWord.Text = "Add New Word";
            this.btn_AddNewWord.UseVisualStyleBackColor = true;
            this.btn_AddNewWord.Click += new System.EventHandler(this.btn_AddNewWord_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(31, 154);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(170, 56);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(31, 246);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(170, 56);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete Word";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(31, 334);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(170, 56);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_AddIlearned
            // 
            this.btn_AddIlearned.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddIlearned.Location = new System.Drawing.Point(31, 421);
            this.btn_AddIlearned.Name = "btn_AddIlearned";
            this.btn_AddIlearned.Size = new System.Drawing.Size(170, 56);
            this.btn_AddIlearned.TabIndex = 5;
            this.btn_AddIlearned.Text = "Add to the words I learned";
            this.btn_AddIlearned.UseVisualStyleBackColor = true;
            this.btn_AddIlearned.Click += new System.EventHandler(this.btn_AddIlearned_Click);
            // 
            // AllWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 515);
            this.Controls.Add(this.btn_AddIlearned);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_AddNewWord);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AllWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AllWords";
            this.Load += new System.EventHandler(this.AllWords_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewAllW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddNewWord;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DGViewAllW;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translation;
        private System.Windows.Forms.Button btn_AddIlearned;
    }
}