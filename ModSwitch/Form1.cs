using System.IO;

namespace ModSwitch
{
    public partial class Form1 : Form
    {
        private List<string> subfolderpath = new List<string>(); // Declare List to store path of Subfolders

        public Form1()
        {
            InitializeComponent();
            LoadSavedPaths();
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing1(object? sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSavedPaths()
        {
            // Retrieve stored paths and populate TextBoxes
            textmods.Text = Properties.Settings.Default.SourceFolderPath;
            textmc.Text = Properties.Settings.Default.DestinationFolderPath;
        }

        private void SavePaths()
        {
            // Save paths to application settings
            Properties.Settings.Default.SourceFolderPath = textmods.Text;
            Properties.Settings.Default.DestinationFolderPath = textmc.Text;
            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save paths when form is closing
            SavePaths();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //
        }

        private void modsbutton_Click(object sender, EventArgs e)
        {
            if (folderBrowsermods.ShowDialog() == DialogResult.OK)
            {
                string FolderModsPath = folderBrowsermods.SelectedPath;
                textmods.Text = FolderModsPath; // Display Path in TextBox
                UpdateComboBox(FolderModsPath);
            }
        }

        private void buttonmc_Click(object sender, EventArgs e)
        {
            if (folderBrowsermc.ShowDialog() == DialogResult.OK)
            {
                string FolderMcPath = folderBrowsermc.SelectedPath;
                textmc.Text = FolderMcPath; // Display Path in TextBox
                UpdateComboBox(FolderMcPath);
            }
        }

        private void buttonselect_Click(object sender, EventArgs e)
        {
            string SourceFolder = dropselect.SelectedIndex >= 0 ? subfolderpath[dropselect.SelectedIndex] : null;
            string DestinationFolder = textmc.Text; // Get Minecraft Folder Path

            if (!string.IsNullOrEmpty(SourceFolder) && Directory.Exists(SourceFolder) && !string.IsNullOrEmpty(DestinationFolder))
            {
                try
                {
                    if (checkselect.Checked)
                    {
                        // Delete existing files in Destination Folder
                        foreach (string file in Directory.GetFiles(DestinationFolder))
                        {
                            File.Delete(file);
                        }
                    }

                    foreach (string file in Directory.GetFiles(SourceFolder))
                    {
                        File.Copy(file, Path.Combine(DestinationFolder, Path.GetFileName(file)), true);
                    }

                    MessageBox.Show("Files copied successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"And Error occurred: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("Please select both source and destination folders!");
            }
        }

        private void dropselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Not currently implemented
        }

        private void textmods_TextChanged(object sender, EventArgs e)
        {
            string folderPath = textmods.Text;

            if (Directory.Exists(folderPath))
            {
                UpdateComboBox(folderPath);
            }
        }

        private void UpdateComboBox(string folderPath)
        {
            string[] subfolders = Directory.GetDirectories(folderPath);

            dropselect.Items.Clear();
            subfolderpath.Clear();

            foreach (string subfolder in subfolders)
            {
                string SubfolderName = Path.GetFileName(subfolder); // Get subfolder Name
                dropselect.Items.Add(SubfolderName); // Display Subfolders (Name only) in DropDown Menu
                subfolderpath.Add(subfolder); // Store full path of the Subfolders
            }
        }       
    }
}
