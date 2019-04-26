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

namespace ToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetDatabase();
            UpdateListView();
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
            int id = 0;
            foreach(ToDo todo in toDos)
            {
                id++;
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                subitem.Name = "WhatToDo";
                subitem.Text = todo.WhatToDo;
                subitem.Tag = todo.WhatToDo;
                ListViewItem item = new ListViewItem()
                {

                };
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
            for(int i = 0; lstVw_References.Items.Count > i; i++)
            {
                lstVw_References.Items[i].SubItems[1].Text = lstVw_References.Items[i].SubItems[1].Text.Substring(0, lstVw_References.Items[i].SubItems[1].Text.Length - 1);
            }
        }

        private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToDo add = new AddToDo();
            add.ShowDialog();
        }
    }
}
