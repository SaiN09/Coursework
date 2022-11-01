using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Учёт_товаров
{
    public class SaveData
    {
        int m1;
        public void sData(DataGridView dtg1)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    string file = saveFileDialog1.FileName;
                    using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
                    {
                        bw.Write(dtg1.Columns.Count);
                        bw.Write(dtg1.Rows.Count);
                        foreach (DataGridViewRow dgvR in dtg1.Rows)
                        {
                            for (int j = 0; j < dtg1.Columns.Count; ++j)
                            {
                                object val = dgvR.Cells[j].Value;
                                if (val == null)
                                {
                                    bw.Write(false);
                                    bw.Write(false);
                                }
                                else
                                {
                                    bw.Write(true);
                                    bw.Write(val.ToString());
                                }
                            }
                        }
                    }
                }
            }
        }
        public void lData(DataGridView dtg1)
        {     
            Stream myStream;
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();

            OpenFileDialog1.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            OpenFileDialog1.FilterIndex = 2;
            OpenFileDialog1.RestoreDirectory = true;
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = OpenFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    if (dtg1[0, 0].Value != null)
                    {
                        dtg1.Rows.Clear();
                    }
                    string file2 = OpenFileDialog1.FileName;
                    using (BinaryReader bw = new BinaryReader(File.Open(file2, FileMode.Open)))
                    {
                        int n = bw.ReadInt32();
                        int m = bw.ReadInt32();
                        m1 = m;
                        for (int i = 0; i < m - 1; ++i)
                        {
                            dtg1.Rows.Add();
                            for (int j = 0; j < n; ++j)
                            {
                                if (bw.ReadBoolean())
                                {
                                    dtg1.Rows[i].Cells[j].Value = bw.ReadString();
                                }
                                else bw.ReadBoolean();
                            }
                        }                                           
                    }
                }
            }
        }
        public void UpdN(DataGridView dtg1)
        {
            Daata.n = m1;
        }
    }
}
           
     


