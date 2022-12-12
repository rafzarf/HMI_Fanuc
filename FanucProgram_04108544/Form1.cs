using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FanucProgram_04108544
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object ip;
        public ushort port;
        public ushort FlibHndl;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ProccessingTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ip = IPAdressTextBox.Text;
            port = Convert.ToUInt16(PortTextBox.Text);
            int timeout = 1;



            short ret = Focas1.cnc_allclibhndl3(ip, port, timeout, out FlibHndl);
            if (ret == Focas1.EW_OK)
            {
                MessageBox.Show("Connected OK");
            }
            else
            {
                MessageBox.Show("Connect Fail");
            }
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        char[] lineData = new char[450];
        public short blkNum;
        //ushort length = 450;
        int len = 50;
        string s;
        string b;
        int Decimalpoint = 4;

        double[] vibrationx = new double[1024];
        double[] vibrationy = new double[1024];
        double[] vibrationz = new double[1024];

        double sumidlex = 0.0;
        double sumidley = 0.0;
        double sumidlez = 0.0;


        //string lener;
        //short number = 256;
        //char[] data = new char[100000];
        //int lent = 1000000000;


        private void timer1_Tick(object sender, EventArgs e)
        {
            speed();//轉速
            feed();//進給
            nc();//讀取nc單節
            abs();//絕對座標
            machine();//機械座標
            RDSPMETER();//讀取主軸附載
            worktime();
            vibrationsensor();
            //RELATIVE();//相對座標
            //distance();//剩餘座標
            //RDZOFS();//讀取工件座標偏移值
            //RDPITCHR();//讀取螺距誤差補償數據
            //RDSVMETER();//讀取伺服軸負載
            //RDCURRENT();//讀取主軸電流
            ////RDSRVSPEED();////讀取伺服軸進給速度
            //RDTOOLGRP();////讀取刀具组號和刀具號
            //get_cuttingTime();//總切削時間
            //get_workingTime();//總運行時間
            //get_circleTime();//單一循環時間
        }


        public void vibrationsensor()
        {
            double[] vibrationx = new double[1024];
            double[] vibrationy = new double[1024];
            double[] vibrationz = new double[1024];

            void Value0()
            {
                for (int i = 0; i <= 1023; i++)
                {
                    //vibrationx[i] = Math.Abs((double)dataGridView1.Rows[i].Cells[0].Value);
                    //vibrationy[i] = Math.Abs((double)dataGridView1.Rows[i].Cells[1].Value);
                    //vibrationz[i] = Math.Abs((double)dataGridView1.Rows[i].Cells[2].Value);

                    vibrationx[i] = Math.Abs((double)dataTable.Rows[i][0]);
                    vibrationy[i] = Math.Abs((double)dataTable.Rows[i][1]);
                    vibrationz[i] = Math.Abs((double)dataTable.Rows[i][2]);
                }

                Array.Sort(vibrationx);
                Array.Reverse(vibrationx);

                Array.Sort(vibrationy);
                Array.Reverse(vibrationy);

                Array.Sort(vibrationz);
                Array.Reverse(vibrationz);

                int a20 = (vibrationx.Length) / 5;//¨ú«e20%¥­§¡

                double sumidlex = 0.0;
                double sumidley = 0.0;
                double sumidlez = 0.0;
                for (int i = 0; i < a20; i++)
                {
                    sumidlex += vibrationx[i];
                    sumidley += vibrationy[i];
                    sumidlez += vibrationz[i];
                }
                sumidlex = sumidlex / a20;
                sumidley = sumidley / a20;
                sumidlez = sumidlez / a20;

                if (idlevibx.Count >= 20)
                {
                    for (int k = 1; k < idlevibx.Count; ++k)
                    {
                        idlevibx[k - 1] = idlevibx[k];
                        idleviby[k - 1] = idleviby[k];
                        idlevibz[k - 1] = idlevibz[k];

                    }
                    idlevibx[idlevibx.Count - 1] = sumidlex;
                    idleviby[idleviby.Count - 1] = sumidley;
                    idlevibz[idlevibz.Count - 1] = sumidlez;
                }
                else
                {
                    idlevibx.Add(sumidlex);
                    idleviby.Add(sumidley);
                    idlevibz.Add(sumidlez);
                }

            }
        }

        public void speed()//轉速
        {
            int Speed = 0;

            Focas1.ODBACT oDBACT = new Focas1.ODBACT();
            short status = Focas1.cnc_acts(FlibHndl, oDBACT);
            Speed = oDBACT.data;
            RotSpeedLabel.Text = Speed + "rpm";
            Console.WriteLine(status);
        }

        public void feed()//讀取進給
        {
            Focas1.ODBACT buf = new Focas1.ODBACT();
            short ret4 = Focas1.cnc_actf(FlibHndl, buf);
            int feed = buf.data;
            FeedrateLabel.Text = feed + "mm/min";
        }

        public void nc()//讀取nc單節
        {
            ushort length = 450;
            short ret2 = Focas1.cnc_rdexecprog(FlibHndl, ref length, out blkNum, lineData);
            NCCodeRichtxtbox.Text = "";

            Console.WriteLine(blkNum);
            for (int i = 0; i < len; i++)
            {
                b = string.Concat(lineData[i]);
                s = b + "";
                if (s == "\n")
                {
                    return;
                }
                NCCodeRichtxtbox.Text += s + "";
            }
        }

        public void abs()//絕對座標
        {

            Focas1.ODBAXIS abs = new Focas1.ODBAXIS();
            Focas1.cnc_absolute(FlibHndl, -1, 4 + 4 * Focas1.MAX_AXIS, abs);
            double[] _AbsolutePosition_double = new double[3];
            for (int i = 0; i < 3; i++)
                _AbsolutePosition_double[i] = Convert.ToDouble(abs.data[i]) / Math.Pow(10, Decimalpoint);
            double _AbsolutePosition_doublex = Convert.ToDouble(_AbsolutePosition_double[0].ToString("#0.000"));
            double _AbsolutePosition_doubley = Convert.ToDouble(_AbsolutePosition_double[1].ToString("#0.000"));
            double _AbsolutePosition_doublez = Convert.ToDouble(_AbsolutePosition_double[2].ToString("#0.000"));
            XAbsCoorLabel.Text = _AbsolutePosition_doublex * 10 + "mm";
            YAbsCoorLabel.Text = _AbsolutePosition_doubley * 10 + "mm";
            ZAbsCoorLabel.Text = _AbsolutePosition_doublez * 10 + "mm";

        }

        public void machine()//機械座標
        {
            Focas1.ODBAXIS machine = new Focas1.ODBAXIS();
            Focas1.cnc_machine(FlibHndl, -1, 4 + 4 * Focas1.MAX_AXIS, machine);
            double[] _machinePosition_double = new double[3];
            for (int i = 0; i < 3; i++)
                _machinePosition_double[i] = Convert.ToDouble(machine.data[i]) / Math.Pow(10, Decimalpoint);
            double _machinePosition_doublex = Convert.ToDouble(_machinePosition_double[0].ToString("#0.000"));
            double _machinePosition_doubley = Convert.ToDouble(_machinePosition_double[1].ToString("#0.000"));
            double _machinePosition_doublez = Convert.ToDouble(_machinePosition_double[2].ToString("#0.000"));
            XMechCoorLabel.Text = _machinePosition_doublex * 10 + "mm";
            YMechCoorLabel.Text = _machinePosition_doubley * 10 + "mm";
            ZMechCoorLabel.Text = _machinePosition_doublez * 10 + "mm";
        }


        public void RDSPMETER()//讀取主軸附載
        {
            Focas1.ODBSPLOAD_data sp = new Focas1.ODBSPLOAD_data();
            short num = 4;
            byte[] bytes = new byte[Marshal.SizeOf(sp) * 4];
            IntPtr ptrWork = Marshal.AllocCoTaskMem(Marshal.SizeOf(sp));

            short ret = Focas1.cnc_rdspmeter(FlibHndl, 0, ref num, bytes);
            if (ret == Focas1.EW_OK)
            {
                int i;
                for (i = 0; i < num; i++)
                {
                    Marshal.Copy(bytes, i * Marshal.SizeOf(sp), ptrWork, Marshal.SizeOf(sp));
                    Marshal.PtrToStructure(ptrWork, sp);
                    // Console.WriteLine("{0}{1} = {2}", (char)sp.spload.name, (char)sp.spload.suff1, sp.spload.data);
                    double RDSPMETER = sp.spload.data;
                    SpindleLoadLabel.Text = RDSPMETER + "%";
                }
            }
            Marshal.FreeCoTaskMem(ptrWork);
        }

        public void worktime()
        {
            Focas1.IODBPSD_1 param6757 = new Focas1.IODBPSD_1();
            Focas1.IODBPSD_1 param6758 = new Focas1.IODBPSD_1();
            short ret = Focas1.cnc_rdparam(FlibHndl, 6757, 0, 8, param6757);
            if (ret == 0)
            {
                int circlingTimeSec = param6757.ldata / 1000;
                ret = Focas1.cnc_rdparam(FlibHndl, 6758, 0, 8, param6758);
                if (ret == 0)
                {
                    int circlingTimeMin = param6758.ldata;
                    int circlingTimeHour = circlingTimeMin / 60;
                    int circlingTimeMin1 = circlingTimeMin % 60;
                    int circlingTime = circlingTimeMin * 60 + circlingTimeSec;
                    //label14.Text = Convert.ToString(circlingTime) + "秒";
                    ProccessingTimeLabel.Text = Convert.ToString(circlingTimeHour) + "h" + Convert.ToString(circlingTimeMin1) + "m" + Convert.ToString(circlingTimeSec) + "s";
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        //save the 3 axe to avgidlevib
        double avgidlevibx = new double();
        double avgidleviby = new double();
        double avgidlevibz = new double();
        
        private void button1_Click(object sender, EventArgs e)
        {
            //¨D¤T¶bªÅÂà¥­§¡­È
            double sumidlevibx = new double();
            double sumidleviby = new double();
            double sumidlevibz = new double();
            Value0();
            for (int i = 0; i < idlevibx.Count; i++)
            {
                sumidlevibx = sumidlevibx + idlevibx[i];
                sumidleviby = sumidleviby + idleviby[i];
                sumidlevibz = sumidlevibz + idlevibz[i];
            }
            avgidlevibx = sumidlevibx / idlevibx.Count;
            avgidleviby = sumidleviby / idleviby.Count;
            avgidlevibz = sumidlevibz / idlevibz.Count;

            XVibLabel.Text = Convert.ToString(avgidlevibx.ToString("f4")) + " g";
            YVibLabel.Text = Convert.ToString(avgidleviby.ToString("f4")) + " g";
            ZVibLabel.Text = Convert.ToString(avgidlevibz.ToString("f4")) + " g";

            idlevibx.Clear();//²M°£°}¦CX
            idleviby.Clear();//²M°£°}¦CY
            idlevibz.Clear();//²M°£°}¦CZ
        }

        //save the 3 axe to idlevib
        List<double> idlevibx = new List<double>();
        List<double> idleviby = new List<double>();
        List<double> idlevibz = new List<double>();

       


        //public void RELATIVE()//相對座標
        //{
        //    Focas1.ODBAXIS RELATIVE = new Focas1.ODBAXIS();
        //    Focas1.cnc_relative(FlibHndl, -1, 4 + 4 * Focas1.MAX_AXIS, RELATIVE);
        //    double[] _RELATIVEPosition_double = new double[3];
        //    for (int i = 0; i < 3; i++)
        //        _RELATIVEPosition_double[i] = Convert.ToDouble(RELATIVE.data[i]) / Math.Pow(10, Decimalpoint);
        //    double _RELATIVEPosition_doublex = Convert.ToDouble(_RELATIVEPosition_double[0].ToString("#0.000"));
        //    double _RELATIVEPosition_doubley = Convert.ToDouble(_RELATIVEPosition_double[1].ToString("#0.000"));
        //    double _RELATIVEPosition_doublez = Convert.ToDouble(_RELATIVEPosition_double[2].ToString("#0.000"));
        //    XRelativeCoorLabel.Text = _RELATIVEPosition_doublex * 10 + "mm";
        //    YRelativeCoorLabel.Text = _RELATIVEPosition_doubley * 10 + "mm";
        //    ZRelativeCoorLabel.Text = _RELATIVEPosition_doublez * 10 + "mm";
        //}

        //public void distance()//剩餘座標
        //{
        //    Focas1.ODBAXIS distance = new Focas1.ODBAXIS();
        //    Focas1.cnc_distance(FlibHndl, -1, 4 + 4 * Focas1.MAX_AXIS, distance);
        //    double[] _distancePosition_double = new double[3];
        //    for (int i = 0; i < 3; i++)
        //        _distancePosition_double[i] = Convert.ToDouble(distance.data[i]) / Math.Pow(10, Decimalpoint);
        //    double _distancePosition_doublex = Convert.ToDouble(_distancePosition_double[0].ToString("#0.000"));
        //    double _distancePosition_doubley = Convert.ToDouble(_distancePosition_double[1].ToString("#0.000"));
        //    double _distancePosition_doublez = Convert.ToDouble(_distancePosition_double[2].ToString("#0.000"));
        //    XRemainCoorLabel.Text = _distancePosition_doublex + "mm";
        //    YRemainCoorLabel.Text = _distancePosition_doubley + "mm";
        //    ZRemainCoorLabel.Text = _distancePosition_doublez + "mm";
        //}

        //public void RDZOFS()//讀取工件座標偏移值
        //{
        //    Focas1.IODBZOFS RDZOFS = new Focas1.IODBZOFS();
        //    Focas1.cnc_rdzofs(FlibHndl, 1, 4, 4 + 4 * 1, RDZOFS);
        //    double[] _RDZOFSPosition_double = new double[3];
        //    for (int i = 0; i < 3; i++)
        //        _RDZOFSPosition_double[i] = Convert.ToDouble(RDZOFS.data[i]) / Math.Pow(10, Decimalpoint);
        //    double _AbsolutePosition_doublex = Convert.ToDouble(_RDZOFSPosition_double[0].ToString("#0.000"));
        //    double _AbsolutePosition_doubley = Convert.ToDouble(_RDZOFSPosition_double[1].ToString("#0.000"));
        //    double _AbsolutePosition_doublez = Convert.ToDouble(_RDZOFSPosition_double[2].ToString("#0.000"));
        //    XWorkOffsetLabel.Text = _AbsolutePosition_doublex + "mm";
        //    YWorkOffsetLabel.Text = _AbsolutePosition_doubley + "mm";
        //    ZWorkOffsetLabel.Text = _AbsolutePosition_doublez + "mm";
        //}
    }
}
