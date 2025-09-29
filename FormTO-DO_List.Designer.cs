namespace To_Do_List_Project
{
    partial class FormTO_DO_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTO_DO_List));
            this.checkedListBoxTasks = new System.Windows.Forms.CheckedListBox();
            this.textBoxTitleNameTask = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            this.buttonCheakedAllTasked = new System.Windows.Forms.Button();
            this.buttonUncheckedTasls = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonRemoveAllTasks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCompleteNumberTasks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPenddingTasks = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxTasks
            // 
            this.checkedListBoxTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(15)))));
            this.checkedListBoxTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxTasks.Font = new System.Drawing.Font("Andalus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxTasks.FormattingEnabled = true;
            this.checkedListBoxTasks.Location = new System.Drawing.Point(798, 127);
            this.checkedListBoxTasks.Name = "checkedListBoxTasks";
            this.checkedListBoxTasks.Size = new System.Drawing.Size(336, 455);
            this.checkedListBoxTasks.TabIndex = 0;
            this.checkedListBoxTasks.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxTasks_SelectedIndexChanged);
            // 
            // textBoxTitleNameTask
            // 
            this.textBoxTitleNameTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(204)))), ((int)(((byte)(3)))));
            this.textBoxTitleNameTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitleNameTask.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitleNameTask.ForeColor = System.Drawing.Color.Black;
            this.textBoxTitleNameTask.Location = new System.Drawing.Point(98, 334);
            this.textBoxTitleNameTask.Multiline = true;
            this.textBoxTitleNameTask.Name = "textBoxTitleNameTask";
            this.textBoxTitleNameTask.Size = new System.Drawing.Size(455, 33);
            this.textBoxTitleNameTask.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(204)))), ((int)(((byte)(3)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(584, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonRemoveTask
            // 
            this.buttonRemoveTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(204)))), ((int)(((byte)(3)))));
            this.buttonRemoveTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveTask.FlatAppearance.BorderSize = 0;
            this.buttonRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveTask.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveTask.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveTask.Location = new System.Drawing.Point(79, 462);
            this.buttonRemoveTask.Name = "buttonRemoveTask";
            this.buttonRemoveTask.Size = new System.Drawing.Size(130, 55);
            this.buttonRemoveTask.TabIndex = 2;
            this.buttonRemoveTask.Text = "Remove Task";
            this.buttonRemoveTask.UseVisualStyleBackColor = false;
            this.buttonRemoveTask.Click += new System.EventHandler(this.buttonRemoveTask_Click);
            // 
            // buttonCheakedAllTasked
            // 
            this.buttonCheakedAllTasked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(204)))), ((int)(((byte)(3)))));
            this.buttonCheakedAllTasked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheakedAllTasked.FlatAppearance.BorderSize = 0;
            this.buttonCheakedAllTasked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheakedAllTasked.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheakedAllTasked.ForeColor = System.Drawing.Color.Black;
            this.buttonCheakedAllTasked.Location = new System.Drawing.Point(370, 462);
            this.buttonCheakedAllTasked.Name = "buttonCheakedAllTasked";
            this.buttonCheakedAllTasked.Size = new System.Drawing.Size(164, 55);
            this.buttonCheakedAllTasked.TabIndex = 2;
            this.buttonCheakedAllTasked.Text = "Checked All Tasks";
            this.buttonCheakedAllTasked.UseVisualStyleBackColor = false;
            this.buttonCheakedAllTasked.Click += new System.EventHandler(this.buttonCheckedAllTasks_Click);
            // 
            // buttonUncheckedTasls
            // 
            this.buttonUncheckedTasls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(204)))), ((int)(((byte)(3)))));
            this.buttonUncheckedTasls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUncheckedTasls.FlatAppearance.BorderSize = 0;
            this.buttonUncheckedTasls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUncheckedTasls.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUncheckedTasls.ForeColor = System.Drawing.Color.Black;
            this.buttonUncheckedTasls.Location = new System.Drawing.Point(540, 462);
            this.buttonUncheckedTasls.Name = "buttonUncheckedTasls";
            this.buttonUncheckedTasls.Size = new System.Drawing.Size(170, 55);
            this.buttonUncheckedTasls.TabIndex = 2;
            this.buttonUncheckedTasls.Text = "Unchecked All Tasks";
            this.buttonUncheckedTasls.UseVisualStyleBackColor = false;
            this.buttonUncheckedTasls.Click += new System.EventHandler(this.buttonUnCheckedAllTasks_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(204)))), ((int)(((byte)(3)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(207, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(511, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save TO-DO List In File";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonSaveAllTasksTODOListInFile_Click);
            // 
            // buttonRemoveAllTasks
            // 
            this.buttonRemoveAllTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(204)))), ((int)(((byte)(3)))));
            this.buttonRemoveAllTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveAllTasks.FlatAppearance.BorderSize = 0;
            this.buttonRemoveAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveAllTasks.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveAllTasks.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveAllTasks.Location = new System.Drawing.Point(215, 462);
            this.buttonRemoveAllTasks.Name = "buttonRemoveAllTasks";
            this.buttonRemoveAllTasks.Size = new System.Drawing.Size(149, 55);
            this.buttonRemoveAllTasks.TabIndex = 2;
            this.buttonRemoveAllTasks.Text = "Remove All Task";
            this.buttonRemoveAllTasks.UseVisualStyleBackColor = false;
            this.buttonRemoveAllTasks.Click += new System.EventHandler(this.buttonRemoveAllTask_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(79, 541);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(210, 638);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Completed Task : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCompleteNumberTasks
            // 
            this.labelCompleteNumberTasks.AutoSize = true;
            this.labelCompleteNumberTasks.BackColor = System.Drawing.Color.Transparent;
            this.labelCompleteNumberTasks.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompleteNumberTasks.ForeColor = System.Drawing.Color.Black;
            this.labelCompleteNumberTasks.Location = new System.Drawing.Point(375, 638);
            this.labelCompleteNumberTasks.Name = "labelCompleteNumberTasks";
            this.labelCompleteNumberTasks.Size = new System.Drawing.Size(22, 26);
            this.labelCompleteNumberTasks.TabIndex = 4;
            this.labelCompleteNumberTasks.Text = "0";
            this.labelCompleteNumberTasks.Click += new System.EventHandler(this.labelCompleteNumberTasks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(496, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pendding Task : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPenddingTasks
            // 
            this.labelPenddingTasks.AutoSize = true;
            this.labelPenddingTasks.BackColor = System.Drawing.Color.Transparent;
            this.labelPenddingTasks.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenddingTasks.ForeColor = System.Drawing.Color.Black;
            this.labelPenddingTasks.Location = new System.Drawing.Point(661, 638);
            this.labelPenddingTasks.Name = "labelPenddingTasks";
            this.labelPenddingTasks.Size = new System.Drawing.Size(22, 26);
            this.labelPenddingTasks.TabIndex = 4;
            this.labelPenddingTasks.Text = "0";
            this.labelPenddingTasks.Click += new System.EventHandler(this.labelPenddingTasks_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(145, 541);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBoxResetAlSettings_Click);
            // 
            // FormTO_DO_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1223, 694);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonUncheckedTasls);
            this.Controls.Add(this.buttonCheakedAllTasked);
            this.Controls.Add(this.buttonRemoveAllTasks);
            this.Controls.Add(this.buttonRemoveTask);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTitleNameTask);
            this.Controls.Add(this.checkedListBoxTasks);
            this.Controls.Add(this.labelPenddingTasks);
            this.Controls.Add(this.labelCompleteNumberTasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTO_DO_List";
            this.Text = "TO DO List";
            this.Load += new System.EventHandler(this.FormTO_DO_List_Load);
            this.Move += new System.EventHandler(this.FormTO_DO_List_Move);
            this.Resize += new System.EventHandler(this.FormTO_DO_List_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxTasks;
        private System.Windows.Forms.TextBox textBoxTitleNameTask;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRemoveTask;
        private System.Windows.Forms.Button buttonCheakedAllTasked;
        private System.Windows.Forms.Button buttonUncheckedTasls;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonRemoveAllTasks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCompleteNumberTasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPenddingTasks;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}