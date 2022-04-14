namespace WinFormDataGridView_test
{
    public partial class Form1 : Form
    {
        private Image m_Img_g = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\gball.png");//add at 2017/08/07
        private Image m_Img_r = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\rball.png");//add at 2017/08/07
        private Image m_Img_b = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\bball.png");//add at 2017/08/07
        private Image m_Img_n = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\nball.png");//add at 2017/08/07
        private Image m_Img_o = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\oball.png");//增加images目錄下的圖片數量
        private Image m_Img_null = null;

        public Form1()
        {
            InitializeComponent();
        }

        void cleandataGridView1()
        {
            try
            {
                //--
                //dataGridView1.ReadOnly = true;//唯讀 不可更改
                dataGridView1.RowHeadersVisible = false;//DataGridView 最前面指示選取列所在位置的箭頭欄位
                dataGridView1.Rows[0].Selected = false;//取消DataGridView的默認選取(選中)Cell 使其不反藍
                dataGridView1.AllowUserToAddRows = false;//是否允許使用者新增資料
                dataGridView1.AllowUserToDeleteRows = false;//是否允許使用者刪除資料
                dataGridView1.AllowUserToOrderColumns = false;//是否允許使用者調整欄位位置
                dataGridView1.AllowUserToResizeRows = false;//是否允許使用者改變行高
                dataGridView1.AllowUserToResizeColumns = false;//是否允許使用者改變欄寬

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;//單一欄位禁止編輯
                    dataGridView1.Columns[i].DefaultCellStyle.NullValue = null;//允許單一圖片放空，不顯示X圖
                }

                //設置所有行背景色
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.Pink;//Color.White;

                //設置奇數行背景色（下標從零開始）
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.YellowGreen;
                
                //選擇顏色指定
                dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Red;


                //將行高調整到適合螢幕上當前顯示的行中所有單元格（包括標頭單元格）的內容。
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

                //允許換行屬性設定
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dataGridView1.AllowUserToAddRows = false;//刪除空白列
                dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;//整列選取
                //--

                do
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow r1 = this.dataGridView1.Rows[i];//取得DataGridView整列資料
                        this.dataGridView1.Rows.Remove(r1);//DataGridView刪除整列
                    }
                } while (dataGridView1.Rows.Count > 0);

            }
            catch
            {
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cleandataGridView1();

            dataGridView1.Rows.Add(m_Img_b, "主選一");
            dataGridView1.Rows.Add(m_Img_b, "主選二");
            dataGridView1.Rows[0].Cells[1].Style.Font = new System.Drawing.Font("Microsoft JhengHei UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.Rows[1].Cells[1].Style.Font = new System.Drawing.Font("Microsoft JhengHei UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            dataGridView1.Rows.Add(m_Img_g, "次選第一");
            dataGridView1.Rows[2].Cells[0].Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Rows.Add(null, "次選第二01234567890123456789012345678901234567890123456789012345678901234567890123456789");
            //dataGridView1.Rows.Add(null, "次選第二\n0123456789\n0123456789\n0123456789\n0123456789\n0123456789\n0123456789\n0123456789\n0123456789");
        }

    }
}