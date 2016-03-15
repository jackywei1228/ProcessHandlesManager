using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProcessHandlesManager
{
    public partial class frmMain : Form
    {
        private ProcessEnum m_proc_enum = null;
        private ProcessHandles m_proc_handles = null;

        #region 主窗体

        public frmMain()
        {
            InitializeComponent();

            m_proc_enum = new ProcessEnum();
            m_proc_handles = new ProcessHandles();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void RefreshProcessList()
        {
            lvwProcesses.BeginUpdate();
            lvwProcesses.Items.Clear();

            foreach (ProcessEnum.PROCESS_INFO proc in m_proc_enum.GetProcessesList())
            {
                ListViewItem lvi = new ListViewItem(proc.m_pid.ToString());
                lvi.SubItems.Add(proc.m_process_name);

                lvwProcesses.Items.Add(lvi);
            }

            lvwProcesses.EndUpdate();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if ("" == txtHandleName.Text) return;

            m_proc_handles.RefreshSystemHandles();

            lvwHandles.BeginUpdate();
            lvwHandles.Items.Clear();

            pbStatus.Value = 0;
            pbStatus.Maximum = m_proc_handles.HandleInfos.Length;
            Application.DoEvents();

            int n = 0;
            foreach (ProcessHandles.SYSTEM_HANDLE_INFORMATION shi in m_proc_handles.HandleInfos)
            {
                n++;
                if (0 == (n % 50))
                {
                    pbStatus.Value = n;
                    lblStatus.Text = n + " / " + pbStatus.Maximum;
                    Application.DoEvents();
                }

                ProcessHandles.PROCESS_HANDLE_INFORMATION phi = m_proc_handles.GetProcessHandleInfo(shi.ProcessId, shi.Handle);

                string handle_name = ProcessHandles.UnicodeStringToString(phi.m_object_name_info.Name);
                if (handle_name.IndexOf(txtHandleName.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ListViewItem lvi = new ListViewItem(shi.ProcessId.ToString());
                    lvi.SubItems.Add("0x" + shi.Handle.ToString("X8"));
                    lvi.SubItems.Add(ProcessHandles.UnicodeStringToString(phi.m_object_type_info.Name));
                    lvi.SubItems.Add(ProcessHandles.UnicodeStringToString(phi.m_object_name_info.Name));

                    lvwHandles.Items.Add(lvi);
                }
            }

            lvwHandles.EndUpdate();

            pbStatus.Value = 0;
            lblStatus.Text = n + " / " + pbStatus.Maximum;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (1 != lvwHandles.SelectedItems.Count) return;

            ListViewItem lvi = lvwHandles.SelectedItems[0];

            int pid = int.Parse(lvi.SubItems[colPID.Index].Text);
            string str_handle = lvi.SubItems[colHandle.Index].Text;
            UInt16 handle = Convert.ToUInt16(str_handle.Substring(2), 16);
            if (DialogResult.Yes != MessageBox.Show(
                "是否确认关闭进程 " + pid + " 句柄 " + str_handle + "？",
                "句柄关闭确认",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                return;
            }

            if (m_proc_handles.CloseProcessHandle(pid, handle))
            {
                RefreshHandles();
                MessageBox.Show("句柄已成功关闭！");
            }
            else
            {
                MessageBox.Show("句柄关闭失败！");
            }
        }

        private void lvwProcesses_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter.enDataType[] COLUMN_DATA_TYPE = {
                ListViewSorter.enDataType.enDataType_Number,
                ListViewSorter.enDataType.enDataType_String
            };

            new ListViewSorter(lvwProcesses, e.Column, COLUMN_DATA_TYPE[e.Column]);
        }

        private void RefreshHandles()
        {
            if (1 != lvwProcesses.SelectedItems.Count) return;

            m_proc_handles.RefreshSystemHandles();
            ListViewItem lvi = lvwProcesses.SelectedItems[0];
            int pid = int.Parse(lvi.SubItems[colPID.Index].Text);
            List<ProcessHandles.SYSTEM_HANDLE_INFORMATION> lst_handles = m_proc_handles.GetProcessHandles(pid);

            lvwHandles.BeginUpdate();
            lvwHandles.Items.Clear();

            foreach (ProcessHandles.SYSTEM_HANDLE_INFORMATION shi in lst_handles)
            {
                ProcessHandles.PROCESS_HANDLE_INFORMATION phi = m_proc_handles.GetProcessHandleInfo(shi.ProcessId, shi.Handle);
                string str_handle_name = ProcessHandles.UnicodeStringToString(phi.m_object_name_info.Name);
                if ("" == str_handle_name)
                {
                    continue;
                }

                ListViewItem lvi_shi = new ListViewItem(shi.ProcessId.ToString());
                lvi_shi.SubItems.Add("0x" + shi.Handle.ToString("X8"));
                lvi_shi.SubItems.Add(ProcessHandles.UnicodeStringToString(phi.m_object_type_info.Name));
                lvi_shi.SubItems.Add(str_handle_name);

                lvwHandles.Items.Add(lvi_shi);
            }

            lvwHandles.EndUpdate();
        }

        private void lvwProcesses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RefreshHandles();
        }

        private void lvwHandles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter.enDataType[] COLUMN_DATA_TYPE = {
                ListViewSorter.enDataType.enDataType_Number,
                ListViewSorter.enDataType.enDataType_String,
                ListViewSorter.enDataType.enDataType_String,
                ListViewSorter.enDataType.enDataType_String
            };

            new ListViewSorter(lvwHandles, e.Column, COLUMN_DATA_TYPE[e.Column]);
        }

        #endregion
    }
}
