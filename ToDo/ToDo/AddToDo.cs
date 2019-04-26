using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class AddToDo : Form
    {
        public AddToDo()
        {
            InitializeComponent();
        }
        List<string> references = new List<string>();
        private void Confirm_Click(object sender, EventArgs e)
        {
            ConfigurationManager manager = new ConfigurationManager();
            ToDo todo = new ToDo()
            {
                When = dateTimePicker1.Value,
                WhatToDo = txt_WhatToDo.Text,
                type = cmbBx_1.Text,
                References = references
            };
            manager.UploadToDo(todo);
        }

        private void Btn_AddRef_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_References.Text))
            {
                references.Add(txt_References.Text);
            }
        }
    }
}
