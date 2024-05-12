namespace ModSwitch
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
            label1 = new Label();
            labelselect = new Label();
            labelmods = new Label();
            labelmc = new Label();
            imagelogo = new PictureBox();
            buttonmc = new Button();
            textmc = new TextBox();
            buttonmods = new Button();
            textmods = new TextBox();
            dropselect = new ComboBox();
            checkselect = new CheckBox();
            buttonselect = new Button();
            folderBrowsermods = new FolderBrowserDialog();
            openFilemods = new OpenFileDialog();
            folderBrowsermc = new FolderBrowserDialog();
            openFilemc = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)imagelogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Berlin Sans FB Demi", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(142, 227, 255);
            label1.Location = new Point(350, 10);
            label1.Name = "label1";
            label1.Size = new Size(300, 60);
            label1.TabIndex = 0;
            label1.Text = "Mod Switch";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelselect
            // 
            labelselect.Anchor = AnchorStyles.Left;
            labelselect.Font = new Font("Berlin Sans FB Demi", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelselect.ForeColor = Color.FromArgb(142, 227, 255);
            labelselect.Location = new Point(50, 150);
            labelselect.Name = "labelselect";
            labelselect.Size = new Size(310, 60);
            labelselect.TabIndex = 1;
            labelselect.Text = "Select your Mods:";
            labelselect.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelmods
            // 
            labelmods.Anchor = AnchorStyles.Left;
            labelmods.Font = new Font("Berlin Sans FB Demi", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelmods.ForeColor = Color.FromArgb(142, 227, 255);
            labelmods.Location = new Point(50, 250);
            labelmods.Name = "labelmods";
            labelmods.Size = new Size(310, 60);
            labelmods.TabIndex = 2;
            labelmods.Text = "Your Mods Folder:";
            labelmods.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelmc
            // 
            labelmc.Anchor = AnchorStyles.Left;
            labelmc.Font = new Font("Berlin Sans FB Demi", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelmc.ForeColor = Color.FromArgb(142, 227, 255);
            labelmc.Location = new Point(50, 350);
            labelmc.Name = "labelmc";
            labelmc.Size = new Size(370, 60);
            labelmc.TabIndex = 3;
            labelmc.Text = "Your Minecraft Folder:";
            labelmc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // imagelogo
            // 
            imagelogo.Image = Properties.Resources.TA;
            imagelogo.Location = new Point(50, 10);
            imagelogo.Name = "imagelogo";
            imagelogo.Size = new Size(100, 100);
            imagelogo.SizeMode = PictureBoxSizeMode.Zoom;
            imagelogo.TabIndex = 4;
            imagelogo.TabStop = false;
            // 
            // buttonmc
            // 
            buttonmc.Anchor = AnchorStyles.Right;
            buttonmc.Location = new Point(917, 368);
            buttonmc.Name = "buttonmc";
            buttonmc.Size = new Size(33, 33);
            buttonmc.TabIndex = 5;
            buttonmc.UseVisualStyleBackColor = true;
            buttonmc.Click += buttonmc_Click;
            // 
            // textmc
            // 
            textmc.Anchor = AnchorStyles.Right;
            textmc.Font = new Font("Calibri Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textmc.Location = new Point(431, 368);
            textmc.Name = "textmc";
            textmc.Size = new Size(480, 33);
            textmc.TabIndex = 6;
            textmc.Text = "smth like \\myfolder\\mymods";
            // 
            // buttonmods
            // 
            buttonmods.Anchor = AnchorStyles.Right;
            buttonmods.Location = new Point(917, 270);
            buttonmods.Name = "buttonmods";
            buttonmods.Size = new Size(33, 33);
            buttonmods.TabIndex = 7;
            buttonmods.UseVisualStyleBackColor = true;
            buttonmods.Click += modsbutton_Click;
            // 
            // textmods
            // 
            textmods.Anchor = AnchorStyles.Right;
            textmods.Font = new Font("Calibri Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textmods.Location = new Point(431, 270);
            textmods.Name = "textmods";
            textmods.Size = new Size(480, 33);
            textmods.TabIndex = 8;
            textmods.Text = "smth like \\.minecraft\\mods";
            textmods.TextChanged += textmods_TextChanged;
            // 
            // dropselect
            // 
            dropselect.Anchor = AnchorStyles.Right;
            dropselect.DropDownStyle = ComboBoxStyle.DropDownList;
            dropselect.Font = new Font("Calibri Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dropselect.FormattingEnabled = true;
            dropselect.ItemHeight = 26;
            dropselect.Location = new Point(431, 170);
            dropselect.Name = "dropselect";
            dropselect.Size = new Size(274, 34);
            dropselect.TabIndex = 9;
            dropselect.SelectedIndexChanged += dropselect_SelectedIndexChanged;
            // 
            // checkselect
            // 
            checkselect.Anchor = AnchorStyles.Right;
            checkselect.AutoSize = true;
            checkselect.Font = new Font("Berlin Sans FB Demi", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkselect.ForeColor = Color.FromArgb(142, 227, 255);
            checkselect.Location = new Point(728, 172);
            checkselect.Name = "checkselect";
            checkselect.Size = new Size(222, 28);
            checkselect.TabIndex = 10;
            checkselect.Text = "Delete existing Files";
            checkselect.UseVisualStyleBackColor = true;
            checkselect.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // buttonselect
            // 
            buttonselect.Anchor = AnchorStyles.Bottom;
            buttonselect.Font = new Font("Berlin Sans FB Demi", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonselect.ForeColor = Color.Black;
            buttonselect.Location = new Point(350, 458);
            buttonselect.Name = "buttonselect";
            buttonselect.Size = new Size(300, 58);
            buttonselect.TabIndex = 11;
            buttonselect.Text = "Switch Mods";
            buttonselect.UseVisualStyleBackColor = true;
            buttonselect.Click += buttonselect_Click;
            // 
            // openFilemods
            // 
            openFilemods.FileName = "openFilemods";
            // 
            // openFilemc
            // 
            openFilemc.FileName = "openFilemc";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(984, 561);
            Controls.Add(buttonselect);
            Controls.Add(checkselect);
            Controls.Add(dropselect);
            Controls.Add(buttonmods);
            Controls.Add(textmods);
            Controls.Add(buttonmc);
            Controls.Add(textmc);
            Controls.Add(imagelogo);
            Controls.Add(labelmc);
            Controls.Add(labelmods);
            Controls.Add(labelselect);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mod Switch";
            ((System.ComponentModel.ISupportInitialize)imagelogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelselect;
        private Label labelmods;
        private Label labelmc;
        private PictureBox imagelogo;
        private Button buttonmc;
        private TextBox textmc;
        private Button buttonmods;
        private TextBox textmods;
        private ComboBox dropselect;
        private CheckBox checkselect;
        private Button buttonselect;
        private FolderBrowserDialog folderBrowsermods;
        private OpenFileDialog openFilemods;
        private FolderBrowserDialog folderBrowsermc;
        private OpenFileDialog openFilemc;
    }
}
