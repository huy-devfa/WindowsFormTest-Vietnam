﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsForm_VietNam
{
    public partial class frmChuong1 : Form
    {

        public frmChuong1()
        {
            InitializeComponent();
        }

        private void rbtncau1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmChuong1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void frmChuong1_Load(object sender, EventArgs e)
        {

            rbtncau1.Checked = true;
            lblCauhoi.Text = "Câu 1: Namespace nào sau đây chứa các lớp cho thao tác Input và Output? ";
            rbtnA.Text = "A. System. Collections";
            rbtnB.Text = "B. System. IO";
            rbtnC.Text = "C. System. Net";
            rbtnD.Text = "D. System. Threading";

        }

        string cautraloicau1 = "";
        string cautraloicau2 = "";
        string cautraloicau3 = "";
        string cautraloicau4 = "";
        string cautraloicau5 = "";
        string cautraloicau6 = "";
        string cautraloicau7 = "";
        string cautraloicau8 = "";
        string cautraloicau9 = "";
        string cautraloicau10 = "";
        string cautraloicau11 = "";
        string cautraloicau12 = "";
        string cautraloicau13 = "";
        string cautraloicau14 = "";
        string cautraloicau15 = "";
        string cautraloicau16 = "";
        string cautraloicau17 = "";
        string cautraloicau18 = "";
        string cautraloicau19 = "";
        string cautraloicau20 = "";
        string cautraloicau21 = "";
        string cautraloicau22 = "";
        string cautraloicau23 = "";
        string cautraloicau24 = "";
        string cautraloicau25 = "";
        string cautraloicau26 = "";
        string cautraloicau27 = "";
        string cautraloicau28 = "";
        string cautraloicau29 = "";
        string cautraloicau30 = "";
        string cautraloicau31 = "";
        string cautraloicau32 = "";
        string cautraloicau33 = "";
        string cautraloicau34 = "";
        string cautraloicau35 = "";
        string cautraloicau36 = "";
        string cautraloicau37 = "";
        string cautraloicau38 = "";
        string cautraloicau39 = "";
        string cautraloicau40 = "";
        string cautraloicau41 = "";
        string cautraloicau42 = "";
        string cautraloicau43 = "";
        string cautraloicau44 = "";
        string cautraloicau45 = "";
        string cautraloicau46 = "";
        string cautraloicau47 = "";
        string cautraloicau48 = "";
        string cautraloicau49 = "";
        string cautraloicau50 = "";
        string cautraloicau51 = "";
        string cautraloicau52 = "";
        string cautraloicau53 = "";
        string cautraloicau54 = "";
        string cautraloicau55 = "";
        string cautraloicau56 = "";
        string cautraloicau57 = "";
        string cautraloicau58 = "";
        string cautraloicau59 = "";
        string cautraloicau60 = "";
        string cautraloicau61 = "";
        string cautraloicau62 = "";
        string cautraloicau63 = "";
        string cautraloicau64 = "";
        string cautraloicau65 = "";
        string cautraloicau66 = "";
        string cautraloicau67 = "";
        string cautraloicau68 = "";
        string cautraloicau69 = "";
        string cautraloicau70 = "";
        string cautraloicau71 = "";
        string cautraloicau72 = "";
        string cautraloicau73 = "";
        string cautraloicau74 = "";
        string cautraloicau75 = "";
        string cautraloicau76 = "";
        string cautraloicau77 = "";
        string cautraloicau78 = "";
        string cautraloicau79 = "";
        string cautraloicau80 = "";
        string cautraloicau81 = "";
        string cautraloicau82 = "";
        string cautraloicau83 = "";
        string cautraloicau84 = "";
        string cautraloicau85 = "";
        string cautraloicau86 = "";
        string cautraloicau87 = "";
        string cautraloicau88 = "";
        string cautraloicau89 = "";
        string cautraloicau90 = "";
        string cautraloicau91 = "";
        string cautraloicau92 = "";
        string cautraloicau93 = "";
        string cautraloicau94 = "";
        string cautraloicau95 = "";
        string cautraloicau96 = "";
        string cautraloicau97 = "";
        string cautraloicau98 = "";
        string cautraloicau99 = "";
        string cautraloicau100 = "";

        int caudung = 0;
        int causai = 0;

        string cautraloidungcau1 = "B";
        string cautraloidungcau2 = "D";
        string cautraloidungcau3 = "C";
        string cautraloidungcau4 = "D";
        string cautraloidungcau5 = "D";
        string cautraloidungcau6 = "B";
        string cautraloidungcau7 = "C";
        string cautraloidungcau8 = "A";
        string cautraloidungcau9 = "C";
        string cautraloidungcau10 = "A";
        string cautraloidungcau11 = "D";
        string cautraloidungcau12 = "C";
        string cautraloidungcau13 = "B";
        string cautraloidungcau14 = "A";
        string cautraloidungcau15 = "A";
        string cautraloidungcau16 = "B";
        string cautraloidungcau17 = "C";
        string cautraloidungcau18 = "C";
        string cautraloidungcau19 = "C";
        string cautraloidungcau20 = "A";
        string cautraloidungcau21 = "D";
        string cautraloidungcau22 = "D";
        string cautraloidungcau23 = "B";
        string cautraloidungcau24 = "A";
        string cautraloidungcau25 = "A";
        string cautraloidungcau26 = "B";
        string cautraloidungcau27 = "C";
        string cautraloidungcau28 = "C";
        string cautraloidungcau29 = "C";
        string cautraloidungcau30 = "A";
        string cautraloidungcau31 = "D";
        string cautraloidungcau32 = "D";
        string cautraloidungcau33 = "B";
        string cautraloidungcau34 = "A";
        string cautraloidungcau35 = "C";
        string cautraloidungcau36 = "D";
        string cautraloidungcau37 = "D";
        string cautraloidungcau38 = "B";
        string cautraloidungcau39 = "C";
        string cautraloidungcau40 = "C";
        string cautraloidungcau41 = "B";
        string cautraloidungcau42 = "B";
        string cautraloidungcau43 = "D";
        string cautraloidungcau44 = "B";
        string cautraloidungcau45 = "B";
        string cautraloidungcau46 = "A";
        string cautraloidungcau47 = "C";
        string cautraloidungcau48 = "B";
        string cautraloidungcau49 = "D";
        string cautraloidungcau50 = "D";
        string cautraloidungcau51 = "D";
        string cautraloidungcau52 = "C";
        string cautraloidungcau53 = "A";
        string cautraloidungcau54 = "A";
        string cautraloidungcau55 = "A";
        string cautraloidungcau56 = "D";
        string cautraloidungcau57 = "C";
        string cautraloidungcau58 = "A";
        string cautraloidungcau59 = "A";
        string cautraloidungcau60 = "B";
        string cautraloidungcau61 = "C";
        string cautraloidungcau62 = "C";
        string cautraloidungcau63 = "A";
        string cautraloidungcau64 = "B";
        string cautraloidungcau65 = "B";
        string cautraloidungcau66 = "B";
        string cautraloidungcau67 = "D";
        string cautraloidungcau68 = "A";
        string cautraloidungcau69 = "D";
        string cautraloidungcau70 = "B";
        string cautraloidungcau71 = "B";
        string cautraloidungcau72 = "A";
        string cautraloidungcau73 = "A";
        string cautraloidungcau74 = "D";
        string cautraloidungcau75 = "A";
        string cautraloidungcau76 = "A";
        string cautraloidungcau77 = "A";
        string cautraloidungcau78 = "C";
        string cautraloidungcau79 = "A";
        string cautraloidungcau80 = "B";
        string cautraloidungcau81 = "A";
        string cautraloidungcau82 = "C";
        string cautraloidungcau83 = "A";
        string cautraloidungcau84 = "C";
        string cautraloidungcau85 = "";
        string cautraloidungcau86 = "";
        string cautraloidungcau87 = "";
        string cautraloidungcau88 = "";
        string cautraloidungcau89 = "";
        string cautraloidungcau90 = "";
        string cautraloidungcau91 = "";
        string cautraloidungcau92 = "";
        string cautraloidungcau93 = "";
        string cautraloidungcau94 = "";
        string cautraloidungcau95 = "";
        string cautraloidungcau96 = "";
        string cautraloidungcau97 = "";
        string cautraloidungcau98 = "";
        string cautraloidungcau99 = "";
        string cautraloidungcau100 = "";



        int socau = 0;
        int statuscaudung = 0;
        int statuscausai = 0;
        private void btnGui_Click(object sender, EventArgs e)
        {
            if (rbtncau1.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau1 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau1 = "B";
                }
                else if (rbtnC.Checked == true)
                {

                    cautraloicau1 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau1 = "D";
                }
                rbtncau2.Checked = true;
                lblCauhoi.Text = "Câu 2: Namespace nào sau đây chứa các lớp dùng để tạo ứng dụng Windows Forms \n gồm Control, User Control và Form, Menu, Toolbar, Layout, Data, Data Binding,\n Data Components, Common Dialog Boxes? \r\n";
                rbtnA.Text = "A. System. Data ";
                rbtnB.Text = "B. System.Drawing";
                rbtnC.Text = "C. System.Xml ";
                rbtnD.Text = "D. System.Windows.Forms";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if(cautraloicau1 == cautraloidungcau1)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau2.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau2 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau2 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau2 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau2 = "D";
                }
                rbtncau3.Checked = true;
                lblCauhoi.Text = "Câu 3 \r\nThành phần nào sau đây cung cấp môi trường thực thi chung cho các \n ngôn ngữ trên nền .NET Framework? \r\n ";
                rbtnA.Text = "A. Framework Class Library (FCL)";
                rbtnB.Text = "B. Microsoft Intermediate Language (MSIL)";
                rbtnC.Text = "C. The Common Language Runtime (CLR) ";
                rbtnD.Text = "D. Just In Time (JIT)s";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau2 == cautraloidungcau2)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau3.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau3 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau3 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau3 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau3 = "D";
                }
                rbtncau4.Checked = true;
                lblCauhoi.Text = "Câu 4: Trong một Solution có 2 Project A và B. Hiện tại, Project A đang được thực thi khi chạy chương trình. " + "\nLập trình viên muốn thiết lập Project B được thực thi khi chạy chương trình cần thực hiện lệnh nào sau đây?\r\n";
                rbtnA.Text = "A. Chọn project B -> Set Default.";
                rbtnB.Text = "B. Chọn project B -> Set project Default.";
                rbtnC.Text = "C. Chọn project B -> Set Startup.";
                rbtnD.Text = "D. Chọn project B -> Set as StartUp Project.";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau3 == cautraloidungcau3)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau4.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau4 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau4 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau4 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau4 = "D";
                }
                rbtncau5.Checked = true;
                lblCauhoi.Text = "Câu 5: Trong một Project có 2 Form là FormA và FormB. Mặc định khi thực chương \n trình thì FormA được hiển thị đầu tiên. " +
                 "Lập trình viên muốn thiết lập cho FormB được hiển thị đầu tiên khi \n thực thi chương trình cần làm gì sau đây?\r\n";
                rbtnA.Text = "A. Chọn FormB -> Set Default.";
                rbtnB.Text = "B. Chọn FormB -> Set as StartUp Form.";
                rbtnC.Text = "C. Thay dòng lệnh Application.Run(new FormA()); thành Application.Run(new FormB());";
                rbtnD.Text = "D. Mở tập tin Program.cs, thay dòng lệnh Application.Run(new FormA()); thành Application.Run(new FormB());";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau4 == cautraloidungcau4)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }

            }
            else if (rbtncau5.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau5 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau5 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau5 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau5 = "D";
                }
                rbtncau6.Checked = true;
                lblCauhoi.Text = "Câu 6: Để đóng Form hiện hành, chúng ta dùng câu lệnh nào sau đây?\r\n";
                rbtnA.Text = "A. Me.Close();";
                rbtnB.Text = "B. This.Close();";
                rbtnC.Text = "C. Me.Exit();";
                rbtnD.Text = "D. This.Exit();";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau5 == cautraloidungcau5)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau6.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau6 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau6 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau6 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau6 = "D";
                }
                rbtncau7.Checked = true;
                lblCauhoi.Text = "Câu 7: Một Form được gọi là MDI Form trong Windows Forms khi?\r\n";
                rbtnA.Text = "A. IsMdiChild = True;";
                rbtnB.Text = "B. IsMdiContainer = False;";
                rbtnC.Text = "C. IsMdiContainer = True;";
                rbtnD.Text = "D. IsMdiParent = True;";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau6 == cautraloidungcau6)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau7.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau7 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau7 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau7 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau7 = "D";
                }
                rbtncau8.Checked = true;
                lblCauhoi.Text = "Câu 8: Hãy chọn câu lệnh được dùng để đóng ứng dụng Windows Form C#?\r\n";
                rbtnA.Text = "A. Application.Exit();";
                rbtnB.Text = "B. Application.Close();";
                rbtnC.Text = "C. This.Close();";
                rbtnD.Text = "D. This.Exit();";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau7 == cautraloidungcau7)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau8.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau8 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau8 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau8 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau8 = "D";
                }
                rbtncau9.Checked = true;
                lblCauhoi.Text = "Câu 9: Để đóng Form hiện hành không giải phóng tài nguyên, chúng ta dùng câu lệnh nào sau đây?\r\n";
                rbtnA.Text = "A. Me.Close();";
                rbtnB.Text = "B. This.Close();";
                rbtnC.Text = "C. This.Hide();";
                rbtnD.Text = "D. This.Exit();";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau8 == cautraloidungcau8)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau9.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau9 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau9 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau9 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau9 = "D";
                }
                rbtncau10.Checked = true;
                lblCauhoi.Text = "Câu 10: Thuộc tính nào sau đây chứa tên nút lệnh trên Form sẽ được gọi thực thi sự kiện Click khi phím Enter được nhấn?\r\n";
                rbtnA.Text = "A. AcceptButton";
                rbtnB.Text = "B. ButtonAccept";
                rbtnC.Text = "C. ButtonCancel";
                rbtnD.Text = "D. CancelButton";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau9 == cautraloidungcau9)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau10.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau10 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau10 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau10 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau10 = "D";
                }
                rbtncau11.Checked = true;
                lblCauhoi.Text = "Câu 11: Câu lệnh nào sau đây khi Form được hiện lên người dùng không thể focus vào các cửa sổ khác?\r\n";
                rbtnA.Text = "A. frm.Activate();";
                rbtnB.Text = "B. frm.DialogShow();";
                rbtnC.Text = "C. frm.Show();";
                rbtnD.Text = "D. frm.ShowDialog();";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau10 == cautraloidungcau10)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau11.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau11 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau11 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau11 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau11 = "D";
                }
                rbtncau12.Checked = true;
                lblCauhoi.Text = "Câu 12: Câu lệnh nào sau đây khi Form được hiện lên người dùng có thể focus vào các cửa sổ khác?\r\n";
                rbtnA.Text = "A. frm.Activate();";
                rbtnB.Text = "B. frm.DialogShow();";
                rbtnC.Text = "C. frm.Show();";
                rbtnD.Text = "D. frm.ShowDialog();";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau11 == cautraloidungcau11)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau12.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau12 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau12 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau12 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau12 = "D";
                }
                rbtncau13.Checked = true;
                lblCauhoi.Text = "Câu 13: Thuộc tính nào sau đây có giá trị True cho phép hiển thị Icon và tiêu đề Form trên thanh Taskbar. False thì ngược lại?\r\n";
                rbtnA.Text = "A. ControlBox";
                rbtnB.Text = "B. ShowInTaskbar";
                rbtnC.Text = "C. StartPosition";
                rbtnD.Text = "D. WindowState";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau12 == cautraloidungcau12)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau13.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau13 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau13 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau13 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau13 = "D";
                }
                rbtncau14.Checked = true;
                lblCauhoi.Text = "Câu 14: Thuộc tính nào sau đây có giá trị từ 0 đến 1.0 hoặc có đơn vị là %. Chỉ độ trong suốt của Form?\r\n";
                rbtnA.Text = "A. Opacity";
                rbtnB.Text = "B. ShowInTaskbar";
                rbtnC.Text = "C. StartPosition";
                rbtnD.Text = "D. WindowState";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau13 == cautraloidungcau13)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau14.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau14 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau14 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau14 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau14 = "D";
                }
                rbtncau15.Checked = true;
                lblCauhoi.Text = "Câu 15: Làm thế nào để thiết lập một sự kiện (event) click cho một button trong C#?\r\n";
                rbtnA.Text = "A. button1_Click(object sender, EventArgs e) {}";
                rbtnB.Text = "B. button_Click(EventArgs e, object sender) {}";
                rbtnC.Text = "C. clickButton(object sender, EventArgs e) {}";
                rbtnD.Text = "D. button_click() {}";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau14 == cautraloidungcau14)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }

            }
            else if (rbtncau15.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau15 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau15 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau15 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau15 = "D";
                }
                rbtncau16.Checked = true;
                lblCauhoi.Text = "Câu 16: Trong C#, làm thế nào để kiểm tra xem một checkbox có được chọn hay không?\r\n";
                rbtnA.Text = "A. checkbox.isChecked";
                rbtnB.Text = "B. checkbox.Checked";
                rbtnC.Text = "C. checkbox.IsSelected";
                rbtnD.Text = "D. checkbox.Selected";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau15 == cautraloidungcau15)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau16.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau16 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau16 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau16 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau16 = "D";
                }
                rbtncau17.Checked = true;
                lblCauhoi.Text = "Câu 17: Trong lập trình C#, làm thế nào để lấy giá trị từ một textbox?\r\n";
                rbtnA.Text = "A. textbox.TextValue";
                rbtnB.Text = "B. textbox.Value";
                rbtnC.Text = "C. textbox.Text";
                rbtnD.Text = "D. textbox.Content";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau16 == cautraloidungcau16)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau17.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau17 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau17 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau17 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau17 = "D";
                }
                rbtncau18.Checked = true;
                lblCauhoi.Text = "Câu 18: Làm thế nào để thiết lập một giá trị mặc định cho một textbox trong C#?\r\n";
                rbtnA.Text = "A. textbox.DefaultValue = \"Default Text\";";
                rbtnB.Text = "B. textbox.Value = \"Default Text\";";
                rbtnC.Text = "C. textbox.Text = \"Default Text\";";
                rbtnD.Text = "D. textbox.InitialText = \"Default Text\";";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau17 == cautraloidungcau17)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }

            }
            else if (rbtncau18.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau18 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau18 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau18 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau18 = "D";
                }
                rbtncau19.Checked = true;
                lblCauhoi.Text = "Câu 19: Trong C#, làm thế nào để thiết lập một radio button là lựa chọn mặc định khi form được hiển thị?\r\n";
                rbtnA.Text = "A. radioButton.Selected = true;";
                rbtnB.Text = "B. radioButton.IsChecked = true;";
                rbtnC.Text = "C. radioButton.Checked = true;";
                rbtnD.Text = "D. radioButton.DefaultChecked = true;";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau18 == cautraloidungcau18)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau19.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau19 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau19 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau19 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau19 = "D";
                }
                rbtncau20.Checked = true;
                lblCauhoi.Text = "Câu 20: Trong lập trình C#, làm thế nào để thiết lập một tooltip cho một control (điều khiển) như button hoặc textbox?\r\n";
                rbtnA.Text = "A. control.ToolTip = \"Tooltip Text\";";
                rbtnB.Text = "B. control.AddTooltip(\"Tooltip Text\");";
                rbtnC.Text = "C. control.SetTooltip(\"Tooltip Text\");";
                rbtnD.Text = "D. control.ShowTooltip(\"Tooltip Text\");";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau19 == cautraloidungcau19)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }

            }


            else if (rbtncau20.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau20 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau20 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau20 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau20 = "D";
                }
                rbtncau21.Checked = true;
                lblCauhoi.Text = "Câu 21: Trong lập trình C#, làm thế nào để thiết lập một label để hiển thị văn bản có định dạng HTML?\r\n";
                rbtnA.Text = "A. label.TextFormat = TextFormat.HTML;";
                rbtnB.Text = "B. label.IsHtml = true;";
                rbtnC.Text = "C. label.EnableHtml = true;";
                rbtnD.Text = "D. label.Text = \"Formatted Text\";";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau20 == cautraloidungcau20)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau21.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau21 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau21 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau21 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau21 = "D";
                }
                rbtncau22.Checked = true;
                lblCauhoi.Text = "Câu 22: Làm thế nào để thiết lập một checkbox để cho phép người dùng chọn nhiều lựa chọn?\r\n";
                rbtnA.Text = "A. checkbox.Mode = SelectionMode.Multiple;";
                rbtnB.Text = "B. checkbox.AllowMultipleSelection = true;";
                rbtnC.Text = "C. checkbox.SelectionType = SelectionType.Multiple;";
                rbtnD.Text = "D. checkbox.MultiSelect = true;";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau21 == cautraloidungcau21)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
                

            }
            else if (rbtncau22.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau22 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau22 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau22 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau22 = "D";
                }
                rbtncau23.Checked = true;
                lblCauhoi.Text = "Câu 23: Trong lập trình C#, làm thế nào để vô hiệu hóa một button?\r\n";
                rbtnA.Text = "A. button.Disable();";
                rbtnB.Text = "B. button.Enabled = false;";
                rbtnC.Text = "C. button.IsDisabled = true;";
                rbtnD.Text = "D. button.AllowClick = false;";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau22 == cautraloidungcau22)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau23.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau23 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau23 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau23 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau23 = "D";
                }
                rbtncau24.Checked = true;
                lblCauhoi.Text = "Câu 24: Làm thế nào để xác định xem một textbox có chứa chỉ số hay không (ví dụ: kiểm tra xem nó có chứa một số nguyên không)?\r\n";
                rbtnA.Text = "A. int.TryParse(textbox.Text, out int result);";
                rbtnB.Text = "B. textbox.Text.IsInteger();";
                rbtnC.Text = "C. Convert.ToInt32(textbox.Text);";
                rbtnD.Text = "D. int.Parse(textbox.Text);";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau23 == cautraloidungcau23)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }

            }
            else if (rbtncau24.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau24 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau24 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau24 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau24 = "D";
                }
                rbtncau25.Checked = true;
                lblCauhoi.Text = "Câu 25: Làm thế nào để thiết lập một sự kiện (event) click cho một button trong C#?\r\n";
                rbtnA.Text = "A. button1_Click(object sender, EventArgs e) {}";
                rbtnB.Text = "B. button_Click(EventArgs e, object sender) {}";
                rbtnC.Text = "C. clickButton(object sender, EventArgs e) {}";
                rbtnD.Text = "D. button_click() {}";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau24 == cautraloidungcau24)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau25.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau25 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau25 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau25 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau25 = "D";
                }
                rbtncau26.Checked = true;
                lblCauhoi.Text = "Câu 26: Trong C#, làm thế nào để kiểm tra xem một checkbox có được chọn hay không?\r\n";
                rbtnA.Text = "A. checkbox.isChecked";
                rbtnB.Text = "B. checkbox.Checked";
                rbtnC.Text = "C. checkbox.IsSelected";
                rbtnD.Text = "D. checkbox.Selected";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau25 == cautraloidungcau25)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }

            }
            else if (rbtncau26.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau26 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau26 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau26 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau26 = "D";
                }
                rbtncau27.Checked = true;
                lblCauhoi.Text = "Câu 27: Trong lập trình C#, làm thế nào để lấy giá trị từ một textbox?\r\n";
                rbtnA.Text = "A. textbox.TextValue";
                rbtnB.Text = "B. textbox.Value";
                rbtnC.Text = "C. textbox.Text";
                rbtnD.Text = "D. textbox.Content";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau26 == cautraloidungcau26)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau27.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau27 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau27 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau27 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau27 = "D";
                }
                rbtncau28.Checked = true;
                lblCauhoi.Text = "Câu 28: Làm thế nào để thiết lập một giá trị mặc định cho một textbox trong C#?\r\n";
                rbtnA.Text = "A. textbox.DefaultValue = \"Default Text\";";
                rbtnB.Text = "B. textbox.Value = \"Default Text\";";
                rbtnC.Text = "C. textbox.Text = \"Default Text\";";
                rbtnD.Text = "D. textbox.InitialText = \"Default Text\";";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau27 == cautraloidungcau27)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }

            }
            else if (rbtncau28.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau28 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau28 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau28 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau28 = "D";
                }
                rbtncau29.Checked = true;
                lblCauhoi.Text = "Câu 29: Trong C#, làm thế nào để thiết lập một radio button là lựa chọn mặc định khi form được hiển thị?\r\n";
                rbtnA.Text = "A. radioButton.Selected = true;";
                rbtnB.Text = "B. radioButton.IsChecked = true;";
                rbtnC.Text = "C. radioButton.Checked = true;";
                rbtnD.Text = "D. radioButton.DefaultChecked = true;";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau28 == cautraloidungcau28)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau29.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau29 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau29 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau29 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau29 = "D";
                }
                rbtncau30.Checked = true;
                lblCauhoi.Text = "Câu 30: Trong lập trình C#, làm thế nào để thiết lập một tooltip cho một control (điều khiển) như button hoặc textbox?\r\n";
                rbtnA.Text = "A. control.ToolTip = \"Tooltip Text\";";
                rbtnB.Text = "B. control.AddTooltip(\"Tooltip Text\");";
                rbtnC.Text = "C. control.SetTooltip(\"Tooltip Text\");";
                rbtnD.Text = "D. control.ShowTooltip(\"Tooltip Text\");";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau29 == cautraloidungcau29)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau30.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau30 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau30 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau30 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau30 = "D";
                }
                rbtncau31.Checked = true;
                lblCauhoi.Text = "Câu 31: Trong lập trình C#, làm thế nào để thiết lập một label để hiển thị văn bản có định dạng HTML?\r\n";
                rbtnA.Text = "A. label.TextFormat = TextFormat.HTML;";
                rbtnB.Text = "B. label.IsHtml = true;";
                rbtnC.Text = "C. label.EnableHtml = true;";
                rbtnD.Text = "D. label.Text = \"Formatted Text\";";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau30 == cautraloidungcau30)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }

            }
            else if (rbtncau31.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau31 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau31 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau31 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau31 = "D";
                }
                rbtncau32.Checked = true;
                lblCauhoi.Text = "Câu 32: Làm thế nào để thiết lập một checkbox để cho phép người dùng chọn nhiều lựa chọn?\r\n";
                rbtnA.Text = "A. checkbox.Mode = SelectionMode.Multiple;";
                rbtnB.Text = "B. checkbox.AllowMultipleSelection = true;";
                rbtnC.Text = "C. checkbox.SelectionType = SelectionType.Multiple;";
                rbtnD.Text = "D. checkbox.MultiSelect = true;";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau31 == cautraloidungcau31)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau32.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau32 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau32 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau32 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau32 = "D";
                }
                rbtncau33.Checked = true;
                lblCauhoi.Text = "Câu 33: Trong lập trình C#, làm thế nào để vô hiệu hóa một button?\r\n";
                rbtnA.Text = "A. button.Disable();";
                rbtnB.Text = "B. button.Enabled = false;";
                rbtnC.Text = "C. button.IsDisabled = true;";
                rbtnD.Text = "D. button.AllowClick = false;";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau32 == cautraloidungcau32)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }
            else if (rbtncau33.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau33 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau33 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau33 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau33 = "D";
                }
                rbtncau34.Checked = true;
                lblCauhoi.Text = "Câu 34: Làm thế nào để xác định xem một textbox có chứa chỉ số hay không (ví dụ: kiểm tra xem nó có chứa một số nguyên không)?\r\n";
                rbtnA.Text = "A. int.TryParse(textbox.Text, out int result);";
                rbtnB.Text = "B. textbox.Text.IsInteger();";
                rbtnC.Text = "C. Convert.ToInt32(textbox.Text);";
                rbtnD.Text = "D. int.Parse(textbox.Text);";
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
                socau++;
                if (cautraloicau33 == cautraloidungcau33)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }

            }
            else if (rbtncau34.Checked == true)
            {
                if (rbtnA.Checked == true)
                {
                    cautraloicau34 = "A";
                }
                else if (rbtnB.Checked == true)
                {
                    cautraloicau34 = "B";
                }
                else if (rbtnC.Checked == true)
                {
                    cautraloicau34 = "C";
                }
                else if (rbtnD.Checked == true)
                {
                    cautraloicau34 = "D";
                }

                socau++;

                if (cautraloicau34 == cautraloidungcau34)
                {
                    caudung++;
                }
                else
                {
                    causai++;
                }
            }

            TestWindowForm_Status_CauDaLam.Text = "Câu đã làm: " + socau.ToString();
            TestWindowForm_Status_CauDung.Text = "Câu đúng: " + caudung.ToString();
            TestWindowForm_Status_CauSai.Text = "Câu sai: " + causai.ToString();
        }

            int socaudalam = 0;

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            string ketqua = "";
            
            for (int i = 1; i <= socau; i++)
            {
                string cautraloicau = (string)this.GetType().GetField($"cautraloicau{i}", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this);
                string cautraloidungcau = (string)this.GetType().GetField($"cautraloidungcau{i}", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this);
                socaudalam++;
                if (cautraloicau == cautraloidungcau)
                {
                    ketqua += i + "." + cautraloicau + " Đúng\r\n" ;
                    
                }
                else
                {
                    ketqua += i + "." + cautraloicau + " Sai\r\n";
                   
                }
            }
            Form frmketqua = new frmKetquakiemtra(ketqua,caudung,causai,socaudalam);
            frmketqua.Show();
            
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cautraloicau1 = "";
            cautraloicau2 = "";
            cautraloicau3 = "";
            cautraloicau4 = "";
            cautraloicau5 = "";
            cautraloicau6 = "";
            cautraloicau7 = "";
            cautraloicau8 = "";
            cautraloicau9 = "";
            cautraloicau10 = "";
            cautraloicau11 = "";
            cautraloicau12 = "";
            cautraloicau13 = "";
            cautraloicau14 = "";
            cautraloicau15 = "";
            cautraloicau16 = "";
            cautraloicau17 = "";
            cautraloicau18 = "";
            cautraloicau19 = "";
            cautraloicau20 = "";
            cautraloicau21 = "";
            cautraloicau22 = "";
            cautraloicau23 = "";
            cautraloicau24 = "";
            cautraloicau25 = "";
            cautraloicau26 = "";
            cautraloicau27 = "";
            cautraloicau28 = "";
            cautraloicau29 = "";
            cautraloicau30 = "";
            cautraloicau31 = "";
            cautraloicau32 = "";
            cautraloicau33 = "";
            cautraloicau34 = "";
            cautraloicau35 = "";
            cautraloicau36 = "";
            cautraloicau37 = "";
            cautraloicau38 = "";
            cautraloicau39 = "";
            cautraloicau40 = "";
            cautraloicau41 = "";
            cautraloicau42 = "";
            cautraloicau43 = "";
            cautraloicau44 = "";
            cautraloicau45 = "";
            cautraloicau46 = "";
            cautraloicau47 = "";
            cautraloicau48 = "";
            cautraloicau49 = "";
            cautraloicau50 = "";
            cautraloicau51 = "";
            cautraloicau52 = "";
            cautraloicau53 = "";
            cautraloicau54 = "";
            cautraloicau55 = "";
            cautraloicau56 = "";
            cautraloicau57 = "";
            cautraloicau58 = "";
            cautraloicau59 = "";
            cautraloicau60 = "";
            cautraloicau61 = "";
            cautraloicau62 = "";
            cautraloicau63 = "";
            cautraloicau64 = "";
            cautraloicau65 = "";
            cautraloicau66 = "";
            cautraloicau67 = "";
            cautraloicau68 = "";
            cautraloicau69 = "";
            cautraloicau70 = "";
            cautraloicau71 = "";
            cautraloicau72 = "";
            cautraloicau73 = "";
            cautraloicau74 = "";
            cautraloicau75 = "";
            cautraloicau76 = "";
            cautraloicau77 = "";
            cautraloicau78 = "";
            cautraloicau79 = "";
            cautraloicau80 = "";
            cautraloicau81 = "";
            cautraloicau82 = "";
            cautraloicau83 = "";
            cautraloicau84 = "";
            cautraloicau85 = "";
            cautraloicau86 = "";
            cautraloicau87 = "";
            cautraloicau88 = "";
            cautraloicau89 = "";
            cautraloicau90 = "";
            cautraloicau91 = "";
            cautraloicau92 = "";
            cautraloicau93 = "";
            cautraloicau94 = "";
            cautraloicau95 = "";
            cautraloicau96 = "";
            cautraloicau97 = "";
            cautraloicau98 = "";
            cautraloicau99 = "";
            cautraloicau100 = "";
            rbtncau1.Checked = true;
            lblCauhoi.Text = "Câu 1: Namespace nào sau đây chứa các lớp cho thao tác Input và Output? ";
            rbtnA.Text = "A. System. Collections";
            rbtnB.Text = "B. System. IO";
            rbtnC.Text = "C. System. Net";
            rbtnD.Text = "D. System. Threading";
            socau = 0;
            caudung = 0;
            causai = 0;
            TestWindowForm_Status_CauDaLam.Text = "Câu đã làm: " + socau.ToString();
            TestWindowForm_Status_CauDung.Text = "Câu đúng: " + caudung.ToString();
            TestWindowForm_Status_CauSai.Text = "Câu sai: " + causai.ToString();
        }
    }
}
