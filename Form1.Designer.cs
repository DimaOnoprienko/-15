namespace Одуванчик_15
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
            textBoxWord = new TextBox();
            textBoxTranslation = new TextBox();
            buttonAdd = new Button();
            buttonSave = new Button();
            buttonLoad = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(101, 63);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(150, 31);
            textBoxWord.TabIndex = 0;
            // 
            // textBoxTranslation
            // 
            textBoxTranslation.Location = new Point(101, 120);
            textBoxTranslation.Name = "textBoxTranslation";
            textBoxTranslation.Size = new Size(150, 31);
            textBoxTranslation.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(295, 63);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Переклад";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += переклад_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(295, 191);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(295, 240);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(112, 34);
            buttonLoad.TabIndex = 4;
            buttonLoad.Text = "Завантажити";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(95, 191);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTranslation);
            Controls.Add(textBoxWord);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxWord;
        private TextBox textBoxTranslation;
        private Button buttonAdd;
        private Button buttonSave;
        private Button buttonLoad;
        private ListBox listBox1;
    }
}