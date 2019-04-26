using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.ListView;
using System.Runtime.InteropServices;

namespace ToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetDatabase();
            UpdateListView();
            RegisterHotKey(this.Handle, this.GetType().GetHashCode(), 0x0002, (int)Keys.Space);
        }

        ConfigurationManager manager = new ConfigurationManager();
        private void SetDatabase()
        {
            string[] strdatabase = File.ReadAllLines(System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\documents\\ToDo\\Database.txt");
            Database database = new Database()
            {
                IP = strdatabase[0],
                databaseName = strdatabase[1],
                username = strdatabase[2],
                password = strdatabase[3],
                port = Convert.ToInt16(strdatabase[4])
            };
            StaticInfo.curretnDatabase = database;
        }

        public void UpdateListView()
        {
            List<ToDo> toDos = manager.GetFromDatabase();
            SetItems(toDos);
        }

        void SetItems(List<ToDo> todos)
        {
            int id = 0;
            foreach (ToDo todo in todos)
            {
                id++;
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                subitem.Name = "WhatToDo";
                subitem.Text = todo.WhatToDo;
                subitem.Tag = todo.WhatToDo;
                ListViewItem item = new ListViewItem();

                item.SubItems.Clear();
                item.SubItems[0] = subitem;
                subitem = new ListViewItem.ListViewSubItem();
                subitem.Name = "WhenToDo";
                subitem.Tag = todo.WhatToDo;
                subitem.Text = todo.When.ToString();
                item.SubItems.Add(subitem);

                subitem = new ListViewItem.ListViewSubItem();
                subitem.Name = "Type";
                subitem.Tag = todo.type;
                subitem.Text = todo.type;
                item.SubItems.Add(subitem);

                subitem = new ListViewItem.ListViewSubItem();
                subitem.Name = "Ref ID";
                subitem.Tag = id;
                subitem.Text = id.ToString();
                item.SubItems.Add(subitem);

                lstVw_Main.Items.Add(item);

                subitem = new ListViewItem.ListViewSubItem();
                subitem.Name = "Reference";
                subitem.Tag = todo.References;
                foreach (var x in todo.References)
                    subitem.Text += x + ",";
                item = new ListViewItem();
                item.SubItems.Add(subitem);
                subitem = new ListViewItem.ListViewSubItem();
                subitem.Tag = id;
                subitem.Text = id.ToString();
                subitem.Name = "Ref ID";
                item.SubItems[0] = subitem;
                lstVw_References.Items.Add(item);
            }
            for (int i = 0; lstVw_References.Items.Count > i; i++)
            {
                lstVw_References.Items[i].SubItems[1].Text = lstVw_References.Items[i].SubItems[1].Text.Substring(0, lstVw_References.Items[i].SubItems[1].Text.Length - 1);
            }
            lstVw_Main.Items[0].Selected = true;
        }

        private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToDo add = new AddToDo();
            add.ShowDialog();
        }

        private void References_Clicked(object sender, EventArgs e)
        {
            SelectedListViewItemCollection items = lstVw_References.SelectedItems;
            if (items.Count > 1)
                return;
            if(Uri.TryCreate(items[0].SubItems["reference"].Text,UriKind.RelativeOrAbsolute,out Uri result))
            {
                DialogResult open = MessageBox.Show("It looks like you selected an URL, would you like to open it?", "Open URL", MessageBoxButtons.YesNoCancel);
                if(open == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(result.ToString());
                }
            }
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                
            }
            base.WndProc(ref m);
        }
    }
}
