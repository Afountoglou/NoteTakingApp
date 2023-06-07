namespace NoteTakingAp
{
    partial class NoteTaker
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newNoteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(464, 31);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(445, 20);
            this.titleTextBox.TabIndex = 0;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(464, 91);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(445, 515);
            this.noteTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleLabel.Location = new System.Drawing.Point(461, -2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(448, 23);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // noteLabel
            // 
            this.noteLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.noteLabel.Location = new System.Drawing.Point(461, 62);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(448, 23);
            this.noteLabel.TabIndex = 3;
            this.noteLabel.Text = "Note:";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // previousNotes
            // 
            this.previousNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previousNotes.BackgroundColor = System.Drawing.Color.White;
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotes.Location = new System.Drawing.Point(12, 12);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.Size = new System.Drawing.Size(426, 467);
            this.previousNotes.TabIndex = 4;
            this.previousNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellDoubleClick);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.White;
            this.loadButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loadButton.Location = new System.Drawing.Point(12, 485);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(206, 58);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteButton.Location = new System.Drawing.Point(224, 485);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(214, 58);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.saveButton.Location = new System.Drawing.Point(224, 548);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(214, 58);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newNoteButton
            // 
            this.newNoteButton.BackColor = System.Drawing.Color.White;
            this.newNoteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newNoteButton.Location = new System.Drawing.Point(12, 548);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(214, 58);
            this.newNoteButton.TabIndex = 8;
            this.newNoteButton.Text = "New Note";
            this.newNoteButton.UseVisualStyleBackColor = false;
            this.newNoteButton.Click += new System.EventHandler(this.newNoteButton_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(921, 618);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Name = "NoteTaker";
            this.Text = "Note Taker";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.DataGridView previousNotes;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newNoteButton;
    }
}

