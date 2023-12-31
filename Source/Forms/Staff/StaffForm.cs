﻿using RestaurantManagement.Source.Forms.Login;
using RestaurantManagement.Source.Services;
using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement.Source.Forms.Staff
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
            this.InitForm();
        }

        private void InitForm()
        {
            this.GetListStaffPosition();
            this.GetListStaffs();
        }

        private void GetListStaffPosition()
        {
            DataTable dataSource = StaffService.GetListStaffPosition();

            if (dataSource.Rows.Count > 0)
            {
                comboBox1.DataSource = dataSource;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
            }
        }

        private void GetListStaffs()
        {
            DataTable dataSource = StaffService.GetListStaffs();

            if (dataSource.Rows.Count > 0)
            {
                listView1.Items.Clear();
                listView1.Columns.Clear();

                Dictionary<string, (string DisplayName, int Width)> columnInfoDictionary = new()
                {
                    { "id", ("ID", 100) },
                    { "name", ("Tên nhân viên", 150) },
                    { "dob", ("Ngày sinh", 120) },
                    { "gender", ("Giới tính", 80) },
                    { "salary", ("Lương", 120) },
                    { "join_date", ("Ngày vào làm", 120) },
                    { "phone", ("Số điện thoại", 120) },
                    { "address", ("Nơi ở", 150) },
                    { "email", ("Email", 150) },
                    { "position_name", ("Vị trí", 120) }
                };

                foreach (KeyValuePair<string, (string DisplayName, int Width)> columnInfo in columnInfoDictionary)
                {
                    if (!dataSource.Columns.Contains(columnInfo.Key)) continue;
                    listView1.Columns.Add(columnInfo.Value.DisplayName, columnInfo.Value.Width);
                }

                foreach (DataRow row in dataSource.Rows)
                {
                    ListViewItem item = new(StringHelper.PadNumberWithZeros(row[0]));

                    for (int i = 1; i < dataSource.Columns.Count; i++)
                    {
                        string key = dataSource.Columns[i].ColumnName;

                        if (key == "position_id") continue;

                        if (key == "gender")
                        {
                            int genderValue = Convert.ToInt32(row[i]);
                            item.SubItems.Add((genderValue == 1) ? "Nữ" : ((genderValue == 2) ? "Nam" : "Khác"));
                        }
                        else if (key == "salary")
                        {
                            item.SubItems.Add(StringHelper.ConvertToMoney(row[i].ToString()));
                        }
                        else
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                    }

                    listView1.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox6.Text;
                string email = textBox1.Text;
                string phone = textBox2.Text;
                string address = textBox3.Text;
                string salary = textBox5.Text;
                int gender = radioButton1.Checked ? 2 : 1;
                int position = Convert.ToInt32(comboBox1.SelectedValue);
                string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string joinDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                int result = StaffService.CreateStaff(name, gender, dob,
                                                      joinDate, email, phone,
                                                      address, position, salary);

                if (result > 0)
                {
                    AlertHelper.Show("Thêm thành công");
                    this.GetListStaffs();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
            }
            catch (Exception ex)
            {
                AlertHelper.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                string selectedId = selectedItem.SubItems[0].Text;

                DialogResult result = MessageBox.Show($"Bạn có muốn xóa nhân viên {StringHelper.PadNumberWithZeros(selectedId)}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int success = StaffService.DeleteStaffById(Convert.ToInt32(selectedId));

                    if (success > 0)
                    {
                        AlertHelper.Show("Xóa thành công.");
                        this.GetListStaffs();
                    }
                }
            }
            else
            {
                AlertHelper.Show("Vui lòng chọn nhân viên muốn xóa");
            }
        }
    }
}
