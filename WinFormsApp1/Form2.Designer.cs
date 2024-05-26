namespace WinFormsApp1
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
            previousNotes = new DataGridView();
            titleBox = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            loadButton = new Button();
            noteBox = new Label();
            deleteButton = new Button();
            saveButton = new Button();
            newNoteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // previousNotes
            // 
            previousNotes.BackgroundColor = Color.WhiteSmoke;
            previousNotes.BorderStyle = BorderStyle.None;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(12, 12);
            previousNotes.Name = "previousNotes";
            previousNotes.RowHeadersWidth = 51;
            previousNotes.RowTemplate.Height = 29;
            previousNotes.Size = new Size(404, 388);
            previousNotes.TabIndex = 0;
            previousNotes.CellContentClick += previousNotes_CellContentClick;
            // 
            // titleBox
            // 
            titleBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            titleBox.Location = new Point(422, 9);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(44, 20);
            titleBox.TabIndex = 1;
            titleBox.Text = "Title:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(422, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 20);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(422, 89);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 425);
            textBox2.TabIndex = 3;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.White;
            loadButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.Location = new Point(12, 406);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(198, 51);
            loadButton.TabIndex = 4;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // noteBox
            // 
            noteBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            noteBox.Location = new Point(422, 66);
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(48, 20);
            noteBox.TabIndex = 5;
            noteBox.Text = "Note:";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(218, 406);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(198, 51);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.White;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(218, 463);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(198, 51);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // newNoteButton
            // 
            newNoteButton.BackColor = Color.White;
            newNoteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newNoteButton.Location = new Point(12, 463);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(198, 51);
            newNoteButton.TabIndex = 8;
            newNoteButton.Text = "New Note";
            newNoteButton.UseVisualStyleBackColor = false;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(809, 526);
            Controls.Add(newNoteButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(noteBox);
            Controls.Add(loadButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(titleBox);
            Controls.Add(previousNotes);
            Name = "NoteTaker";
            Text = "Note Taker";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView previousNotes;
        private Label titleBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button loadButton;
        private Label noteBox;
        private Button deleteButton;
        private Button saveButton;
        private Button newNoteButton;
    }
}