using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace MultiROM_Linker
{
    public partial class MultiROM : Form
    {
        private int romindex = 1;
        private bool oversize = false;

        public MultiROM()
        {
            InitializeComponent();

            var banksize = new Dictionary<int, string>()
            {
                {1024,"1k"},
                {2048,"2k"},
                {4096,"4k"},
                {8192,"8k"},
                {16384,"16k"},
                {32768,"32k"},
                {65536,"64k"},
                {131072,"128k"},
                {262144,"256k"},
                {524288,"512k"}
            };

            var romsize = new Dictionary<int, string>()
            {
                {2048,"2716 - 2k"},
                {4096,"2732 - 4k"},
                {8192,"2764 - 8k"},
                {16384,"27128 - 16k"},
                {32768,"27256 - 32k"},
                {65536,"27512 - 64k"},
                {131072,"27c010 - 128k"},
                {262144,"27c020 - 256k"},
                {524288,"27c040 - 512k"},
                {1048576,"27c080 - 1M"}
            };

            cb_banksize.DataSource = banksize.ToList();
            cb_banksize.ValueMember = "Key";
            cb_banksize.DisplayMember = "Value";

            cb_romsize.DataSource = romsize.ToList();
            cb_romsize.ValueMember = "Key";
            cb_romsize.DisplayMember = "Value";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dgv_files.AutoGenerateColumns = false;
            //dgv_files.Columns.Add("FileName", "File Name");
            //dgv_files.Columns.Add("FileSize", "Size");
            // dgv_files.DataSource = fileList;
        }

        private void bt_addROM_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    var length = new System.IO.FileInfo(fileName).Length;
                    int index = dgv_files.Rows.Add();
                    dgv_files.Rows[index].Cells["id"].Value = romindex;
                    dgv_files.Rows[index].Cells["filename"].Value = Path.GetFileName(fileName);
                    dgv_files.Rows[index].Cells["filesize"].Value = length;
                    dgv_files.Rows[index].Cells["fullname"].Value = fileName;
                    if (length>(int)(cb_banksize.SelectedValue))
                    {
                        dgv_files.Rows[index].Cells["filesize"].Style.ForeColor = Color.Red;
                        oversize = true;
                    }
                    romindex++;
                    //fileList.Add(fileName);
                    //tb_debug.AppendText(fileName);
                }
                dgv_files.Refresh();
            }
        }

        private void cb_banksize_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_files.Rows)
            {
                if (Convert.ToInt32(row.Cells["filesize"].Value) > (int)cb_banksize.SelectedValue)
                {
                    row.Cells["filesize"].Style.ForeColor = Color.Red;
                    oversize = true;
                }
                else
                {
                   row.Cells["filesize"].Style.ForeColor = Color.Black;
                }
            }
        }

        private void bt_uplist_Click(object sender, EventArgs e)
        {
            if (dgv_files.SelectedRows.Count > 0)
            {
                int rowIndex = dgv_files.SelectedRows[0].Index;
                if (rowIndex > 0)
                {
                    DataGridViewRow row = dgv_files.Rows[rowIndex];
                    dgv_files.Rows.RemoveAt(rowIndex);
                    dgv_files.Rows.Insert(rowIndex - 1, row);
                    dgv_files.ClearSelection();
                    dgv_files.Rows[rowIndex - 1].Selected = true;
                }
            }
        }

        private void bt_downlist_Click(object sender, EventArgs e)
        {
            if (dgv_files.SelectedRows.Count > 0)
            {
                int rowIndex = dgv_files.SelectedRows[0].Index;
                if (rowIndex < dgv_files.Rows.Count - 1)
                {
                    DataGridViewRow row = dgv_files.Rows[rowIndex];
                    dgv_files.Rows.RemoveAt(rowIndex);
                    dgv_files.Rows.Insert(rowIndex + 1, row);
                    dgv_files.ClearSelection();
                    dgv_files.Rows[rowIndex + 1].Selected = true;
                }
            }
        }

        private void bt_make_Click(object sender, EventArgs e)
        {
            tb_debug.Text = "";
            int rowcount = dgv_files.RowCount;
            int banksize = (int)cb_banksize.SelectedValue;
            int romsize = (int)cb_romsize.SelectedValue;
            tb_debug.AppendText("Bank size: " + banksize.ToString() + " bytes" + Environment.NewLine);
            tb_debug.AppendText("ROM size: " + romsize.ToString() + " bytes" + Environment.NewLine);
            if(rowcount * banksize<romsize)
            {
                int amount = (romsize - banksize * rowcount) / banksize;
                tb_debug.AppendText("You can add " + amount.ToString() + " more ROM images" + Environment.NewLine);
            }
            else if (rowcount * banksize > romsize)
            {
                int amount = (banksize * rowcount - romsize) / banksize;
                tb_debug.AppendText("Too much ROM images, delete " + amount.ToString() + Environment.NewLine);
            }
            else if (oversize)
            {
                tb_debug.AppendText("Too large ROM images in the list" + Environment.NewLine);
            }
            else
            {
                byte[] fullROM = new byte[romsize];
                int fileindex = 0;
                foreach (DataGridViewRow row in dgv_files.Rows)
                {
                    byte[] romImage = File.ReadAllBytes(row.Cells["fullname"].Value.ToString());
                    Array.Copy(romImage, 0, fullROM, fileindex*banksize, romImage.Length);
                    fileindex++;
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;

                    File.WriteAllBytes(savePath, fullROM);

                    tb_debug.AppendText("ROM File saved to " + savePath);
                }
                else
                {
                    tb_debug.AppendText("Error" + Environment.NewLine);
                }
            }
        }

        private void bt_resetIndex_Click(object sender, EventArgs e)
        {
            romindex = 1;
            foreach (DataGridViewRow row in dgv_files.Rows)
            {
                row.Cells["id"].Value = romindex;
                romindex++;
            }
        }
    }
}
