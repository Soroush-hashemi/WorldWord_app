
namespace WorldWord_App.Forms
{
    partial class Wordslearned
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
            this.btn_EditL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVViewAllwL = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchL = new System.Windows.Forms.TextBox();
            this.btn_DeleteL = new System.Windows.Forms.Button();
            this.btn_RefreshL = new System.Windows.Forms.Button();
            this.IDWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewAllwL)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EditL
            // 
            this.btn_EditL.Location = new System.Drawing.Point(14, 117);
            this.btn_EditL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_EditL.Name = "btn_EditL";
            this.btn_EditL.Size = new System.Drawing.Size(176, 81);
            this.btn_EditL.TabIndex = 0;
            this.btn_EditL.Text = "Edit";
            this.btn_EditL.UseVisualStyleBackColor = true;
            this.btn_EditL.Click += new System.EventHandler(this.btn_EditL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVViewAllwL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchL);
            this.groupBox1.Location = new System.Drawing.Point(196, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(665, 550);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // DGVViewAllwL
            // 
            this.DGVViewAllwL.AllowUserToAddRows = false;
            this.DGVViewAllwL.AllowUserToDeleteRows = false;
            this.DGVViewAllwL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVViewAllwL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVViewAllwL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDWord,
            this.Word,
            this.Translation});
            this.DGVViewAllwL.Location = new System.Drawing.Point(6, 57);
            this.DGVViewAllwL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGVViewAllwL.Name = "DGVViewAllwL";
            this.DGVViewAllwL.ReadOnly = true;
            this.DGVViewAllwL.RowHeadersWidth = 51;
            this.DGVViewAllwL.RowTemplate.Height = 24;
            this.DGVViewAllwL.Size = new System.Drawing.Size(652, 487);
            this.DGVViewAllwL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search :  ";
            // 
            // txtSearchL
            // 
            this.txtSearchL.Location = new System.Drawing.Point(131, 21);
            this.txtSearchL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchL.Name = "txtSearchL";
            this.txtSearchL.Size = new System.Drawing.Size(528, 29);
            this.txtSearchL.TabIndex = 0;
            this.txtSearchL.TextChanged += new System.EventHandler(this.txtSearchL_TextChanged);
            // 
            // btn_DeleteL
            // 
            this.btn_DeleteL.Location = new System.Drawing.Point(14, 233);
            this.btn_DeleteL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DeleteL.Name = "btn_DeleteL";
            this.btn_DeleteL.Size = new System.Drawing.Size(176, 81);
            this.btn_DeleteL.TabIndex = 2;
            this.btn_DeleteL.Text = "Delete";
            this.btn_DeleteL.UseVisualStyleBackColor = true;
            this.btn_DeleteL.Click += new System.EventHandler(this.btn_DeleteL_Click);
            // 
            // btn_RefreshL
            // 
            this.btn_RefreshL.Location = new System.Drawing.Point(14, 350);
            this.btn_RefreshL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_RefreshL.Name = "btn_RefreshL";
            this.btn_RefreshL.Size = new System.Drawing.Size(176, 81);
            this.btn_RefreshL.TabIndex = 1;
            this.btn_RefreshL.Text = "Refresh";
            this.btn_RefreshL.UseVisualStyleBackColor = true;
            this.btn_RefreshL.Click += new System.EventHandler(this.btn_RefreshL_Click);
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
            // Wordslearned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 575);
            this.Controls.Add(this.btn_RefreshL);
            this.Controls.Add(this.btn_DeleteL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_EditL);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Wordslearned";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Wordslearned_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewAllwL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_EditL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DeleteL;
        private System.Windows.Forms.Button btn_RefreshL;
        private System.Windows.Forms.TextBox txtSearchL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVViewAllwL;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translation;
    }
}