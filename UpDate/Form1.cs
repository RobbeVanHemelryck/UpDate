using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpDate
{
    public partial class MainForm : Form
    {
        public UpDateService upDateService { get; set; }
        public MainForm()
        {
            upDateService = new UpDateService();
            InitializeComponent();
        }

        private void folderSelectButton_Click(object sender, EventArgs e)
        {
            string dir = showFolderDialog();
            folderSelectTextBox.Text = dir;

            var files = upDateService.LoadFilesRecursively(dir);
            imagesDataGrid.DataSource = files;
            totalAmountLabel.Text = files.Count + " files";
            selectedAmountLabel.Text = "0 selected";
            totalAmountLabel.Visible = true;
            selectedAmountLabel.Visible = true;
        }

        private string showFolderDialog()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }
            return "";
        }

        private void openTitleDateButton_Click(object sender, EventArgs e)
        {
            var form = new TitleDateForm();
            form.Show(this);
        }

        private void imagesDataGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            selectedAmountLabel.Text = imagesDataGrid.SelectedRows.Count + " selected";
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            var selectedRows = imagesDataGrid.SelectedRows;
            List<DisplayImage> selectedFiles = new List<DisplayImage>();
            foreach(DataGridViewRow row in selectedRows)
            {
                selectedFiles.Add((DisplayImage)row.DataBoundItem);
            }
            
        }
    }
}
