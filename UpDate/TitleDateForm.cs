using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpDate
{
    public partial class TitleDateForm : Form
    {
        public event Action<ImageNameConfig> OnSave;
        private ImageNameConfig imageNameConfig = null;

        public TitleDateForm()
        {
            InitializeComponent();imageNameConfig = new ImageNameConfig();
        }

        private void saveNameConfig_Click(object sender, EventArgs e)
        {
            //Formats
            foreach (DataGridViewRow row in formats.Rows)
            {
                var cell1 = row.Cells[0].Value;
                if (cell1 != null) imageNameConfig.DateFormats.Add(cell1.ToString());
            }

            //Scenarios
            Scenario scenario = new Scenario();

            //Conditions
            foreach (DataGridViewRow row in scenario1Conditions.Rows)
            {
                var cell1 = row.Cells[0].Value ?? "";
                var cell2 = row.Cells[1].Value ?? "";

                if(cell1 == "" || cell2 == "")
                {
                    scenario.Conditions.Add(x => true);
                    continue;
                }

                string cond = cell1.ToString();
                string value = cell2.ToString();

                Expression<Predicate<string>> expr;
                if (cond == "starts with") expr = (string name) => name.StartsWith(value, StringComparison.OrdinalIgnoreCase);
                else if (cond == "end with") expr = (string name) => name.EndsWith(value, StringComparison.OrdinalIgnoreCase);
                else expr = (string name) => name.ToUpper().Contains(value.ToUpper());

                scenario.Conditions.Add(expr);
            }

            //Actions
            foreach (DataGridViewRow row in scenario1Actions.Rows)
            {
                var cell1 = row.Cells[0].Value;
                var cell2 = row.Cells[1].Value ?? "";

                if (cell1 != null)
                {
                    scenario.Actions.Add(new Action
                    {
                        OldValue = cell1.ToString(),
                        NewValue = cell2.ToString()
                    });
                }

            }
            imageNameConfig.Scenarios.Add(scenario);

            OnSave(imageNameConfig);
            this.Close();
        }
    }
}
