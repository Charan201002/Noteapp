namespace NoteTakingApp
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.TitleEntryBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageEntryBox = new System.Windows.Forms.TextBox();
            this.savedNotesTable = new System.Windows.Forms.DataGridView();
            this.NewBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.savedNotesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleEntryBox
            // 
            this.TitleEntryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleEntryBox.Location = new System.Drawing.Point(129, 48);
            this.TitleEntryBox.Margin = new System.Windows.Forms.Padding(0);
            this.TitleEntryBox.Name = "TitleEntryBox";
            this.TitleEntryBox.Size = new System.Drawing.Size(320, 22);
            this.TitleEntryBox.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(53, 48);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(53, 22);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title:";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(39, 104);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(85, 22);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "Message:";
            // 
            // MessageEntryBox
            // 
            this.MessageEntryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageEntryBox.Location = new System.Drawing.Point(129, 104);
            this.MessageEntryBox.Margin = new System.Windows.Forms.Padding(0);
            this.MessageEntryBox.Multiline = true;
            this.MessageEntryBox.Name = "MessageEntryBox";
            this.MessageEntryBox.Size = new System.Drawing.Size(320, 233);
            this.MessageEntryBox.TabIndex = 3;
            // 
            // savedNotesTable
            // 
            this.savedNotesTable.AllowUserToAddRows = false;
            this.savedNotesTable.AllowUserToDeleteRows = false;
            this.savedNotesTable.AllowUserToResizeColumns = false;
            this.savedNotesTable.AllowUserToResizeRows = false;
            this.savedNotesTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savedNotesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savedNotesTable.Location = new System.Drawing.Point(502, 48);
            this.savedNotesTable.Margin = new System.Windows.Forms.Padding(0);
            this.savedNotesTable.Name = "savedNotesTable";
            this.savedNotesTable.ReadOnly = true;
            this.savedNotesTable.RowHeadersVisible = false;
            this.savedNotesTable.RowHeadersWidth = 51;
            this.savedNotesTable.RowTemplate.Height = 24;
            this.savedNotesTable.Size = new System.Drawing.Size(249, 288);
            this.savedNotesTable.TabIndex = 4;
            this.savedNotesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.savedNotesTable_CellContentClick);
            // 
            // NewBtn
            // 
            this.NewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.Location = new System.Drawing.Point(129, 376);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 30);
            this.NewBtn.TabIndex = 5;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(374, 375);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 31);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadBtn.Location = new System.Drawing.Point(502, 376);
            this.ReadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 32);
            this.ReadBtn.TabIndex = 7;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(665, 375);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 31);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 455);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.savedNotesTable);
            this.Controls.Add(this.MessageEntryBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleEntryBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NoteForm";
            this.Text = "Note-taking App";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.savedNotesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox TitleEntryBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageEntryBox;
        private System.Windows.Forms.DataGridView savedNotesTable;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

    