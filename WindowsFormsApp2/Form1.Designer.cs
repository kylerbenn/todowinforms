namespace WindowsFormsApp2
{
    partial class Form1
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
            this.BoxName = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxTodo = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.listBoxTodo = new System.Windows.Forms.ListBox();
            this.listBoxDone = new System.Windows.Forms.ListBox();
            this.labelTodo = new System.Windows.Forms.Label();
            this.labelDone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BoxName.SuspendLayout();
            this.groupBoxTodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxName
            // 
            this.BoxName.Controls.Add(this.btnSubmit);
            this.BoxName.Controls.Add(this.textBox1);
            this.BoxName.Controls.Add(this.labelName);
            this.BoxName.Location = new System.Drawing.Point(12, 12);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(431, 72);
            this.BoxName.TabIndex = 0;
            this.BoxName.TabStop = false;
            this.BoxName.Text = "Enter your name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(339, 25);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 20);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 0;
            // 
            // groupBoxTodo
            // 
            this.groupBoxTodo.Controls.Add(this.buttonAdd);
            this.groupBoxTodo.Controls.Add(this.textBoxTask);
            this.groupBoxTodo.Location = new System.Drawing.Point(12, 119);
            this.groupBoxTodo.Name = "groupBoxTodo";
            this.groupBoxTodo.Size = new System.Drawing.Size(233, 74);
            this.groupBoxTodo.TabIndex = 1;
            this.groupBoxTodo.TabStop = false;
            this.groupBoxTodo.Text = "Add Todo";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(144, 30);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 20);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(18, 30);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(109, 20);
            this.textBoxTask.TabIndex = 0;
            // 
            // listBoxTodo
            // 
            this.listBoxTodo.FormattingEnabled = true;
            this.listBoxTodo.Location = new System.Drawing.Point(12, 251);
            this.listBoxTodo.Name = "listBoxTodo";
            this.listBoxTodo.Size = new System.Drawing.Size(167, 134);
            this.listBoxTodo.TabIndex = 2;
            // 
            // listBoxDone
            // 
            this.listBoxDone.FormattingEnabled = true;
            this.listBoxDone.Location = new System.Drawing.Point(313, 251);
            this.listBoxDone.Name = "listBoxDone";
            this.listBoxDone.Size = new System.Drawing.Size(172, 134);
            this.listBoxDone.TabIndex = 3;
            // 
            // labelTodo
            // 
            this.labelTodo.AutoSize = true;
            this.labelTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTodo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTodo.Location = new System.Drawing.Point(44, 209);
            this.labelTodo.Name = "labelTodo";
            this.labelTodo.Size = new System.Drawing.Size(95, 39);
            this.labelTodo.TabIndex = 4;
            this.labelTodo.Text = "Todo";
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelDone.Location = new System.Drawing.Point(344, 209);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(99, 39);
            this.labelDone.TabIndex = 5;
            this.labelDone.Text = "Done";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "done";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 440);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.labelTodo);
            this.Controls.Add(this.listBoxDone);
            this.Controls.Add(this.listBoxTodo);
            this.Controls.Add(this.groupBoxTodo);
            this.Controls.Add(this.BoxName);
            this.Name = "Form1";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BoxName.ResumeLayout(false);
            this.BoxName.PerformLayout();
            this.groupBoxTodo.ResumeLayout(false);
            this.groupBoxTodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxTodo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.ListBox listBoxTodo;
        private System.Windows.Forms.ListBox listBoxDone;
        private System.Windows.Forms.Label labelTodo;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

