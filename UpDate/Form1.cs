using MetadataExtractor;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UpDate.UpDateService;

namespace UpDate
{
    public partial class MainForm : Form
    {
        public UpDateService upDateService { get; set; }
        private ImageNameConfig imageNameConfig;
        private string mostRecentFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        public MainForm()
        {
            upDateService = new UpDateService();
            this.fixFuiven();

            
            InitializeComponent();
            this.CheckDatesToChange();
            //if(!maskedTextBox1.Modified) maskedTextBox1.Text = "00/00/0000 23:59";
        }

        private void CheckDatesToChange()
        {
            for (int i = 0; i < datesToChangeList.Items.Count; i++)
            {
                datesToChangeList.SetItemChecked(i, true);
            }
        }

        private void folderSelectButton_Click(object sender, EventArgs e)
        {
            string dir = showFolderDialog();
            folderSelectTextBox.Text = dir;

            var files = upDateService.LoadFilesRecursively(dir);
            files = files.OrderBy(x => x.Date).ToList();
            imagesDataGrid.DataSource = files;

            imagesDataGrid.SelectAll();

            totalAmountLabel.Text = files.Count + " files";
            selectedAmountLabel.Text = files.Count + " selected";
            totalAmountLabel.Visible = true;
            selectedAmountLabel.Visible = true;

            maskedTextBox1.Clear();
            maskedTextBox1.Focus();
        }

        private string showFolderDialog()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = mostRecentFolder;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                mostRecentFolder = dialog.FileName;
                return dialog.FileName;
            }
            return "";
        }

        private void openTitleDateButton_Click(object sender, EventArgs e)
        {
            var form = new TitleDateForm();
            form.OnSave += res => imageNameConfig = res;
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
            List<string> selectedFiles = new List<string>();
            foreach(DataGridViewRow row in selectedRows)
            {
                DisplayImage img = (DisplayImage)row.DataBoundItem;
                selectedFiles.Add(img.FileInfo.FullName);
            }

            List<DateType> datesToChange = new List<DateType>();
            //for (int i = 0; i < datesToChangeList.SelectedItems.Count; i++)
            //{
            //    string value = datesToChangeList.SelectedItems[i].ToString();
            //    datesToChange.Add(value == "Date created" ? DateType.CREATED : value == "Date modified" ? DateType.MODIFIED : DateType.TAKEN);
            //}

            DateTime hardCodedDateTime;
            string dateTimeInput = maskedTextBox1.Text;
            DateTime.TryParseExact(dateTimeInput, "yyyy-MM-dd HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out hardCodedDateTime);
            upDateService.FixDates(selectedFiles, datesToChange, imageNameConfig, hardCodedDateTime);
        }

        private void fixFuiven()
        {
            List<string> dirs = System.IO.Directory.GetDirectories(@"\\192.168.0.102\Libraries\Libraries\Pictures\iPhone 5S Foto's\Fuiven").ToList();
            foreach (string dir in dirs)
            {
                string dateTimeString = Path.GetFileName(dir).Substring(0, 10) + " 23:59";
                DateTime dateTime = DateTime.Parse(dateTimeString);
                var files = upDateService.LoadFilesRecursively(dir);

                List<string> fileNames = files.Select(x => x.FileInfo.FullName).ToList();
                upDateService.FixDates(fileNames, new List<DateType>(), imageNameConfig, dateTime);
            }
        }
    }
}
