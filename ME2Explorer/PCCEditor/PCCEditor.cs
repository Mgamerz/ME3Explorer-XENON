﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Be.Windows.Forms;
using ME2Explorer.Unreal;
using ME2Explorer.Unreal.Classes;
using ME2Explorer.Helper;
using KFreonLib.MEDirectories;

namespace ME2Explorer
{
    public partial class PCCEditor : Form
    {
        public int CurrList = 2;
        public int PreviewStyle = 0;
        public PCCObject pcc;
        public List<int> classes;

        public PCCEditor()
        {
            InitializeComponent();
        }

        public void RefreshLists()
        {
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = false;
            if (pcc == null)
                return;
            int count = 0;
            if (CurrList == 0)
            {
                toolStripButton1.Checked = true;
                listBox1.BeginUpdate();
                listBox1.Items.Clear();
                foreach (string name in pcc.Names)
                    listBox1.Items.Add((count++).ToString("d6") + " : " + name);
                listBox1.EndUpdate();
            }
            if (CurrList == 1)
            {
                toolStripButton2.Checked = true;
                listBox1.BeginUpdate();
                listBox1.Items.Clear();
                foreach (PCCObject.ImportEntry imp in pcc.Imports)
                    listBox1.Items.Add((count++).ToString("d6") + " : " + pcc.FollowLink(imp.link) + imp.Name);
                listBox1.EndUpdate();
            }
            if (CurrList == 2)
            {
                toolStripButton3.Checked = true;
                listBox1.BeginUpdate();
                listBox1.Items.Clear();
                foreach (PCCObject.ExportEntry exp in pcc.Exports)
                    listBox1.Items.Add((count++).ToString("d6") + " : " + exp.PackageFullName + "." + exp.ObjectName);
                listBox1.EndUpdate();

            }
            toolStripComboBox1.Items.Clear();
            foreach (int index in classes)
                toolStripComboBox1.Items.Add(pcc.GetClass(index));

        }

        private void openPccToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "*.pcc|*.pcc";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pcc = new PCCObject(d.FileName);
                CurrList = 0;
                classes = new List<int>();
                foreach (PCCObject.ExportEntry ent in pcc.Exports)
                {
                    int f = -1;
                    for (int i = 0; i < classes.Count(); i++)
                        if (classes[i] == ent.ClassNameID)
                            f = i;
                    if (f == -1)
                        classes.Add(ent.ClassNameID);
                }
                bool run = true;
                while (run)
                {
                    run = false;
                    for (int i = 0; i < classes.Count() - 1; i++)
                        if (pcc.GetName(classes[i]).CompareTo(pcc.GetName(classes[i + 1])) > 0)
                        {
                            int t = classes[i];
                            classes[i] = classes[i + 1];
                            classes[i + 1] = t;
                            run = true;
                        }
                }
                RefreshLists();
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            CurrList = 0;
            RefreshLists();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            CurrList = 1;
            RefreshLists();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            CurrList = 2;
            RefreshLists();
        }

        private void savePccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pcc == null)
                return;
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "*.pcc|*.pcc";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pcc.SaveToFile(d.FileName);
                MessageBox.Show("Done.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preview();
        }

        private void rawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreviewStyle = 0;
            Preview();
        }

        private void Preview()
        {

            int n = listBox1.SelectedIndex;
            if (n == -1)
                return;
            if (CurrList != 2)
                return;
            rtb1.Visible = false;
            hb1.Visible = false;
            switch (PreviewStyle)
            {
                case 0:
                    PreviewRaw(n);
                    break;
                case 1:
                    PreviewProps(n);
                    break;
            }

        }

        private void PreviewProps(int n)
        {
            PCCObject.ExportEntry ent = pcc.Exports[n];
            List<SaltPropertyReader.Property> props = SaltPropertyReader.getPropList(pcc, ent.Data);
            rtb1.Visible = true;
            string s = "";
            s += "ObjectName : " + ent.ObjectName + "\n";
            s += "Class : " + ent.ClassName + "\n";
            s += "Data size : 0x" + ent.DataSize.ToString("X8") + "\n";
            s += "Data offset : 0x" + ent.DataOffset.ToString("X8") + "\n\nProperties: \n";
            foreach (SaltPropertyReader.Property p in props)
                s += SaltPropertyReader.PropertyToText(p, pcc) + "\n";

            if (ent.ClassName == "Texture2D" || ent.ClassName == "LightMapTexture2D" || ent.ClassName == "TextureFlipBook")
            {
                s += "\nImage Info: \n";
                try
                {
                    Texture2D tex2D = new Texture2D(pcc, n, Path.Combine(ME2Directory.gamePath, "BIOGame"));
                    for (int i = 0; i < tex2D.imgList.Count; i++)
                    {
                        s += i + ": Location: " + tex2D.imgList[i].storageType + ", Offset: " + tex2D.imgList[i].offset + ", ImgSize: " + tex2D.imgList[i].imgSize.ToString() + ", CprSize = " + tex2D.imgList[i].cprSize + ", UncSize = " + tex2D.imgList[i].uncSize + "\n";
                    }
                }
                catch { }
            }

            rtb1.Text = s;
            Status.Text = ent.ClassName + " Offset: " + ent.DataOffset + " - " + (ent.DataOffset + ent.DataSize);
        }

        private void PreviewRaw(int n)
        {
            hb1.Visible = true;
            PCCObject.ExportEntry ent = pcc.Exports[n];
            hb1.ByteProvider = new DynamicByteProvider(ent.Data);
            Status.Text = ent.ClassName + " Offset: " + ent.DataOffset + " - " + (ent.DataOffset + ent.DataSize);
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreviewStyle = 1;
            Preview();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if (n == -1)
                n = 0;
            else
                n++;
            int m = toolStripComboBox1.SelectedIndex;
            if (m == -1)
                return;
            if (CurrList != 2)
                return;
            int clas = classes[m];
            for (int i = n; i < pcc.Exports.Count(); i++)
                if (pcc.Exports[i].ClassNameID == clas)
                {
                    listBox1.SelectedIndex = i;
                    return;
                }
        }

        private void exportBINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if (n == -1)
                return;
            if (CurrList != 2)
                return;
            PCCObject.ExportEntry ent = pcc.Exports[n];
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "*.bin|*.bin";
            d.FileName = ent.ObjectName + ".bin";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = new FileStream(d.FileName, FileMode.Create, FileAccess.Write);
                fs.Write(ent.Data, 0, ent.DataSize);
                fs.Close();
                MessageBox.Show("Done.");
            }
        }
        private void dumpWholePCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "*.bin|*.bin";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pcc.DumpPCC(d.FileName);
            }
            MessageBox.Show("Done");
        }

        private void addNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pcc == null)
                return;
            string result = Microsoft.VisualBasic.Interaction.InputBox("Enter the name to add");

            if (String.IsNullOrEmpty(result))
                return;

            pcc.AddName(result);
            MessageBox.Show(result + ": has been added to the namelist", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void getNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Enter number of name (hex is fine too)", "Get Name", "", 0, 0);
            if (String.IsNullOrEmpty(result))
                return;

            if (result.Length <= 2 || (result[0] != '0' && result[0] != 'x'))
            {
                // regular int
                int val;
                try
                {
                    val = Convert.ToInt32(result);
                }
                catch
                {
                    return;
                }
                if (val < 0 || val > pcc.NameCount)
                    return;

                MessageBox.Show(pcc.GetName(val));
            }
            else
            {
                // hex input
                int val;
                try
                {
                    val = Convert.ToInt32(result.Substring(2), 16);
                }
                catch
                {
                    return;
                }
                if (val < 0 || val > pcc.NameCount)
                    return;
                MessageBox.Show(pcc.GetName(val));
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Interpreter();
        }

        public void Interpreter()
        {
            int n = listBox1.SelectedIndex;
            if (n == -1)
                return;
            Interpreter2.Interpreter2 ip = new Interpreter2.Interpreter2();
            ip.MdiParent = this.MdiParent;
            ip.pcc = pcc;
            ip.Index = n;
            ip.InitInterpreter();
            ip.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FindByString();   
        }

        private void FindByString()
        {
            int n = listBox1.SelectedIndex;
            if (n == -1)
                n = 0;
            else
                n++;
            if (CurrList != 2)
                return;
            string name = toolStripTextBox1.Text.ToLower();
            if (name == "")
                return;
            for (int i = n; i < pcc.Exports.Count(); i++)
                if (pcc.Exports[i].ObjectName.ToLower().Contains(name))
                {
                    listBox1.SelectedIndex = i;
                    return;
                }
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)0xd)
                FindByString();
        }

        private void saveHexChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pcc == null)
                return;
            int n = listBox1.SelectedIndex;
            if (n == -1 || CurrList != 2)
                return;
            MemoryStream m = new MemoryStream();
            for (int i = 0; i < hb1.ByteProvider.Length; i++)
                m.WriteByte(hb1.ByteProvider.ReadByte(i));
            PCCObject.ExportEntry ent = pcc.Exports[n];
            ent.Data = m.ToArray();
            ent.hasChanged = true;
            pcc.Exports[n] = ent;
        }
    }
}
