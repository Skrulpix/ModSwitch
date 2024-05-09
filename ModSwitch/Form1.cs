using System.IO;

namespace ModSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private List<string> subfolderpath = new List<string>(); // Declare List to store path of Subfolders

        private void modsbutton_Click(object sender, EventArgs e)
        {
            if (folderBrowsermods.ShowDialog() == DialogResult.OK)
            {
                string FolderModsPath = folderBrowsermods.SelectedPath;
                textmods.Text = FolderModsPath; // Display Path in TextBox
                string[] subfolders = Directory.GetDirectories(FolderModsPath);

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

        private void buttonmc_Click(object sender, EventArgs e)
        {
            if (folderBrowsermc.ShowDialog() == DialogResult.OK)
            {
                string FolderMcPath = folderBrowsermc.SelectedPath;
                textmc.Text = FolderMcPath; // Display Path in TextBox
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
    }
}
